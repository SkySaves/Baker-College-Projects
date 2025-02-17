Public Class MainForm
    Private Sub btnWorkout_Click(sender As Object, e As EventArgs) Handles btnWorkout.Click
        Dim wf As New WorkoutForm()
        wf.Show()
        Me.Hide()
    End Sub

    Private Sub btnNutrition_Click(sender As Object, e As EventArgs) Handles btnNutrition.Click
        Dim nf As New NutritionForm()
        nf.Show()
        Me.Hide()
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

End Class
