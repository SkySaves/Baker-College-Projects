<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WorkoutFormIndividual
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        components = New ComponentModel.Container()
        btnBack = New Button()
        lblWorkoutName = New Label()
        Label2 = New Label()
        Panel1 = New Panel()
        txtWorkoutNote = New TextBox()
        btnFinish = New Button()
        Panel2 = New Panel()
        lblElapsedTime = New Label()
        flpExercises = New FlowLayoutPanel()
        btnCancel = New Button()
        Timer1 = New Timer(components)
        btnAddExercise = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = SystemColors.ControlText
        btnBack.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBack.ForeColor = SystemColors.ButtonHighlight
        btnBack.Location = New Point(38, 28)
        btnBack.Margin = New Padding(3, 2, 3, 2)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(82, 35)
        btnBack.TabIndex = 1
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' lblWorkoutName
        ' 
        lblWorkoutName.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblWorkoutName.Location = New Point(74, 97)
        lblWorkoutName.Name = "lblWorkoutName"
        lblWorkoutName.Size = New Size(196, 21)
        lblWorkoutName.TabIndex = 3
        lblWorkoutName.Text = "Insert Workout Name Here"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(575, 75)
        Label2.Name = "Label2"
        Label2.Size = New Size(128, 42)
        Label2.TabIndex = 4
        Label2.Text = "Current Duration" & vbCrLf & "of Workout:"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(txtWorkoutNote)
        Panel1.Location = New Point(147, 176)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(556, 44)
        Panel1.TabIndex = 5
        ' 
        ' txtWorkoutNote
        ' 
        txtWorkoutNote.Location = New Point(3, 13)
        txtWorkoutNote.Margin = New Padding(3, 2, 3, 2)
        txtWorkoutNote.Name = "txtWorkoutNote"
        txtWorkoutNote.Size = New Size(536, 23)
        txtWorkoutNote.TabIndex = 0
        txtWorkoutNote.Text = "Workout note (optional)"
        ' 
        ' btnFinish
        ' 
        btnFinish.BackColor = SystemColors.ControlText
        btnFinish.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnFinish.ForeColor = SystemColors.ButtonHighlight
        btnFinish.Location = New Point(704, 28)
        btnFinish.Margin = New Padding(3, 2, 3, 2)
        btnFinish.Name = "btnFinish"
        btnFinish.Size = New Size(82, 35)
        btnFinish.TabIndex = 6
        btnFinish.Text = "Finish"
        btnFinish.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(lblElapsedTime)
        Panel2.Location = New Point(704, 75)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(118, 56)
        Panel2.TabIndex = 7
        ' 
        ' lblElapsedTime
        ' 
        lblElapsedTime.AutoSize = True
        lblElapsedTime.Location = New Point(23, 13)
        lblElapsedTime.Name = "lblElapsedTime"
        lblElapsedTime.Size = New Size(93, 30)
        lblElapsedTime.TabIndex = 0
        lblElapsedTime.Text = "Current Time on" & vbCrLf & "Rest Timer"
        ' 
        ' flpExercises
        ' 
        flpExercises.AutoScroll = True
        flpExercises.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpExercises.Location = New Point(38, 224)
        flpExercises.Margin = New Padding(3, 2, 3, 2)
        flpExercises.Name = "flpExercises"
        flpExercises.Size = New Size(782, 366)
        flpExercises.TabIndex = 8
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(22, 610)
        btnCancel.Margin = New Padding(3, 2, 3, 2)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(99, 33)
        btnCancel.TabIndex = 9
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        ' 
        ' btnAddExercise
        ' 
        btnAddExercise.Location = New Point(365, 611)
        btnAddExercise.Margin = New Padding(3, 2, 3, 2)
        btnAddExercise.Name = "btnAddExercise"
        btnAddExercise.Size = New Size(114, 32)
        btnAddExercise.TabIndex = 10
        btnAddExercise.Text = "Add Exercise"
        btnAddExercise.UseVisualStyleBackColor = True
        ' 
        ' WorkoutFormIndividual
        ' 
        Me.AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(844, 672)
        Me.Controls.Add(flpExercises)
        Me.Controls.Add(btnAddExercise)
        Me.Controls.Add(btnCancel)
        Me.Controls.Add(Panel2)
        Me.Controls.Add(btnFinish)
        Me.Controls.Add(Panel1)
        Me.Controls.Add(Label2)
        Me.Controls.Add(lblWorkoutName)
        Me.Controls.Add(btnBack)
        Me.Margin = New Padding(3, 2, 3, 2)
        Me.Name = "WorkoutFormIndividual"
        Me.Text = "WorkoutFormIndividual"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
    Friend WithEvents btnBack As Button
    Friend WithEvents lblWorkoutName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtWorkoutNote As TextBox
    Friend WithEvents btnFinish As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblElapsedTime As Label
    Friend WithEvents flpExercises As FlowLayoutPanel
    Friend WithEvents btnCancel As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnAddExercise As Button
End Class
