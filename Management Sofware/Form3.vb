Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Net.Http
Imports System.Text

Public Class Form3
    Private Async Sub Form3_LoadAsync(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadUserInfo()
    End Sub

    Private Async Function LoadUserInfo() As Task
        If Form1.LoggedInEmail = "" Then
            MessageBox.Show("No user is logged in.")
            Return
        End If

        Dim firebaseUrl As String = "https://guidance-management-syst-70349-default-rtdb.firebaseio.com/accounts.json"

        Using client As New HttpClient()
            Try
                Dim response As HttpResponseMessage = Await client.GetAsync(firebaseUrl)
                If response.IsSuccessStatusCode Then
                    Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
                    Dim accounts As JObject = JObject.Parse(jsonResponse)

                    ' Hanapin ang user gamit ang email
                    For Each account In accounts
                        Dim userData As JObject = account.Value
                        If userData("email").ToString() = Form1.LoggedInEmail Then
                            pfpname.Text = userData("username").ToString() ' Ipakita ang Username
                            emaildisplay.Text = userData("email").ToString() ' Ipakita ang Email
                            Exit For
                        End If
                    Next
                Else
                    MessageBox.Show("Failed to retrieve user data.")
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Function

    Private Async Function Form3_Load(sender As Object, e As EventArgs) As Task Handles MyBase.Load
        ' Tawagin ang function para mag-load ng user info
        Await LoadUserInfo()

        ' I-add ang marital status options sa ComboBox
        status.Items.Clear()
        status.Items.Add("Single")
        status.Items.Add("Married")
        status.Items.Add("Widowed")
        status.Items.Add("Separated")
        status.Items.Add("Divorced")

        ' I-add ang course options sa ComboBox
        course.Items.Clear()
        course.Items.Add("BEED")
        course.Items.Add("BSED")
        course.Items.Add("BSBA")
        course.Items.Add("ACT")
        course.Items.Add("CARE GIVING")
    End Function

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        ' I-clear ang LoggedInEmail
        Form1.LoggedInEmail = ""

        ' Ipakita ulit ang Login Form (Form1)
        Dim loginForm As New Form1()
        loginForm.Show()

        ' Isara ang kasalukuyang form (Form3)
        Me.Close()
    End Sub

    Private Sub calendar_DateChanged(sender As Object, e As DateRangeEventArgs) Handles calendar.DateChanged
        ' I-set ang napiling date sa datebirth textbox
        datebirth.Text = e.Start.ToShortDateString
    End Sub

    Private Sub male_CheckedChanged(sender As Object, e As EventArgs) Handles male.CheckedChanged
        If male.Checked Then
            gender.Text = "Male"
        End If
    End Sub

    Private Sub female_CheckedChanged(sender As Object, e As EventArgs) Handles female.CheckedChanged
        If female.Checked Then
            gender.Text = "Female"
        End If
    End Sub

    Private Async Function SaveStudentInfo() As Task
        Dim firebaseUrl As String = "https://guidance-management-syst-70349-default-rtdb.firebaseio.com/students.json"

        Dim studentData As New Dictionary(Of String, String) From {
    {"id", id.Text},
    {"name", namefillup.Text},
    {"lastname", lastnamefillup.Text},
    {"middlename", middlenamefillup.Text},
    {"course", course.SelectedItem?.ToString()},
    {"status", status.SelectedItem?.ToString()},
    {"mobileno", mobileno.Text},
    {"datebirth", datebirth.Text},
    {"year", year.Text},
    {"height", height.Text},
    {"weight", weight.Text},
    {"section", section.Text},
    {"complexion", complexion.Text},
    {"cityadds", cityadds.Text},
    {"provincialadds", provincialadds.Text},
    {"genave", genave.Text},
    {"religion", religion.Text},
    {"employer", employer.Text},
    {"incident", incident.Text},
    {"address", address.Text},
    {"relationship", relationship.Text},
    {"contactno", contactno.Text},
    {"placeofbirth", placeofbirth.Text},
    {"emailadds", emailadds.Text},
    {"telephoneno", telephoneno.Text},
    {"gender", gender.Text},
    {"appointment", appointment.Text}, ' Isama ang appointment
    {"complain", complain.Text} ' Isama ang complain
}


        Dim json As String = JsonConvert.SerializeObject(studentData)

        Using client As New HttpClient()
            Try
                Dim content As New StringContent(json, Encoding.UTF8, "application/json")
                Dim response As HttpResponseMessage = Await client.PostAsync(firebaseUrl, content)

                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Student data saved successfully!")
                Else
                    MessageBox.Show("Failed to save data.")
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Function

    Private Async Sub saved_Click(sender As Object, e As EventArgs) Handles saved.Click
        Await SaveStudentInfo()
    End Sub


    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        id.Clear()
        namefillup.Clear()
        lastnamefillup.Clear()
        middlenamefillup.Clear()
        course.SelectedIndex = -1 ' I-clear ang napiling course sa ComboBox
        status.SelectedIndex = -1 ' I-clear ang marital status sa ComboBox
        mobileno.Clear()
        datebirth.Clear()
        year.Clear()
        height.Clear()
        weight.Clear()
        section.Clear()
        complexion.Clear()
        cityadds.Clear()
        provincialadds.Clear()
        genave.Clear()
        religion.Clear()
        employer.Clear()
        incident.Clear()
        address.Clear()
        relationship.Clear()
        contactno.Clear()
        placeofbirth.Clear()
        emailadds.Clear()
        telephoneno.Clear()
        gender.Clear()

        male.Checked = False
        female.Checked = False

        calendar.SetDate(DateTime.Today)

        ' I-clear din ang appointment at complain fields
        appointment.Clear()
        complain.Clear()

        MessageBox.Show("All fields have been cleared.")
    End Sub


    Private Sub list_Click(sender As Object, e As EventArgs) Handles list.Click
        Dim departmentForm As New Listof_department()
        departmentForm.Show()
    End Sub

    Private Sub appointment_TextChanged(sender As Object, e As EventArgs) Handles appointment.TextChanged

    End Sub

    Private Sub appointmentcalendar_DateChanged(sender As Object, e As DateRangeEventArgs) Handles appointmentcalendar.DateChanged
        appointment.Text = e.Start.ToShortDateString()
    End Sub


    Private Sub complain_TextChanged(sender As Object, e As EventArgs) Handles complain.TextChanged

    End Sub
End Class
