'programmer: Max Buckel
'date: 2017-2-24
'function: allows the user to enter attendence data and view it in a table format
Imports System.Data.OleDb
Public Class frmAttendenceEntry

    Public allowEdits As Boolean = False

    Private Sub frmAttendenceEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'fills the table adapter with values so they can be used to customly programatically populate the datatable
        Me.CustomerAttendanceTableAdapter.Connection = frmMain.database
        Me.CustomerAttendanceTableAdapter.Fill(Me.Jamils_Good_Old_FunDataSet.CustomerAttendance)
        dtpEndDate.MaxDate = Today
        dtpEndDate.Value = Today
        dtpBeginDate.Value = New DateTime(Today.Year, Today.Month, Today.Day - 7)
        dtpBeginDate.MaxDate = Today
    End Sub



    'changes edit to false on form close to prevent crash
    Private Sub frmAttendenceEntry_Close(sender As Object, e As EventArgs) Handles MyBase.Closing
        allowEdits = False
        btnAllowEdits.Text = "Allowing Editing"
        dgvAttendenceEntry.ReadOnly = True
    End Sub


    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click, MyBase.Load
        Me.CustomerAttendanceTableAdapter.ClearBeforeFill = True 'resets the connection so that the user entered data will properly fill the table
        Me.CustomerAttendanceTableAdapter.Fill(Me.Jamils_Good_Old_FunDataSet.CustomerAttendance)

        allowEdits = False
        Dim currentDate As Date = dtpBeginDate.Value
        dgvAttendenceEntry.ColumnCount = 26
        'clears all old values from the schedule
        dgvAttendenceEntry.Rows().Clear()
        'creates and fills the rows with the dayname
        dgvAttendenceEntry.RowCount = DateDiff(DateInterval.Day, dtpBeginDate.Value, dtpEndDate.Value) + 1
        For i As Integer = 0 To dgvAttendenceEntry.RowCount() - 1
            dgvAttendenceEntry.Rows(i).Cells(1).Value = currentDate.ToString("dddd") 'gets the day from the current date
            dgvAttendenceEntry.Rows(i).Cells(0).Value = currentDate.ToShortDateString() 'removes the time values from the end of the date 
            currentDate = DateAdd(DateInterval.Day, 1, currentDate)
        Next
        'fill the column headers with time labels
        For i As Integer = 0 To dgvAttendenceEntry.ColumnCount() - 3
            dgvAttendenceEntry.Columns(i + 2).HeaderCell.Value = String.Format("{0:0000}", (i * 100)) & "-" & String.Format("{0:0000}", ((i + 1) * 100))
        Next
        'filter the binding source to only show dates between the selected values
        CustomerAttendanceBindingSource.Filter = "attendanceDate >= #" & dtpBeginDate.Value & "# AND  attendanceDate <= #" & dtpEndDate.Value & "#"
        Dim startRowDate As DateTime = dgvAttendenceEntry.Rows(0).Cells(0).Value
        For x As Integer = 0 To CustomerAttendanceBindingSource.Count() - 1
            Dim currentItemDate As DateTime = CustomerAttendanceBindingSource(x)(1)
            Dim currentHour As Integer = Math.Floor(CustomerAttendanceBindingSource(x)(2) / 100) + 2
            dgvAttendenceEntry.Rows(DateDiff(DateInterval.Day, startRowDate, currentItemDate)).Cells(currentHour).Value = CustomerAttendanceBindingSource(x)(3)
        Next
        If btnAllowEdits.Text = "Disable Editing" Then
            allowEdits = True
        End If
    End Sub

    'sets the min limit of end date when begin is changed
    Private Sub dtpBeginDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpBeginDate.ValueChanged
        dtpEndDate.MinDate = dtpBeginDate.Value
    End Sub

    'sets the max limit of begin when end is changed
    Private Sub dtpEndDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpEndDate.ValueChanged
        dtpBeginDate.MaxDate = dtpEndDate.Value
    End Sub

    'updates the database when a cell value is changed
    Private Sub dgvAttendenceEntry_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAttendenceEntry.CellValueChanged
        'command variables
        Dim updateCommand As OleDbCommand
        Dim insertCommand As OleDbCommand
        'variables used for what to update in database
        Dim currentTime As Integer
        Dim dateTime As DateTime
        Dim attendenceAmt As Integer
        If (allowEdits = True) Then

            Try
                attendenceAmt = dgvAttendenceEntry.Rows(e.RowIndex()).Cells(e.ColumnIndex()).Value
            Catch ex As Exception
                MessageBox.Show("Attendence Amount Should be a Number")
                attendenceAmt = 0
                dgvAttendenceEntry.Rows(e.RowIndex()).Cells(e.ColumnIndex()).Value = 0
            End Try

            If attendenceAmt > 0 Then ' if positive number is entered, either updates of inserts to the database
                currentTime = (e.ColumnIndex() - 2) * 100
                dateTime = DateTime.Parse(dgvAttendenceEntry.Rows(e.RowIndex()).Cells(0).Value)
                frmMain.database.Open()
                updateCommand = New OleDbCommand("UPDATE CustomerAttendance SET attendanceDate = ? , attendanceTime = ?, attendanceAmount = ? WHERE attendanceDate = ? AND attendanceTime = ?", frmMain.database)
                updateCommand.Parameters.AddWithValue("day", dateTime)
                updateCommand.Parameters.AddWithValue("day", currentTime)
                updateCommand.Parameters.AddWithValue("day", attendenceAmt)
                updateCommand.Parameters.AddWithValue("day", dateTime)
                updateCommand.Parameters.AddWithValue("day", currentTime)
                Try
                    Dim updated As Integer = updateCommand.ExecuteNonQuery() ' gives a 0 if nothing is updated, used to tell insert command to be used instead

                    If (updated = 0) Then
                        insertCommand = New OleDbCommand("Insert into CustomerAttendance(attendanceDate , attendanceTime , attendanceAmount )values('" & dateTime & "','" & currentTime & "','" & attendenceAmt & "')", frmMain.database)
                        updated = insertCommand.ExecuteNonQuery()
                    End If

                Catch ex As Exception

                    MessageBox.Show("Error Updating Attendance Records:  " & ex.ToString)
                End Try
                updateCommand.Dispose()
                frmMain.database.Close()
            ElseIf attendenceAmt = 0 Then 'if nothing is entered then the record will be remove from the database to reduce size
                frmMain.database.Open()
                currentTime = (e.ColumnIndex() - 2) * 100
                dateTime = DateTime.Parse(dgvAttendenceEntry.Rows(e.RowIndex()).Cells(0).Value)
                updateCommand = New OleDbCommand("DELETE * FROM CustomerAttendance WHERE attendanceDate = ? AND attendanceTime = ?", frmMain.database)
                updateCommand.Parameters.AddWithValue("day", dateTime)
                updateCommand.Parameters.AddWithValue("day", currentTime)
                Try
                    updateCommand.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show("Error Updating Attendance Records:  " & ex.ToString)
                End Try
                updateCommand.Dispose()
                frmMain.database.Close()
            ElseIf attendenceAmt < 0 Then ' If negative number is entered, tells user invalid and refreshs the table from database
                MessageBox.Show("Attendence Amount should not be negative")
                allowEdits = False
                btnRefresh.PerformClick()
                allowEdits = True
            End If

        End If





    End Sub

    'turns on and off the editing of cells
    Private Sub btnAllowEdits_Click(sender As Object, e As EventArgs) Handles btnAllowEdits.Click
        allowEdits = Not allowEdits
        dgvAttendenceEntry.ReadOnly = Not dgvAttendenceEntry.ReadOnly
        dgvAttendenceEntry.Columns(0).ReadOnly = True
        dgvAttendenceEntry.Columns(1).ReadOnly = True

        If allowEdits = True Then
            btnAllowEdits.Text = "Disable Editing"
        Else
            btnAllowEdits.Text = "Allowing Editing"
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class