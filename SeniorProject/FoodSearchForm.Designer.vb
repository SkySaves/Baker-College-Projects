<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FoodSearchForm
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
        txtSearchTerm = New TextBox()
        btnSearch = New Button()
        lstResults = New ListBox()
        lblLabel2 = New Label()
        cbServings = New ComboBox()
        Label2 = New Label()
        numQuantity = New NumericUpDown()
        btnAdd = New Button()
        btnCancel = New Button()
        CType(numQuantity, ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(23, 137)
        Label1.Name = "Label1"
        Label1.Size = New Size(119, 25)
        Label1.TabIndex = 0
        Label1.Text = "Search Term:"
        ' 
        ' txtSearchTerm
        ' 
        txtSearchTerm.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearchTerm.Location = New Point(148, 137)
        txtSearchTerm.Name = "txtSearchTerm"
        txtSearchTerm.Size = New Size(150, 29)
        txtSearchTerm.TabIndex = 1
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(304, 139)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(81, 27)
        btnSearch.TabIndex = 2
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' lstResults
        ' 
        lstResults.FormattingEnabled = True
        lstResults.ItemHeight = 15
        lstResults.Location = New Point(23, 188)
        lstResults.Name = "lstResults"
        lstResults.Size = New Size(709, 199)
        lstResults.TabIndex = 3
        ' 
        ' lblLabel2
        ' 
        lblLabel2.AutoSize = True
        lblLabel2.Location = New Point(23, 400)
        lblLabel2.Name = "lblLabel2"
        lblLabel2.Size = New Size(54, 15)
        lblLabel2.TabIndex = 4
        lblLabel2.Text = "Servings:"
        ' 
        ' cbServings
        ' 
        cbServings.FormattingEnabled = True
        cbServings.Location = New Point(83, 397)
        cbServings.Name = "cbServings"
        cbServings.Size = New Size(121, 23)
        cbServings.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(23, 430)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 15)
        Label2.TabIndex = 6
        Label2.Text = "Quantity:"
        ' 
        ' numQuantity
        ' 
        numQuantity.DecimalPlaces = 1
        numQuantity.Location = New Point(83, 428)
        numQuantity.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        numQuantity.Name = "numQuantity"
        numQuantity.Size = New Size(120, 23)
        numQuantity.TabIndex = 7
        numQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(27, 469)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 23)
        btnAdd.TabIndex = 8
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(108, 469)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(75, 23)
        btnCancel.TabIndex = 9
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' FoodSearchForm
        ' 
        Me.AutoScaleDimensions = New SizeF(7F, 15F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(800, 627)
        Me.Controls.Add(btnCancel)
        Me.Controls.Add(btnAdd)
        Me.Controls.Add(numQuantity)
        Me.Controls.Add(Label2)
        Me.Controls.Add(cbServings)
        Me.Controls.Add(lblLabel2)
        Me.Controls.Add(lstResults)
        Me.Controls.Add(btnSearch)
        Me.Controls.Add(txtSearchTerm)
        Me.Controls.Add(Label1)
        Me.Name = "FoodSearchForm"
        Me.Text = "FoodSearchForm"
        CType(numQuantity, ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearchTerm As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents lstResults As ListBox
    Friend WithEvents lblLabel2 As Label
    Friend WithEvents cbServings As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents numQuantity As NumericUpDown
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnCancel As Button
End Class
