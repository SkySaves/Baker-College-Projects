Public Class WorkoutFormIndividual

    Private _currentWorkout As Workout

    '--- 1) Parameterless constructor: For "Start Empty Workout"
    Public Sub New()
        InitializeComponent()
        ' _currentWorkout will be Nothing here; handled in Load event
    End Sub

    '--- 2) Constructor that directly takes a Workout object
    Public Sub New(workout As Workout)
        InitializeComponent()
        _currentWorkout = workout
    End Sub

    '--- 3) Constructor that takes a WorkoutTemplate 
    '        and converts it into a fresh Workout session.
    Public Sub New(template As WorkoutTemplate)
        InitializeComponent()

        ' Create a brand-new Workout based on this template
        Dim w As New Workout()
        w.WorkoutName = template.TemplateName
        w.WorkoutNote = String.Empty          ' or pull from template if you prefer
        w.StartTime = DateTime.Now

        ' Copy each Exercise from the template -> new Workout's Exercises
        For Each tempEx In template.Exercises
            Dim newEx As New Exercise With {
                .ExerciseName = tempEx.ExerciseName,
                .IsMachine = tempEx.IsMachine,
                .Notes = tempEx.Notes
            }

            ' If you want to copy sets from the template as well:
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
        ' If _currentWorkout was never assigned in the constructor, create a new one
        If _currentWorkout Is Nothing Then
            _currentWorkout = New Workout()
            _currentWorkout.StartTime = DateTime.Now
        End If

        lblWorkoutName.Text = _currentWorkout.WorkoutName
        txtWorkoutNote.Text = _currentWorkout.WorkoutNote

        ' Start the timer for the "rest" or "elapsed" time
        Timer1.Interval = 1000
        Timer1.Start()

        PopulateExercises()
    End Sub

    Private Sub PopulateExercises()
        ' flpExercises is a FlowLayoutPanel on your form
        flpExercises.Controls.Clear()
        For Each ex In _currentWorkout.Exercises
            ' Create a custom user control for each Exercise
            Dim ctrl As New ExerciseControl(ex)
            AddHandler ctrl.ExerciseChanged, AddressOf OnExerciseChanged
            AddHandler ctrl.AddSetClicked, AddressOf OnAddSetClicked
            flpExercises.Controls.Add(ctrl)
        Next
    End Sub

    Private Sub OnExerciseChanged(sender As Object, e As EventArgs)
        ' A set or note changed in an exercise control
        ' (Optional) you can do something here, like auto-save
    End Sub

    Private Sub OnAddSetClicked(sender As ExerciseControl, e As EventArgs)
        ' "Add Set" was clicked on a particular ExerciseControl
        Dim ex As Exercise = sender.BoundExercise  ' or a function to find the matching Exercise
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
        ' Create a new blank Exercise
        Dim ex As New Exercise With {
            .ExerciseName = "New Exercise",
            .Notes = ""
        }
        _currentWorkout.Exercises.Add(ex)

        PopulateExercises()
    End Sub

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        ' Save or finalize the workout
        _currentWorkout.WorkoutName = lblWorkoutName.Text
        _currentWorkout.WorkoutNote = txtWorkoutNote.Text
        ' Stop timer if needed
        Dim main As New MainForm()
        main.Show()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ' Discard changes
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim elapsed As TimeSpan = DateTime.Now - _currentWorkout.StartTime
        lblElapsedTime.Text = elapsed.ToString("mm\:ss")
    End Sub

End Class
