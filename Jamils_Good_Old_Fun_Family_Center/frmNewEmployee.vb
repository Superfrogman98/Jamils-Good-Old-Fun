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

        If txtFirstName.Text.Trim <> "" Then
            If txtLastName.Text.Trim <> "" Then
                If txtPosition.Text.Trim <> "" Then
                    If txtStreet.Text.Trim <> "" Then
                        If txtCity.Text.Trim <> "" Then
                            If txtState.Text.Trim <> "" Then
                                If strZipcode <> "00000" Then
                                    If strMainPhone.Length = 12 Then
                                        If txtEmail.Text.Trim <> "" And txtEmail.Text.Contains("@") And txtEmail.Text.Contains(".") And txtEmail.Text.EndsWith(".") = False Then
                                            If strSecondaryPhone = "--" Then
                                                strSecondaryPhone = "N/A"
                                            End If

                                            strAddress = txtStreet.Text & "," & txtCity.Text & "," & txtState.Text & "," & strZipcode

                                            Try
                                                Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= ..\..\Jamils_Good_Old_Fun.accdb;")
                                                con.Open()
                                                Dim cmd As New OleDbCommand("insert into EmployeeData([First Name], [Last Name],[Position], Email, [Main Phone], [Secondary Phone],Address)values('" & txtFirstName.Text.Trim & "','" & txtLastName.Text.Trim & "','" & txtPosition.Text.Trim & "','" & txtEmail.Text.Trim & "','" & strMainPhone & "' ,'" & strSecondaryPhone & "','" & strAddress & "' )", con)
                                                cmd.ExecuteNonQuery()
                                                MessageBox.Show("Inserted Successfuly")
                                                con.Close()
                                                frmMain.EmployeeDataTableAdapter.Fill(frmMain.Jamils_Good_Old_FunDataSet.EmployeeData)
                                            Catch
                                                MessageBox.Show("Error")
                                            End Try
                                        Else
                                            MessageBox.Show("Invalid Email Address Entered", "Invalid Input")
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


    Private Sub dtpDateOfHire_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateOfHire.ValueChanged

    End Sub

    Private Sub valid_phone_Keys(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMainPhone1.KeyPress, txtMainPhone2.KeyPress, txtMainPhone3.KeyPress, txtSecondary1.KeyPress, txtSecondary2.KeyPress, txtSecondary3.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "" Then

        Else
            e.Handled = True
        End If
    End Sub
End Class