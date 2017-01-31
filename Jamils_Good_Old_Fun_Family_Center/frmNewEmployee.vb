'programmer: Max Buckel
'function: create a new employee, add it to the database, then update the list

Imports System.Data.OleDb
Public Class frmNewEmployee



    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
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
                                                    frmMain.database.Open()
                                                    Dim addNewEmployee As New OleDbCommand("insert into EmployeeData([First Name], [Last Name],[Position], Email, [Main Phone], [Secondary Phone],Address,DOH)values('" & txtFirstName.Text.Trim & "','" & txtLastName.Text.Trim & "','" & txtPosition.Text.Trim & "','" & txtEmail.Text.Trim & "','" & strMainPhone & "' ,'" & strSecondaryPhone & "','" & strAddress & "','" & dateOfHire & "')", frmMain.database)
                                                    addNewEmployee.ExecuteNonQuery()
                                                    MessageBox.Show("Employee Added to database")
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
    'clears all fields on load
    Private Sub frmNewEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtPosition.Text = ""
        txtStreet.Text = ""
        txtCity.Text = ""
        txtState.Text = ""
        nudZip.Value = 00000
        txtMainPhone1.Text = ""
        txtMainPhone2.Text = ""
        txtMainPhone3.Text = ""
        txtSecondary1.Text = ""
        txtSecondary2.Text = ""
        txtSecondary3.Text = ""
        txtEmail.Text = ""

    End Sub
End Class