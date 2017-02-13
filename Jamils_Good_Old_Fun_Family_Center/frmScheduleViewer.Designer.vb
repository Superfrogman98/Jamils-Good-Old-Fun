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
        Me.tlpSchedule = New System.Windows.Forms.TableLayoutPanel()
        Me.cbxViewSelect = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxEmployeeSelect = New System.Windows.Forms.ComboBox()
        Me.EmployeeDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Jamils_Good_Old_FunDataSet = New Jamils_Good_Old_Fun_Family_Center.Jamils_Good_Old_FunDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EmployeeDataTableAdapter = New Jamils_Good_Old_Fun_Family_Center.Jamils_Good_Old_FunDataSetTableAdapters.EmployeeDataTableAdapter()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.EmployeeDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Jamils_Good_Old_FunDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpSchedule
        '
        Me.tlpSchedule.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.tlpSchedule.AllowDrop = True
        Me.tlpSchedule.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tlpSchedule.ColumnCount = 1
        Me.tlpSchedule.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSchedule.Location = New System.Drawing.Point(12, 47)
        Me.tlpSchedule.Name = "tlpSchedule"
        Me.tlpSchedule.RowCount = 1
        Me.tlpSchedule.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSchedule.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 482.0!))
        Me.tlpSchedule.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 482.0!))
        Me.tlpSchedule.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 482.0!))
        Me.tlpSchedule.Size = New System.Drawing.Size(179, 483)
        Me.tlpSchedule.TabIndex = 0
        '
        'cbxViewSelect
        '
        Me.cbxViewSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxViewSelect.FormattingEnabled = True
        Me.cbxViewSelect.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday", "Full Week"})
        Me.cbxViewSelect.Location = New System.Drawing.Point(90, 17)
        Me.cbxViewSelect.Name = "cbxViewSelect"
        Me.cbxViewSelect.Size = New System.Drawing.Size(121, 21)
        Me.cbxViewSelect.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
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
        Me.cbxEmployeeSelect.Location = New System.Drawing.Point(551, 19)
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
        Me.Label2.Location = New System.Drawing.Point(453, 22)
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
        Me.btnRefresh.Location = New System.Drawing.Point(1012, 6)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(158, 23)
        Me.btnRefresh.TabIndex = 4
        Me.btnRefresh.Text = "Refresh Schedule"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbxViewSelect)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbxEmployeeSelect)
        Me.GroupBox1.Location = New System.Drawing.Point(-3, -11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1196, 52)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'frmScheduleViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMinSize = New System.Drawing.Size(0, 100)
        Me.ClientSize = New System.Drawing.Size(1183, 653)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tlpSchedule)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmScheduleViewer"
        Me.Text = "Schedule Viewer"
        CType(Me.EmployeeDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Jamils_Good_Old_FunDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tlpSchedule As TableLayoutPanel
    Friend WithEvents cbxViewSelect As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbxEmployeeSelect As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Jamils_Good_Old_FunDataSet As Jamils_Good_Old_FunDataSet
    Friend WithEvents EmployeeDataBindingSource As BindingSource
    Friend WithEvents EmployeeDataTableAdapter As Jamils_Good_Old_FunDataSetTableAdapters.EmployeeDataTableAdapter
    Friend WithEvents btnRefresh As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
