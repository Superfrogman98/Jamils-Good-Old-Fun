<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAttendenceEntry
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAttendenceEntry))
        Me.dtpBeginDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Jamils_Good_Old_FunDataSet = New Jamils_Good_Old_Fun_Family_Center.Jamils_Good_Old_FunDataSet()
        Me.CustomerAttendanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerAttendanceTableAdapter = New Jamils_Good_Old_Fun_Family_Center.Jamils_Good_Old_FunDataSetTableAdapters.CustomerAttendanceTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Jamils_Good_Old_FunDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerAttendanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpBeginDate
        '
        Me.dtpBeginDate.Location = New System.Drawing.Point(297, 14)
        Me.dtpBeginDate.MaxDate = New Date(2017, 2, 23, 0, 0, 0, 0)
        Me.dtpBeginDate.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtpBeginDate.Name = "dtpBeginDate"
        Me.dtpBeginDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpBeginDate.TabIndex = 0
        Me.dtpBeginDate.Value = New Date(2017, 2, 23, 0, 0, 0, 0)
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Location = New System.Drawing.Point(568, 14)
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
        Me.Label1.Location = New System.Drawing.Point(509, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Through"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(227, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "View Dates:"
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(783, 11)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 4
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDate, Me.colDay})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 45)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(1029, 600)
        Me.DataGridView1.TabIndex = 5
        '
        'colDate
        '
        Me.colDate.HeaderText = "Date"
        Me.colDate.Name = "colDate"
        '
        'colDay
        '
        Me.colDay.HeaderText = "Day"
        Me.colDay.Name = "colDay"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(-6, -16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1066, 55)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Jamils_Good_Old_FunDataSet
        '
        Me.Jamils_Good_Old_FunDataSet.DataSetName = "Jamils_Good_Old_FunDataSet"
        Me.Jamils_Good_Old_FunDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerAttendanceBindingSource
        '
        Me.CustomerAttendanceBindingSource.DataMember = "CustomerAttendance"
        Me.CustomerAttendanceBindingSource.DataSource = Me.Jamils_Good_Old_FunDataSet
        '
        'CustomerAttendanceTableAdapter
        '
        Me.CustomerAttendanceTableAdapter.ClearBeforeFill = True
        '
        'frmAttendenceEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1053, 657)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpEndDate)
        Me.Controls.Add(Me.dtpBeginDate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAttendenceEntry"
        Me.Text = "Enter Customer Attendance"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Jamils_Good_Old_FunDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerAttendanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpBeginDate As DateTimePicker
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Jamils_Good_Old_FunDataSet As Jamils_Good_Old_FunDataSet
    Friend WithEvents CustomerAttendanceBindingSource As BindingSource
    Friend WithEvents CustomerAttendanceTableAdapter As Jamils_Good_Old_FunDataSetTableAdapters.CustomerAttendanceTableAdapter
    Friend WithEvents colDate As DataGridViewTextBoxColumn
    Friend WithEvents colDay As DataGridViewTextBoxColumn
End Class
