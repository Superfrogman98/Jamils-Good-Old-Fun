<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAttendanceReport
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAttendanceReport))
        Me.chrAttendance = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.CustomerAttendanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JamilsGoodOldFunDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Jamils_Good_Old_FunDataSet = New Jamils_Good_Old_Fun_Family_Center.Jamils_Good_Old_FunDataSet()
        Me.CustomerAttendanceTableAdapter = New Jamils_Good_Old_Fun_Family_Center.Jamils_Good_Old_FunDataSetTableAdapters.CustomerAttendanceTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.dtpBeginDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNoItems = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.chrAttendance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerAttendanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JamilsGoodOldFunDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Jamils_Good_Old_FunDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'chrAttendance
        '
        ChartArea1.AxisX.Title = "Date"
        ChartArea1.AxisY.Title = "Attendence Amount"
        ChartArea1.Name = "ChartArea1"
        Me.chrAttendance.ChartAreas.Add(ChartArea1)
        Me.chrAttendance.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.chrAttendance.Location = New System.Drawing.Point(0, 61)
        Me.chrAttendance.Name = "chrAttendance"
        Me.chrAttendance.Size = New System.Drawing.Size(1046, 491)
        Me.chrAttendance.TabIndex = 0
        Title1.Name = "chartTitle"
        Me.chrAttendance.Titles.Add(Title1)
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
        'Jamils_Good_Old_FunDataSet
        '
        Me.Jamils_Good_Old_FunDataSet.DataSetName = "Jamils_Good_Old_FunDataSet"
        Me.Jamils_Good_Old_FunDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerAttendanceTableAdapter
        '
        Me.CustomerAttendanceTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.btnPrint)
        Me.GroupBox1.Controls.Add(Me.btnRefresh)
        Me.GroupBox1.Controls.Add(Me.dtpBeginDate)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.MaximumSize = New System.Drawing.Size(1066, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1046, 55)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(789, 16)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 3
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(708, 16)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 2
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'dtpBeginDate
        '
        Me.dtpBeginDate.Location = New System.Drawing.Point(423, 17)
        Me.dtpBeginDate.MaxDate = New Date(2017, 2, 23, 0, 0, 0, 0)
        Me.dtpBeginDate.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtpBeginDate.Name = "dtpBeginDate"
        Me.dtpBeginDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpBeginDate.TabIndex = 1
        Me.dtpBeginDate.Value = New Date(2017, 2, 23, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(338, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "View Week Of:"
        '
        'lblNoItems
        '
        Me.lblNoItems.AutoSize = True
        Me.lblNoItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoItems.Location = New System.Drawing.Point(135, 262)
        Me.lblNoItems.Name = "lblNoItems"
        Me.lblNoItems.Size = New System.Drawing.Size(777, 73)
        Me.lblNoItems.TabIndex = 0
        Me.lblNoItems.Text = "No Attendence This Week"
        Me.lblNoItems.Visible = False
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(870, 16)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmAttendanceReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(1046, 552)
        Me.Controls.Add(Me.lblNoItems)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chrAttendance)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(2000, 591)
        Me.Name = "frmAttendanceReport"
        Me.Text = "Customer Attendance Reports"
        CType(Me.chrAttendance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerAttendanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JamilsGoodOldFunDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Jamils_Good_Old_FunDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chrAttendance As DataVisualization.Charting.Chart
    Friend WithEvents JamilsGoodOldFunDataSetBindingSource As BindingSource
    Friend WithEvents Jamils_Good_Old_FunDataSet As Jamils_Good_Old_FunDataSet
    Friend WithEvents CustomerAttendanceBindingSource As BindingSource
    Friend WithEvents CustomerAttendanceTableAdapter As Jamils_Good_Old_FunDataSetTableAdapters.CustomerAttendanceTableAdapter
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents dtpBeginDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents lblNoItems As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnClose As Button
End Class
