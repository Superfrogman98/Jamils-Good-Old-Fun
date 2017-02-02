<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddScheduleItem
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
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.nudStart = New System.Windows.Forms.NumericUpDown()
        Me.nudStop = New System.Windows.Forms.NumericUpDown()
        Me.cbxDay = New System.Windows.Forms.ComboBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        CType(Me.nudStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudStop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(321, 24)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(400, 24)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(3, 2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(105, 2)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(180, 36)
        Me.txtDescription.TabIndex = 3
        '
        'nudStart
        '
        Me.nudStart.Increment = New Decimal(New Integer() {15, 0, 0, 0})
        Me.nudStart.Location = New System.Drawing.Point(287, 2)
        Me.nudStart.Maximum = New Decimal(New Integer() {2359, 0, 0, 0})
        Me.nudStart.Name = "nudStart"
        Me.nudStart.Size = New System.Drawing.Size(100, 20)
        Me.nudStart.TabIndex = 4
        '
        'nudStop
        '
        Me.nudStop.Increment = New Decimal(New Integer() {15, 0, 0, 0})
        Me.nudStop.Location = New System.Drawing.Point(389, 2)
        Me.nudStop.Maximum = New Decimal(New Integer() {2359, 0, 0, 0})
        Me.nudStop.Name = "nudStop"
        Me.nudStop.Size = New System.Drawing.Size(100, 20)
        Me.nudStop.TabIndex = 5
        '
        'cbxDay
        '
        Me.cbxDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxDay.FormattingEnabled = True
        Me.cbxDay.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"})
        Me.cbxDay.Location = New System.Drawing.Point(3, 2)
        Me.cbxDay.Name = "cbxDay"
        Me.cbxDay.Size = New System.Drawing.Size(100, 21)
        Me.cbxDay.TabIndex = 2
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(3, 24)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'frmAddScheduleItem
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 50)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.nudStop)
        Me.Controls.Add(Me.nudStart)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.cbxDay)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAddScheduleItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Add Schedule Item"
        CType(Me.nudStart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudStop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents nudStart As NumericUpDown
    Friend WithEvents nudStop As NumericUpDown
    Friend WithEvents cbxDay As ComboBox
    Friend WithEvents btnDelete As Button
End Class
