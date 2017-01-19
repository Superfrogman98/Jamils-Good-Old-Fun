<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDaySelect
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
        Me.cbxDaySelect = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cbxDaySelect
        '
        Me.cbxDaySelect.FormattingEnabled = True
        Me.cbxDaySelect.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"})
        Me.cbxDaySelect.Location = New System.Drawing.Point(0, 0)
        Me.cbxDaySelect.Margin = New System.Windows.Forms.Padding(0)
        Me.cbxDaySelect.Name = "cbxDaySelect"
        Me.cbxDaySelect.Size = New System.Drawing.Size(121, 21)
        Me.cbxDaySelect.TabIndex = 0
        '
        'frmDaySelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(121, 21)
        Me.ControlBox = False
        Me.Controls.Add(Me.cbxDaySelect)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "frmDaySelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Select Day"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbxDaySelect As ComboBox
End Class
