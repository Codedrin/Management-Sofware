Imports MySql.Data.MySqlClient

Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUserInfo()
        InitializeComboBoxes()
    End Sub

    Private Sub LoadUserInfo()
        If Form1.LoggedInEmail = "" Then
            MessageBox.Show("No user is logged in.")
            Return
        End If

        Try
            OpenConnection()

            Dim query As String = "SELECT name, emailadds FROM students WHERE emailadds = @Email"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@Email", Form1.LoggedInEmail)

            Using reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    pfpname.Text = reader("name").ToString()
                    emaildisplay.Text = reader("emailadds").ToString()
                Else
                    MessageBox.Show("User not found.")
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading user info: " & ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub InitializeComboBoxes()
        status.Items.Clear()
        status.Items.AddRange(New String() {"Single", "Married", "Widowed", "Separated", "Divorced"})

        course.Items.Clear()
        course.Items.AddRange(New String() {"BEED", "BSED", "BSBA", "ACT", "CARE GIVING"})
    End Sub

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Form1.LoggedInEmail = ""
        Dim loginForm As New Form1()
        loginForm.Show()
        Me.Close()
    End Sub

    Private Sub calendar_DateChanged(sender As Object, e As DateRangeEventArgs) Handles calendar.DateChanged
        datebirth.Text = e.Start.ToShortDateString
    End Sub

    Private Sub appointmentcalendar_DateChanged(sender As Object, e As DateRangeEventArgs) Handles appointmentcalendar.DateChanged
        appointment.Text = e.Start.ToShortDateString
    End Sub

    Private Sub male_CheckedChanged(sender As Object, e As EventArgs) Handles male.CheckedChanged
        If male.Checked Then gender.Text = "Male"
    End Sub

    Private Sub female_CheckedChanged(sender As Object, e As EventArgs) Handles female.CheckedChanged
        If female.Checked Then gender.Text = "Female"
    End Sub

    Private Sub saved_Click(sender As Object, e As EventArgs) Handles saved.Click
        SaveStudentInfo()
    End Sub

    Private Sub SaveStudentInfo()
        Try
            OpenConnection()

            Dim query As String = "INSERT INTO students (id, name, lastname, middlename, course, status, mobileno, datebirth, year, height, weight, section, complexion, cityadds, provincialadds, genave, religion, employer, incident, address, relationship, contactno, placeofbirth, emailadds, telephoneno, gender, appointment, complain) " &
                                  "VALUES (@id, @name, @lastname, @middlename, @course, @status, @mobileno, @datebirth, @year, @height, @weight, @section, @complexion, @cityadds, @provincialadds, @genave, @religion, @employer, @incident, @address, @relationship, @contactno, @placeofbirth, @emailadds, @telephoneno, @gender, @appointment, @complain)"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", id.Text)
                cmd.Parameters.AddWithValue("@name", namefillup.Text)
                cmd.Parameters.AddWithValue("@lastname", lastnamefillup.Text)
                cmd.Parameters.AddWithValue("@middlename", middlenamefillup.Text)
                cmd.Parameters.AddWithValue("@course", course.SelectedItem?.ToString())
                cmd.Parameters.AddWithValue("@status", status.SelectedItem?.ToString())
                cmd.Parameters.AddWithValue("@mobileno", mobileno.Text)
                cmd.Parameters.AddWithValue("@datebirth", datebirth.Text)
                cmd.Parameters.AddWithValue("@year", year.Text)
                cmd.Parameters.AddWithValue("@height", height.Text)
                cmd.Parameters.AddWithValue("@weight", weight.Text)
                cmd.Parameters.AddWithValue("@section", section.Text)
                cmd.Parameters.AddWithValue("@complexion", complexion.Text)
                cmd.Parameters.AddWithValue("@cityadds", cityadds.Text)
                cmd.Parameters.AddWithValue("@provincialadds", provincialadds.Text)
                cmd.Parameters.AddWithValue("@genave", genave.Text)
                cmd.Parameters.AddWithValue("@religion", religion.Text)
                cmd.Parameters.AddWithValue("@employer", employer.Text)
                cmd.Parameters.AddWithValue("@incident", incident.Text)
                cmd.Parameters.AddWithValue("@address", address.Text)
                cmd.Parameters.AddWithValue("@relationship", relationship.Text)
                cmd.Parameters.AddWithValue("@contactno", contactno.Text)
                cmd.Parameters.AddWithValue("@placeofbirth", placeofbirth.Text)
                cmd.Parameters.AddWithValue("@emailadds", emailadds.Text)
                cmd.Parameters.AddWithValue("@telephoneno", telephoneno.Text)
                cmd.Parameters.AddWithValue("@gender", gender.Text)
                cmd.Parameters.AddWithValue("@appointment", appointment.Text)
                cmd.Parameters.AddWithValue("@complain", complain.Text)

                Dim result = cmd.ExecuteNonQuery()

                If result > 0 Then
                    MessageBox.Show("Student info saved successfully!")
                Else
                    MessageBox.Show("Failed to save student info.")
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then DirectCast(ctrl, TextBox).Clear()
        Next

        course.SelectedIndex = -1
        status.SelectedIndex = -1
        male.Checked = False
        female.Checked = False
        gender.Clear()
        calendar.SetDate(Date.Today)
        appointmentcalendar.SetDate(Date.Today)
        MessageBox.Show("All fields cleared.")
    End Sub

    Private Sub list_Click(sender As Object, e As EventArgs) Handles list.Click
        Dim departmentForm As New Listof_department()
        departmentForm.Show()
    End Sub
End Class
