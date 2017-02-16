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
        viewSelected = 0
        cbxViewSelect.SelectedIndex = 0
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


        tlpSchedule.Visible = False ' sets the schedule to invisible so it can generate everything faster
        'counts how many valid items there will be
        Dim itemCount As Integer = 0
        For i As Integer = 0 To frmMain.Jamils_Good_Old_FunDataSet.EmployeeSchedule.Count - 1
            If ((singleEmployee = True And frmMain.Jamils_Good_Old_FunDataSet.EmployeeSchedule(i).EmployeeID = employeeSelected) Or singleEmployee = False) And (frmMain.Jamils_Good_Old_FunDataSet.EmployeeSchedule(i).dayID = viewSelected Or viewSelected = 7) Then
                itemCount += 1
            End If
        Next
        Dim scheduleItems(itemCount - 1) As scheduleItem
        'clear past items from grid view 
        tlpSchedule.Controls.Clear()
        tlpSchedule.ColumnStyles.Clear()
        tlpSchedule.RowStyles.Clear()
        tlpSchedule.ColumnCount = 1
        tlpSchedule.AutoScroll = False
        If (itemCount > 0) Then
            'base generation code for schedule
            tlpSchedule.AutoScroll = True
            tlpSchedule.ColumnCount = 97
            tlpSchedule.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 90))
            For i As Integer = 0 To 96
                tlpSchedule.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 15))
            Next

            'loops through the valid count and creates a row for structure one found
            Dim currentRowCounter As Integer = 0
            Dim matchingItems As Integer = 0

            While matchingItems < itemCount
                If ((singleEmployee = True And frmMain.Jamils_Good_Old_FunDataSet.EmployeeSchedule(currentRowCounter).EmployeeID = employeeSelected) Or singleEmployee = False) And (frmMain.Jamils_Good_Old_FunDataSet.EmployeeSchedule(currentRowCounter).dayID = viewSelected Or viewSelected = 7) Then

                    scheduleItems(matchingItems) = New scheduleItem(frmMain.Jamils_Good_Old_FunDataSet.EmployeeSchedule(currentRowCounter).EmployeeID, frmMain.Jamils_Good_Old_FunDataSet.EmployeeSchedule(currentRowCounter).Description, frmMain.Jamils_Good_Old_FunDataSet.EmployeeSchedule(currentRowCounter).dayID, frmMain.Jamils_Good_Old_FunDataSet.EmployeeSchedule(currentRowCounter).Start_TIme, frmMain.Jamils_Good_Old_FunDataSet.EmployeeSchedule(currentRowCounter).Stop_Time)
                    matchingItems += 1
                End If
                currentRowCounter += 1
            End While


            Dim days() As Integer = {0, 0, 0, 0, 0, 0, 0}
            Dim validIDs() As Integer = {scheduleItems(0).employeeID}

            If (singleEmployee = False) Then
                scheduleItems = scheduleItems.OrderBy(Function(c) c.employeeID).ToArray 'sorts the schedule items by the employeeid ascending
                'puts all the employee IDs into an array
                Dim currentIDIndex As Integer = 1
                For i As Integer = 1 To scheduleItems.Length() - 1
                    If (scheduleItems(i).employeeID <> scheduleItems(i - 1).employeeID) Then
                        ReDim Preserve validIDs(validIDs.Length())
                        validIDs(currentIDIndex) = scheduleItems(i).employeeID
                        currentIDIndex += 1
                    Else

                    End If
                Next

                Dim singleEmployeeItems(0) As scheduleItem
                For currentID As Integer = 0 To validIDs.Length() - 1
                    ReDim singleEmployeeItems(0)

                    For i As Integer = 0 To scheduleItems.Length() - 1
                        If (scheduleItems(i).employeeID <> validIDs(currentID) Or i = scheduleItems.Length() - 1) Then
                            ReDim Preserve singleEmployeeItems(singleEmployeeItems.Length() - 1)
                            For x As Integer = 0 To days.Length() - 1
                                For y As Integer = 0 To singleEmployeeItems.Length() - 1
                                    If (singleEmployeeItems(y).dayID = x) Then
                                        days(scheduleItems(y).dayID) += 1
                                        Exit For
                                    End If
                                Next
                            Next
                        Else
                            ReDim Preserve singleEmployeeItems(singleEmployeeItems.Length())
                            singleEmployeeItems(i) = scheduleItems(i)
                        End If
                    Next
                Next
            Else
                scheduleItems = scheduleItems.OrderBy(Function(c) c.dayID).ToArray
                For x As Integer = 0 To days.Length() - 1
                    For i As Integer = 0 To scheduleItems.Length() - 1
                        If (scheduleItems(i).dayID = x) Then
                            days(scheduleItems(i).dayID) += 1
                            Exit For
                        End If
                    Next
                Next

            End If


            For i As Integer = 0 To days.Length() - 1
                If (days(i) > 0) Then
                    MessageBox.Show(dayNames(i) & " rowcount: " & days(i))
                End If

            Next


            'tlpSchedule.RowStyles.Add(New RowStyle(SizeType.Absolute, 40))
            'Dim singleDay As New Label
            'singleDay.Name = "txt" + days(viewSelected)
            'singleDay.Text = days(viewSelected)
            'singleDay.Height = 42
            'singleDay.Margin = New Padding(0, 0, 0, 0)
            'tlpSchedule.Controls.Add(singleDay, 0, 0)
        Else
                Dim L As New Label
            L.Name = "txtNoItems"
            L.Text = "No Scheduled Items For This Employee"
            L.Width = 1120
            L.Height = 400
            L.TextAlign = ContentAlignment.MiddleCenter
            L.Margin = New Padding(0, 0, 0, 0)
            L.Font = New Font("Microsoft Sans Serif", 70)
            tlpSchedule.Controls.Add(L, 0, 0)
        End If
        tlpSchedule.Visible = True

    End Sub

    Private Sub cbxAllEmployees_CheckedChanged(sender As Object, e As EventArgs) Handles cbxAllEmployees.CheckedChanged
        cbxEmployeeSelect.Enabled = Not cbxEmployeeSelect.Enabled
        singleEmployee = Not cbxAllEmployees.Checked
    End Sub
End Class