Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Threading.Tasks
Imports Newtonsoft.Json.Linq

Public Class FatSecretApiHelper
    Private Shared _accessToken As String
    Private Shared _tokenExpiration As DateTime

    ' Insert your keys here or store in a config file:
    Private Const CLIENT_ID As String = "f6035f7ac36c4163a60cbdaec086d972"
    Private Const CLIENT_SECRET As String = "ca5a8c8f4cd843feace77f8f79b26fd0"

    ''' <summary>
    ''' Gets or refreshes the FatSecret OAuth token.
    ''' </summary>
    Public Shared Async Function GetAccessTokenAsync() As Task(Of String)
        ' If we already have a token and it isn't expired, just reuse it
        If Not String.IsNullOrEmpty(_accessToken) AndAlso DateTime.Now < _tokenExpiration Then
            Return _accessToken
        End If

        Using client As New HttpClient()
            client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

            Dim requestData = New List(Of KeyValuePair(Of String, String)) From {
                New KeyValuePair(Of String, String)("grant_type", "client_credentials"),
                New KeyValuePair(Of String, String)("client_id", CLIENT_ID),
                New KeyValuePair(Of String, String)("client_secret", CLIENT_SECRET),
                New KeyValuePair(Of String, String)("scope", "basic")
            }

            Dim content = New FormUrlEncodedContent(requestData)
            Dim response = Await client.PostAsync("https://oauth.fatsecret.com/connect/token", content)

            If response.IsSuccessStatusCode Then
                Dim json = Await response.Content.ReadAsStringAsync()
                Dim tokenData = JObject.Parse(json)
                _accessToken = tokenData("access_token").ToString()
                Dim expiresInSeconds = CInt(tokenData("expires_in"))
                _tokenExpiration = DateTime.Now.AddSeconds(expiresInSeconds - 30) ' buffer

                Return _accessToken
            Else
                Throw New Exception("Failed to retrieve access token from FatSecret. Status: " &
                                    response.StatusCode.ToString())
            End If
        End Using
    End Function

    ''' <summary>
    ''' Calls the method-based integration (POST to rest/server.api)
    ''' with method=foods.search.v4, returning up to maxCount results.
    ''' </summary>
    Public Shared Async Function SearchFoodsAsync(term As String, maxCount As Integer) As Task(Of List(Of (Integer, String)))
        Dim results As New List(Of (Integer, String))()
        Dim token As String = Await GetAccessTokenAsync()

        Using client As New HttpClient()
            client.DefaultRequestHeaders.Authorization =
            New AuthenticationHeaderValue("Bearer", token)
            client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

            Dim requestData As New Dictionary(Of String, String) From {
            {"method", "foods.search"}, ' or "food.search" — see #2 below
            {"search_expression", term},
            {"max_results", maxCount.ToString()},
            {"format", "json"}
        }

            Dim content = New FormUrlEncodedContent(requestData)
            Dim response = Await client.PostAsync("https://platform.fatsecret.com/rest/server.api", content)
            Dim json As String = Await response.Content.ReadAsStringAsync()

            If response.IsSuccessStatusCode Then
                Dim root = Newtonsoft.Json.Linq.JObject.Parse(json)
                Dim foodsToken = root("foods")?("food")

                If foodsToken Is Nothing Then
                    ' Show the entire JSON if "food" is missing, so we see if there's an error object
                    MessageBox.Show($"No 'food' found in JSON. Full response:{Environment.NewLine}{json}")
                    Return results
                End If

                If foodsToken.Type = Newtonsoft.Json.Linq.JTokenType.Array Then
                    For Each item In foodsToken
                        Dim foodId = CInt(item("food_id"))
                        Dim foodName = CStr(item("food_name"))
                        results.Add((foodId, foodName))
                    Next
                Else
                    ' single result
                    Dim foodId = CInt(foodsToken("food_id"))
                    Dim foodName = CStr(foodsToken("food_name"))
                    results.Add((foodId, foodName))
                End If
            Else
                ' Something else is happening
                MessageBox.Show($"food search call failed: {response.StatusCode}{Environment.NewLine}{json}")
            End If
        End Using

        Return results
    End Function



    ''' <summary>
    ''' Calls food.get.v4 for a specific food_id. Returns JToken for the food object.
    ''' (We can parse the servings, etc. from it.)
    ''' </summary>
    Public Shared Async Function GetFoodObjectAsync(foodId As Integer) As Task(Of JObject)
        Dim token As String = Await GetAccessTokenAsync()

        Using client As New HttpClient()
            client.DefaultRequestHeaders.Authorization =
                New AuthenticationHeaderValue("Bearer", token)
            client.DefaultRequestHeaders.Accept.Add(
                New MediaTypeWithQualityHeaderValue("application/json"))

            Dim url As String = $"https://platform.fatsecret.com/rest/food/v4?food_id={foodId}&format=json"
            Dim response = Await client.GetAsync(url)
            If response.IsSuccessStatusCode Then
                Dim json = Await response.Content.ReadAsStringAsync()
                Dim root = JObject.Parse(json)
                Return root("food") ' the "food" object
            Else
                Throw New Exception("Failed to fetch food details. Status: " &
                                    response.StatusCode.ToString())
            End If
        End Using
    End Function

End Class
