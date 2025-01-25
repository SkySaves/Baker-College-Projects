<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NutritionForm
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
        Label1 = New Label()
        btnNextDay = New Button()
        btnPreviousDay = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        lbConsumed = New Label()
        lbBurned = New Label()
        lbRemaining = New Label()
        lbEnergy = New Label()
        Label5 = New Label()
        Label6 = New Label()
        lbProtein = New Label()
        Label7 = New Label()
        lbCarbs = New Label()
        Label9 = New Label()
        lbFat = New Label()
        btnAddUncat = New Button()
        btnAddBreakfast = New Button()
        btnAddLunch = New Button()
        btnAddDinner = New Button()
        btnAddSnacks = New Button()
        TableLayoutPanel1 = New TableLayoutPanel()
        cbSnacks = New ComboBox()
        cbDinner = New ComboBox()
        cbLunch = New ComboBox()
        cbBreakfast = New ComboBox()
        cbUncat = New ComboBox()
        btnBack = New Button()
        TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(383, 61)
        Label1.Name = "Label1"
        Label1.Size = New Size(65, 25)
        Label1.TabIndex = 0
        Label1.Text = "Today"
        ' 
        ' btnNextDay
        ' 
        btnNextDay.BackColor = SystemColors.ControlText
        btnNextDay.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnNextDay.ForeColor = SystemColors.ButtonHighlight
        btnNextDay.Location = New Point(456, 56)
        btnNextDay.Margin = New Padding(3, 2, 3, 2)
        btnNextDay.Name = "btnNextDay"
        btnNextDay.Size = New Size(51, 33)
        btnNextDay.TabIndex = 2
        btnNextDay.Text = "->"
        btnNextDay.UseVisualStyleBackColor = False
        ' 
        ' btnPreviousDay
        ' 
        btnPreviousDay.BackColor = SystemColors.ControlText
        btnPreviousDay.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPreviousDay.ForeColor = SystemColors.ButtonHighlight
        btnPreviousDay.Location = New Point(327, 56)
        btnPreviousDay.Margin = New Padding(3, 2, 3, 2)
        btnPreviousDay.Name = "btnPreviousDay"
        btnPreviousDay.Size = New Size(51, 33)
        btnPreviousDay.TabIndex = 3
        btnPreviousDay.Text = "<-"
        btnPreviousDay.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(371, 126)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 25)
        Label2.TabIndex = 4
        Label2.Text = "Burned"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(204, 126)
        Label3.Name = "Label3"
        Label3.Size = New Size(102, 25)
        Label3.TabIndex = 5
        Label3.Text = "Consumed"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(507, 126)
        Label4.Name = "Label4"
        Label4.Size = New Size(101, 25)
        Label4.TabIndex = 6
        Label4.Text = "Remaining"
        ' 
        ' lbConsumed
        ' 
        lbConsumed.AutoSize = True
        lbConsumed.BorderStyle = BorderStyle.FixedSingle
        lbConsumed.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbConsumed.Location = New Point(225, 162)
        lbConsumed.Name = "lbConsumed"
        lbConsumed.Size = New Size(58, 23)
        lbConsumed.TabIndex = 7
        lbConsumed.Text = "Label5"
        ' 
        ' lbBurned
        ' 
        lbBurned.AutoSize = True
        lbBurned.BorderStyle = BorderStyle.FixedSingle
        lbBurned.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbBurned.Location = New Point(374, 162)
        lbBurned.Name = "lbBurned"
        lbBurned.Size = New Size(58, 23)
        lbBurned.TabIndex = 8
        lbBurned.Text = "Label6"
        ' 
        ' lbRemaining
        ' 
        lbRemaining.AutoSize = True
        lbRemaining.BorderStyle = BorderStyle.FixedSingle
        lbRemaining.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbRemaining.Location = New Point(522, 162)
        lbRemaining.Name = "lbRemaining"
        lbRemaining.Size = New Size(58, 23)
        lbRemaining.TabIndex = 9
        lbRemaining.Text = "Label7"
        ' 
        ' lbEnergy
        ' 
        lbEnergy.AutoSize = True
        lbEnergy.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbEnergy.Location = New Point(269, 221)
        lbEnergy.Name = "lbEnergy"
        lbEnergy.Size = New Size(56, 21)
        lbEnergy.TabIndex = 10
        lbEnergy.Text = "Label5"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(189, 221)
        Label5.Name = "Label5"
        Label5.Size = New Size(68, 21)
        Label5.TabIndex = 11
        Label5.Text = "Energy -"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(189, 256)
        Label6.Name = "Label6"
        Label6.Size = New Size(70, 21)
        Label6.TabIndex = 13
        Label6.Text = "Protein -"
        ' 
        ' lbProtein
        ' 
        lbProtein.AutoSize = True
        lbProtein.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbProtein.Location = New Point(269, 256)
        lbProtein.Name = "lbProtein"
        lbProtein.Size = New Size(56, 21)
        lbProtein.TabIndex = 12
        lbProtein.Text = "Label5"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(189, 290)
        Label7.Name = "Label7"
        Label7.Size = New Size(89, 21)
        Label7.TabIndex = 15
        Label7.Text = "Net Carbs -"
        ' 
        ' lbCarbs
        ' 
        lbCarbs.AutoSize = True
        lbCarbs.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbCarbs.Location = New Point(291, 290)
        lbCarbs.Name = "lbCarbs"
        lbCarbs.Size = New Size(56, 21)
        lbCarbs.TabIndex = 14
        lbCarbs.Text = "Label5"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(189, 326)
        Label9.Name = "Label9"
        Label9.Size = New Size(40, 21)
        Label9.TabIndex = 17
        Label9.Text = "Fat -"
        ' 
        ' lbFat
        ' 
        lbFat.AutoSize = True
        lbFat.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbFat.Location = New Point(239, 326)
        lbFat.Name = "lbFat"
        lbFat.Size = New Size(56, 21)
        lbFat.TabIndex = 16
        lbFat.Text = "Label5"
        ' 
        ' btnAddUncat
        ' 
        btnAddUncat.AutoSize = True
        btnAddUncat.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnAddUncat.Dock = DockStyle.Fill
        btnAddUncat.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAddUncat.Location = New Point(3, 2)
        btnAddUncat.Margin = New Padding(3, 2, 3, 2)
        btnAddUncat.Name = "btnAddUncat"
        btnAddUncat.Size = New Size(36, 31)
        btnAddUncat.TabIndex = 18
        btnAddUncat.Text = "+"
        btnAddUncat.UseVisualStyleBackColor = True
        ' 
        ' btnAddBreakfast
        ' 
        btnAddBreakfast.AutoSize = True
        btnAddBreakfast.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnAddBreakfast.Dock = DockStyle.Fill
        btnAddBreakfast.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAddBreakfast.Location = New Point(3, 37)
        btnAddBreakfast.Margin = New Padding(3, 2, 3, 2)
        btnAddBreakfast.Name = "btnAddBreakfast"
        btnAddBreakfast.Size = New Size(36, 31)
        btnAddBreakfast.TabIndex = 19
        btnAddBreakfast.Text = "+"
        btnAddBreakfast.UseVisualStyleBackColor = True
        ' 
        ' btnAddLunch
        ' 
        btnAddLunch.AutoSize = True
        btnAddLunch.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnAddLunch.Dock = DockStyle.Fill
        btnAddLunch.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAddLunch.Location = New Point(3, 72)
        btnAddLunch.Margin = New Padding(3, 2, 3, 2)
        btnAddLunch.Name = "btnAddLunch"
        btnAddLunch.Size = New Size(36, 31)
        btnAddLunch.TabIndex = 20
        btnAddLunch.Text = "+"
        btnAddLunch.UseVisualStyleBackColor = True
        ' 
        ' btnAddDinner
        ' 
        btnAddDinner.AutoSize = True
        btnAddDinner.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnAddDinner.Dock = DockStyle.Fill
        btnAddDinner.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAddDinner.Location = New Point(3, 107)
        btnAddDinner.Margin = New Padding(3, 2, 3, 2)
        btnAddDinner.Name = "btnAddDinner"
        btnAddDinner.Size = New Size(36, 31)
        btnAddDinner.TabIndex = 21
        btnAddDinner.Text = "+"
        btnAddDinner.UseVisualStyleBackColor = True
        ' 
        ' btnAddSnacks
        ' 
        btnAddSnacks.AutoSize = True
        btnAddSnacks.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnAddSnacks.Dock = DockStyle.Fill
        btnAddSnacks.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAddSnacks.Location = New Point(3, 142)
        btnAddSnacks.Margin = New Padding(3, 2, 3, 2)
        btnAddSnacks.Name = "btnAddSnacks"
        btnAddSnacks.Size = New Size(36, 31)
        btnAddSnacks.TabIndex = 22
        btnAddSnacks.Text = "+"
        btnAddSnacks.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 6.78670359F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 93.213295F))
        TableLayoutPanel1.Controls.Add(cbSnacks, 1, 4)
        TableLayoutPanel1.Controls.Add(cbDinner, 1, 3)
        TableLayoutPanel1.Controls.Add(cbLunch, 1, 2)
        TableLayoutPanel1.Controls.Add(cbBreakfast, 1, 1)
        TableLayoutPanel1.Controls.Add(btnAddSnacks, 0, 4)
        TableLayoutPanel1.Controls.Add(btnAddBreakfast, 0, 1)
        TableLayoutPanel1.Controls.Add(btnAddDinner, 0, 3)
        TableLayoutPanel1.Controls.Add(btnAddLunch, 0, 2)
        TableLayoutPanel1.Controls.Add(btnAddUncat, 0, 0)
        TableLayoutPanel1.Controls.Add(cbUncat, 1, 0)
        TableLayoutPanel1.Location = New Point(144, 377)
        TableLayoutPanel1.Margin = New Padding(3, 2, 3, 2)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 5
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.Size = New Size(623, 165)
        TableLayoutPanel1.TabIndex = 23
        ' 
        ' cbSnacks
        ' 
        cbSnacks.Dock = DockStyle.Fill
        cbSnacks.FormattingEnabled = True
        cbSnacks.Location = New Point(45, 142)
        cbSnacks.Margin = New Padding(3, 2, 3, 2)
        cbSnacks.Name = "cbSnacks"
        cbSnacks.Size = New Size(575, 23)
        cbSnacks.TabIndex = 27
        ' 
        ' cbDinner
        ' 
        cbDinner.Dock = DockStyle.Fill
        cbDinner.FormattingEnabled = True
        cbDinner.Location = New Point(45, 107)
        cbDinner.Margin = New Padding(3, 2, 3, 2)
        cbDinner.Name = "cbDinner"
        cbDinner.Size = New Size(575, 23)
        cbDinner.TabIndex = 26
        ' 
        ' cbLunch
        ' 
        cbLunch.Dock = DockStyle.Fill
        cbLunch.FormattingEnabled = True
        cbLunch.Location = New Point(45, 72)
        cbLunch.Margin = New Padding(3, 2, 3, 2)
        cbLunch.Name = "cbLunch"
        cbLunch.Size = New Size(575, 23)
        cbLunch.TabIndex = 25
        ' 
        ' cbBreakfast
        ' 
        cbBreakfast.Dock = DockStyle.Fill
        cbBreakfast.FormattingEnabled = True
        cbBreakfast.Location = New Point(45, 37)
        cbBreakfast.Margin = New Padding(3, 2, 3, 2)
        cbBreakfast.Name = "cbBreakfast"
        cbBreakfast.Size = New Size(575, 23)
        cbBreakfast.TabIndex = 24
        ' 
        ' cbUncat
        ' 
        cbUncat.Dock = DockStyle.Fill
        cbUncat.FormattingEnabled = True
        cbUncat.Location = New Point(45, 2)
        cbUncat.Margin = New Padding(3, 2, 3, 2)
        cbUncat.Name = "cbUncat"
        cbUncat.Size = New Size(575, 23)
        cbUncat.TabIndex = 23
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = SystemColors.ControlText
        btnBack.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBack.ForeColor = SystemColors.ButtonHighlight
        btnBack.Location = New Point(26, 32)
        btnBack.Margin = New Padding(3, 2, 3, 2)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(82, 32)
        btnBack.TabIndex = 24
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' NutritionForm
        ' 
        Me.AutoScaleDimensions = New SizeF(7F, 15F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(888, 642)
        Me.Controls.Add(btnBack)
        Me.Controls.Add(TableLayoutPanel1)
        Me.Controls.Add(Label9)
        Me.Controls.Add(lbFat)
        Me.Controls.Add(Label7)
        Me.Controls.Add(lbCarbs)
        Me.Controls.Add(Label6)
        Me.Controls.Add(lbProtein)
        Me.Controls.Add(Label5)
        Me.Controls.Add(lbEnergy)
        Me.Controls.Add(lbRemaining)
        Me.Controls.Add(lbBurned)
        Me.Controls.Add(lbConsumed)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label2)
        Me.Controls.Add(btnPreviousDay)
        Me.Controls.Add(btnNextDay)
        Me.Controls.Add(Label1)
        Me.Margin = New Padding(3, 2, 3, 2)
        Me.Name = "NutritionForm"
        Me.Text = "NutritionForm"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnNextDay As Button
    Friend WithEvents btnPreviousDay As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbConsumed As Label
    Friend WithEvents lbBurned As Label
    Friend WithEvents lbRemaining As Label
    Friend WithEvents lbEnergy As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbProtein As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbCarbs As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbFat As Label
    Friend WithEvents btnAddUncat As Button
    Friend WithEvents btnAddBreakfast As Button
    Friend WithEvents btnAddLunch As Button
    Friend WithEvents btnAddDinner As Button
    Friend WithEvents btnAddSnacks As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents cbUncat As ComboBox
    Friend WithEvents cbSnacks As ComboBox
    Friend WithEvents cbDinner As ComboBox
    Friend WithEvents cbLunch As ComboBox
    Friend WithEvents cbBreakfast As ComboBox
    Friend WithEvents btnBack As Button
End Class
