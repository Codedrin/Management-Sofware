Imports System.Net.Http
Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json

Public Class Listof_department
    Private studentsData As JObject

    Private Async Sub Listof_department_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadStudentsFromFirebase()
    End Sub

    Private Async Function LoadStudentsFromFirebase() As Task
        Dim firebaseUrl As String = "https://guidance-management-syst-70349-default-rtdb.firebaseio.com/students.json"

        Using client As New HttpClient()
            Try
                Dim response As HttpResponseMessage = Await client.GetAsync(firebaseUrl)

                If response.IsSuccessStatusCode Then
                    Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
                    studentsData = JObject.Parse(jsonResponse)

                    ' Clear all ListBoxes before loading new data
                    ClearListBoxes()

                    ' Populate ListBoxes with student names
                    For Each student In studentsData
                        Dim studentData As JObject = student.Value
                        Dim fullName As String = $"{studentData("lastname")}, {studentData("name")}"
                        Dim course As String = studentData("course").ToString()

                        AddStudentToListBox(fullName, course)
                    Next
                Else
                    MessageBox.Show("Failed to retrieve student data.", "Error", MessageBoxButtons.OK)
                End If
            Catch ex As Exception
                MessageBox.Show($"Error loading students: {ex.Message}", "Error", MessageBoxButtons.OK)
            End Try
        End Using
    End Function

    ' Clears all ListBox items
    Private Sub ClearListBoxes()
        beed.Items.Clear()
        bsed.Items.Clear()
        bsba.Items.Clear()
        act.Items.Clear()
        caregiving.Items.Clear()
    End Sub

    ' Adds student name to the correct ListBox based on course
    Private Sub AddStudentToListBox(fullName As String, course As String)
        Select Case course
            Case "BEED" : beed.Items.Add(fullName)
            Case "BSED" : bsed.Items.Add(fullName)
            Case "BSBA" : bsba.Items.Add(fullName)
            Case "ACT" : act.Items.Add(fullName)
            Case "CARE GIVING" : caregiving.Items.Add(fullName)
        End Select
    End Sub

    ' Handles ListBox item click event
    Private Sub ListBox_Click(sender As Object, e As EventArgs) Handles beed.Click, bsed.Click, bsba.Click, act.Click, caregiving.Click
        Dim listBox As ListBox = DirectCast(sender, ListBox)

        If listBox.SelectedItem IsNot Nothing Then
            Dim selectedName As String = listBox.SelectedItem.ToString()
            ShowStudentDetails(selectedName, listBox)
        End If
    End Sub

    ' Displays student details with a delete option
    Private Sub ShowStudentDetails(fullName As String, listBox As ListBox)
        If studentsData Is Nothing Then Exit Sub

        For Each student In studentsData
            Dim studentData As JObject = student.Value
            Dim storedFullName As String = $"{studentData("lastname")}, {studentData("name")}"

            If storedFullName = fullName Then
                Dim studentId As String = student.Key ' Firebase key

                Dim details As String =
            "STUDENT INFORMATION" & vbCrLf &
            "==================================" & vbCrLf &
            $"ID: {studentData("id")}" & vbCrLf &
            $"Name: {studentData("name")} {studentData("middlename")} {studentData("lastname")}" & vbCrLf &
            $"Mobile No: {studentData("mobileno")}" & vbCrLf &
            $"Telephone No: {studentData("telephoneno")}" & vbCrLf &
            $"Email: {studentData("emailadds")}" & vbCrLf &
            "----------------------------------" & vbCrLf &
            $"Address: {studentData("address")}, {studentData("cityadds")}" & vbCrLf &
            $"Provincial Address: {studentData("provincialadds")}" & vbCrLf &
            $"Date of Birth: {studentData("datebirth")}" & vbCrLf &
            $"Place of Birth: {studentData("placeofbirth")}" & vbCrLf &
            $"Gender: {studentData("gender")}" & vbCrLf &
            $"Status: {studentData("status")}" & vbCrLf &
            $"Religion: {studentData("religion")}" & vbCrLf &
            $"Course: {studentData("course")}" & vbCrLf &
            $"Year: {studentData("year")}" & vbCrLf &
            $"Section: {studentData("section")}" & vbCrLf &
            $"General Average: {studentData("genave")}" & vbCrLf &
            $"Employer: {studentData("employer")}" & vbCrLf &
            $"Incident: {studentData("incident")}" & vbCrLf &
            "----------------------------------" & vbCrLf &
            $"Height: {studentData("height")} cm" & vbCrLf &
            $"Weight: {studentData("weight")} kg" & vbCrLf &
            $"Complexion: {studentData("complexion")}" & vbCrLf &
            "----------------------------------" & vbCrLf &
            "**APPOINTMENT & COMPLAINTS**" & vbCrLf &
            $"Appointment: {studentData("appointment")}" & vbCrLf &
            $"Complaint: {studentData("complain")}" & vbCrLf

                Dim messageBox As New Form With {
            .Text = "Student Details",
            .Size = New Size(600, 700),
            .StartPosition = FormStartPosition.CenterScreen,
            .AutoSizeMode = AutoSizeMode.GrowAndShrink
        }

                Dim lblDetails As New Label With {
            .Text = details,
            .Font = New Font("Arial", 12, FontStyle.Regular),
            .AutoSize = False,
            .Size = New Size(550, 500),
            .Location = New Point(20, 20),
            .Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        }

                ' Adjust the label to take up most of the form height without overlapping the button
                lblDetails.Size = New Size(messageBox.ClientSize.Width - 40, messageBox.ClientSize.Height - 100)

                ' Center the "Close" button below the text dynamically
                Dim btnClose As New Button With {
    .Text = "Close",
    .Size = New Size(120, 40),
    .Location = New Point((messageBox.ClientSize.Width - 120) \ 2, lblDetails.Bottom + 10),
    .Anchor = AnchorStyles.Bottom
}

                ' Ensure the button stays properly positioned when resizing
                AddHandler messageBox.Resize, Sub()
                                                  lblDetails.Size = New Size(messageBox.ClientSize.Width - 40, messageBox.ClientSize.Height - 100)
                                                  btnClose.Location = New Point((messageBox.ClientSize.Width - 120) \ 2, lblDetails.Bottom + 10)
                                              End Sub

                AddHandler btnClose.Click, Sub(sender, e) messageBox.Close()




                messageBox.Controls.Add(lblDetails)
                messageBox.Controls.Add(btnClose)
                messageBox.ShowDialog()

                Exit Sub
            End If
        Next
    End Sub



    ' Deletes student from Firebase and ListBox
    Private Async Function DeleteStudent(studentId As String, fullName As String, listBox As ListBox) As Task
        Dim firebaseUrl As String = $"https://guidance-management-syst-70349-default-rtdb.firebaseio.com/students/{studentId}.json"

        Using client As New HttpClient()
            Try
                Dim response As HttpResponseMessage = Await client.DeleteAsync(firebaseUrl)

                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Student deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    listBox.Items.Remove(fullName)
                Else
                    MessageBox.Show("Failed to delete student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show($"Error deleting student: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Function


End Class
