'programmer: Max Buckel
'date: 2017-2-14
'function: viewer for the schedule, organizes the schedule to a more comprehensive view
Public Class frmScheduleViewer
    Public employeeSelected As Integer
    Private Sub frmScheduleViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.EmployeeDataTableAdapter.Fill(Me.Jamils_Good_Old_FunDataSet.EmployeeData)
        employeeSelected = cbxEmployeeSelect.SelectedValue
    End Sub

    'changes the employee the the user is viewing
    Private Sub cbxEmployeeSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxEmployeeSelect.SelectedIndexChanged
        employeeSelected = cbxEmployeeSelect.SelectedValue

    End Sub

    Private Sub cbxViewSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxViewSelect.SelectedIndexChanged

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

        tlpSchedule.Visible = False ' sets the schedule to invisible so it can generate everything faster
        Dim itemCount As Integer = 0
        For i As Integer = 0 To frmMain.Jamils_Good_Old_FunDataSet.EmployeeSchedule.Count - 1
            If frmMain.Jamils_Good_Old_FunDataSet.EmployeeSchedule(i).EmployeeID = employeeSelected Then
                itemCount += 1
            End If
        Next
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
            For i As Integer = 0 To itemCount - 1

                tlpSchedule.RowStyles.Add(New RowStyle(SizeType.Absolute, 40))

                Dim L As New Label
                L.Name = "txtR" + i.ToString() '+ "C" + q.ToString()
                L.Text = frmMain.Jamils_Good_Old_FunDataSet.EmployeeSchedule(i).Day
                L.Height = 42
                L.Margin = New Padding(0, 0, 0, 0)
                'L.BackColor = Color.FromKnownColor(i)
                tlpSchedule.Controls.Add(L, 0, i)
                'tlpSchedule.SetRowSpan(L, 2)
            Next

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
End Class