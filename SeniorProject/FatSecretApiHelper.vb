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
        Try
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
                    Throw New Exception("Failed to retrieve access token from FatSecret. Status: " & response.StatusCode.ToString())
                End If
            End Using
        Catch ex As Exception
            Throw New Exception("Error in GetAccessTokenAsync: " & ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' Searches foods using FatSecret's API.
    ''' </summary>
    Public Shared Async Function SearchFoodsAsync(term As String, maxCount As Integer) As Task(Of List(Of (Integer, String)))
        Dim results As New List(Of (Integer, String))()
        Try
            Dim token As String = Await GetAccessTokenAsync()
            Using client As New HttpClient()
                client.DefaultRequestHeaders.Authorization = New AuthenticationHeaderValue("Bearer", token)
                client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

                Dim requestData As New Dictionary(Of String, String) From {
                    {"method", "foods.search"},
                    {"search_expression", term},
                    {"max_results", maxCount.ToString()},
                    {"format", "json"}
                }

                Dim content = New FormUrlEncodedContent(requestData)
                Dim response = Await client.PostAsync("https://platform.fatsecret.com/rest/server.api", content)
                Dim json As String = Await response.Content.ReadAsStringAsync()

                If response.IsSuccessStatusCode Then
                    Dim root = JObject.Parse(json)
                    Dim foodsToken = root("foods")?("food")

                    If foodsToken Is Nothing Then
                        MessageBox.Show($"No 'food' found in JSON. Full response:{Environment.NewLine}{json}", "Search Foods", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return results
                    End If

                    If foodsToken.Type = JTokenType.Array Then
                        For Each item In foodsToken
                            Dim foodId As Integer
                            If Integer.TryParse(item("food_id")?.ToString(), foodId) Then
                                Dim foodName = CStr(item("food_name"))
                                results.Add((foodId, foodName))
                            End If
                        Next
                    Else
                        Dim foodId As Integer
                        If Integer.TryParse(foodsToken("food_id")?.ToString(), foodId) Then
                            Dim foodName = CStr(foodsToken("food_name"))
                            results.Add((foodId, foodName))
                        End If
                    End If
                Else
                    MessageBox.Show($"Food search call failed: {response.StatusCode}{Environment.NewLine}{json}", "Search Foods", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error in SearchFoodsAsync: " & ex.Message, "Search Foods", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return results
    End Function

    ''' <summary>
    ''' Retrieves detailed food information.
    ''' </summary>
    Public Shared Async Function GetFoodObjectAsync(foodId As Integer) As Task(Of JObject)
        Try
            Dim token As String = Await GetAccessTokenAsync()
            Using client As New HttpClient()
                client.DefaultRequestHeaders.Authorization = New AuthenticationHeaderValue("Bearer", token)
                client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

                Dim url As String = $"https://platform.fatsecret.com/rest/food/v4?food_id={foodId}&format=json"
                Dim response = Await client.GetAsync(url)
                If response.IsSuccessStatusCode Then
                    Dim json = Await response.Content.ReadAsStringAsync()
                    Dim root = JObject.Parse(json)
                    Return CType(root("food"), JObject)
                Else
                    Throw New Exception("Failed to fetch food details. Status: " & response.StatusCode.ToString())
                End If
            End Using
        Catch ex As Exception
            Throw New Exception("Error in GetFoodObjectAsync: " & ex.Message)
        End Try
    End Function
End Class
