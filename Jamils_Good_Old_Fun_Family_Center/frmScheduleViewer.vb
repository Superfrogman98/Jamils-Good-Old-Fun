'programmer: Max Buckel
'date: 2017-2-14
'function: viewer for the schedule, organizes the schedule to a more comprehensive view

Structure scheduleItem
    Public employeeID As Integer
    Public description As String
    Public dayID As Integer
    Public startTime As Integer
    Public stopTime As Integer
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

            'loops through the valid count and creates a row for each one found
            Dim currentRowCounter As Integer = 0
            Dim matchingItems As Integer = 0
            While matchingItems < itemCount
                If ((singleEmployee = True And frmMain.Jamils_Good_Old_FunDataSet.EmployeeSchedule(currentRowCounter).EmployeeID = employeeSelected) Or singleEmployee = False) And (frmMain.Jamils_Good_Old_FunDataSet.EmployeeSchedule(currentRowCounter).dayID = viewSelected Or viewSelected = 7) Then
                    Dim singleItem As scheduleItem
                    singleItem.employeeID = frmMain.Jamils_Good_Old_FunDataSet.EmployeeSchedule(currentRowCounter).EmployeeID
                    singleItem.description = frmMain.Jamils_Good_Old_FunDataSet.EmployeeSchedule(currentRowCounter).Description
                    singleItem.dayID = frmMain.Jamils_Good_Old_FunDataSet.EmployeeSchedule(currentRowCounter).dayID
                    singleItem.startTime = frmMain.Jamils_Good_Old_FunDataSet.EmployeeSchedule(currentRowCounter).Start_TIme
                    singleItem.stopTime = frmMain.Jamils_Good_Old_FunDataSet.EmployeeSchedule(currentRowCounter).Stop_Time
                    scheduleItems(matchingItems) = singleItem
                    matchingItems += 1
                End If
                currentRowCounter += 1
            End While

            For i As Integer = 0 To scheduleItems.Length() - 1
                MessageBox.Show("EmployeeID " & scheduleItems(i).employeeID & " Description " & scheduleItems(i).description & "DayID  " & scheduleItems(i).dayID)
            Next
            Dim day() As String = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"}
            If (viewSelected <> 7) Then
                tlpSchedule.RowStyles.Add(New RowStyle(SizeType.Absolute, 40))
                Dim singleDay As New Label
                singleDay.Name = "txt" + day(viewSelected)
                singleDay.Text = day(viewSelected)
                singleDay.Height = 42
                singleDay.Margin = New Padding(0, 0, 0, 0)
                tlpSchedule.Controls.Add(singleDay, 0, 0)
            Else
                For i As Integer = 0 To 6
                    tlpSchedule.RowStyles.Add(New RowStyle(SizeType.Absolute, 40))
                    Dim multiDay As New Label
                    multiDay.Name = "txt" + day(i)
                    multiDay.Text = day(i)
                    multiDay.Height = 42
                    multiDay.Margin = New Padding(0, 0, 0, 0)
                    tlpSchedule.Controls.Add(multiDay, 0, i)
                Next
            End If
            Dim endLabel As New Label
            endLabel.Name = "txtEndRow"
            endLabel.Text = " "
            tlpSchedule.Controls.Add(endLabel, 0, 7)

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
        singleEmployee = cbxEmployeeSelect.Enabled
    End Sub
End Class