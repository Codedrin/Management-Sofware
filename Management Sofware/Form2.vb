Imports MySql.Data.MySqlClient

Public Class Form2
    Private Sub Regbtn_Click(sender As Object, e As EventArgs) Handles regbtn.Click
        Dim username As String = Me.username.Text.Trim()
        Dim email As String = Me.email.Text.Trim()
        Dim password As String = Me.password.Text.Trim()

        If username = "" Or email = "" Or password = "" Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        Try
            OpenConnection()

            Dim query As String = "INSERT INTO users (username, email, password) VALUES (@username, @email, @password)"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@email", email)
            cmd.Parameters.AddWithValue("@password", password)

            Dim result As Integer = cmd.ExecuteNonQuery()
            If result > 0 Then
                MessageBox.Show("Registration successful!")
            Else
                MessageBox.Show("Failed to register.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub
    Private Sub Backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        Dim form1 As New Form1()
        form1.Show() ' Ipakita ang Form1
        Me.Hide() ' Itago ang Form2
    End Sub

    Private Sub Seepass2_CheckedChanged(sender As Object, e As EventArgs) Handles seepass2.CheckedChanged
        If seepass2.Checked Then
            password.PasswordChar = ControlChars.NullChar ' 
        Else
            password.PasswordChar = "•"c '
        End If
    End Sub
End Class
