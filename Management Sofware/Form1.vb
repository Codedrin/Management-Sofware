Imports MySql.Data.MySqlClient


Public Class Form1
    Public Shared LoggedInEmail As String

    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        Dim email As String = emaltxt.Text.Trim()
        Dim password As String = passtxt.Text.Trim()

        If email = "" Or password = "" Then
            MessageBox.Show("Please enter both email and password.")
            Return
        End If

        Try
            OpenConnection()

            Dim query As String = "SELECT * FROM users WHERE email = @Email AND password = @Password"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@Email", email)
            cmd.Parameters.AddWithValue("@Password", password)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                LoggedInEmail = email
                MessageBox.Show("Login successful!")

                Dim form3 As New Form3()
                form3.Show()
                Me.Hide()
            Else
                MessageBox.Show("Incorrect email or password.")
            End If

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub


    Private Sub Registerbtn_Click(sender As Object, e As EventArgs) Handles registerbtn.Click
        Dim form2 As New Form2()
        form2.Show()
        Me.Hide()
    End Sub

    Private Sub Forgotbtn_Click(sender As Object, e As EventArgs) Handles forgotbtn.Click
        Dim forgotPassForm As New forgotpassword()
        forgotPassForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ActiveForm.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        ActiveForm.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        ActiveForm.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Seepass1_CheckedChanged(sender As Object, e As EventArgs) Handles seepass1.CheckedChanged
        If seepass1.Checked Then
            passtxt.PasswordChar = ControlChars.NullChar
        Else
            passtxt.PasswordChar = "•"c
        End If
    End Sub

End Class