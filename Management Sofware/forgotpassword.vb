Imports MySql.Data.MySqlClient

Public Class forgotpassword
    Private Sub Changepass_Click(sender As Object, e As EventArgs) Handles changepass.Click
        Dim email As String = emalfor.Text.Trim()
        Dim newPassword As String = newpass.Text.Trim()

        If email = "" Or newPassword = "" Then
            MessageBox.Show("Please enter your email and new password.")
            Return
        End If

        Try
            OpenConnection()

            ' Check if the email exists
            Dim checkQuery As String = "SELECT * FROM users WHERE email = @Email"
            Using checkCmd As New MySqlCommand(checkQuery, conn)
                checkCmd.Parameters.AddWithValue("@Email", email)

                Using reader As MySqlDataReader = checkCmd.ExecuteReader()
                    If reader.HasRows Then
                        reader.Close()

                        ' Update password
                        Dim updateQuery As String = "UPDATE users SET password = @NewPassword WHERE email = @Email"
                        Using updateCmd As New MySqlCommand(updateQuery, conn)
                            updateCmd.Parameters.AddWithValue("@NewPassword", newPassword)
                            updateCmd.Parameters.AddWithValue("@Email", email)

                            Dim result As Integer = updateCmd.ExecuteNonQuery()
                            If result > 0 Then
                                MessageBox.Show("Password updated successfully!")
                            Else
                                MessageBox.Show("Failed to update password.")
                            End If
                        End Using
                    Else
                        MessageBox.Show("Email not found in the database.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles backbutton.Click
        Dim form1 As New Form1()
        form1.Show()
        Me.Hide()
    End Sub

    Private Sub Seepass3_CheckedChanged(sender As Object, e As EventArgs) Handles seepass3.CheckedChanged
        If seepass3.Checked Then
            newpass.PasswordChar = ControlChars.NullChar
        Else
            newpass.PasswordChar = "•"c
        End If
    End Sub
End Class