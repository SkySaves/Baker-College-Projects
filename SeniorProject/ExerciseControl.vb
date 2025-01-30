Public Class ExerciseControl
    Inherits UserControl

    Private _exercise As Exercise

    ' This event lets the parent form know if sets/exercise are updated, or if user 
    ' clicks "Add Set," etc.
    Public Event ExerciseChanged(ByVal sender As Object, ByVal e As EventArgs)
    Public Event AddSetClicked(ByVal sender As ExerciseControl, ByVal e As EventArgs)
    Public Event ExerciseNotesClicked(ByVal sender As ExerciseControl, ByVal e As EventArgs)

    Public Sub New(ex As Exercise)
        InitializeComponent()
        _exercise = ex
        PopulateExerciseData()
    End Sub

    ' If using a parameterless constructor (Designer usually wants one),
    ' you can do Overloads or pass in data after InitializeComponent.
    Public Sub New()
        InitializeComponent()
    End Sub

    Public ReadOnly Property BoundExercise As Exercise
        Get
            Return _exercise
        End Get
    End Property



    Private Sub ExerciseControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' If you only have ex in constructor, you can move Populate call here, etc.
    End Sub

    Private Sub PopulateExerciseData()
        If _exercise Is Nothing Then Return

        txtExerciseName.Text = _exercise.ExerciseName
        If String.IsNullOrWhiteSpace(_exercise.Notes) Then
            pnlNotes.Visible = False
        Else
            pnlNotes.Visible = True
            txtExerciseNotes.Text = _exercise.Notes
        End If

        ' Clear existing rows in your sets table (DataGridView or TableLayoutPanel, etc.)
        dgvSets.Rows.Clear()

        For i As Integer = 0 To _exercise.Sets.Count - 1
            Dim s As ExerciseSet = _exercise.Sets(i)
            dgvSets.Rows.Add(
                s.SetNumber.ToString(),
                $"{s.PreviousWeight} lbs × {s.PreviousReps}",
                s.Weight.ToString(),
                s.Reps.ToString(),
                s.IsCompleted
            )
        Next
    End Sub

    Private Sub btnAddSet_Click(sender As Object, e As EventArgs) Handles btnAddSet.Click
        RaiseEvent AddSetClicked(Me, EventArgs.Empty)
    End Sub

    ' If you have a button or label to toggle the note area:
    'Private Sub btnToggleNotes_Click(sender As Object, e As EventArgs) Handles btnToggleNotes.Click
    ' pnlNotes.Visible = Not pnlNotes.Visible
    'End Sub

    ' If the user changes sets in the DGV, or checks them off, handle it:
    Private Sub dgvSets_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) _
        Handles dgvSets.CellValueChanged

        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim row = dgvSets.Rows(e.RowIndex)
            Dim setObj = _exercise.Sets(e.RowIndex)

            ' Column mapping depends on how you set up your DataGridView:
            setObj.SetNumber = CInt(row.Cells("colSetNumber").Value)
            ' The 'Previous' column is read-only (optional).
            setObj.Weight = CDbl(row.Cells("colWeight").Value)
            setObj.Reps = CInt(row.Cells("colReps").Value)
            setObj.IsCompleted = CBool(row.Cells("colCompleted").Value)

            RaiseEvent ExerciseChanged(Me, EventArgs.Empty)
        End If
    End Sub

End Class
