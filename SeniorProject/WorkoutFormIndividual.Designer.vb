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
        btnBack = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Panel1 = New Panel()
        TextBox1 = New TextBox()
        btnFinish = New Button()
        Panel2 = New Panel()
        lbTimer = New Label()
        Label3 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = SystemColors.ControlText
        btnBack.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBack.ForeColor = SystemColors.ButtonHighlight
        btnBack.Location = New Point(44, 38)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(94, 47)
        btnBack.TabIndex = 1
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(85, 129)
        Label1.Name = "Label1"
        Label1.Size = New Size(245, 28)
        Label1.TabIndex = 3
        Label1.Text = "Insert Workout Name Here"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(85, 167)
        Label2.Name = "Label2"
        Label2.Size = New Size(264, 28)
        Label2.TabIndex = 4
        Label2.Text = "Current Duration of Workout"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(TextBox1)
        Panel1.Location = New Point(168, 234)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(635, 59)
        Panel1.TabIndex = 5
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(3, 17)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(612, 27)
        TextBox1.TabIndex = 0
        TextBox1.Text = "Workout note (optional)"
        ' 
        ' btnFinish
        ' 
        btnFinish.BackColor = SystemColors.ControlText
        btnFinish.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnFinish.ForeColor = SystemColors.ButtonHighlight
        btnFinish.Location = New Point(804, 38)
        btnFinish.Name = "btnFinish"
        btnFinish.Size = New Size(94, 47)
        btnFinish.TabIndex = 6
        btnFinish.Text = "Finish"
        btnFinish.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(lbTimer)
        Panel2.Location = New Point(778, 100)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(155, 78)
        Panel2.TabIndex = 7
        ' 
        ' lbTimer
        ' 
        lbTimer.AutoSize = True
        lbTimer.Location = New Point(26, 17)
        lbTimer.Name = "lbTimer"
        lbTimer.Size = New Size(115, 40)
        lbTimer.TabIndex = 0
        lbTimer.Text = "Current Time on" & vbCrLf & "Rest Timer"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(150, 419)
        Label3.Name = "Label3"
        Label3.Size = New Size(398, 20)
        Label3.TabIndex = 8
        Label3.Text = "INSERT ALL WORKOUT DETAILS FOR EACH EXERCISE HERE"
        ' 
        ' WorkoutFormIndividual
        ' 
        Me.AutoScaleDimensions = New SizeF(8F, 20F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(964, 1058)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Panel2)
        Me.Controls.Add(btnFinish)
        Me.Controls.Add(Panel1)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(btnBack)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnFinish As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbTimer As Label
    Friend WithEvents Label3 As Label
End Class
