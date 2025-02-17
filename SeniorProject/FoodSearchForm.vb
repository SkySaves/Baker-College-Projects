Imports Newtonsoft.Json.Linq

Public Class FoodSearchForm

    Private _mealCategory As String
    Private _selectedFoodId As Integer = -1
    Private _foodObject As JObject = Nothing ' Store full JSON details

    ' Returned if the user picks a food
    Public Property SelectedConsumedFood As ConsumedFood = Nothing

    Public Sub New(mealCategory As String)
        InitializeComponent()
        _mealCategory = mealCategory
    End Sub

    ' Parameterless constructor for Designer:
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Async Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim term As String = txtSearchTerm.Text.Trim()
        If String.IsNullOrEmpty(term) Then
            MessageBox.Show("Please enter a search term.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        lstResults.Items.Clear()
        cbServings.Items.Clear()
        numQuantity.Value = 1
        _selectedFoodId = -1
        _foodObject = Nothing

        Try
            Dim results = Await FatSecretApiHelper.SearchFoodsAsync(term, 25)
            If results.Count = 0 Then
                MessageBox.Show("No results found.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            For Each r In results
                Dim displayText = $"{r.Item2}  (ID: {r.Item1})"
                lstResults.Items.Add(displayText)
            Next
        Catch ex As Exception
            MessageBox.Show("Error searching foods: " & ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Async Sub lstResults_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstResults.SelectedIndexChanged
        If lstResults.SelectedIndex < 0 Then Return
        Dim selectedText As String = CStr(lstResults.SelectedItem)
        Dim startIndex = selectedText.LastIndexOf("ID: ")
        If startIndex < 0 Then
            MessageBox.Show("Invalid selection format.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim idSubstring = selectedText.Substring(startIndex + 4).Trim(")"c)
        Dim foodId As Integer
        If Integer.TryParse(idSubstring, foodId) Then
            _selectedFoodId = foodId
            Try
                _foodObject = Await FatSecretApiHelper.GetFoodObjectAsync(foodId)
                PopulateServingsCombo()
            Catch ex As Exception
                MessageBox.Show("Error fetching food details: " & ex.Message, "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Could not parse food ID.", "Parsing Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub PopulateServingsCombo()
        cbServings.Items.Clear()
        If _foodObject Is Nothing Then Return

        Dim servingsToken = _foodObject("servings")?("serving")
        If servingsToken Is Nothing Then
            MessageBox.Show("No serving information available for this food.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If servingsToken.Type = JTokenType.Array Then
            For Each s In servingsToken
                Dim desc = CStr(s("serving_description"))
                cbServings.Items.Add(desc)
            Next
        Else
            Dim desc = CStr(servingsToken("serving_description"))
            cbServings.Items.Add(desc)
        End If

        If cbServings.Items.Count > 0 Then
            cbServings.SelectedIndex = 0
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub FoodSearchForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Add " & _mealCategory & " Food"
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If _selectedFoodId < 0 Then
            MessageBox.Show("Please select a food result first.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If cbServings.SelectedIndex < 0 Then
            MessageBox.Show("Please select a serving size.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If _foodObject Is Nothing Then
            MessageBox.Show("No food details loaded.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedDesc = CStr(cbServings.SelectedItem)
        Dim servingsToken = _foodObject("servings")?("serving")
        Dim chosenServing As JToken = Nothing

        If servingsToken Is Nothing Then
            MessageBox.Show("No serving data found.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If servingsToken.Type = JTokenType.Array Then
            For Each s In servingsToken
                If CStr(s("serving_description")) = selectedDesc Then
                    chosenServing = s
                    Exit For
                End If
            Next
        Else
            chosenServing = servingsToken
        End If

        If chosenServing Is Nothing Then
            MessageBox.Show("Could not find the selected serving details.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim quantity As Double = CDbl(numQuantity.Value)
        Try
            Dim baseCals = CDbl(chosenServing("calories"))
            Dim baseCarbs = CDbl(chosenServing("carbohydrate"))
            Dim baseProt = CDbl(chosenServing("protein"))
            Dim baseFat = CDbl(chosenServing("fat"))
            Dim foodName = CStr(_foodObject("food_name"))

            Dim totalCals = baseCals * quantity
            Dim totalCarbs = baseCarbs * quantity
            Dim totalProt = baseProt * quantity
            Dim totalFat = baseFat * quantity

            Dim newFood As New ConsumedFood With {
                .MealCategory = _mealCategory,
                .FoodName = foodName,
                .ServingDescription = $"{quantity} x {selectedDesc}",
                .Calories = totalCals,
                .Carbs = totalCarbs,
                .Protein = totalProt,
                .Fat = totalFat
            }

            Me.SelectedConsumedFood = newFood
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error processing serving details: " & ex.Message, "Processing Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
