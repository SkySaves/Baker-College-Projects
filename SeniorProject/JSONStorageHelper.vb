Imports System.IO
Imports Newtonsoft.Json

Public Class JSONStorageHelper

    Private Shared logsFile As String =
        System.IO.Path.Combine(Application.StartupPath, "dailyLogs.json")

    Public Shared Sub SaveDailyLogs(logs As Dictionary(Of Date, DailyLog))
        Dim json = JsonConvert.SerializeObject(logs, Formatting.Indented)
        File.WriteAllText(logsFile, json)
    End Sub

    Public Shared Function LoadDailyLogs() As Dictionary(Of Date, DailyLog)
        If Not File.Exists(logsFile) Then
            Return New Dictionary(Of Date, DailyLog)()
        End If

        Dim json = File.ReadAllText(logsFile)
        Dim result = JsonConvert.DeserializeObject(Of Dictionary(Of Date, DailyLog))(json)
        If result Is Nothing Then
            Return New Dictionary(Of Date, DailyLog)()
        End If
        Return result
    End Function

End Class
