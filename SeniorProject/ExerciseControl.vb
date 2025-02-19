Public Class ExerciseControl
    Inherits UserControl

    Private _exercise As Exercise

    ' This event lets the parent form know if sets/exercise are updated, or if user 
    ' clicks "Add Set," etc.
    Public Event ExerciseChanged(ByVal sender As Object, ByVal e As EventArgs)
    Public Event AddSetClicked(ByVal sender As ExerciseControl, ByVal e As EventArgs)
    Public Event ExerciseNotesClicked(ByVal sender As ExerciseControl, ByVal e As EventArgs)

    ' Constructor taking an Exercise instance
    Public Sub New(ex As Exercise)
        InitializeComponent()
        _exercise = ex
        PopulateExerciseData()
    End Sub

    ' Parameterless constructor for Designer
    Public Sub New()
        InitializeComponent()
    End Sub

    Public ReadOnly Property BoundExercise As Exercise
        Get
            Return _exercise
        End Get
    End Property

    Private Sub ExerciseControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _exercise IsNot Nothing Then PopulateExerciseData()
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

        dgvSets.Rows.Clear()

        ' NOTE: Removed the previous data from the row.
        For i As Integer = 0 To _exercise.Sets.Count - 1
            Dim s As ExerciseSet = _exercise.Sets(i)
            dgvSets.Rows.Add(
                s.SetNumber.ToString(),
                s.Weight.ToString(),
                s.Reps.ToString(),
                s.IsCompleted)
        Next
    End Sub

    Private Sub btnAddSet_Click(sender As Object, e As EventArgs) Handles btnAddSet.Click
        RaiseEvent AddSetClicked(Me, EventArgs.Empty)
    End Sub

    Private Sub dgvSets_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) _
        Handles dgvSets.CellValueChanged

        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim row = dgvSets.Rows(e.RowIndex)
            Dim setObj = _exercise.Sets(e.RowIndex)

            Try
                ' Only update the editable columns.
                setObj.SetNumber = CInt(row.Cells("colSetNumber").Value)
                setObj.Weight = CDbl(row.Cells("colWeight").Value)
                setObj.Reps = CInt(row.Cells("colReps").Value)
                setObj.IsCompleted = Convert.ToBoolean(row.Cells("colCompleted").Value)

                RaiseEvent ExerciseChanged(Me, EventArgs.Empty)
            Catch ex As Exception
                MessageBox.Show("Invalid input in the sets grid. Please check your values." & Environment.NewLine & ex.Message,
                                "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                PopulateExerciseData()
            End Try
        End If
    End Sub

    Private Sub txtExerciseName_TextChanged(sender As Object, e As EventArgs) Handles txtExerciseName.TextChanged
        If _exercise IsNot Nothing Then
            _exercise.ExerciseName = txtExerciseName.Text
            RaiseEvent ExerciseChanged(Me, EventArgs.Empty)
        End If
    End Sub

    Private Sub txtExerciseNotes_TextChanged(sender As Object, e As EventArgs) Handles txtExerciseNotes.TextChanged
        If _exercise IsNot Nothing Then
            _exercise.Notes = txtExerciseNotes.Text
            RaiseEvent ExerciseChanged(Me, EventArgs.Empty)
        End If
    End Sub

End Class
