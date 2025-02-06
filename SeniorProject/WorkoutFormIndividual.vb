' ----- WorkoutFormIndividual.vb -----
Imports System

Public Class WorkoutFormIndividual

    Private _currentWorkout As Workout

    '--- 1) Parameterless constructor: For "Start Empty Workout"
    Public Sub New()
        InitializeComponent()
        ' _currentWorkout will be Nothing here; the Load event sets it if needed
    End Sub

    '--- 2) Constructor that directly takes a Workout object
    Public Sub New(workout As Workout)
        InitializeComponent()
        _currentWorkout = workout
    End Sub

    '--- 3) Constructor that takes a WorkoutTemplate and converts it into a fresh Workout
    Public Sub New(template As WorkoutTemplate)
        InitializeComponent()

        Dim w As New Workout()
        w.WorkoutName = template.TemplateName
        w.WorkoutNote = String.Empty
        w.StartTime = DateTime.Now

        For Each tempEx In template.Exercises
            Dim newEx As New Exercise With {
                .ExerciseName = tempEx.ExerciseName,
                .IsMachine = tempEx.IsMachine,
                .Notes = tempEx.Notes
            }
            ' Copy sets
            For Each s In tempEx.Sets
                Dim newSet As New ExerciseSet With {
                    .SetNumber = s.SetNumber,
                    .PreviousWeight = s.PreviousWeight,
                    .PreviousReps = s.PreviousReps,
                    .Weight = s.Weight,
                    .Reps = s.Reps,
                    .IsCompleted = False
                }
                newEx.Sets.Add(newSet)
            Next

            w.Exercises.Add(newEx)
        Next

        _currentWorkout = w
    End Sub

    Private Sub WorkoutFormIndividual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _currentWorkout Is Nothing Then
            _currentWorkout = New Workout()
            _currentWorkout.StartTime = DateTime.Now
        End If

        txtWorkoutName.Text = _currentWorkout.WorkoutName

        txtWorkoutNote.Text = _currentWorkout.WorkoutNote

        Timer1.Interval = 1000
        Timer1.Start()

        PopulateExercises()
    End Sub

    Private Sub PopulateExercises()
        flpExercises.Controls.Clear()
        For Each ex In _currentWorkout.Exercises
            Dim ctrl As New ExerciseControl(ex)
            AddHandler ctrl.ExerciseChanged, AddressOf OnExerciseChanged
            AddHandler ctrl.AddSetClicked, AddressOf OnAddSetClicked
            flpExercises.Controls.Add(ctrl)
        Next
    End Sub

    Private Sub OnExerciseChanged(sender As Object, e As EventArgs)
        ' Optionally do something (auto-save, etc.)
    End Sub

    Private Sub OnAddSetClicked(sender As ExerciseControl, e As EventArgs)
        Dim ex As Exercise = sender.BoundExercise
        If ex IsNot Nothing Then
            Dim newSetNumber As Integer = ex.Sets.Count + 1
            Dim newSet As New ExerciseSet With {
                .SetNumber = newSetNumber,
                .PreviousWeight = 0,
                .PreviousReps = 0,
                .Weight = 0,
                .Reps = 0,
                .IsCompleted = False
            }
            ex.Sets.Add(newSet)
        End If
        PopulateExercises()
    End Sub

    Private Sub btnAddExercise_Click(sender As Object, e As EventArgs) Handles btnAddExercise.Click
        Dim ex As New Exercise With {
            .ExerciseName = "New Exercise"
        }
        _currentWorkout.Exercises.Add(ex)
        PopulateExercises()
    End Sub

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        ' Save or finalize the workout
        _currentWorkout.WorkoutName = txtWorkoutName.Text

        _currentWorkout.WorkoutNote = txtWorkoutNote.Text
        Timer1.Stop()

        ' Prompt: do you want to save this as a new template?
        Dim result = MessageBox.Show("Do you want to save this workout as a new template?",
                                     "Save Template?", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim newTemplate As New WorkoutTemplate()
            newTemplate.TemplateID = WorkoutDataStore.GetNextTemplateID()
            newTemplate.TemplateName = _currentWorkout.WorkoutName
            newTemplate.LastPerformedOn = DateTime.Now

            ' Copy all exercises/sets into the new template
            For Each wEx In _currentWorkout.Exercises
                Dim tEx As New Exercise With {
                    .ExerciseName = wEx.ExerciseName,
                    .IsMachine = wEx.IsMachine,
                    .Notes = wEx.Notes
                }
                For Each s In wEx.Sets
                    Dim newSet As New ExerciseSet With {
                        .SetNumber = s.SetNumber,
                        .PreviousWeight = s.PreviousWeight,
                        .PreviousReps = s.PreviousReps,
                        .Weight = s.Weight,
                        .Reps = s.Reps,
                        .IsCompleted = s.IsCompleted
                    }
                    tEx.Sets.Add(newSet)
                Next
                newTemplate.Exercises.Add(tEx)
            Next

            ' Add it to the shared store
            WorkoutDataStore.CurrentTemplates.Add(newTemplate)
        End If

        ' Return to WorkoutForm
        Dim wf As New WorkoutForm()
        wf.Show()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ' If you want to fully discard changes and go back:
        Timer1.Stop()
        Dim wf As New WorkoutForm()
        wf.Show()
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim elapsed As TimeSpan = DateTime.Now - _currentWorkout.StartTime
        lblElapsedTime.Text = elapsed.ToString("mm\:ss")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Timer1.Stop()
        Dim wf As New WorkoutForm()
        wf.Show()
        Me.Close()
    End Sub
End Class
