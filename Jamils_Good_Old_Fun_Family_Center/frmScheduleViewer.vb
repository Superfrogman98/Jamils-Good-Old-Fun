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

        'clears all old values from the schedule
        dgvScheduleView.Rows().Clear()
        If (itemCount > 0) Then  'only trys to fill grid if there are items, if not will just put a message

            'sets some propeties back to normal after a blank selection may have changed them
            dgvScheduleView.Font = New Font("Microsoft Sans Serif", 8.25)
            dgvScheduleView.ColumnHeadersVisible = True
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
            If ((scheduleStopTime Mod 100) <> 0) Then
                scheduleStopTime = scheduleStopTime + (100 - (scheduleStopTime Mod 100))
            End If


            'subtracts from start time so that the start time for labels will start at an hours start
            scheduleStartTime = scheduleStartTime - (scheduleStartTime Mod 100)
            Dim timeColumnCount As Integer = (scheduleStopTime - scheduleStartTime) / 100

            'loops and creates the number of time columns needed and labels for each of them
            dgvScheduleView.ColumnCount = timeColumnCount + 1
            dgvScheduleView.RowCount = 1
            dgvScheduleView.Columns(0).Width = 90
            dgvScheduleView.Columns(0).HeaderCell.Value = "Day"
            Dim timeStart As Integer = 1
            'adds a row to the schedule in multi employee mode so that names can be put beside a row
            If (singleEmployee = False) Then
                dgvScheduleView.ColumnCount += 1
                dgvScheduleView.Columns(1).HeaderCell.Value = "Employee Name"
                timeStart += 1
                timeColumnCount += 1
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
                                dgvScheduleView.RowCount += 1
                                Exit For
                            End If
                        Next
                    Next
                Next
                dgvScheduleView.RowCount -= 1 'removes the extra row that is created by the for loop

                'puts employee name in second box in multiple employee view
                Dim currentRow As Integer = 0
                For currentDay As Integer = 0 To days.Length() - 1 'loops through each day in a week
                    For currentID As Integer = 0 To validIDs.Length() - 1 'loops through all the ids that are in the schedule
                        If days(currentDay) > 0 Then ' checks for the rows on a day, if there are any will add the names to that row

                            Dim currentEmployeeData() As DataRow = frmMain.Jamils_Good_Old_FunDataSet.EmployeeSchedule.Select("EmployeeID =" & validIDs(currentID) & " AND " & "dayID = " & currentDay)

                            Dim currentEmployeeName() As DataRow = frmMain.Jamils_Good_Old_FunDataSet.EmployeeData.Select("ID =" & validIDs(currentID))
                            If (currentEmployeeData.Length() > 0) Then
                                For currentTimeItem As Integer = 0 To currentEmployeeData.Length() - 1

                                    'finds which column a time item should go in, accounts for diference caused by not having excess beginning boxes
                                    Dim column As Integer = ((currentEmployeeData(currentTimeItem)(3) - scheduleStartTime) / 100)
                                    'fills in the cell columns, prevents crashes from empty items by catching the error
                                    Try
                                        dgvScheduleView.Rows(currentRow).Cells(0).Value = dayNames(currentDay)
                                        dgvScheduleView.Rows(currentRow).Cells(1).Value = currentEmployeeName(0)(1) & " " & currentEmployeeName(0)(2)
                                        'loops through the stop time of an item - the start time to get how many columns it should span
                                        Dim itemStopTime As Integer = currentEmployeeData(currentTimeItem)(4)
                                        Dim itemStartTime As Integer = currentEmployeeData(currentTimeItem)(3)
                                        If ((itemStopTime Mod 100) <> 0) Then
                                            itemStopTime = itemStopTime + (100 - (itemStopTime Mod 100))
                                        End If

                                        itemStartTime = itemStartTime - (itemStartTime Mod 100)
                                        Dim additionalColumnsNeeded As Integer = ((itemStopTime - itemStartTime) / 100) - 1

                                        If (additionalColumnsNeeded > 0) Then
                                            For i As Integer = 0 To additionalColumnsNeeded
                                                'done this way so that the new time is added to the bottom of the existing time in the cell

                                                dgvScheduleView.Rows(currentRow).Cells(2 + column + i).Value = currentEmployeeData(currentTimeItem)(5) + ": " + currentEmployeeData(currentTimeItem)(3).ToString() + " - " + currentEmployeeData(currentTimeItem)(4).ToString() + vbNewLine + dgvScheduleView.Rows(currentRow).Cells(2 + column + i).Value

                                            Next
                                        Else
                                            Console.Write(dgvScheduleView.Rows(currentRow).Cells(2 + column).Value)
                                            dgvScheduleView.Rows(currentRow).Cells(2 + column).Value = currentEmployeeData(currentTimeItem)(5) + ": " + currentEmployeeData(currentTimeItem)(3).ToString() + " - " + currentEmployeeData(currentTimeItem)(4).ToString() + vbNewLine + dgvScheduleView.Rows(currentRow).Cells(2 + column).Value
                                        End If
                                    Catch ex As Exception
                                        Debug.Write("Cell filling failed with values( dayname: " & dayNames(currentDay) & ", Employee: " & currentEmployeeName(0)(1) & " " & currentEmployeeName(0)(2) & ", Description: " & currentEmployeeData(currentTimeItem)(5) & ") for column: " & column + 2 & "and row: " & currentRow & vbNewLine)
                                    End Try
                                Next
                            Else
                                currentRow -= 1 ' subtracts a one so that blank rows aren't created in the schedule
                            End If
                            currentRow += 1 ' increase the row after going through all the entries for one employee on a valid day
                        End If

                    Next
                Next

            Else 'if only one employee is checked will go here and run once
                For x As Integer = 0 To days.Length() - 1 ' checks if a day is in the schedule items to see if a row is needed for it
                    For i As Integer = 0 To scheduleItems.Length() - 1
                        If (scheduleItems(i).dayID = x) Then
                            days(scheduleItems(i).dayID) += 1
                            dgvScheduleView.RowCount += 1
                            Exit For
                        End If
                    Next
                Next
                dgvScheduleView.RowCount -= 1 'removes the extra row that is created by the for loop


                'puts employee name in second box in multiple employee view
                Dim currentRow As Integer = 0
                For currentDay As Integer = 0 To days.Length() - 1 'loops through each day in a week
                    If days(currentDay) > 0 Then ' checks for the rows on a day, if there are any will add the names to that row
                        For i As Integer = 0 To scheduleItems.Length() - 1
                            If (scheduleItems(i).dayID = currentDay) Then
                                Dim column As Integer = ((scheduleItems(i).startTime - scheduleStartTime) / 100)
                                dgvScheduleView.Rows(currentRow).Cells(0).Value = dayNames(currentDay)
                                dgvScheduleView.Rows(currentRow).Cells(1 + column).Value = scheduleItems(i).description
                            End If
                        Next
                        currentRow += 1
                    Else
                        'currentRow -= 1 ' subtracts a one so that blank rows aren't created in the schedule
                    End If
                Next
            End If

        Else 'if there are no items matching the criterial will fill the grid with a message
            dgvScheduleView.RowCount = 1
            dgvScheduleView.ColumnCount = 1
            dgvScheduleView.ColumnHeadersVisible = False
            dgvScheduleView.Rows(0).Height = dgvScheduleView.Height
            dgvScheduleView.Columns(0).Width = dgvScheduleView.Width
            dgvScheduleView.Rows(0).Cells(0).Value = "No Scheduled Items For This Selection"
            dgvScheduleView.Font = New Font("Microsoft Sans Serif", 45)
            dgvScheduleView.ScrollBars = ScrollBars.None
        End If
    End Sub

    'changes view from all employees to a single selected one
    Private Sub cbxAllEmployees_CheckedChanged(sender As Object, e As EventArgs) Handles cbxAllEmployees.CheckedChanged
        cbxEmployeeSelect.Enabled = Not cbxEmployeeSelect.Enabled
        singleEmployee = Not cbxAllEmployees.Checked
    End Sub
End Class