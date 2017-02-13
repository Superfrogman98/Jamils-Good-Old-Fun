Public Class frmScheduleViewer
    Private Sub frmScheduleViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.EmployeeDataTableAdapter.Fill(Me.Jamils_Good_Old_FunDataSet.EmployeeData)
    End Sub

    Private Sub cbxEmployeeSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxEmployeeSelect.SelectedIndexChanged

        tlpSchedule.Controls.Clear()
        tlpSchedule.AutoScroll = True
        tlpSchedule.ColumnStyles.Clear()
        tlpSchedule.RowStyles.Clear()


        tlpSchedule.ColumnCount = 1
        ' For q As Integer = 0 To 9
        ' tlpSchedule.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10))
        ' Next
        tlpSchedule.Visible = False

        For i As Integer = 0 To 174
            tlpSchedule.RowStyles.Add(New RowStyle(SizeType.Absolute, 20))
            'For q As Integer = 0 To 9
            Dim L As New Label
            L.Name = "txtR" + i.ToString() '+ "C" + q.ToString()
            L.Text = "Color: " + (i).ToString()
            L.BackColor = Color.FromKnownColor(i)
            tlpSchedule.Controls.Add(L, 0, i)
            ' Next
        Next
        tlpSchedule.Visible = True
    End Sub

    Private Sub cbxViewSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxViewSelect.SelectedIndexChanged
        tlpSchedule.Controls.Clear()
        tlpSchedule.AutoScroll = True
        tlpSchedule.ColumnStyles.Clear()
        tlpSchedule.RowStyles.Clear()


        tlpSchedule.ColumnCount = 1
        ' For q As Integer = 0 To 9
        ' tlpSchedule.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10))
        ' Next
        tlpSchedule.Visible = False

        For i As Integer = 0 To 174
            tlpSchedule.RowStyles.Add(New RowStyle(SizeType.Absolute, 20))
            'For q As Integer = 0 To 9
            Dim L As New Label
            L.Name = "txtR" + i.ToString() '+ "C" + q.ToString()
            L.Text = "Color: " + (i).ToString()
            L.BackColor = Color.FromKnownColor(i)
            tlpSchedule.Controls.Add(L, 0, i)
            ' Next
        Next
        tlpSchedule.Visible = True
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        tlpSchedule.Controls.Clear()
        tlpSchedule.AutoScroll = True
        tlpSchedule.ColumnStyles.Clear()
        tlpSchedule.RowStyles.Clear()


        tlpSchedule.ColumnCount = 1
        ' For q As Integer = 0 To 9
        ' tlpSchedule.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10))
        ' Next
        tlpSchedule.Visible = False

        For i As Integer = 0 To 174
            tlpSchedule.RowStyles.Add(New RowStyle(SizeType.Absolute, 20))
            'For q As Integer = 0 To 9
            Dim L As New Label
            L.Name = "txtR" + i.ToString() '+ "C" + q.ToString()
            L.Text = "Color: " + (i).ToString()
            L.BackColor = Color.FromKnownColor(i)
            tlpSchedule.Controls.Add(L, 0, i)
            ' Next
        Next
        tlpSchedule.Visible = True
    End Sub
End Class