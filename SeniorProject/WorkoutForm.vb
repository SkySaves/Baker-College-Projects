Public Class WorkoutForm

    Private workoutTemplates As List(Of WorkoutTemplate)

    Private Sub WorkoutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' For now, just create a single template in memory. 
        ' In the future, you could load these from a DB or file.
        workoutTemplates = New List(Of WorkoutTemplate)()

        Dim legDay As New WorkoutTemplate With {
            .TemplateID = 1,
            .TemplateName = "Leg Day",
            .LastPerformedOn = DateTime.Now.AddDays(-3) ' e.g. performed 3 days ago
        }

        ' Add a couple of exercises
        Dim ex1 As New Exercise With {
    .ExerciseName = "Lying Leg Curl",
    .IsMachine = True
}
        ' Add one set:
        ex1.Sets.Add(New ExerciseSet With {
    .SetNumber = 1,
    .Weight = 0,     ' or 50, or whatever you like
    .Reps = 10,
    .PreviousWeight = 0,
    .PreviousReps = 8,
    .IsCompleted = False
})
        legDay.Exercises.Add(ex1)

        Dim ex2 As New Exercise With {
    .ExerciseName = "Leg Extension",
    .IsMachine = True
}
        ex2.Sets.Add(New ExerciseSet With {.SetNumber = 1, .Weight = 0, .Reps = 12})
        legDay.Exercises.Add(ex2)


        workoutTemplates.Add(legDay)

        ' Render these templates in your UI. 
        ' Suppose you have a Panel called pnlTemplates (or in your screenshot it might be Panel7).
        PopulateTemplatePanel()
    End Sub

    Private Sub btnStartEmptyWorkout_Click(sender As Object, e As EventArgs) Handles btnStartEmptyWorkout.Click
        ' Open WorkoutFormIndividual with NO template (i.e. empty).
        Dim wfIndividual As New WorkoutFormIndividual()
        wfIndividual.Show()
        Me.Close() ' Closes this form so only the individual workout form is open
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim main As New MainForm()
        main.Show()
        Me.Close()
    End Sub

    Private Sub PopulateTemplatePanel()
        ' Clear anything that might be there
        Panel7.Controls.Clear()

        ' For each template, we’ll show a label that, when clicked, opens the detail form.
        Dim yPos As Integer = 10
        For Each template In workoutTemplates
            Dim lbl As New Label()
            lbl.AutoSize = True
            lbl.Text = $"{template.TemplateName}{Environment.NewLine}" &
                       $"Last performed on {template.LastPerformedOn?.ToShortDateString()}"
            lbl.Top = yPos
            lbl.Left = 10
            lbl.Tag = template.TemplateID      ' store the ID in Tag so we know which one was clicked

            ' Hook up the click event
            AddHandler lbl.Click, AddressOf TemplateLabel_Click

            Panel7.Controls.Add(lbl)
            yPos += lbl.Height + 10
        Next
    End Sub

    Private Sub TemplateLabel_Click(sender As Object, e As EventArgs)
        Dim clickedLabel As Label = DirectCast(sender, Label)

        ' Retrieve which template ID this label corresponds to
        Dim templateID As Integer = Convert.ToInt32(clickedLabel.Tag)

        ' Find that template
        Dim selectedTemplate As WorkoutTemplate =
        workoutTemplates.FirstOrDefault(Function(t) t.TemplateID = templateID)

        If selectedTemplate IsNot Nothing Then
            ' ►► Use the NEW constructor that accepts a WorkoutTemplate ◄◄
            Dim wfIndividual As New WorkoutFormIndividual(selectedTemplate)
            wfIndividual.Show()
            Me.Close()
        End If
    End Sub


    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint

    End Sub
End Class
