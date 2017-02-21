'programmer: Max Buckel
'date: 2017-2-14
'function: viewer for the schedule, organizes the schedule to a more comprehensive view

Structure scheduleItem

    Public employeeID As Integer
    Public description As String
    Public dayID As Integer
    Public startTime As Integer
    Public stopTime As Integer

    Sub New(ByVal _employeeID As Integer, ByVal _description As String, ByVal _dayID As Integer, ByVal _startTime As Integer, ByVal _stopTime As Integer)
        employeeID = _employeeID
        description = _description
        dayID = _dayID
        startTime = _startTime
        stopTime = _stopTime
    End Sub

End Structure
Public Class frmScheduleViewer
    Public employeeSelected As Integer
    Public viewSelected As Integer
    Public singleEmployee As Boolean = True


    Private Sub frmScheduleViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.EmployeeDataTableAdapter.Fill(Me.Jamils_Good_Old_FunDataSet.EmployeeData)
        employeeSelected = cbxEmployeeSelect.SelectedValue
        viewSelected = 7
        cbxViewSelect.SelectedIndex = 7
    End Sub

    'changes the employee that the user is viewing
    Private Sub cbxEmployeeSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxEmployeeSelect.SelectedIndexChanged
        employeeSelected = cbxEmployeeSelect.SelectedValue

    End Sub

    'lets the user change the view
    Private Sub cbxViewSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxViewSelect.SelectedIndexChanged
        viewSelected = cbxViewSelect.SelectedIndex
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Dim dayNames() As String = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"}
        Dim dayRowStart() As Integer = {0, 0, 0, 0, 0, 0, 0} 'holds the row that a day starts on for the schedule

        'for loop to count how many items there will be so that the amount can be used to set the length of the scheduleItems array
        Dim itemCount As Integer = 0
        For i As Integer = 0 To frmMain.Jamils_Good_Old_FunDataSet.EmployeeSchedule.Count - 1
            If ((singleEmployee = True And frmMain.Jamils_Good_Old_FunDataSet.EmployeeSchedule(i).EmployeeID = employeeSelected) Or singleEmployee = False) And (frmMain.Jamils_Good_Old_FunDataSet.EmployeeSchedule(i).dayID = viewSelected Or viewSelected = 7) Then
                itemCount += 1
            End If
        Next
        Dim scheduleItems(itemCount - 1) As scheduleItem ' array to hold all the valid schedule items structures
        'only trys to fill grid if there are items, if not will just put a message
        If (itemCount > 0) Then
            Dim currentRowCounter As Integer = 0 ' variable to go through rows in the schedule table in the database
            Dim matchingItems As Integer = 0 'variable to store the count of created valid
            Dim scheduleStartTime As Integer = 2300 'variable for the schedule generation so excess blank rows at the start aren't made 
            Dim scheduleStopTime As Integer = 0 'variable for the schedule generation so excess blank rows at the end aren't made 


            'while the number of structures in the array is less then the item count previously found, will go through the database and create schedules
            While matchingItems < itemCount
                If ((singleEmployee = True And frmMain.Jamils_Good_Old_FunDataSet.EmployeeSchedule(currentRowCounter).EmployeeID = employeeSelected) Or singleEmployee = False) And (frmMain.Jamils_Good_Old_FunDataSet.EmployeeSchedule(currentRowCounter).dayID = viewSelected Or viewSelected = 7) Then
                    'populates the array by using the constructor for a scheduleItem
                    scheduleItems(matchingItems) = New scheduleItem(frmMain.Jamils_Good_Old_FunDataSet.EmployeeSchedule(currentRowCounter).EmployeeID, frmMain.Jamils_Good_Old_FunDataSet.EmployeeSchedule(currentRowCounter).Description, frmMain.Jamils_Good_Old_FunDataSet.EmployeeSchedule(currentRowCounter).dayID, frmMain.Jamils_Good_Old_FunDataSet.EmployeeSchedule(currentRowCounter).Start_TIme, frmMain.Jamils_Good_Old_FunDataSet.EmployeeSchedule(currentRowCounter).Stop_Time)
                    matchingItems += 1
                    If (frmMain.Jamils_Good_Old_FunDataSet.EmployeeSchedule(currentRowCounter).Start_TIme < scheduleStartTime) Then
                        scheduleStartTime = frmMain.Jamils_Good_Old_FunDataSet.EmployeeSchedule(currentRowCounter).Start_TIme
                    End If
                    If (frmMain.Jamils_Good_Old_FunDataSet.EmployeeSchedule(currentRowCounter).Stop_Time > scheduleStopTime) Then
                        scheduleStopTime = frmMain.Jamils_Good_Old_FunDataSet.EmployeeSchedule(currentRowCounter).Stop_Time
                    End If

                End If
                currentRowCounter += 1
            End While

            'adds to stop time so that the labels will end at an hours end
            If ((scheduleStartTime Mod 100) <> 0) Then
                scheduleStopTime = scheduleStopTime + (100 - (scheduleStartTime Mod 100))
            End If


            'subtracts from start time so that the start time for labels will start at an hours start
            scheduleStartTime = scheduleStartTime - (scheduleStartTime Mod 100)
            Dim timeColumnCount As Integer = (scheduleStopTime - scheduleStartTime) / 100

            'loops and creates the number of time columns needed and labels for each of them

            dgvScheduleView.ColumnCount = 2 + timeColumnCount
            dgvScheduleView.Columns(0).Width = 90
            dgvScheduleView.RowCount = 1 + itemCount
            dgvScheduleView.Columns(0).HeaderCell.Value = "Day"
            Dim timeStart As Integer = 1
            'adds a row to the schedule in multi employee mode so that names can be put beside a row
            If (singleEmployee = False) Then
                dgvScheduleView.ColumnCount += 1
                dgvScheduleView.Columns(1).HeaderCell.Value = "Employee Name"
                timeStart += 1
            End If


            Dim currentTime As Integer = scheduleStartTime 'variable for making time labels, sets it to the earliest to so there aren't extra empty boxes

            'for loop to create the time labels
            For i As Integer = timeStart To timeColumnCount
                dgvScheduleView.Columns(i).Width = 150
                dgvScheduleView.Columns(i).HeaderCell.Value = currentTime & "-" & currentTime + 100
                currentTime += 100
            Next

            Dim days() As Integer = {0, 0, 0, 0, 0, 0, 0} ' keeps track of the necessary row counts for each day
            Dim validIDs() As Integer = {scheduleItems(0).employeeID} 'array to hold all the employeeids from the schedule items

            'checks if view all employees is true
            If (singleEmployee = False) Then
                scheduleItems = scheduleItems.OrderBy(Function(c) c.employeeID).ToArray 'sorts the schedule items by the employeeid ascending
                'puts all the employee IDs into an array from the structures
                Dim currentIDIndex As Integer = 1
                For i As Integer = 1 To scheduleItems.Length() - 1
                    If (scheduleItems(i).employeeID <> scheduleItems(i - 1).employeeID) Then
                        ReDim Preserve validIDs(validIDs.Length())
                        validIDs(currentIDIndex) = scheduleItems(i).employeeID
                        currentIDIndex += 1
                    End If
                Next
                'loops through the schedule items and counts the number or rows needed for each day, only counts a day once per employee
                For currentID As Integer = 0 To validIDs.Length() - 1
                    For x As Integer = 0 To days.Length() - 1
                        For y As Integer = 0 To scheduleItems.Length() - 1
                            If (scheduleItems(y).dayID = x And scheduleItems(y).employeeID = validIDs(currentID)) Then
                                days(scheduleItems(y).dayID) += 1
                                Exit For
                            End If
                        Next
                    Next
                Next

                'creates day labels for multiple employee view, sets row span so the label goes next to all rows for that day
                Dim currentRow As Integer = 1
                For i As Integer = 0 To days.Length() - 1
                    If (days(i) > 0) Then
                        For x As Integer = 0 To days(i)
                            'dgvScheduleView.Rows(currentRow).Cells(0).Value = dayNames(i)
                            currentRow += 1
                        Next
                    End If
                Next
                'puts employee name in second box in multiple employee view
                For currentDay As Integer = 0 To days.Length() - 1 'loops through each day in a week
                    For currentID As Integer = 0 To validIDs.Length() - 1 'loops through all the ids that are in the schedule
                        If days(currentDay) > 0 Then ' checks for the rows on a day, if there are any will add the names to that row
                            For currentScheduleItem As Integer = 0 To scheduleItems.Length() - 1 'loops through each schedule item
                                'checks if the schedule items id and day match what is currently at in the loops
                                If (scheduleItems(currentScheduleItem).employeeID = validIDs(currentID) & scheduleItems(currentScheduleItem).dayID = currentDay) Then



                                End If
                            Next
                        End If
                    Next
                Next

            Else 'if only one employee is checked will go here and run once
                For x As Integer = 0 To days.Length() - 1
                    For i As Integer = 0 To scheduleItems.Length() - 1
                        If (scheduleItems(i).dayID = x) Then
                            days(scheduleItems(i).dayID) += 1
                            Exit For
                        End If
                    Next
                Next
                Dim currentRow As Integer = 1
                For i As Integer = 0 To days.Length() - 1
                    If (days(i) > 0) Then
                        'dgvScheduleView.Rows(currentRow).Cells(0).Value = dayNames(i)

                        currentRow += 1
                    End If
                Next
            End If

        Else
            'Dim L As New Label
            'L.Name = "txtNoItems"
            'L.Text = "No Scheduled Items For This Employee"
            'L.Width = 1120
            'L.Height = 400
            'L.TextAlign = ContentAlignment.MiddleCenter
            'L.Margin = New Padding(0, 0, 0, 0)
            'L.Font = New Font("Microsoft Sans Serif", 70)
        End If
    End Sub

    Private Sub cbxAllEmployees_CheckedChanged(sender As Object, e As EventArgs) Handles cbxAllEmployees.CheckedChanged
        cbxEmployeeSelect.Enabled = Not cbxEmployeeSelect.Enabled
        singleEmployee = Not cbxAllEmployees.Checked
    End Sub
End Class