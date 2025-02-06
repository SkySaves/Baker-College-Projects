<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExerciseControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        pnlNotes = New Panel()
        txtExerciseNotes = New RichTextBox()
        btnAddSet = New Button()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        dgvSets = New DataGridView()
        colSetNumber = New DataGridViewTextBoxColumn()
        colPrevious = New DataGridViewTextBoxColumn()
        colWeight = New DataGridViewTextBoxColumn()
        colReps = New DataGridViewTextBoxColumn()
        colCompleted = New DataGridViewCheckBoxColumn()
        txtExerciseName = New TextBox()
        pnlNotes.SuspendLayout()
        CType(dgvSets, ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' pnlNotes
        ' 
        pnlNotes.Controls.Add(txtExerciseNotes)
        pnlNotes.Location = New Point(118, 80)
        pnlNotes.Name = "pnlNotes"
        pnlNotes.Size = New Size(507, 64)
        pnlNotes.TabIndex = 1
        ' 
        ' txtExerciseNotes
        ' 
        txtExerciseNotes.Location = New Point(19, 0)
        txtExerciseNotes.Name = "txtExerciseNotes"
        txtExerciseNotes.Size = New Size(447, 59)
        txtExerciseNotes.TabIndex = 0
        txtExerciseNotes.Text = ""
        ' 
        ' btnAddSet
        ' 
        btnAddSet.Location = New Point(325, 247)
        btnAddSet.Name = "btnAddSet"
        btnAddSet.Size = New Size(75, 23)
        btnAddSet.TabIndex = 2
        btnAddSet.Text = "Add Set"
        btnAddSet.UseVisualStyleBackColor = True
        ' 
        ' dgvSets
        ' 
        dgvSets.Anchor = AnchorStyles.None
        dgvSets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvSets.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvSets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSets.Columns.AddRange(New DataGridViewColumn() {colSetNumber, colPrevious, colWeight, colReps, colCompleted})
        dgvSets.Location = New Point(100, 149)
        dgvSets.Name = "dgvSets"
        dgvSets.Size = New Size(543, 92)
        dgvSets.TabIndex = 3
        ' 
        ' colSetNumber
        ' 
        colSetNumber.HeaderText = "Set #"
        colSetNumber.Name = "colSetNumber"
        colSetNumber.ReadOnly = True
        ' 
        ' colPrevious
        ' 
        colPrevious.HeaderText = "Previous"
        colPrevious.Name = "colPrevious"
        colPrevious.ReadOnly = True
        ' 
        ' colWeight
        ' 
        colWeight.HeaderText = "Weight"
        colWeight.Name = "colWeight"
        ' 
        ' colReps
        ' 
        colReps.HeaderText = "Reps"
        colReps.Name = "colReps"
        ' 
        ' colCompleted
        ' 
        colCompleted.HeaderText = "Completed"
        colCompleted.Name = "colCompleted"
        colCompleted.Resizable = DataGridViewTriState.True
        colCompleted.SortMode = DataGridViewColumnSortMode.Automatic
        ' 
        ' txtExerciseName
        ' 
        txtExerciseName.Anchor = AnchorStyles.None
        txtExerciseName.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtExerciseName.Location = New Point(310, 41)
        txtExerciseName.Name = "txtExerciseName"
        txtExerciseName.Size = New Size(146, 33)
        txtExerciseName.TabIndex = 4
        ' 
        ' ExerciseControl
        ' 
        Me.AutoScaleDimensions = New SizeF(7F, 15F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.Controls.Add(txtExerciseName)
        Me.Controls.Add(dgvSets)
        Me.Controls.Add(btnAddSet)
        Me.Controls.Add(pnlNotes)
        Me.Name = "ExerciseControl"
        Me.Size = New Size(722, 331)
        pnlNotes.ResumeLayout(False)
        CType(dgvSets, ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
    Friend WithEvents pnlNotes As Panel
    Friend WithEvents txtExerciseNotes As RichTextBox
    Friend WithEvents btnAddSet As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents dgvSets As DataGridView
    Friend WithEvents colSetNumber As DataGridViewTextBoxColumn
    Friend WithEvents colWeight As DataGridViewTextBoxColumn
    Friend WithEvents colReps As DataGridViewTextBoxColumn
    Friend WithEvents colCompleted As DataGridViewCheckBoxColumn
    Friend WithEvents colPrevious As DataGridViewTextBoxColumn
    Friend WithEvents txtExerciseName As TextBox

End Class
