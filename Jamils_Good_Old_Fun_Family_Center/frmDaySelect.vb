Public Class frmDaySelect
    Private Sub cbxDaySelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxDaySelect.SelectionChangeCommitted

        frmMain.dgvSchedule.Rows(frmMain.selectedScheduleRow).Cells(0).Value = cbxDaySelect.SelectedItem
        Me.Close()
    End Sub
End Class