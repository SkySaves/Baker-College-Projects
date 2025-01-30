' ------ WorkoutModels.vb ------
Public Class Workout
    Public Property WorkoutName As String
    Public Property WorkoutNote As String
    Public Property StartTime As DateTime = DateTime.Now
    Public Property Exercises As List(Of Exercise) = New List(Of Exercise)()
End Class

Public Class Exercise
    Public Property ExerciseName As String
    Public Property Notes As String
    Public Property Sets As List(Of ExerciseSet) = New List(Of ExerciseSet)()
    Public Property IsMachine As Boolean
    Public Property Name As String

End Class

Public Class ExerciseSet
    Public Property SetNumber As Integer
    Public Property PreviousWeight As Double
    Public Property PreviousReps As Integer
    Public Property Weight As Double
    Public Property Reps As Integer
    Public Property IsCompleted As Boolean
End Class
