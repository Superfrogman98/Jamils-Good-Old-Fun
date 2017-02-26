'Programmer: Max Buckel
'Date: 2017-2-25
'function: display the total attendance of the center by days and total amount

Imports System.Drawing
Imports System.Drawing.Printing

Public Class frmAttendanceReport


    'handles the loading of form, fills the data source and sets the range max values
    Private Sub frmAttendanceReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Jamils_Good_Old_FunDataSet.CustomerAttendance' table. You can move, or remove it, as needed.
        Me.CustomerAttendanceTableAdapter.Connection = frmMain.database
        Me.CustomerAttendanceTableAdapter.Fill(Me.Jamils_Good_Old_FunDataSet.CustomerAttendance)

        dtpBeginDate.Value = New DateTime(Today.Year, Today.Month, Today.Day - 7)
        dtpBeginDate.MaxDate = Today
    End Sub

    'on refresh, load and changeing of the date select the chart will change the values displayed
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click, MyBase.Load, dtpBeginDate.ValueChanged
        Me.CustomerAttendanceTableAdapter.ClearBeforeFill = True 'resets the connection so that the user entered data will properly fill the table
        Me.CustomerAttendanceTableAdapter.Fill(Me.Jamils_Good_Old_FunDataSet.CustomerAttendance)

        Dim currentDate As Date = dtpBeginDate.Value 'used for creating the x values of the chart
        'filter the binding source to only show dates between the selected values
        chrAttendance.Series.Clear()
        chrAttendance.Legends.Clear()
        CustomerAttendanceBindingSource.Filter = "attendanceDate >= #" & dtpBeginDate.Value & "# AND  attendanceDate <= #" & dtpBeginDate.Value.AddDays(6) & "#"
        chrAttendance.Titles("chartTitle").Text = "Customer Attendance for Week of " & dtpBeginDate.Value & " Through " & dtpBeginDate.Value.AddDays(6)


        If CustomerAttendanceBindingSource.Count > 0 Then
            chrAttendance.Visible = True
            lblNoItems.Visible = False
            chrAttendance.ChartAreas("ChartArea1").AxisY.Maximum = 10
            'used to add together all the attendence from one day
            Dim currentDateCount As Integer = 0
            'creates a series for all the dates to be in named for the first day of the week, and enables value labels
            chrAttendance.Series.Add(currentDate.ToShortDateString())
            chrAttendance.Series(currentDate.ToShortDateString()).IsValueShownAsLabel = True
            chrAttendance.Series(dtpBeginDate.Value.ToShortDateString).LabelBackColor = Color.LightGray

            'loops through all the days
            For i As Integer = 0 To 6
                currentDateCount = 0
                'adds all the attendence amounts for a day together
                For x As Integer = 0 To CustomerAttendanceBindingSource.Count() - 1
                    If (CustomerAttendanceBindingSource(x)(1) = currentDate) Then
                        currentDateCount += CustomerAttendanceBindingSource(x)(3)
                    End If
                Next

                'adds the value to the chart
                chrAttendance.Series(dtpBeginDate.Value.ToShortDateString).Points.AddXY(currentDate.ToShortDateString(), currentDateCount)
                currentDate = DateAdd(DateInterval.Day, 1, currentDate) 'increase the day to the next one
                'sets a higher maximum so labels aren't cut off
                If (chrAttendance.ChartAreas("ChartArea1").AxisY.Maximum < currentDateCount + 10) Then
                    chrAttendance.ChartAreas("ChartArea1").AxisY.Maximum = Math.Ceiling(currentDateCount) + 5

                End If
                chrAttendance.ChartAreas("ChartArea1").RecalculateAxesScale()
            Next
        Else
            chrAttendance.Visible = False
            lblNoItems.Visible = True
        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim pd As New System.Drawing.Printing.PrintDocument()
        pd.DefaultPageSettings.Landscape = True
        AddHandler pd.PrintPage, AddressOf pd_PrintPage

        Dim dlgPrintPreview As New EnhancedPrintPreviewDialog
        dlgPrintPreview.ClientSize = New System.Drawing.Size(600, 600)
        dlgPrintPreview.Document = pd ' Previews print
        dlgPrintPreview.ShowDialog()

    End Sub
    Private Sub pd_PrintPage(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        ' Create and initialize print font 
        Dim printFont As New System.Drawing.Font("Arial", 10)
        ' Create Rectangle structure, used to set the position of the chart 
        Dim myRec As New System.Drawing.Rectangle(10, 30, 1000, 750)

        ' Draw  the chart
        chrAttendance.Printing.PrintPaint(ev.Graphics, myRec)
    End Sub

End Class