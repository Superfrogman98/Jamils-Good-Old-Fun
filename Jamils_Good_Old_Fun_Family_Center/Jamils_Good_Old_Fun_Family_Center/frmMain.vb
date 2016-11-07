'programmer: Max Buckel
'function: manage the general operations of Jamil's good old fun family center
Public Class frmMain

    Dim objNewEmployee As Object = frmNewEmployee

    'closes the program
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'loads names from the data base into the search field
        Me.EmployeeDataTableAdapter.Fill(Me.Jamils_Good_Old_FunDataSet.EmployeeData)
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
        If e.RowIndex <> -1 Then


            lblEmployeeName.Text = Jamils_Good_Old_FunDataSet.EmployeeData(e.RowIndex).First_Name & " , " & Jamils_Good_Old_FunDataSet.EmployeeData(e.RowIndex).Last_Name
            lblPosition.Text = Jamils_Good_Old_FunDataSet.EmployeeData(e.RowIndex).Position
            strAddress = Split(Jamils_Good_Old_FunDataSet.EmployeeData(e.RowIndex).Address, ",")
            lblAddress.Text = strAddress(0) & vbNewLine & strAddress(1) & ", " & strAddress(2) & " " & strAddress(3)
            lblMain.Text = Jamils_Good_Old_FunDataSet.EmployeeData(e.RowIndex).Main_Phone
            lblSecondary.Text = Jamils_Good_Old_FunDataSet.EmployeeData(e.RowIndex).Secondary_Phone
            lblEmail.Text = Jamils_Good_Old_FunDataSet.EmployeeData(e.RowIndex).Email

        End If
    End Sub

    'opens the form to enter a new employees data
    Private Sub NewEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewEmployeeToolStripMenuItem.Click
        objNewEmployee.ShowDialog()
    End Sub
End Class
