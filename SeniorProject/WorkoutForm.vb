Imports System
Imports System.Linq

Public Class WorkoutForm

    Private Sub WorkoutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            WorkoutDataStore.Initialize()
            PopulateTemplatePanel()
        Catch ex As Exception
            MessageBox.Show("Error loading workout form: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnStartEmptyWorkout_Click(sender As Object, e As EventArgs) Handles btnStartEmptyWorkout.Click
        Try
            Dim wfIndividual As New WorkoutFormIndividual()
            wfIndividual.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error starting empty workout: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Try
            Dim main As New MainForm()
            main.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error returning to main form: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PopulateTemplatePanel()
        Try
            Panel7.Controls.Clear()
            Dim yPos As Integer = 10
            For Each template In WorkoutDataStore.CurrentTemplates
                Dim lbl As New Label()
                lbl.AutoSize = True
                lbl.Text = $"{template.TemplateName}{Environment.NewLine}" &
                           "Last performed on " & If(template.LastPerformedOn.HasValue, template.LastPerformedOn.Value.ToShortDateString(), "N/A")
                lbl.Top = yPos
                lbl.Left = 10
                lbl.Tag = template.TemplateID
                AddHandler lbl.Click, AddressOf TemplateLabel_Click
                Panel7.Controls.Add(lbl)
                yPos += lbl.Height + 10
            Next
        Catch ex As Exception
            MessageBox.Show("Error populating template panel: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TemplateLabel_Click(sender As Object, e As EventArgs)
        Try
            Dim clickedLabel As Label = DirectCast(sender, Label)
            Dim templateID As Integer = Convert.ToInt32(clickedLabel.Tag)
            Dim selectedTemplate = WorkoutDataStore.CurrentTemplates.FirstOrDefault(Function(t) t.TemplateID = templateID)
            If selectedTemplate IsNot Nothing Then
                Dim wfIndividual As New WorkoutFormIndividual(selectedTemplate)
                wfIndividual.Show()
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error selecting template: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
