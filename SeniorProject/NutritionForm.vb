Imports System.Threading.Tasks
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json

Public Class NutritionForm

    Private currentDate As Date = Date.Today
    Private dailyLogs As Dictionary(Of Date, DailyLog) = Nothing

    Private Sub NutritionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dailyLogs = JSONStorageHelper.LoadDailyLogs()
            lblDate.Text = currentDate.ToString("MMMM dd, yyyy")

            If Not dailyLogs.ContainsKey(currentDate) Then
                dailyLogs(currentDate) = New DailyLog With {
                    .LogDate = currentDate,
                    .Foods = New List(Of ConsumedFood)()
                }
            End If

            RefreshUIAsync()
        Catch ex As Exception
            MessageBox.Show("Error loading nutrition data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub NutritionForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            JSONStorageHelper.SaveDailyLogs(dailyLogs)
            Application.Exit()
        Catch ex As Exception
            MessageBox.Show("Error saving nutrition data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnPreviousDay_Click(sender As Object, e As EventArgs) Handles btnPreviousDay.Click
        Try
            currentDate = currentDate.AddDays(-1)
            lblDate.Text = currentDate.ToString("MMMM dd, yyyy")
            If Not dailyLogs.ContainsKey(currentDate) Then
                dailyLogs(currentDate) = New DailyLog With {
                    .LogDate = currentDate,
                    .Foods = New List(Of ConsumedFood)()
                }
            End If
            RefreshUIAsync()
        Catch ex As Exception
            MessageBox.Show("Error navigating to previous day: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnNextDay_Click(sender As Object, e As EventArgs) Handles btnNextDay.Click
        Try
            currentDate = currentDate.AddDays(1)
            lblDate.Text = currentDate.ToString("MMMM dd, yyyy")
            If Not dailyLogs.ContainsKey(currentDate) Then
                dailyLogs(currentDate) = New DailyLog With {
                    .LogDate = currentDate,
                    .Foods = New List(Of ConsumedFood)()
                }
            End If
            RefreshUIAsync()
        Catch ex As Exception
            MessageBox.Show("Error navigating to next day: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Async Sub RefreshUIAsync()
        Try
            Dim log = dailyLogs(currentDate)
            Dim totalCalories As Double = 0
            Dim totalProtein As Double = 0
            Dim totalCarbs As Double = 0
            Dim totalFat As Double = 0

            For Each food In log.Foods
                totalCalories += food.Calories
                totalProtein += food.Protein
                totalCarbs += food.Carbs
                totalFat += food.Fat
            Next

            Dim dailyTarget As Double = 2000
            Dim burned As Double = 0
            Dim consumed As Double = totalCalories
            Dim remaining As Double = dailyTarget - (consumed - burned)

            lblConsumed.Text = consumed.ToString("N0")
            lblBurned.Text = burned.ToString("N0")
            lblRemaining.Text = remaining.ToString("N0")

            lblEnergy.Text = totalCalories.ToString("N0")
            lblProtein.Text = totalProtein.ToString("N1")
            lblCarbs.Text = totalCarbs.ToString("N1")
            lblFat.Text = totalFat.ToString("N1")

            dgvFoods.Rows.Clear()
            For Each f In log.Foods
                dgvFoods.Rows.Add(
                    f.MealCategory,
                    f.FoodName,
                    f.ServingDescription,
                    f.Calories.ToString("N0"),
                    f.Protein.ToString("N1"),
                    f.Carbs.ToString("N1"),
                    f.Fat.ToString("N1"))
            Next

            Await Task.CompletedTask
        Catch ex As Exception
            MessageBox.Show("Error refreshing UI: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' The Add buttons use this helper:
    Private Sub btnAddUncat_Click(sender As Object, e As EventArgs) Handles btnAddUncat.Click
        AddFoodForCategory("Uncategorized")
    End Sub

    Private Sub btnAddBreakfast_Click(sender As Object, e As EventArgs) Handles btnAddBreakfast.Click
        AddFoodForCategory("Breakfast")
    End Sub

    Private Sub btnAddLunch_Click(sender As Object, e As EventArgs) Handles btnAddLunch.Click
        AddFoodForCategory("Lunch")
    End Sub

    Private Sub btnAddDinner_Click(sender As Object, e As EventArgs) Handles btnAddDinner.Click
        AddFoodForCategory("Dinner")
    End Sub

    Private Sub btnAddSnacks_Click(sender As Object, e As EventArgs) Handles btnAddSnacks.Click
        AddFoodForCategory("Snacks")
    End Sub

    Private Sub AddFoodForCategory(cat As String)
        Try
            Using frm As New FoodSearchForm(cat)
                Dim result = frm.ShowDialog()
                If result = DialogResult.OK Then
                    Dim pickedFood = frm.SelectedConsumedFood
                    If pickedFood IsNot Nothing Then
                        dailyLogs(currentDate).Foods.Add(pickedFood)
                        RefreshUIAsync()
                    End If
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error adding food for category: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Try
            Dim main As New MainForm()
            main.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error going back: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
