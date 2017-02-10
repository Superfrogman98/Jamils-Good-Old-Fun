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
        Me.tlpSchedule = New System.Windows.Forms.TableLayoutPanel()
        Me.SuspendLayout()
        '
        'tlpSchedule
        '
        Me.tlpSchedule.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.tlpSchedule.AllowDrop = True
        Me.tlpSchedule.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tlpSchedule.ColumnCount = 1
        Me.tlpSchedule.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSchedule.Location = New System.Drawing.Point(0, 0)
        Me.tlpSchedule.Name = "tlpSchedule"
        Me.tlpSchedule.RowCount = 1
        Me.tlpSchedule.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSchedule.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 640.0!))
        Me.tlpSchedule.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 640.0!))
        Me.tlpSchedule.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 640.0!))
        Me.tlpSchedule.Size = New System.Drawing.Size(1181, 653)
        Me.tlpSchedule.TabIndex = 0
        '
        'frmScheduleViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMinSize = New System.Drawing.Size(0, 100)
        Me.ClientSize = New System.Drawing.Size(1183, 653)
        Me.Controls.Add(Me.tlpSchedule)
        Me.Name = "frmScheduleViewer"
        Me.Text = "Schedule Viewer"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpSchedule As TableLayoutPanel
End Class
