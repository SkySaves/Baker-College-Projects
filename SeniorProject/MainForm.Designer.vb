﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        btnWorkout = New Button()
        btnNutrition = New Button()
        Me.SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ImageAlign = ContentAlignment.TopCenter
        Label1.Location = New Point(146, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(289, 21)
        Label1.TabIndex = 0
        Label1.Text = "Please select where you would like to go"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' btnWorkout
        ' 
        btnWorkout.BackColor = SystemColors.ActiveCaptionText
        btnWorkout.ForeColor = SystemColors.ButtonHighlight
        btnWorkout.Location = New Point(207, 96)
        btnWorkout.Margin = New Padding(3, 2, 3, 2)
        btnWorkout.Name = "btnWorkout"
        btnWorkout.Size = New Size(194, 61)
        btnWorkout.TabIndex = 1
        btnWorkout.Text = "Workout Tracker"
        btnWorkout.UseVisualStyleBackColor = False
        ' 
        ' btnNutrition
        ' 
        btnNutrition.BackColor = SystemColors.ActiveCaptionText
        btnNutrition.ForeColor = SystemColors.ButtonHighlight
        btnNutrition.Location = New Point(207, 194)
        btnNutrition.Margin = New Padding(3, 2, 3, 2)
        btnNutrition.Name = "btnNutrition"
        btnNutrition.Size = New Size(194, 61)
        btnNutrition.TabIndex = 2
        btnNutrition.Text = "Nutrition Tracker"
        btnNutrition.UseVisualStyleBackColor = False
        ' 
        ' MainForm
        ' 
        Me.AutoScaleDimensions = New SizeF(7F, 15F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(605, 338)
        Me.Controls.Add(btnNutrition)
        Me.Controls.Add(btnWorkout)
        Me.Controls.Add(Label1)
        Me.Margin = New Padding(3, 2, 3, 2)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnWorkout As Button
    Friend WithEvents btnNutrition As Button

End Class
