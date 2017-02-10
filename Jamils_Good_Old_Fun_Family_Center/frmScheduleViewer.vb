Public Class frmScheduleViewer
    Private Sub tlpSchedule_Click(sender As Object, e As EventArgs) Handles tlpSchedule.Click


        tlpSchedule.Controls.Clear()
        tlpSchedule.AutoScroll = True
        tlpSchedule.ColumnStyles.Clear()
        tlpSchedule.RowStyles.Clear()

        tlpSchedule.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 30))

        tlpSchedule.Visible = False

        For i As Integer = 0 To 400
            Dim L As New Label
            tlpSchedule.RowStyles.Add(New RowStyle(SizeType.Absolute, 20))

            L.Name = "txt" + i.ToString()
            L.Text = "eee" + i.ToString()
            L.BackColor = Color.Blue


            tlpSchedule.Controls.Add(L, 0, i)
        Next
        tlpSchedule.Visible = True
    End Sub
End Class