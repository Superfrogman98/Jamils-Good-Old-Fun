'programmer: Max Buckel
'date: 2017-2-24
'function: allows the user to enter attendence data and view it in a table format


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
        dgvAttendenceEntry.RowCount = DateDiff(DateInterval.Day, dtpBeginDate.Value, dtpEndDate.Value) + 1

        For i As Integer = 0 To dgvAttendenceEntry.RowCount() - 1
            dgvAttendenceEntry.Rows(i).Cells(0).Value = frmMain.dayNames(i Mod 7)
        Next

        dgvAttendenceEntry.ColumnCount = 26

        'filter the binding source to only show dates between the selected values
        CustomerAttendanceBindingSource.Filter = "attendanceDate >= #" & dtpBeginDate.Value & "# AND  attendanceDate <= #" & dtpEndDate.Value & "#" '
        Try
            MessageBox.Show(CustomerAttendanceBindingSource(0)(1).ToString)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub dtpBeginDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpBeginDate.ValueChanged
        dtpEndDate.MinDate = dtpBeginDate.Value
    End Sub

    Private Sub dtpEndDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpEndDate.ValueChanged
        dtpBeginDate.MaxDate = dtpEndDate.Value
    End Sub
End Class