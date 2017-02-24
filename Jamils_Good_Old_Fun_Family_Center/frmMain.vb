'programmer: Max Buckel
'function: manage the general operations of Jamil's good old fun family center
Imports System.ComponentModel
Imports System.Data.OleDb

Public Class frmMain
    'database connection for saving data and reading it
    Dim connectionString As String = My.Settings.Database 'default is connection string for the database that the program comes with
    Public database As OleDbConnection
    Public dataAdapter As OleDbDataAdapter = New OleDbDataAdapter()
    'holds the day names for easy access in for loops in schedule viewer and attendence
    Public dayNames() As String = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"}
    'variable to keep track of the current viewed employee
    Public currentEmployee As Integer = 0
    'tracks the day column sort order
    Dim colOneSortOrder As Boolean = True
    Public selectedScheduleRow As Integer = 0

    'seperate forms to be opened 
    Dim objNewEmployee As Object = frmNewEmployee 'form for creating a new employee
    Dim objEditEmployee As Object = frmEditEmployee
    Dim objAddScheduleItem As Object = frmAddScheduleItem
    Dim objViewSchedule As Object = frmScheduleViewer
    Dim objHelpPage As Object = frmHelp
    Dim objEnterAttendence As Object = frmAttendenceEntry
    Dim objViewReport As Object = frmAttendanceReport

    'closes the program
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub


    'handles filling in the datatable upon form load
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'loads names from the data base into the search field
        database = New OleDbConnection(connectionString)
        Me.EmployeeDataTableAdapter.Connection = database
        Me.EmployeeScheduleTableAdapter.Connection = database
        Try
            Debug.Write("Datatable fill, connection string from settings file- ")

            Me.EmployeeDataTableAdapter.Fill(Me.Jamils_Good_Old_FunDataSet.EmployeeData)
            Debug.Write(" Succeded" & vbNewLine)
        Catch ex As Exception
            connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|Jamils_Good_Old_Fun.accdb" 'connection string for the debug/release folder
            database = New OleDbConnection(connectionString)
            Try
                Me.EmployeeDataTableAdapter.Connection = database
                Me.EmployeeScheduleTableAdapter.Connection = database
                Me.EmployeeDataTableAdapter.Fill(Me.Jamils_Good_Old_FunDataSet.EmployeeData)
            Catch ex2 As Exception
                MessageBox.Show("Database Not Found, try setting connection manualy")
            End Try
        End Try
    End Sub

    'searches the datatable for the employee that is put into the field
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click, txtSearch.LostFocus
        Dim strFilter As String
        If txtSearch.Text.Trim <> "" Then
            strFilter = txtSearch.Text.Trim
            If strFilter.Contains(" ") Then
                Dim filterArray() As String = Split(strFilter, " ")
                EmployeeDataBindingSource.Filter = "[First Name] LIKE '" & filterArray(0) & "*'  and [Last Name] LIKE'" & filterArray(1) & "*' "
            Else
                EmployeeDataBindingSource.Filter = "[First Name] LIKE '" & strFilter & "*'  or [Last Name] LIKE'" & strFilter & "*' "
            End If
        Else
            EmployeeDataBindingSource.RemoveFilter()
        End If
    End Sub

    'when the user clicks on a cell, updates the data on the side
    Private Sub dgvEmployees_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployees.CellEnter
        Dim strAddress(4) As String
        default_Schedule_Fill()

        If e.RowIndex <> -1 Then
            currentEmployee = dgvEmployees.Rows(e.RowIndex).Cells(2).Value  'sets current employee for editing button to work
            Dim currentEmployeeData() As DataRow = Jamils_Good_Old_FunDataSet.EmployeeData.Select("ID=" & currentEmployee) 'creates a temporary copy of the row to use to find the employees index in the database
            currentEmployee = Jamils_Good_Old_FunDataSet.EmployeeData.Rows.IndexOf(currentEmployeeData(0)) ' sets the currentEmployee value to the database index value
            'fill in name field
            default_Schedule_Fill()
            Try
                lblEmployeeName.Text = Jamils_Good_Old_FunDataSet.EmployeeData(currentEmployee).First_Name & " " & Jamils_Good_Old_FunDataSet.EmployeeData(currentEmployee).Last_Name
            Catch ex As Exception
                lblEmployeeName.Text = "Not Found"
            End Try
            'fill in position field
            Try
                lblPosition.Text = Jamils_Good_Old_FunDataSet.EmployeeData(currentEmployee).Position
            Catch ex As Exception
                lblPosition.Text = "Not Found"
            End Try
            'fill in address field
            Try
                strAddress = Split(Jamils_Good_Old_FunDataSet.EmployeeData(currentEmployee).Address, ",")
                lblAddress.Text = strAddress(0) & vbNewLine & strAddress(1) & ", " & strAddress(2) & " " & strAddress(3)
            Catch ex As Exception
                lblAddress.Text = "Not Found"
            End Try
            'fill in main phone field
            Try
                lblMain.Text = Jamils_Good_Old_FunDataSet.EmployeeData(currentEmployee).Main_Phone
            Catch ex As Exception
                lblMain.Text = "Not Found"
            End Try
            'fill in second phone field
            Try
                lblSecondary.Text = Jamils_Good_Old_FunDataSet.EmployeeData(currentEmployee).Secondary_Phone
            Catch ex As Exception
                lblSecondary.Text = "N/A"
            End Try
            'fill in email field
            Try
                lblEmail.Text = Jamils_Good_Old_FunDataSet.EmployeeData(currentEmployee).Email
            Catch ex As Exception
                lblEmail.Text = "Not Found"
            End Try
            'fill in date of hire field
            Try
                lblDOH.Text = Jamils_Good_Old_FunDataSet.EmployeeData(currentEmployee).DOH
            Catch ex As Exception
                lblDOH.Text = "Not Found"
            End Try
        End If
    End Sub
    'opens the form to enter a new employees data
    Private Sub NewEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewEmployeeToolStripMenuItem.Click
        objNewEmployee.ShowDialog()
    End Sub

    'opens the form to edit employee data
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        objEditEmployee.showDialog()
    End Sub

    'lets the users select a new database file, will also set the connection string in the settings so that the choice will persist
    Private Sub select_New_Database()
        Try
            Dim openFileDialog1 As New OpenFileDialog()
            openFileDialog1.Title = "Select Database File"
            openFileDialog1.Filter = "MS-Access Files|*.accdb"
            openFileDialog1.FileName = ""
            openFileDialog1.InitialDirectory = "C:\Temp"  'Suggested path for where the file could exist
            openFileDialog1.ShowDialog()

            'if no file is selected then message will be displayed
            If openFileDialog1.FileName = "" Then
                MessageBox.Show("No File was selected")
            Else
                Dim dbNameWithPath As String = openFileDialog1.FileName 'openFileDialog1.FileName is where the selected file is stored
                connectionString = "Provider=Microsoft.ace.OLEDB.12.0;Data Source=" & dbNameWithPath
                My.Settings.Database = connectionString 'sets the settings of the program to persist with the selected file across multiple instances

                database = New OleDbConnection(connectionString)
                'trys filling the table from the database the user selected, upon fail the catch will causes the connection string to switch to the default database
                Me.EmployeeDataTableAdapter.Connection = database
                Me.EmployeeScheduleTableAdapter.Connection = database
                Me.EmployeeDataTableAdapter.Fill(Me.Jamils_Good_Old_FunDataSet.EmployeeData)
            End If
        Catch ex As Exception
            MessageBox.Show("New database connection failed")
            connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Jamils_Good_Old_Fun.accdb"
            database = New OleDbConnection(connectionString)
            Try
                Me.EmployeeDataTableAdapter.Connection = database
                Me.EmployeeScheduleTableAdapter.Connection = database
                Me.EmployeeDataTableAdapter.Fill(Me.Jamils_Good_Old_FunDataSet.EmployeeData)
            Catch ex2 As Exception
                MessageBox.Show("No Database Not Found")
            End Try
        End Try

    End Sub

    'uses the new database function to allow the user to change the connected database
    Private Sub ChangeDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeDatabaseToolStripMenuItem.Click
        select_New_Database()
    End Sub

    Private Sub dgvSchedual_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvSchedule.ColumnHeaderMouseClick

        If (e.ColumnIndex = 0 And colOneSortOrder = True) Then
            EmployeeScheduleBindingSource.Sort = "dayID DESC, [Start Time] ASC" 'sorts the order by day Descending then by start time Ascending
            colOneSortOrder = False
        ElseIf (e.ColumnIndex = 0 And colOneSortOrder = False) Then
            EmployeeScheduleBindingSource.Sort = "dayID ASC, [Start Time] ASC" 'sorts the order by day then by start time both ascending
            colOneSortOrder = True
        End If
    End Sub

    Public Sub default_Schedule_Fill()
        Try
            Me.EmployeeScheduleTableAdapter.Fill(Me.Jamils_Good_Old_FunDataSet.EmployeeSchedule)
            EmployeeScheduleBindingSource.Filter = "EmployeeID = '" & Jamils_Good_Old_FunDataSet.EmployeeData(currentEmployee).ID & "'"
            EmployeeScheduleBindingSource.Sort = "dayID, [Start Time]" 'default sorts the order by day then by start time 
            dgvSchedule.Columns(2).DefaultCellStyle.Format = "0000"
            dgvSchedule.Columns(3).DefaultCellStyle.Format = "0000"
        Catch ex As Exception
            Console.WriteLine("Error In Filling schedule: " & ex.ToString())
        End Try

    End Sub

    Private Sub btnEditSchedule_Click(sender As Object, e As EventArgs) Handles btnEditSchedule.Click
        btnEditSchedule.Enabled = False
        btnEditSchedule.Text = "Editing"
        btnSubmit.Visible = True
        dgvSchedule.ReadOnly = False
        dgvSchedule.AllowUserToAddRows = True
        dgvSchedule.Columns(0).ReadOnly = True
        dgvSchedule.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        btnEditSchedule.Enabled = True
        btnEditSchedule.Text = "Edit Schedule"
        btnSubmit.Visible = False
        dgvSchedule.ReadOnly = True
        dgvSchedule.AllowUserToAddRows = False
        dgvSchedule.SelectionMode = DataGridViewSelectionMode.CellSelect
    End Sub

    Private Sub dgvSchedule_CellBeginEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSchedule.CellClick
        Dim intDayLocationY As Integer
        If (btnEditSchedule.Enabled = False) Then
            If (e.RowIndex > -1) Then
                selectedScheduleRow = e.RowIndex
                intDayLocationY = (Me.Location.Y + 285 + 44 - dgvSchedule.VerticalScrollingOffset + (e.RowIndex * 22)) 'sets the location where the add item pops up to be directly below the selected cell
                Dim intDayLocationX As Integer = (Me.Location.X + 230) ' 21 differece to account for border and padding
                Dim pntDay As New Point(intDayLocationX, intDayLocationY)
                frmAddScheduleItem.Location = pntDay
                    frmAddScheduleItem.ShowDialog()
                End If
            End If
    End Sub

    Private Sub viewScheduleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles viewScheduleToolStripMenuItem.Click
        objViewSchedule.showDialog()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        objHelpPage.ShowDialog()
    End Sub

    Private Sub EnterAttendenceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnterAttendenceToolStripMenuItem.Click
        objEnterAttendence.ShowDialog()
    End Sub

    Private Sub ViewReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewReportsToolStripMenuItem.Click
        objViewReport.ShowDialog()
    End Sub


End Class

