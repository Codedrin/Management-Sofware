Imports System.Net.Http
Imports System.Text
Imports System.Threading.Tasks
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class forgotpassword
    Private Async Sub changepass_Click(sender As Object, e As EventArgs) Handles changepass.Click
        Dim email As String = emalfor.Text
        Dim newPassword As String = newpass.Text

        If email = "" Or newPassword = "" Then
            MessageBox.Show("Please enter your email and new password.")
            Return
        End If

        Dim firebaseUrl As String = "https://guidance-management-syst-70349-default-rtdb.firebaseio.com/accounts.json"

        Using client As New HttpClient()
            Try
                ' Kunin lahat ng account data mula sa Firebase
                Dim response As HttpResponseMessage = Await client.GetAsync(firebaseUrl)
                If response.IsSuccessStatusCode Then
                    Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
                    Dim accounts As JObject = JObject.Parse(jsonResponse)

                    Dim userKey As String = Nothing

                    ' Hanapin ang email sa database
                    For Each account In accounts
                        Dim userData As JObject = account.Value
                        If userData("email").ToString() = email Then
                            userKey = account.Key ' Kunin ang unique key ng user
                            Exit For
                        End If
                    Next

                    If userKey IsNot Nothing Then
                        ' Update ang password sa Firebase
                        Dim updateUrl As String = $"https://guidance-management-syst-70349-default-rtdb.firebaseio.com/accounts/{userKey}.json"
                        Dim updatedData As New JObject From {{"password", newPassword}}
                        Dim json As String = JsonConvert.SerializeObject(updatedData)
                        Dim content As New StringContent(json, Encoding.UTF8, "application/json")

                        Dim updateResponse As HttpResponseMessage = Await client.PatchAsync(updateUrl, content)

                        If updateResponse.IsSuccessStatusCode Then
                            MessageBox.Show("Password updated successfully!")
                        Else
                            MessageBox.Show("Failed to update password.")
                        End If
                    Else
                        MessageBox.Show("Email not found in the database.")
                    End If
                Else
                    MessageBox.Show("Failed to connect to Firebase.")
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles backbutton.Click
        Dim form1 As New Form1()
        form1.Show()
        Me.Hide() ' Itago ang kasalukuyang form
    End Sub

    Private Sub forgotpassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub seepass3_CheckedChanged(sender As Object, e As EventArgs) Handles seepass3.CheckedChanged
        If seepass3.Checked Then
            newpass.PasswordChar = ControlChars.NullChar ' Ipakita ang password
        Else
            newpass.PasswordChar = "•"c ' Itago ang password
        End If
    End Sub


End Class
