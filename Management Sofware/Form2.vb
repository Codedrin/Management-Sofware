Imports System.Net.Http
Imports System.Text
Imports System.Threading.Tasks
Imports Newtonsoft.Json

Public Class Form2
    Private Async Sub regbtn_Click(sender As Object, e As EventArgs) Handles regbtn.Click
        Dim username As String = Me.username.Text
        Dim email As String = Me.email.Text
        Dim password As String = Me.password.Text

        If username = "" Or email = "" Or password = "" Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        Dim firebaseUrl As String = "https://guidance-management-syst-70349-default-rtdb.firebaseio.com/accounts.json"
        Dim userData As New Dictionary(Of String, String) From {
            {"username", username},
            {"email", email},
            {"password", password}
        }

        Dim json As String = JsonConvert.SerializeObject(userData)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")

        Using client As New HttpClient()
            Try
                Dim response As HttpResponseMessage = Await client.PostAsync(firebaseUrl, content)
                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Registration successful!")
                Else
                    MessageBox.Show("Failed to register.")
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        Dim form1 As New Form1()
        form1.Show() ' Ipakita ang Form1
        Me.Hide() ' Itago ang Form2
    End Sub

    Private Sub seepass2_CheckedChanged(sender As Object, e As EventArgs) Handles seepass2.CheckedChanged
        If seepass2.Checked Then
            password.PasswordChar = ControlChars.NullChar ' Ipakita ang password
        Else
            password.PasswordChar = "•"c ' Itago ang password
        End If
    End Sub
End Class
