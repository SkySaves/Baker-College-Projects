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
        lblDate = New Label()
        btnNextDay = New Button()
        btnPreviousDay = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        lblConsumed = New Label()
        lblBurned = New Label()
        lblRemaining = New Label()
        lblEnergy = New Label()
        Label5 = New Label()
        Label6 = New Label()
        lblProtein = New Label()
        Label7 = New Label()
        lblCarbs = New Label()
        Label9 = New Label()
        lblFat = New Label()
        btnBack = New Button()
        dgvFoods = New DataGridView()
        colMealCategory = New DataGridViewTextBoxColumn()
        colFoodName = New DataGridViewTextBoxColumn()
        colServingDescription = New DataGridViewTextBoxColumn()
        colCalories = New DataGridViewTextBoxColumn()
        colProtein = New DataGridViewTextBoxColumn()
        colCarbs = New DataGridViewTextBoxColumn()
        colFat = New DataGridViewTextBoxColumn()
        Label1 = New Label()
        Label8 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        btnAddUncat = New Button()
        btnAddLunch = New Button()
        btnAddDinner = New Button()
        btnAddBreakfast = New Button()
        TableLayoutPanel1 = New TableLayoutPanel()
        btnAddSnacks = New Button()
        CType(dgvFoods, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDate.Location = New Point(414, 53)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(65, 25)
        lblDate.TabIndex = 0
        lblDate.Text = "Today"
        ' 
        ' btnNextDay
        ' 
        btnNextDay.BackColor = SystemColors.ControlText
        btnNextDay.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnNextDay.ForeColor = SystemColors.ButtonHighlight
        btnNextDay.Location = New Point(704, 53)
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
        btnPreviousDay.Location = New Point(208, 53)
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
        ' lblConsumed
        ' 
        lblConsumed.AutoSize = True
        lblConsumed.BorderStyle = BorderStyle.FixedSingle
        lblConsumed.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblConsumed.Location = New Point(225, 162)
        lblConsumed.Name = "lblConsumed"
        lblConsumed.Size = New Size(58, 23)
        lblConsumed.TabIndex = 7
        lblConsumed.Text = "Label5"
        ' 
        ' lblBurned
        ' 
        lblBurned.AutoSize = True
        lblBurned.BorderStyle = BorderStyle.FixedSingle
        lblBurned.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblBurned.Location = New Point(374, 162)
        lblBurned.Name = "lblBurned"
        lblBurned.Size = New Size(58, 23)
        lblBurned.TabIndex = 8
        lblBurned.Text = "Label6"
        ' 
        ' lblRemaining
        ' 
        lblRemaining.AutoSize = True
        lblRemaining.BorderStyle = BorderStyle.FixedSingle
        lblRemaining.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblRemaining.Location = New Point(522, 162)
        lblRemaining.Name = "lblRemaining"
        lblRemaining.Size = New Size(58, 23)
        lblRemaining.TabIndex = 9
        lblRemaining.Text = "Label7"
        ' 
        ' lblEnergy
        ' 
        lblEnergy.AutoSize = True
        lblEnergy.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEnergy.Location = New Point(269, 221)
        lblEnergy.Name = "lblEnergy"
        lblEnergy.Size = New Size(56, 21)
        lblEnergy.TabIndex = 10
        lblEnergy.Text = "Label5"
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
        ' lblProtein
        ' 
        lblProtein.AutoSize = True
        lblProtein.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblProtein.Location = New Point(269, 256)
        lblProtein.Name = "lblProtein"
        lblProtein.Size = New Size(56, 21)
        lblProtein.TabIndex = 12
        lblProtein.Text = "Label5"
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
        ' lblCarbs
        ' 
        lblCarbs.AutoSize = True
        lblCarbs.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCarbs.Location = New Point(291, 290)
        lblCarbs.Name = "lblCarbs"
        lblCarbs.Size = New Size(56, 21)
        lblCarbs.TabIndex = 14
        lblCarbs.Text = "Label5"
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
        ' lblFat
        ' 
        lblFat.AutoSize = True
        lblFat.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblFat.Location = New Point(239, 326)
        lblFat.Name = "lblFat"
        lblFat.Size = New Size(56, 21)
        lblFat.TabIndex = 16
        lblFat.Text = "Label5"
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
        ' dgvFoods
        ' 
        dgvFoods.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvFoods.Columns.AddRange(New DataGridViewColumn() {colMealCategory, colFoodName, colServingDescription, colCalories, colProtein, colCarbs, colFat})
        dgvFoods.Location = New Point(189, 350)
        dgvFoods.Name = "dgvFoods"
        dgvFoods.Size = New Size(740, 214)
        dgvFoods.TabIndex = 25
        ' 
        ' colMealCategory
        ' 
        colMealCategory.HeaderText = "Meal Category"
        colMealCategory.Name = "colMealCategory"
        ' 
        ' colFoodName
        ' 
        colFoodName.HeaderText = "Food Name"
        colFoodName.Name = "colFoodName"
        ' 
        ' colServingDescription
        ' 
        colServingDescription.HeaderText = "Serving"
        colServingDescription.Name = "colServingDescription"
        ' 
        ' colCalories
        ' 
        colCalories.HeaderText = "Calories"
        colCalories.Name = "colCalories"
        ' 
        ' colProtein
        ' 
        colProtein.HeaderText = "Protein"
        colProtein.Name = "colProtein"
        ' 
        ' colCarbs
        ' 
        colCarbs.HeaderText = "Carbs"
        colCarbs.Name = "colCarbs"
        ' 
        ' colFat
        ' 
        colFat.HeaderText = "Fat"
        colFat.Name = "colFat"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(58, 389)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 15)
        Label1.TabIndex = 26
        Label1.Text = "Uncategorized"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(83, 424)
        Label8.Name = "Label8"
        Label8.Size = New Size(55, 15)
        Label8.TabIndex = 27
        Label8.Text = "Breakfast"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(101, 459)
        Label10.Name = "Label10"
        Label10.Size = New Size(40, 15)
        Label10.TabIndex = 28
        Label10.Text = "Lunch"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(96, 494)
        Label11.Name = "Label11"
        Label11.Size = New Size(42, 15)
        Label11.TabIndex = 29
        Label11.Text = "Dinner"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(95, 530)
        Label12.Name = "Label12"
        Label12.Size = New Size(43, 15)
        Label12.TabIndex = 30
        Label12.Text = "Snacks"
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
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 6.78670359F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 93.213295F))
        TableLayoutPanel1.Controls.Add(btnAddSnacks, 0, 4)
        TableLayoutPanel1.Controls.Add(btnAddBreakfast, 0, 1)
        TableLayoutPanel1.Controls.Add(btnAddDinner, 0, 3)
        TableLayoutPanel1.Controls.Add(btnAddLunch, 0, 2)
        TableLayoutPanel1.Controls.Add(btnAddUncat, 0, 0)
        TableLayoutPanel1.Location = New Point(144, 377)
        TableLayoutPanel1.Margin = New Padding(3, 2, 3, 2)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 5
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.Size = New Size(623, 176)
        TableLayoutPanel1.TabIndex = 23
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
        btnAddSnacks.Size = New Size(36, 32)
        btnAddSnacks.TabIndex = 22
        btnAddSnacks.Text = "+"
        btnAddSnacks.UseVisualStyleBackColor = True
        ' 
        ' NutritionForm
        ' 
        Me.AutoScaleDimensions = New SizeF(7F, 15F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(1021, 809)
        Me.Controls.Add(Label12)
        Me.Controls.Add(Label11)
        Me.Controls.Add(Label10)
        Me.Controls.Add(Label8)
        Me.Controls.Add(Label1)
        Me.Controls.Add(dgvFoods)
        Me.Controls.Add(btnBack)
        Me.Controls.Add(TableLayoutPanel1)
        Me.Controls.Add(Label9)
        Me.Controls.Add(lblFat)
        Me.Controls.Add(Label7)
        Me.Controls.Add(lblCarbs)
        Me.Controls.Add(Label6)
        Me.Controls.Add(lblProtein)
        Me.Controls.Add(Label5)
        Me.Controls.Add(lblEnergy)
        Me.Controls.Add(lblRemaining)
        Me.Controls.Add(lblBurned)
        Me.Controls.Add(lblConsumed)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label2)
        Me.Controls.Add(btnPreviousDay)
        Me.Controls.Add(btnNextDay)
        Me.Controls.Add(lblDate)
        Me.Margin = New Padding(3, 2, 3, 2)
        Me.Name = "NutritionForm"
        Me.Text = "NutritionForm"
        CType(dgvFoods, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents lblDate As Label
    Friend WithEvents btnNextDay As Button
    Friend WithEvents btnPreviousDay As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblConsumed As Label
    Friend WithEvents lblBurned As Label
    Friend WithEvents lblRemaining As Label
    Friend WithEvents lblEnergy As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblProtein As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblCarbs As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblFat As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents dgvFoods As DataGridView
    Friend WithEvents colMealCategory As DataGridViewTextBoxColumn
    Friend WithEvents colFoodName As DataGridViewTextBoxColumn
    Friend WithEvents colServingDescription As DataGridViewTextBoxColumn
    Friend WithEvents colCalories As DataGridViewTextBoxColumn
    Friend WithEvents colProtein As DataGridViewTextBoxColumn
    Friend WithEvents colCarbs As DataGridViewTextBoxColumn
    Friend WithEvents colFat As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btnAddUncat As Button
    Friend WithEvents btnAddLunch As Button
    Friend WithEvents btnAddDinner As Button
    Friend WithEvents btnAddBreakfast As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnAddSnacks As Button
End Class
