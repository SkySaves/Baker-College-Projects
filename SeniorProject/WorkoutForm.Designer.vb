<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WorkoutForm
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
        btnBack = New Button()
        lbWorkout = New Label()
        Label1 = New Label()
        btnStartEmptyWorkout = New Button()
        Label2 = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Panel7 = New Panel()
        lbExercise2 = New Label()
        lbExercise1 = New Label()
        lbLastPerformed = New Label()
        lbWorkoutName = New Label()
        Panel8 = New Panel()
        FlowLayoutPanel1.SuspendLayout()
        Panel7.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = SystemColors.ControlText
        btnBack.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBack.ForeColor = SystemColors.ButtonHighlight
        btnBack.Location = New Point(47, 47)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(94, 47)
        btnBack.TabIndex = 0
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' lbWorkout
        ' 
        lbWorkout.AutoSize = True
        lbWorkout.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbWorkout.Location = New Point(392, 101)
        lbWorkout.Name = "lbWorkout"
        lbWorkout.Size = New Size(162, 46)
        lbWorkout.TabIndex = 1
        lbWorkout.Text = "Workout"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(122, 199)
        Label1.Name = "Label1"
        Label1.Size = New Size(108, 28)
        Label1.TabIndex = 2
        Label1.Text = "Quick Start"
        ' 
        ' btnStartEmptyWorkout
        ' 
        btnStartEmptyWorkout.Location = New Point(122, 241)
        btnStartEmptyWorkout.Name = "btnStartEmptyWorkout"
        btnStartEmptyWorkout.Size = New Size(393, 40)
        btnStartEmptyWorkout.TabIndex = 3
        btnStartEmptyWorkout.Text = "START AN EMPTY WORKOUT"
        btnStartEmptyWorkout.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(122, 317)
        Label2.Name = "Label2"
        Label2.Size = New Size(132, 28)
        Label2.TabIndex = 4
        Label2.Text = "My Templates"
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.Controls.Add(Panel7)
        FlowLayoutPanel1.Location = New Point(122, 377)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(526, 449)
        FlowLayoutPanel1.TabIndex = 5
        ' 
        ' Panel7
        ' 
        Panel7.Controls.Add(lbExercise2)
        Panel7.Controls.Add(lbExercise1)
        Panel7.Controls.Add(lbLastPerformed)
        Panel7.Controls.Add(lbWorkoutName)
        Panel7.Controls.Add(Panel8)
        Panel7.Location = New Point(3, 3)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(523, 168)
        Panel7.TabIndex = 8
        ' 
        ' lbExercise2
        ' 
        lbExercise2.AutoSize = True
        lbExercise2.Location = New Point(12, 108)
        lbExercise2.Name = "lbExercise2"
        lbExercise2.Size = New Size(193, 20)
        lbExercise2.TabIndex = 4
        lbExercise2.Text = "3 x Leg Extension (Machine)"
        ' 
        ' lbExercise1
        ' 
        lbExercise1.AutoSize = True
        lbExercise1.Location = New Point(12, 87)
        lbExercise1.Name = "lbExercise1"
        lbExercise1.Size = New Size(194, 20)
        lbExercise1.TabIndex = 3
        lbExercise1.Text = "3 x Lying Leg Curl (Machine)"
        ' 
        ' lbLastPerformed
        ' 
        lbLastPerformed.AutoSize = True
        lbLastPerformed.Location = New Point(12, 41)
        lbLastPerformed.Name = "lbLastPerformed"
        lbLastPerformed.Size = New Size(215, 20)
        lbLastPerformed.TabIndex = 2
        lbLastPerformed.Text = "*Last Performed on ** days ago"
        ' 
        ' lbWorkoutName
        ' 
        lbWorkoutName.AutoSize = True
        lbWorkoutName.Location = New Point(11, 12)
        lbWorkoutName.Name = "lbWorkoutName"
        lbWorkoutName.Size = New Size(117, 20)
        lbWorkoutName.TabIndex = 1
        lbWorkoutName.Text = "*WorkoutName*"
        ' 
        ' Panel8
        ' 
        Panel8.Location = New Point(56, 120)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(8, 8)
        Panel8.TabIndex = 0
        ' 
        ' WorkoutForm
        ' 
        Me.AutoScaleDimensions = New SizeF(8F, 20F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(947, 859)
        Me.Controls.Add(FlowLayoutPanel1)
        Me.Controls.Add(Label2)
        Me.Controls.Add(btnStartEmptyWorkout)
        Me.Controls.Add(Label1)
        Me.Controls.Add(lbWorkout)
        Me.Controls.Add(btnBack)
        Me.Name = "WorkoutForm"
        Me.Text = "WorkoutForm"
        FlowLayoutPanel1.ResumeLayout(False)
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents lbWorkout As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnStartEmptyWorkout As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents lbExercise2 As Label
    Friend WithEvents lbExercise1 As Label
    Friend WithEvents lbLastPerformed As Label
    Friend WithEvents lbWorkoutName As Label
End Class
