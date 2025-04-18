Imports MySql.Data.MySqlClient

Public Class Form2
    Private Sub Regbtn_Click(sender As Object, e As EventArgs) Handles regbtn.Click
        Dim usernameInput As String = username.Text.Trim()
        Dim emailInput As String = email.Text.Trim()
        Dim passwordInput As String = password.Text.Trim()

        If usernameInput = "" Or emailInput = "" Or passwordInput = "" Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        Try
            OpenConnection()

            Dim query As String = "INSERT INTO users (username, email, password) VALUES (@username, @email, @password)"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@username", usernameInput)
            cmd.Parameters.AddWithValue("@email", emailInput)
            cmd.Parameters.AddWithValue("@password", passwordInput)

            Dim result As Integer = cmd.ExecuteNonQuery()
            If result > 0 Then
                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                username.Text = ""
                email.Text = ""
                password.Text = ""


                Dim loginForm As New Form1()
                loginForm.Show()
                Me.Hide()
            Else
                MessageBox.Show("Failed to register.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub Backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        Dim form1 As New Form1()
        form1.Show()
        Me.Hide()
    End Sub

    Private Sub Seepass2_CheckedChanged(sender As Object, e As EventArgs) Handles seepass2.CheckedChanged
        If seepass2.Checked Then
            password.PasswordChar = ControlChars.NullChar
        Else
            password.PasswordChar = "•"c
        End If
    End Sub
End Class
