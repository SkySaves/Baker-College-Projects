Imports System.Linq

Public Class WorkoutDataStore
    ' This shared list holds all templates in memory.
    Public Shared CurrentTemplates As New List(Of WorkoutTemplate)()

    Public Shared Sub Initialize()
        Try
            If CurrentTemplates.Count = 0 Then
                Dim legDay As New WorkoutTemplate With {
                    .TemplateID = 1,
                    .TemplateName = "Leg Day",
                    .LastPerformedOn = DateTime.Now.AddDays(-3)
                }

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
        Catch ex As Exception
            MessageBox.Show("Error initializing workout templates: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Shared Function GetNextTemplateID() As Integer
        Try
            If CurrentTemplates.Count = 0 Then
                Return 1
            End If
            Return CurrentTemplates.Max(Function(t) t.TemplateID) + 1
        Catch ex As Exception
            MessageBox.Show("Error generating next template ID: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 1
        End Try
    End Function
End Class
