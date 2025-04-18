Imports System.Net.Http
Imports System.Text
Imports System.Threading.Tasks
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class Form1
    Public Shared LoggedInEmail As String ' Magagamit ito sa ibang Form

    Private Async Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        Dim email As String = emaltxt.Text
        Dim password As String = passtxt.Text

        If email = "" Or password = "" Then
            MessageBox.Show("Please enter both email and password.")
            Return
        End If

        Dim firebaseUrl As String = "https://guidance-management-syst-70349-default-rtdb.firebaseio.com/accounts.json"

        Using client As New HttpClient()
            Try
                Dim response As HttpResponseMessage = Await client.GetAsync(firebaseUrl)
                If response.IsSuccessStatusCode Then
                    Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
                    Dim accounts As JObject = JObject.Parse(jsonResponse)

                    ' Check each user record if email and password match
                    For Each account In accounts
                        Dim userData As JObject = account.Value
                        If userData("email").ToString() = email AndAlso userData("password").ToString() = password Then
                            LoggedInEmail = email ' I-save ang email ng nag-login
                            MessageBox.Show("Login successful!")

                            Dim form3 As New Form3()
                            form3.Show()
                            Me.Hide()
                            Return
                        End If
                    Next

                    MessageBox.Show("Your account is wrong.")
                Else
                    MessageBox.Show("Failed to connect to Firebase.")
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub registerbtn_Click(sender As Object, e As EventArgs) Handles registerbtn.Click
        Dim form2 As New Form2()
        form2.Show() ' Ipakita ang Form2
        Me.Hide() ' Itago ang Form1
    End Sub

    Private Sub forgotbtn_Click(sender As Object, e As EventArgs) Handles forgotbtn.Click
        Dim forgotPassForm As New forgotpassword()
        forgotPassForm.Show() ' Ipakita ang forgotpass form
        Me.Hide() ' Itago ang Form1
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

    Private Sub seepass1_CheckedChanged(sender As Object, e As EventArgs) Handles seepass1.CheckedChanged
        If seepass1.Checked Then
            passtxt.PasswordChar = ControlChars.NullChar ' Ipakita ang password
        Else
            passtxt.PasswordChar = "•"c ' Itago ang password
        End If
    End Sub

End Class