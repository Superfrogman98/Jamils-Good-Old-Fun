'programmer: Max Buckel
'date: 2017-1-26
'function: allow the user to create a new item in an employees schedule
Imports System.Data.OleDb
Public Class frmAddScheduleItem
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim uniqueTime As Boolean = True
        'command variables
        Dim updateCommand As OleDbCommand
        Dim insertCommand As OleDbCommand
        'day string and id variables for use in the update command
        Dim day As String = cbxDay.SelectedItem
        Dim dayID As Integer = cbxDay.SelectedIndex
        'unique key for updating row, works across employees
        Dim key As String
        If (frmMain.selectedScheduleRow < frmMain.dgvSchedule.RowCount - 1) Then
            key = frmMain.Jamils_Good_Old_FunDataSet.EmployeeData(frmMain.currentEmployee).ID & frmMain.dgvSchedule.Rows(frmMain.selectedScheduleRow).Cells(0).Value & frmMain.dgvSchedule.Rows(frmMain.selectedScheduleRow).Cells(2).Value
        Else
            key = frmMain.Jamils_Good_Old_FunDataSet.EmployeeData(frmMain.currentEmployee).ID & day & nudStart.Value
        End If

        'loops through the rows in the data grid view, grid is already filtered to only employeeID matches, so checks for a day match, and then for the start and stop times to be between any other start and stop time pairs on that day before changing to false, if a match is found the loop is exited, and the If to modify the database will be false and a message will be put out
        For i As Integer = 0 To frmMain.dgvSchedule.RowCount() - 2
            If (day = frmMain.dgvSchedule.Rows(i).Cells(0).Value And i <> frmMain.selectedScheduleRow) Then
                If ((nudStart.Value > frmMain.dgvSchedule.Rows(i).Cells(2).Value And nudStart.Value < frmMain.dgvSchedule.Rows(i).Cells(3).Value) Or (nudStop.Value > frmMain.dgvSchedule.Rows(i).Cells(2).Value And nudStart.Value < frmMain.dgvSchedule.Rows(i).Cells(3).Value)) Then
                    uniqueTime = False
                    Exit For
                End If
            End If
        Next

        If (uniqueTime = True And txtDescription.Text.Trim <> "") Then
            If (frmMain.selectedScheduleRow < frmMain.dgvSchedule.RowCount - 1) Then
                frmMain.database.Open()
                'MessageBox.Show("1 " & day & "," & dayID & "," & nudStart.Value & "," & nudStop.Value & "," & txtDescription.Text & "," & frmMain.currentEmployee)
                updateCommand = New OleDbCommand("UPDATE EmployeeSchedule SET [Day] = ? , [Start TIme] = ?, [Stop Time] = ?, Description = ? , dayID= ? WHERE [KEY] = ?", frmMain.database)
                updateCommand.Parameters.AddWithValue("day", day)
                updateCommand.Parameters.AddWithValue("startTime", nudStart.Value)
                updateCommand.Parameters.AddWithValue("stopTime", nudStop.Value)
                updateCommand.Parameters.AddWithValue("Description", txtDescription.Text)
                updateCommand.Parameters.AddWithValue("dayID", dayID)
                updateCommand.Parameters.AddWithValue("[KEY]", key)
                'trys using the command, if there is an error a message is displayed
                Try
                    updateCommand.ExecuteNonQuery()
                    MessageBox.Show("Schedule Updated")
                Catch ex As Exception
                    MessageBox.Show("Error With Updating schedule:  " & ex.ToString)
                End Try
                'gets rid of the command once used
                updateCommand.Dispose()
            Else
                frmMain.database.Open()
                'MessageBox.Show("2 " & day & "," & dayID & "," & nudStart.Value & "," & nudStop.Value & "," & txtDescription.Text & "," & frmMain.currentEmployee)
                insertCommand = New OleDbCommand("insert into EmployeeSchedule( EmployeeID, [Day], [Start TIme],[Stop Time], Description, dayID )values('" & frmMain.Jamils_Good_Old_FunDataSet.EmployeeData(frmMain.currentEmployee).ID & "','" & day & "','" & nudStart.Value & "','" & nudStop.Value & "','" & txtDescription.Text.Trim & "','" & dayID & "')", frmMain.database)
                'trys using the command, if there is an error a message is displayed
                Try
                    insertCommand.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show("Error With Updating schedule:  " & ex.ToString)

                End Try
                insertCommand.Dispose()
            End If
            frmMain.database.Close()
            frmMain.EmployeeScheduleTableAdapter.Fill(frmMain.Jamils_Good_Old_FunDataSet.EmployeeSchedule)
            Me.Close()
        ElseIf (uniqueTime = False) Then
            MessageBox.Show("The schedule item that you have created or changed overlaps with another schedule item, please correct this!", "Invalid Entry")
        ElseIf (txtDescription.Text.Trim = "") Then
            MessageBox.Show("The schedule item that you have created or changed is missing a description, please correct this!", "Invalid Entry")
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim deleteCommand As OleDbCommand
        Dim confirmRemove As Integer
        Dim key As String = frmMain.Jamils_Good_Old_FunDataSet.EmployeeData(frmMain.currentEmployee).ID & frmMain.dgvSchedule.Rows(frmMain.selectedScheduleRow).Cells(0).Value & frmMain.dgvSchedule.Rows(frmMain.selectedScheduleRow).Cells(2).Value
        confirmRemove = MessageBox.Show("Are you sure you would Like to remove this schedule item? This action cannot be undone!", "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If confirmRemove = 6 Then
            Try
                deleteCommand = New OleDbCommand("DELETE * FROM EmployeeSchedule WHERE [KEY] = ?", frmMain.database)
                frmMain.database.Open()
                deleteCommand.Parameters.AddWithValue("[KEY]", key)
                deleteCommand.ExecuteNonQuery()
                frmMain.database.Close()
                deleteCommand.Dispose()
                MessageBox.Show("Schedule Item Has Been Removed", "Action Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmMain.EmployeeScheduleTableAdapter.Fill(frmMain.Jamils_Good_Old_FunDataSet.EmployeeSchedule)
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Schedule Item Could Not Be Removed", "Action Failure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End If
    End Sub

    Private Sub nudStart_ValueChanged(sender As Object, e As EventArgs) Handles nudStart.Leave
        Dim valueEnd As Integer
        'only gets the last two digits from the time
        If (nudStart.Value.ToString.Length() <= 2) Then
            valueEnd = nudStart.Value
        Else
            valueEnd = Int(nudStart.Value.ToString.Remove(0, nudStart.Value.ToString.Length() - 2))

        End If
        If (valueEnd > 59 And valueEnd < 99) Then
            nudStart.Value = nudStart.Value + (100 - valueEnd)

        End If
        nudStop.Minimum = nudStart.Value
    End Sub

    Private Sub nudStop_ValueChanged(sender As Object, e As EventArgs) Handles nudStop.Leave

        Dim valueEnd As Integer
        'only gets the last two digits from the time
        If (nudStop.Value.ToString.Length() <= 2) Then
            valueEnd = nudStop.Value
        Else
            valueEnd = Int(nudStop.Value.ToString.Remove(0, nudStop.Value.ToString.Length() - 2))
        End If
        If (valueEnd > 59 And valueEnd < 99) Then
            nudStop.Value = nudStop.Value + (100 - valueEnd)
        End If
        nudStart.Maximum = nudStop.Value
    End Sub


    Private Sub frmAddScheduleItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nudStart.Maximum = 2359
        nudStop.Maximum = 2359
        nudStart.Minimum = 0
        nudStop.Minimum = 15
        'fills in values when row is selected in edit mode
        Try
            Debug.Write("Loading Day Value- ")
            cbxDay.SelectedIndex = Int(frmMain.dgvSchedule.Rows(frmMain.selectedScheduleRow).Cells(4).Value)
            Debug.Write(" loaded for editing" & vbNewLine)
        Catch ex As Exception
            cbxDay.SelectedIndex = 0
        End Try

        Try
            Debug.Write("Loading Description Text- ")
            txtDescription.Text = frmMain.dgvSchedule.Rows(frmMain.selectedScheduleRow).Cells(1).Value
            Debug.Write(" loaded for editing" & vbNewLine)
        Catch ex As Exception
            txtDescription.Text = ""
        End Try

        Try
            Debug.Write("Loading Start time Value- ")
            nudStart.Value = frmMain.dgvSchedule.Rows(frmMain.selectedScheduleRow).Cells(2).Value
            Debug.Write(" loaded for editing" & vbNewLine)
        Catch ex As Exception
            nudStart.Value = nudStart.Minimum
        End Try

        Try
            Debug.Write("Loading Stop time Value- ")
            nudStop.Value = frmMain.dgvSchedule.Rows(frmMain.selectedScheduleRow).Cells(3).Value
            Debug.Write(" loaded for editing" & vbNewLine)
        Catch ex As Exception
            nudStop.Value = nudStop.Minimum
        End Try
        If (frmMain.selectedScheduleRow = frmMain.dgvSchedule.RowCount - 1) Then
            btnDelete.Enabled = False
        Else
            btnDelete.Enabled = True
        End If
    End Sub

    Private Sub nudStart_ValueChanged_1(sender As Object, e As EventArgs) Handles nudStart.ValueChanged

        Dim valueEnd As Integer
        If (nudStart.Value.ToString.Length() <= 2) Then
            valueEnd = nudStart.Value
        Else
            valueEnd = Int(nudStart.Value.ToString.Remove(0, nudStart.Value.ToString.Length() - 2))
        End If
        If (valueEnd > 59 And valueEnd < 99) Then

            If valueEnd = 85 Then
                nudStart.Value = nudStart.Value - valueEnd + 45
            Else
                nudStart.Value = nudStart.Value + (100 - valueEnd)
            End If
        End If

    End Sub

    Private Sub nudStop_ValueChanged_1(sender As Object, e As EventArgs) Handles nudStop.ValueChanged

        Dim valueEnd As Integer
        'only gets the last two digits from the time
        If (nudStop.Value.ToString.Length() <= 2) Then
            valueEnd = nudStop.Value
        Else
            valueEnd = Int(nudStop.Value.ToString.Remove(0, nudStop.Value.ToString.Length() - 2))
        End If
        If (valueEnd > 59 And valueEnd < 99 And valueEnd <> 85) Then
            If valueEnd = 85 Then
                MessageBox.Show(valueEnd)
            Else
                nudStop.Value = nudStop.Value + (100 - valueEnd)
            End If

        End If
    End Sub
End Class