Imports Newtonsoft.Json.Linq

Public Class FoodSearchForm

    Private _mealCategory As String
    Private _selectedFoodId As Integer = -1
    Private _foodObject As JObject = Nothing ' We'll store the entire JSON from food.get

    ' We'll return this from ShowDialog() if the user picks something
    Public Property SelectedConsumedFood As ConsumedFood = Nothing

    Public Sub New(mealCategory As String)
        InitializeComponent()
        _mealCategory = mealCategory
    End Sub

    ' If you need a parameterless constructor for the Designer:
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Async Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim term As String = txtSearchTerm.Text.Trim()
        If String.IsNullOrEmpty(term) Then
            MessageBox.Show("Please enter a search term.")
            Return
        End If

        ' Clear out the old results
        lstResults.Items.Clear()
        cbServings.Items.Clear()
        numQuantity.Value = 1
        _selectedFoodId = -1
        _foodObject = Nothing

        Try
            Dim results = Await FatSecretApiHelper.SearchFoodsAsync(term, 25) ' up to 25 results
            If results.Count = 0 Then
                MessageBox.Show("No results found.")
                Return
            End If

            ' Display them in the list box
            ' each item: "Pizza (12345)" but store the ID in the Tag or something
            For Each r In results
                Dim displayText = $"{r.Item2}  (ID: {r.Item1})"
                lstResults.Items.Add(displayText)
            Next

        Catch ex As Exception
            MessageBox.Show("Error searching foods: " & ex.Message)
        End Try
    End Sub

    Private Async Sub lstResults_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstResults.SelectedIndexChanged
        If lstResults.SelectedIndex < 0 Then Return
        ' Parse out the ID from the selected item text
        Dim selectedText As String = CStr(lstResults.SelectedItem)
        ' Usually it looks like "Pizza (ID: 33691)"
        ' Let's parse out the ID
        Dim startIndex = selectedText.LastIndexOf("ID: ")
        If startIndex < 0 Then Return
        Dim idSubstring = selectedText.Substring(startIndex + 4).Trim(")"c)
        Dim foodId As Integer
        If Integer.TryParse(idSubstring, foodId) Then
            _selectedFoodId = foodId

            ' Now call the food.get API to load all servings
            Try
                _foodObject = Await FatSecretApiHelper.GetFoodObjectAsync(foodId)
                PopulateServingsCombo()
            Catch ex As Exception
                MessageBox.Show("Error fetching food details: " & ex.Message)
            End Try
        End If
    End Sub

    ''' <summary>
    ''' Called after we load the food details JSON, to fill cbServings with each available serving.
    ''' </summary>
    Private Sub PopulateServingsCombo()
        cbServings.Items.Clear()

        If _foodObject Is Nothing Then Return

        ' The food JSON might have:
        '  "servings": {
        '    "serving": [ {..}, {..} ] or a single object
        '  }
        Dim servingsToken = _foodObject("servings")("serving")
        If servingsToken Is Nothing Then Return

        If servingsToken.Type = JTokenType.Array Then
            ' multiple servings
            For Each s In servingsToken
                Dim desc = CStr(s("serving_description"))
                cbServings.Items.Add(desc)
            Next
        Else
            ' only one serving
            Dim desc = CStr(servingsToken("serving_description"))
            cbServings.Items.Add(desc)
        End If

        If cbServings.Items.Count > 0 Then
            cbServings.SelectedIndex = 0
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ' user canceled
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub FoodSearchForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' If we want to show the category anywhere in the title, we can do:
        Me.Text = "Add " & _mealCategory & " Food"
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If _selectedFoodId < 0 Then
            MessageBox.Show("Please select a food result first.")
            Return
        End If
        If cbServings.SelectedIndex < 0 Then
            MessageBox.Show("Please select a serving size.")
            Return
        End If

        If _foodObject Is Nothing Then
            MessageBox.Show("No food details loaded.")
            Return
        End If

        ' We get the serving object that corresponds to the selection
        Dim selectedDesc = CStr(cbServings.SelectedItem)
        ' We'll find it in the JSON again
        Dim servingsToken = _foodObject("servings")("serving")
        Dim chosenServing As JToken = Nothing

        If servingsToken.Type = JTokenType.Array Then
            For Each s In servingsToken
                If CStr(s("serving_description")) = selectedDesc Then
                    chosenServing = s
                    Exit For
                End If
            Next
        Else
            ' only one
            chosenServing = servingsToken
        End If

        If chosenServing Is Nothing Then
            MessageBox.Show("Could not find the selected serving details.")
            Return
        End If

        Dim quantity = CDbl(numQuantity.Value)

        ' retrieve the base macros from the chosen serving
        ' Each serving can have e.g. "calories", "fat", "carbohydrate", "protein"...
        ' We'll multiply them by quantity
        Dim baseCals = CDbl(chosenServing("calories"))
        Dim baseCarbs = CDbl(chosenServing("carbohydrate"))
        Dim baseProt = CDbl(chosenServing("protein"))
        Dim baseFat = CDbl(chosenServing("fat"))
        Dim foodName = CStr(_foodObject("food_name"))

        ' multiply them by quantity
        Dim totalCals = baseCals * quantity
        Dim totalCarbs = baseCarbs * quantity
        Dim totalProt = baseProt * quantity
        Dim totalFat = baseFat * quantity

        ' Build a ConsumedFood to return
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
    End Sub

End Class
