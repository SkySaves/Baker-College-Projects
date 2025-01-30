
Public Class WorkoutTemplate
    Public Property TemplateID As Integer        ' unique ID
    Public Property TemplateName As String
    Public Property LastPerformedOn As DateTime? ' can be null if never performed
    Public Property Exercises As List(Of Exercise)

    Public Sub New()
        Exercises = New List(Of Exercise)()
    End Sub
End Class
