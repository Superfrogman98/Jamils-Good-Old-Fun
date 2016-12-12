<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttendenceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnterAttendenceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScedualsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateSceduleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintSceduleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintSceduleToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.gpbEmployees = New System.Windows.Forms.GroupBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.lblDOH = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblSecondary = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblMain = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvEmployees = New System.Windows.Forms.DataGridView()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JamilsGoodOldFunDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Jamils_Good_Old_FunDataSet = New Jamils_Good_Old_Fun_Family_Center.Jamils_Good_Old_FunDataSet()
        Me.lblEmployeeName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EmployeeDataTableAdapter = New Jamils_Good_Old_Fun_Family_Center.Jamils_Good_Old_FunDataSetTableAdapters.EmployeeDataTableAdapter()
        Me.MenuStrip1.SuspendLayout()
        Me.gpbEmployees.SuspendLayout()
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JamilsGoodOldFunDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Jamils_Good_Old_FunDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EmployeesToolStripMenuItem, Me.CustomerToolStripMenuItem, Me.ScedualsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(728, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'EmployeesToolStripMenuItem
        '
        Me.EmployeesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewEmployeeToolStripMenuItem})
        Me.EmployeesToolStripMenuItem.Name = "EmployeesToolStripMenuItem"
        Me.EmployeesToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.EmployeesToolStripMenuItem.Text = "Employees"
        '
        'NewEmployeeToolStripMenuItem
        '
        Me.NewEmployeeToolStripMenuItem.Name = "NewEmployeeToolStripMenuItem"
        Me.NewEmployeeToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.NewEmployeeToolStripMenuItem.Text = "New Employee"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AttendenceToolStripMenuItem})
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.CustomerToolStripMenuItem.Text = "Customers"
        '
        'AttendenceToolStripMenuItem
        '
        Me.AttendenceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnterAttendenceToolStripMenuItem, Me.ViewReportsToolStripMenuItem})
        Me.AttendenceToolStripMenuItem.Name = "AttendenceToolStripMenuItem"
        Me.AttendenceToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.AttendenceToolStripMenuItem.Text = "Attendence"
        '
        'EnterAttendenceToolStripMenuItem
        '
        Me.EnterAttendenceToolStripMenuItem.Name = "EnterAttendenceToolStripMenuItem"
        Me.EnterAttendenceToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.EnterAttendenceToolStripMenuItem.Text = "Enter Attendence"
        '
        'ViewReportsToolStripMenuItem
        '
        Me.ViewReportsToolStripMenuItem.Name = "ViewReportsToolStripMenuItem"
        Me.ViewReportsToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ViewReportsToolStripMenuItem.Text = "View Reports"
        '
        'ScedualsToolStripMenuItem
        '
        Me.ScedualsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateSceduleToolStripMenuItem, Me.PrintSceduleToolStripMenuItem, Me.PrintSceduleToolStripMenuItem1})
        Me.ScedualsToolStripMenuItem.Name = "ScedualsToolStripMenuItem"
        Me.ScedualsToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.ScedualsToolStripMenuItem.Text = "Schedule "
        '
        'CreateSceduleToolStripMenuItem
        '
        Me.CreateSceduleToolStripMenuItem.Name = "CreateSceduleToolStripMenuItem"
        Me.CreateSceduleToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CreateSceduleToolStripMenuItem.Text = "Create Scedule"
        '
        'PrintSceduleToolStripMenuItem
        '
        Me.PrintSceduleToolStripMenuItem.Name = "PrintSceduleToolStripMenuItem"
        Me.PrintSceduleToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PrintSceduleToolStripMenuItem.Text = "View Scedule"
        '
        'PrintSceduleToolStripMenuItem1
        '
        Me.PrintSceduleToolStripMenuItem1.Name = "PrintSceduleToolStripMenuItem1"
        Me.PrintSceduleToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.PrintSceduleToolStripMenuItem1.Text = "Print Scedule"
        '
        'gpbEmployees
        '
        Me.gpbEmployees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.gpbEmployees.Controls.Add(Me.btnEdit)
        Me.gpbEmployees.Controls.Add(Me.lblDOH)
        Me.gpbEmployees.Controls.Add(Me.Label9)
        Me.gpbEmployees.Controls.Add(Me.lblEmail)
        Me.gpbEmployees.Controls.Add(Me.Label12)
        Me.gpbEmployees.Controls.Add(Me.lblSecondary)
        Me.gpbEmployees.Controls.Add(Me.Label10)
        Me.gpbEmployees.Controls.Add(Me.lblMain)
        Me.gpbEmployees.Controls.Add(Me.Label8)
        Me.gpbEmployees.Controls.Add(Me.Label4)
        Me.gpbEmployees.Controls.Add(Me.lblAddress)
        Me.gpbEmployees.Controls.Add(Me.Label6)
        Me.gpbEmployees.Controls.Add(Me.lblPosition)
        Me.gpbEmployees.Controls.Add(Me.Label5)
        Me.gpbEmployees.Controls.Add(Me.dgvEmployees)
        Me.gpbEmployees.Controls.Add(Me.lblEmployeeName)
        Me.gpbEmployees.Controls.Add(Me.Label3)
        Me.gpbEmployees.Controls.Add(Me.Label2)
        Me.gpbEmployees.Controls.Add(Me.btnSearch)
        Me.gpbEmployees.Controls.Add(Me.txtSearch)
        Me.gpbEmployees.Controls.Add(Me.Label1)
        Me.gpbEmployees.Location = New System.Drawing.Point(12, 27)
        Me.gpbEmployees.Name = "gpbEmployees"
        Me.gpbEmployees.Size = New System.Drawing.Size(704, 513)
        Me.gpbEmployees.TabIndex = 0
        Me.gpbEmployees.TabStop = False
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(592, 27)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 24
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'lblDOH
        '
        Me.lblDOH.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDOH.Location = New System.Drawing.Point(299, 121)
        Me.lblDOH.Name = "lblDOH"
        Me.lblDOH.Size = New System.Drawing.Size(102, 13)
        Me.lblDOH.TabIndex = 23
        Me.lblDOH.Text = "                              "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(235, 121)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Hire Date: "
        '
        'lblEmail
        '
        Me.lblEmail.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblEmail.Location = New System.Drawing.Point(511, 121)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(167, 13)
        Me.lblEmail.TabIndex = 21
        Me.lblEmail.Text = "                              "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(419, 121)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Email Address:"
        '
        'lblSecondary
        '
        Me.lblSecondary.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSecondary.Location = New System.Drawing.Point(511, 95)
        Me.lblSecondary.Name = "lblSecondary"
        Me.lblSecondary.Size = New System.Drawing.Size(167, 13)
        Me.lblSecondary.TabIndex = 19
        Me.lblSecondary.Text = "                              "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(419, 95)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Secondary Phone:"
        '
        'lblMain
        '
        Me.lblMain.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblMain.Location = New System.Drawing.Point(511, 71)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(167, 13)
        Me.lblMain.TabIndex = 17
        Me.lblMain.Text = "                              "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(419, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Main Phone:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(407, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Contact Information"
        '
        'lblAddress
        '
        Me.lblAddress.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblAddress.Location = New System.Drawing.Point(281, 143)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(120, 29)
        Me.lblAddress.TabIndex = 15
        Me.lblAddress.Text = "                              "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(236, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Address:"
        '
        'lblPosition
        '
        Me.lblPosition.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPosition.Location = New System.Drawing.Point(280, 95)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(121, 13)
        Me.lblPosition.TabIndex = 13
        Me.lblPosition.Text = "                              "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(236, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Position:"
        '
        'dgvEmployees
        '
        Me.dgvEmployees.AllowUserToAddRows = False
        Me.dgvEmployees.AllowUserToDeleteRows = False
        Me.dgvEmployees.AllowUserToResizeRows = False
        Me.dgvEmployees.AutoGenerateColumns = False
        Me.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployees.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn})
        Me.dgvEmployees.DataSource = Me.EmployeeDataBindingSource
        Me.dgvEmployees.Location = New System.Drawing.Point(0, 56)
        Me.dgvEmployees.Name = "dgvEmployees"
        Me.dgvEmployees.ReadOnly = True
        Me.dgvEmployees.RowHeadersVisible = False
        Me.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmployees.Size = New System.Drawing.Size(200, 451)
        Me.dgvEmployees.TabIndex = 11
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmployeeDataBindingSource
        '
        Me.EmployeeDataBindingSource.DataMember = "EmployeeData"
        Me.EmployeeDataBindingSource.DataSource = Me.JamilsGoodOldFunDataSetBindingSource
        '
        'JamilsGoodOldFunDataSetBindingSource
        '
        Me.JamilsGoodOldFunDataSetBindingSource.DataSource = Me.Jamils_Good_Old_FunDataSet
        Me.JamilsGoodOldFunDataSetBindingSource.Position = 0
        '
        'Jamils_Good_Old_FunDataSet
        '
        Me.Jamils_Good_Old_FunDataSet.DataSetName = "Jamils_Good_Old_FunDataSet"
        Me.Jamils_Good_Old_FunDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblEmployeeName
        '
        Me.lblEmployeeName.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblEmployeeName.Location = New System.Drawing.Point(279, 71)
        Me.lblEmployeeName.Name = "lblEmployeeName"
        Me.lblEmployeeName.Size = New System.Drawing.Size(121, 13)
        Me.lblEmployeeName.TabIndex = 10
        Me.lblEmployeeName.Text = "                              "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(235, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(231, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(327, 37)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Employee Information"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(121, 30)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(79, 23)
        Me.btnSearch.TabIndex = 7
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(0, 30)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSearch.Size = New System.Drawing.Size(115, 20)
        Me.txtSearch.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(51, 0, 51, 6)
        Me.Label1.Size = New System.Drawing.Size(200, 28)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Employees"
        '
        'EmployeeDataTableAdapter
        '
        Me.EmployeeDataTableAdapter.ClearBeforeFill = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 543)
        Me.Controls.Add(Me.gpbEmployees)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Jamil's Good Old Fun Family Center"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.gpbEmployees.ResumeLayout(False)
        Me.gpbEmployees.PerformLayout()
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JamilsGoodOldFunDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Jamils_Good_Old_FunDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AttendenceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnterAttendenceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents gpbEmployees As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents lblEmployeeName As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvEmployees As DataGridView
    Friend WithEvents JamilsGoodOldFunDataSetBindingSource As BindingSource
    Friend WithEvents Jamils_Good_Old_FunDataSet As Jamils_Good_Old_FunDataSet
    Friend WithEvents EmployeeDataBindingSource As BindingSource
    Friend WithEvents lblAddress As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblPosition As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblSecondary As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblMain As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ScedualsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateSceduleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintSceduleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintSceduleToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeDataTableAdapter As Jamils_Good_Old_FunDataSetTableAdapters.EmployeeDataTableAdapter
    Friend WithEvents lblDOH As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnEdit As Button
End Class
