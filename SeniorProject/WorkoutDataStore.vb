' ----- WorkoutDataStore.vb -----
Imports System.Linq

Public Class WorkoutDataStore
    ' This shared list holds all templates in memory.
    Public Shared CurrentTemplates As New List(Of WorkoutTemplate)()

    Public Shared Sub Initialize()
        ' If no templates exist yet, create one default example
        If CurrentTemplates.Count = 0 Then
            Dim legDay As New WorkoutTemplate With {
                .TemplateID = 1,
                .TemplateName = "Leg Day",
                .LastPerformedOn = DateTime.Now.AddDays(-3)
            }

            ' Add a couple of exercises to Leg Day
            Dim ex1 As New Exercise With {
                .ExerciseName = "Lying Leg Curl",
                .IsMachine = True
            }
            ex1.Sets.Add(New ExerciseSet With {
                .SetNumber = 1,
                .Weight = 50,
                .Reps = 10,
                .PreviousWeight = 40,
                .PreviousReps = 8,
                .IsCompleted = False
            })
            legDay.Exercises.Add(ex1)

            Dim ex2 As New Exercise With {
                .ExerciseName = "Leg Extension",
                .IsMachine = True
            }
            ex2.Sets.Add(New ExerciseSet With {
                .SetNumber = 1,
                .Weight = 60,
                .Reps = 12
            })
            legDay.Exercises.Add(ex2)

            CurrentTemplates.Add(legDay)
        End If
    End Sub

    ' Handy method to generate a new TemplateID
    Public Shared Function GetNextTemplateID() As Integer
        If CurrentTemplates.Count = 0 Then
            Return 1
        End If
        Return CurrentTemplates.Max(Function(t) t.TemplateID) + 1
    End Function
End Class
