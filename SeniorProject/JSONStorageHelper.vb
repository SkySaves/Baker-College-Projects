Imports System.IO
Imports Newtonsoft.Json

Public Class JSONStorageHelper

    Private Shared logsFile As String = Path.Combine(Application.StartupPath, "dailyLogs.json")

    Public Shared Sub SaveDailyLogs(logs As Dictionary(Of Date, DailyLog))
        Try
            Dim json = JsonConvert.SerializeObject(logs, Formatting.Indented)
            File.WriteAllText(logsFile, json)
        Catch ex As Exception
            MessageBox.Show("Error saving daily logs: " & ex.Message, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Shared Function LoadDailyLogs() As Dictionary(Of Date, DailyLog)
        Try
            If Not File.Exists(logsFile) Then
                Return New Dictionary(Of Date, DailyLog)()
            End If

            Dim json = File.ReadAllText(logsFile)
            Dim result = JsonConvert.DeserializeObject(Of Dictionary(Of Date, DailyLog))(json)
            If result Is Nothing Then
                Return New Dictionary(Of Date, DailyLog)()
            End If
            Return result
        Catch ex As Exception
            MessageBox.Show("Error loading daily logs: " & ex.Message, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return New Dictionary(Of Date, DailyLog)()
        End Try
    End Function
End Class
