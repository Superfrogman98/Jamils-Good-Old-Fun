'programmer: Max Buckel
'function: Edit an existing employees data in the database


Imports System.Data.OleDb
Public Class frmEditEmployee
    Private Sub frmEditEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim strAddress(4) As String
        Dim strMainPhone(3) As String
        Dim strSecondPhone(3) As String
        Try
            Me.Text = "Editing Employee: " & frmMain.Jamils_Good_Old_FunDataSet.EmployeeData(frmMain.currentEmployee).First_Name & " " & frmMain.Jamils_Good_Old_FunDataSet.EmployeeData(frmMain.currentEmployee).Last_Name
            txtFirstName.Text = frmMain.Jamils_Good_Old_FunDataSet.EmployeeData(frmMain.currentEmployee).First_Name
            txtLastName.Text = frmMain.Jamils_Good_Old_FunDataSet.EmployeeData(frmMain.currentEmployee).Last_Name
        Catch ex As Exception
            Me.Text = "Editing Employee: Name Not Found"
            txtFirstName.Text = " Not Found "
            txtLastName.Text = " Not Found "
        End Try
        'fill in position field
        Try
            txtPosition.Text = frmMain.Jamils_Good_Old_FunDataSet.EmployeeData(frmMain.currentEmployee).Position
        Catch ex As Exception
            txtPosition.Text = "Not Found"
        End Try
        'fill in address field
        Try

            strAddress = Split(frmMain.Jamils_Good_Old_FunDataSet.EmployeeData(frmMain.currentEmployee).Address, ",")
            txtStreet.Text = strAddress(0)
            txtCity.Text = strAddress(1)
            txtState.Text = strAddress(2)
            nudZip.Value = strAddress(3)
        Catch ex As Exception
            txtStreet.Text = "Not Found"
            txtCity.Text = "Not Found"
            txtState.Text = "Not Found"
            nudZip.Value = 00000
        End Try
        'fill in main phone field
        Try

            strMainPhone = Split(frmMain.Jamils_Good_Old_FunDataSet.EmployeeData(frmMain.currentEmployee).Main_Phone, "-")

            txtMainPhone1.Text = strMainPhone(0)
            txtMainPhone2.Text = strMainPhone(1)
            txtMainPhone3.Text = strMainPhone(2)

        Catch ex As Exception
            txtMainPhone1.Text = "N/A"
            txtMainPhone2.Text = ""
            txtMainPhone3.Text = ""
        End Try
        'fill in second phone field
        Try

            strSecondPhone = Split(frmMain.Jamils_Good_Old_FunDataSet.EmployeeData(frmMain.currentEmployee).Secondary_Phone, "-")

            txtSecondary1.Text = strSecondPhone(0)
            txtSecondary2.Text = strSecondPhone(1)
            txtSecondary3.Text = strSecondPhone(2)
        Catch ex As Exception
            txtSecondary1.Text = "N/A"
            txtSecondary1.Text = ""
            txtSecondary1.Text = ""

        End Try
        'fill in email field
        Try
            txtEmail.Text = frmMain.Jamils_Good_Old_FunDataSet.EmployeeData(frmMain.currentEmployee).Email
        Catch ex As Exception
            txtEmail.Text = "Not Found"
        End Try
        'fill in date of hire field
        Try
            dtpDateOfHire.Value = frmMain.Jamils_Good_Old_FunDataSet.EmployeeData(frmMain.currentEmployee).DOH
        Catch ex As Exception

        End Try


    End Sub
    'closes the form
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    'updates the database to reflect the users changes
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim updateCommand As OleDbCommand


        Dim dateOfHire As Date = Format(dtpDateOfHire.Value, "MM-" & "dd" & "-yy")
        Dim strZipcode As String = nudZip.Value.ToString()
        strZipcode = strZipcode.PadLeft(5, "0"c)
        Dim strMainPhone As String
        strMainPhone = txtMainPhone1.Text & "-" & txtMainPhone2.Text & "-" & txtMainPhone3.Text
        Dim strSecondaryPhone As String
        strSecondaryPhone = txtSecondary1.Text & "-" & txtSecondary2.Text & "-" & txtSecondary3.Text
        Dim strAddress As String

        'validates for blank fields, then posts the data to the database or gives an error message
        If txtFirstName.Text.Trim <> "" Then
            If txtLastName.Text.Trim <> "" Then
                If txtPosition.Text.Trim <> "" Then
                    If txtStreet.Text.Trim <> "" Then
                        If txtCity.Text.Trim <> "" Then
                            If txtState.Text.Trim <> "" Then
                                If strZipcode <> "00000" Then
                                    If strMainPhone.Length = 12 Then
                                        If (strSecondaryPhone.Length > 2 And strSecondaryPhone.Length = 12) Or strSecondaryPhone.Length = 2 Then
                                            If txtEmail.Text.Trim <> "" And txtEmail.Text.Contains("@") And txtEmail.Text.Contains(".") And txtEmail.Text.EndsWith(".") = False Then
                                                'checks for a blank secondary phone field, if true then sets the fill text
                                                If strSecondaryPhone = "--" Then
                                                    strSecondaryPhone = "N/A"
                                                End If
                                                strAddress = txtStreet.Text & "," & txtCity.Text & "," & txtState.Text & "," & strZipcode
                                                Try
                                                    'gets the current employees id, creates a command to use to update the database, opens the database connection, the executes the command and confirms the update was completed, then closes the connection and updates the data table of employees
                                                    Dim employeeID As Integer = frmMain.Jamils_Good_Old_FunDataSet.EmployeeData(frmMain.currentEmployee).ID
                                                    updateCommand = New OleDbCommand("UPDATE EmployeeData SET [First Name] = ? ,[Last Name] = ?, [Position] = ?,Email = ?,[Main Phone] = ?, [Secondary Phone] = ?,Address= ?, DOH = ? WHERE ID = employeeID", frmMain.database)
                                                    updateCommand.Parameters.AddWithValue("firstName", txtFirstName.Text.Trim)
                                                    updateCommand.Parameters.AddWithValue("lastName", txtLastName.Text.Trim)
                                                    updateCommand.Parameters.AddWithValue("position", txtPosition.Text.Trim)
                                                    updateCommand.Parameters.AddWithValue("email", txtEmail.Text.Trim)
                                                    updateCommand.Parameters.AddWithValue("mainPhone", strMainPhone)
                                                    updateCommand.Parameters.AddWithValue("secondPhone", strSecondaryPhone)
                                                    updateCommand.Parameters.AddWithValue("address", strAddress)
                                                    updateCommand.Parameters.AddWithValue("doh", dateOfHire)
                                                    updateCommand.Parameters.AddWithValue("employeeID", employeeID)
                                                    frmMain.database.Open()
                                                    Try
                                                        updateCommand.ExecuteNonQuery()
                                                        MessageBox.Show("Data for: '" & frmMain.Jamils_Good_Old_FunDataSet.EmployeeData(frmMain.currentEmployee).First_Name & " " & frmMain.Jamils_Good_Old_FunDataSet.EmployeeData(frmMain.currentEmployee).Last_Name & "' was updated")
                                                    Catch ex As Exception
                                                        MessageBox.Show("Error With Updating database \n" & ex.ToString)
                                                    End Try

                                                    frmMain.database.Close()

                                                    frmMain.EmployeeDataTableAdapter.Fill(frmMain.Jamils_Good_Old_FunDataSet.EmployeeData)
                                                    Me.Close()


                                                Catch ex As Exception
                                                    MessageBox.Show(ex.Message)
                                                End Try
                                            Else
                                                MessageBox.Show("Invalid Email Address Entered", "Invalid Input")
                                                Exit Sub
                                            End If
                                        Else
                                            MessageBox.Show("Secondary Phone Number Wrong Length or Not Blank", "Invalid Input")
                                            Exit Sub
                                        End If
                                    Else
                                        MessageBox.Show("Main Phone Number Wrong Length ", "Invalid Input")
                                        Exit Sub
                                    End If
                                Else
                                    MessageBox.Show("Invalid Zip Code Entered", "Invalid Input")
                                    Exit Sub
                                End If
                            Else
                                MessageBox.Show("No State Entered", "Invalid Input")
                                Exit Sub
                            End If
                        Else
                            MessageBox.Show("No City Entered", "Invalid Input")
                            Exit Sub
                        End If
                    Else
                        MessageBox.Show("No Street Entered", "Invalid Input")
                        Exit Sub
                    End If
                Else
                    MessageBox.Show("No Position Entered", "Invalid Input")
                    Exit Sub
                End If
            Else
                MessageBox.Show("No Last Name Entered", "Invalid Input")
                Exit Sub
            End If
        Else
            MessageBox.Show("No First Name Entered", "Invalid Input")
            Exit Sub
        End If
    End Sub

    'only allows numbers and backspace to be put into the phone fields
    Private Sub valid_phone_Keys(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMainPhone1.KeyPress, txtMainPhone2.KeyPress, txtMainPhone3.KeyPress, txtSecondary1.KeyPress, txtSecondary2.KeyPress, txtSecondary3.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "" Then

        Else
            e.Handled = True
        End If
    End Sub
    'removes the current viewed employee from the database with a confirm box
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim deleteCommand As OleDbCommand
        Dim confirmRemove As Integer
        confirmRemove = MessageBox.Show("Are you sure you would like to remove " & frmMain.Jamils_Good_Old_FunDataSet.EmployeeData(frmMain.currentEmployee).First_Name & " " & frmMain.Jamils_Good_Old_FunDataSet.EmployeeData(frmMain.currentEmployee).Last_Name & " from the database? This action cannot be undone!", "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If confirmRemove = 6 Then
            MessageBox.Show(frmMain.Jamils_Good_Old_FunDataSet.EmployeeData(frmMain.currentEmployee).First_Name & " " & frmMain.Jamils_Good_Old_FunDataSet.EmployeeData(frmMain.currentEmployee).Last_Name & " has been removed from the database.", "Action Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            deleteCommand = New OleDbCommand("DELETE * FROM EmployeeData WHERE ID = employeeID", frmMain.database)
            frmMain.database.Open()
            deleteCommand.Parameters.AddWithValue("employeeID", frmMain.Jamils_Good_Old_FunDataSet.EmployeeData(frmMain.currentEmployee).ID)
            deleteCommand.ExecuteNonQuery()
            frmMain.database.Close()
            frmMain.EmployeeDataTableAdapter.Fill(frmMain.Jamils_Good_Old_FunDataSet.EmployeeData)
            Me.Close()
        End If
    End Sub
End Class