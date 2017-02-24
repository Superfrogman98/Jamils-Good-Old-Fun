<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmScheduleViewer
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmScheduleViewer))
        Me.cbxViewSelect = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxEmployeeSelect = New System.Windows.Forms.ComboBox()
        Me.EmployeeDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Jamils_Good_Old_FunDataSet = New Jamils_Good_Old_Fun_Family_Center.Jamils_Good_Old_FunDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EmployeeDataTableAdapter = New Jamils_Good_Old_Fun_Family_Center.Jamils_Good_Old_FunDataSetTableAdapters.EmployeeDataTableAdapter()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbxAllEmployees = New System.Windows.Forms.CheckBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.DirectorySearcher1 = New System.DirectoryServices.DirectorySearcher()
        Me.dgvScheduleView = New System.Windows.Forms.DataGridView()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.EmployeeDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Jamils_Good_Old_FunDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvScheduleView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbxViewSelect
        '
        Me.cbxViewSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxViewSelect.FormattingEnabled = True
        Me.cbxViewSelect.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday", "Full Week"})
        Me.cbxViewSelect.Location = New System.Drawing.Point(81, 17)
        Me.cbxViewSelect.Name = "cbxViewSelect"
        Me.cbxViewSelect.Size = New System.Drawing.Size(121, 21)
        Me.cbxViewSelect.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "View Select: "
        '
        'cbxEmployeeSelect
        '
        Me.cbxEmployeeSelect.DataSource = Me.EmployeeDataBindingSource
        Me.cbxEmployeeSelect.DisplayMember = "Full Name"
        Me.cbxEmployeeSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxEmployeeSelect.FormattingEnabled = True
        Me.cbxEmployeeSelect.Location = New System.Drawing.Point(315, 19)
        Me.cbxEmployeeSelect.Name = "cbxEmployeeSelect"
        Me.cbxEmployeeSelect.Size = New System.Drawing.Size(121, 21)
        Me.cbxEmployeeSelect.TabIndex = 2
        Me.cbxEmployeeSelect.ValueMember = "ID"
        '
        'EmployeeDataBindingSource
        '
        Me.EmployeeDataBindingSource.DataMember = "EmployeeData"
        Me.EmployeeDataBindingSource.DataSource = Me.Jamils_Good_Old_FunDataSet
        '
        'Jamils_Good_Old_FunDataSet
        '
        Me.Jamils_Good_Old_FunDataSet.DataSetName = "Jamils_Good_Old_FunDataSet"
        Me.Jamils_Good_Old_FunDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(217, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Employee Select: "
        '
        'EmployeeDataTableAdapter
        '
        Me.EmployeeDataTableAdapter.ClearBeforeFill = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(756, 17)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(158, 23)
        Me.btnRefresh.TabIndex = 4
        Me.btnRefresh.Text = "Refresh Schedule"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbxAllEmployees)
        Me.GroupBox1.Controls.Add(Me.btnRefresh)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnPrint)
        Me.GroupBox1.Controls.Add(Me.cbxViewSelect)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbxEmployeeSelect)
        Me.GroupBox1.Location = New System.Drawing.Point(-3, -11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1196, 52)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'cbxAllEmployees
        '
        Me.cbxAllEmployees.AutoSize = True
        Me.cbxAllEmployees.Location = New System.Drawing.Point(442, 20)
        Me.cbxAllEmployees.Name = "cbxAllEmployees"
        Me.cbxAllEmployees.Size = New System.Drawing.Size(117, 17)
        Me.cbxAllEmployees.TabIndex = 7
        Me.cbxAllEmployees.Text = "View All Employees"
        Me.cbxAllEmployees.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(1053, 15)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(97, 23)
        Me.btnPrint.TabIndex = 6
        Me.btnPrint.Text = "Print Schedule"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'DirectorySearcher1
        '
        Me.DirectorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'dgvScheduleView
        '
        Me.dgvScheduleView.AllowUserToAddRows = False
        Me.dgvScheduleView.AllowUserToDeleteRows = False
        Me.dgvScheduleView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvScheduleView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvScheduleView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvScheduleView.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvScheduleView.Location = New System.Drawing.Point(6, 47)
        Me.dgvScheduleView.Name = "dgvScheduleView"
        Me.dgvScheduleView.ReadOnly = True
        Me.dgvScheduleView.RowHeadersVisible = False
        Me.dgvScheduleView.Size = New System.Drawing.Size(1141, 554)
        Me.dgvScheduleView.TabIndex = 9
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'frmScheduleViewer
        '
        Me.AcceptButton = Me.btnRefresh
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1154, 613)
        Me.Controls.Add(Me.dgvScheduleView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1170, 652)
        Me.Name = "frmScheduleViewer"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "Schedule Viewer"
        CType(Me.EmployeeDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Jamils_Good_Old_FunDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvScheduleView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbxViewSelect As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbxEmployeeSelect As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Jamils_Good_Old_FunDataSet As Jamils_Good_Old_FunDataSet
    Friend WithEvents EmployeeDataBindingSource As BindingSource
    Friend WithEvents EmployeeDataTableAdapter As Jamils_Good_Old_FunDataSetTableAdapters.EmployeeDataTableAdapter
    Friend WithEvents btnRefresh As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnPrint As Button
    Friend WithEvents DirectorySearcher1 As DirectoryServices.DirectorySearcher
    Friend WithEvents cbxAllEmployees As CheckBox
    Friend WithEvents dgvScheduleView As DataGridView
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
