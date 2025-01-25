Public Class WorkoutForm

    Private Sub WorkoutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Placeholder for workout data loading in future versions.
    End Sub

    Private Sub btnStartEmptyWorkout_Click(sender As Object, e As EventArgs) Handles btnStartEmptyWorkout.Click
        Dim wfIndividual As New WorkoutFormIndividual()
        wfIndividual.Show()
        Me.Close() ' Closes this form so only the individual workout form is open
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim main As New MainForm()
        main.Show()
        Me.Close()
    End Sub
End Class
