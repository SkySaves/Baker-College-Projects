' ----- WorkoutForm.vb -----
Imports System
Imports System.Linq

Public Class WorkoutForm

    Private Sub WorkoutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Make sure we have at least one default template loaded
        WorkoutDataStore.Initialize()

        ' Render these templates in your Panel
        PopulateTemplatePanel()
    End Sub

    Private Sub btnStartEmptyWorkout_Click(sender As Object, e As EventArgs) Handles btnStartEmptyWorkout.Click
        ' Start an empty workout
        Dim wfIndividual As New WorkoutFormIndividual()
        wfIndividual.Show()
        Me.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim main As New MainForm()
        main.Show()
        Me.Close()
    End Sub

    Private Sub PopulateTemplatePanel()
        Panel7.Controls.Clear()

        ' For each template in the shared data store, show a label
        Dim yPos As Integer = 10
        For Each template In WorkoutDataStore.CurrentTemplates
            Dim lbl As New Label()
            lbl.AutoSize = True
            lbl.Text = $"{template.TemplateName}{Environment.NewLine}" &
                       $"Last performed on {template.LastPerformedOn?.ToShortDateString()}"
            lbl.Top = yPos
            lbl.Left = 10
            lbl.Tag = template.TemplateID

            AddHandler lbl.Click, AddressOf TemplateLabel_Click

            Panel7.Controls.Add(lbl)
            yPos += lbl.Height + 10
        Next
    End Sub

    Private Sub TemplateLabel_Click(sender As Object, e As EventArgs)
        Dim clickedLabel As Label = DirectCast(sender, Label)
        Dim templateID As Integer = Convert.ToInt32(clickedLabel.Tag)

        ' Find the template by ID
        Dim selectedTemplate = WorkoutDataStore.CurrentTemplates.
            FirstOrDefault(Function(t) t.TemplateID = templateID)

        If selectedTemplate IsNot Nothing Then
            Dim wfIndividual As New WorkoutFormIndividual(selectedTemplate)
            wfIndividual.Show()
            Me.Close()
        End If
    End Sub

End Class
