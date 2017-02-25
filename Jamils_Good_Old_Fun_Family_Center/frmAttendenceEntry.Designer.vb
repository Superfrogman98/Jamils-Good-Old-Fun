<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAttendenceEntry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAttendenceEntry))
        Me.dtpBeginDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.dgvAttendenceEntry = New System.Windows.Forms.DataGridView()
        Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAllowEdits = New System.Windows.Forms.Button()
        Me.Jamils_Good_Old_FunDataSet = New Jamils_Good_Old_Fun_Family_Center.Jamils_Good_Old_FunDataSet()
        Me.CustomerAttendanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JamilsGoodOldFunDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerAttendanceTableAdapter = New Jamils_Good_Old_Fun_Family_Center.Jamils_Good_Old_FunDataSetTableAdapters.CustomerAttendanceTableAdapter()
        Me.btnPrint = New System.Windows.Forms.Button()
        CType(Me.dgvAttendenceEntry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Jamils_Good_Old_FunDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerAttendanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JamilsGoodOldFunDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpBeginDate
        '
        Me.dtpBeginDate.Location = New System.Drawing.Point(297, 19)
        Me.dtpBeginDate.MaxDate = New Date(2017, 2, 23, 0, 0, 0, 0)
        Me.dtpBeginDate.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtpBeginDate.Name = "dtpBeginDate"
        Me.dtpBeginDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpBeginDate.TabIndex = 0
        Me.dtpBeginDate.Value = New Date(2017, 2, 23, 0, 0, 0, 0)
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Location = New System.Drawing.Point(568, 19)
        Me.dtpEndDate.MaxDate = New Date(2017, 2, 23, 0, 0, 0, 0)
        Me.dtpEndDate.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpEndDate.TabIndex = 1
        Me.dtpEndDate.Value = New Date(2017, 2, 1, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(509, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Through"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(227, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "View Dates:"
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(783, 18)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 4
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'dgvAttendenceEntry
        '
        Me.dgvAttendenceEntry.AllowUserToAddRows = False
        Me.dgvAttendenceEntry.AllowUserToDeleteRows = False
        Me.dgvAttendenceEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAttendenceEntry.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDate, Me.colDay})
        Me.dgvAttendenceEntry.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvAttendenceEntry.Location = New System.Drawing.Point(0, 61)
        Me.dgvAttendenceEntry.Name = "dgvAttendenceEntry"
        Me.dgvAttendenceEntry.ReadOnly = True
        Me.dgvAttendenceEntry.RowHeadersVisible = False
        Me.dgvAttendenceEntry.Size = New System.Drawing.Size(1053, 596)
        Me.dgvAttendenceEntry.TabIndex = 5
        '
        'colDate
        '
        Me.colDate.Frozen = True
        Me.colDate.HeaderText = "Date"
        Me.colDate.Name = "colDate"
        Me.colDate.ReadOnly = True
        '
        'colDay
        '
        Me.colDay.Frozen = True
        Me.colDay.HeaderText = "Day"
        Me.colDay.Name = "colDay"
        Me.colDay.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnPrint)
        Me.GroupBox1.Controls.Add(Me.btnAllowEdits)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 0, 0, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(1053, 55)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'btnAllowEdits
        '
        Me.btnAllowEdits.Location = New System.Drawing.Point(12, 18)
        Me.btnAllowEdits.Name = "btnAllowEdits"
        Me.btnAllowEdits.Size = New System.Drawing.Size(140, 23)
        Me.btnAllowEdits.TabIndex = 7
        Me.btnAllowEdits.Text = "Allow Editing"
        Me.btnAllowEdits.UseVisualStyleBackColor = True
        '
        'Jamils_Good_Old_FunDataSet
        '
        Me.Jamils_Good_Old_FunDataSet.DataSetName = "Jamils_Good_Old_FunDataSet"
        Me.Jamils_Good_Old_FunDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerAttendanceBindingSource
        '
        Me.CustomerAttendanceBindingSource.DataMember = "CustomerAttendance"
        Me.CustomerAttendanceBindingSource.DataSource = Me.JamilsGoodOldFunDataSetBindingSource
        '
        'JamilsGoodOldFunDataSetBindingSource
        '
        Me.JamilsGoodOldFunDataSetBindingSource.DataSource = Me.Jamils_Good_Old_FunDataSet
        Me.JamilsGoodOldFunDataSetBindingSource.Position = 0
        '
        'CustomerAttendanceTableAdapter
        '
        Me.CustomerAttendanceTableAdapter.ClearBeforeFill = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(966, 18)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 7
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'frmAttendenceEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1053, 657)
        Me.Controls.Add(Me.dgvAttendenceEntry)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpEndDate)
        Me.Controls.Add(Me.dtpBeginDate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(2600, 696)
        Me.Name = "frmAttendenceEntry"
        Me.Text = "Enter Customer Attendance"
        CType(Me.dgvAttendenceEntry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Jamils_Good_Old_FunDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerAttendanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JamilsGoodOldFunDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpBeginDate As DateTimePicker
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents dgvAttendenceEntry As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Jamils_Good_Old_FunDataSet As Jamils_Good_Old_FunDataSet
    Friend WithEvents CustomerAttendanceBindingSource As BindingSource
    Friend WithEvents JamilsGoodOldFunDataSetBindingSource As BindingSource
    Friend WithEvents CustomerAttendanceTableAdapter As Jamils_Good_Old_FunDataSetTableAdapters.CustomerAttendanceTableAdapter
    Friend WithEvents btnAllowEdits As Button
    Friend WithEvents colDate As DataGridViewTextBoxColumn
    Friend WithEvents colDay As DataGridViewTextBoxColumn
    Friend WithEvents btnPrint As Button
End Class
