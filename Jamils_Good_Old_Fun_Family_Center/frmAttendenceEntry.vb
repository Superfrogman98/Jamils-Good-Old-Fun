Public Class frmAttendenceEntry
    Private Sub frmAttendenceEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Jamils_Good_Old_FunDataSet.CustomerAttendance' table. You can move, or remove it, as needed.
        Me.CustomerAttendanceTableAdapter.Fill(Me.Jamils_Good_Old_FunDataSet.CustomerAttendance)
        dtpEndDate.MaxDate = Today
        dtpEndDate.Value = Today
        dtpBeginDate.Value = New DateTime(Today.Year, Today.Month, Today.Day - 7)
        dtpBeginDate.MaxDate = Today
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

    End Sub
End Class