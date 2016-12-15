﻿'programmer: Max Buckel
'function: manage the general operations of Jamil's good old fun family center
Imports System.Data.OleDb
Public Class frmMain
    'database connection for saving data and reading it
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Jamils_Good_Old_Fun.accdb" 'default is connection string for a built version of the program
    Public database As New OleDbConnection(connectionString)
    Public dataAdapter As OleDbDataAdapter = New OleDbDataAdapter()

    'variable to keep track of the current viewed employee
    Public currentEmployee As Integer = 0

    'seperate forms to be opened
    Dim objNewEmployee As Object = frmNewEmployee
    Dim objEditEmployee As Object = frmEditEmployee

    'closes the program
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'loads names from the data base into the search field
        'sets the initial connection to match the database variable
        Me.EmployeeDataTableAdapter.Connection = database
        Try
            'trys filling the table from the database, upon fail the catch will causes the connection string to switch and the connection to update, this should allow the program to switch between working in debug and compiled versions
            Me.EmployeeDataTableAdapter.Fill(Me.Jamils_Good_Old_FunDataSet.EmployeeData)
        Catch ex As Exception
            connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|Jamils_Good_Old_Fun.accdb" 'connection string for the debug/release folder
            database = New OleDbConnection(connectionString)
            Try
                Me.EmployeeDataTableAdapter.Connection = database
                Me.EmployeeDataTableAdapter.Fill(Me.Jamils_Good_Old_FunDataSet.EmployeeData)
            Catch ex2 As Exception
                MessageBox.Show("Database Not Found")
            End Try
        End Try
    End Sub


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
    Private Sub dgvEmployees_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployees.CellClick
        Dim strAddress(4) As String
        currentEmployee = e.RowIndex
        If e.RowIndex <> -1 Then
            'fill in name field
            Try
                lblEmployeeName.Text = Jamils_Good_Old_FunDataSet.EmployeeData(e.RowIndex).First_Name & " " & Jamils_Good_Old_FunDataSet.EmployeeData(e.RowIndex).Last_Name
            Catch ex As Exception
                lblEmployeeName.Text = "Not Found"
            End Try
            'fill in position field
            Try
                lblPosition.Text = Jamils_Good_Old_FunDataSet.EmployeeData(e.RowIndex).Position
            Catch ex As Exception
                lblPosition.Text = "Not Found"
            End Try
            'fill in address field
            Try
                strAddress = Split(Jamils_Good_Old_FunDataSet.EmployeeData(e.RowIndex).Address, ",")
                lblAddress.Text = strAddress(0) & vbNewLine & strAddress(1) & ", " & strAddress(2) & " " & strAddress(3)
            Catch ex As Exception
                lblAddress.Text = "Not Found"
            End Try
            'fill in main phone field
            Try
                lblMain.Text = Jamils_Good_Old_FunDataSet.EmployeeData(e.RowIndex).Main_Phone
            Catch ex As Exception
                lblMain.Text = "Not Found"
            End Try
            'fill in second phone field
            Try
                lblSecondary.Text = Jamils_Good_Old_FunDataSet.EmployeeData(e.RowIndex).Secondary_Phone
            Catch ex As Exception
                lblSecondary.Text = "N/A"
            End Try
            'fill in email field
            Try
                lblEmail.Text = Jamils_Good_Old_FunDataSet.EmployeeData(e.RowIndex).Email
            Catch ex As Exception
                lblEmail.Text = "Not Found"
            End Try
            'fill in date of hire field
            Try
                lblDOH.Text = Jamils_Good_Old_FunDataSet.EmployeeData(e.RowIndex).DOH
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


End Class
