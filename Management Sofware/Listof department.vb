Imports MySql.Data.MySqlClient

Public Class Listof_department
    Private studentsData As New List(Of Dictionary(Of String, String))

    Private Sub Listof_department_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStudentsFromMySQL()
    End Sub

    Private Sub LoadStudentsFromMySQL()
        Try
            OpenConnection()

            Dim query As String = "SELECT * FROM students"
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ClearListBoxes()
            studentsData.Clear()

            While reader.Read()
                Dim studentDict As New Dictionary(Of String, String)

                For i As Integer = 0 To reader.FieldCount - 1
                    studentDict(reader.GetName(i)) = reader(i).ToString()
                Next

                studentsData.Add(studentDict)

                Dim fullName As String = $"{studentDict("lastname")}, {studentDict("name")}"
                Dim course As String = studentDict("course")

                AddStudentToListBox(fullName, course)
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading students: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub ClearListBoxes()
        beed.Items.Clear()
        bsed.Items.Clear()
        bsba.Items.Clear()
        act.Items.Clear()
        caregiving.Items.Clear()
    End Sub

    Private Sub AddStudentToListBox(fullName As String, course As String)
        Select Case course.ToUpper()
            Case "BEED" : beed.Items.Add(fullName)
            Case "BSED" : bsed.Items.Add(fullName)
            Case "BSBA" : bsba.Items.Add(fullName)
            Case "ACT" : act.Items.Add(fullName)
            Case "CARE GIVING" : caregiving.Items.Add(fullName)
        End Select
    End Sub

    Private Sub ListBox_Click(sender As Object, e As EventArgs) Handles beed.Click, bsed.Click, bsba.Click, act.Click, caregiving.Click
        Dim listBox As ListBox = DirectCast(sender, ListBox)

        If listBox.SelectedItem IsNot Nothing Then
            Dim selectedName As String = listBox.SelectedItem.ToString()
            ShowStudentDetails(selectedName)
        End If
    End Sub

    Private Sub ShowStudentDetails(fullName As String)
        For Each student In studentsData
            Dim storedFullName As String = $"{student("lastname")}, {student("name")}"
            If storedFullName = fullName Then
                Dim details As String =
                    "STUDENT INFORMATION" & vbCrLf &
                    "==================================" & vbCrLf &
                    $"ID: {student("id")}" & vbCrLf &
                    $"Name: {student("name")} {student("middlename")} {student("lastname")}" & vbCrLf &
                    $"Mobile No: {student("mobileno")}" & vbCrLf &
                    $"Telephone No: {student("telephoneno")}" & vbCrLf &
                    $"Email: {student("emailadds")}" & vbCrLf &
                    "----------------------------------" & vbCrLf &
                    $"Address: {student("address")}, {student("cityadds")}" & vbCrLf &
                    $"Provincial Address: {student("provincialadds")}" & vbCrLf &
                    $"Date of Birth: {student("datebirth")}" & vbCrLf &
                    $"Place of Birth: {student("placeofbirth")}" & vbCrLf &
                    $"Gender: {student("gender")}" & vbCrLf &
                    $"Status: {student("status")}" & vbCrLf &
                    $"Religion: {student("religion")}" & vbCrLf &
                    $"Course: {student("course")}" & vbCrLf &
                    $"Year: {student("year")}" & vbCrLf &
                    $"Section: {student("section")}" & vbCrLf &
                    $"General Average: {student("genave")}" & vbCrLf &
                    $"Employer: {student("employer")}" & vbCrLf &
                    $"Incident: {student("incident")}" & vbCrLf &
                    "----------------------------------" & vbCrLf &
                    $"Height: {student("height")} cm" & vbCrLf &
                    $"Weight: {student("weight")} kg" & vbCrLf &
                    $"Complexion: {student("complexion")}" & vbCrLf &
                    "----------------------------------" & vbCrLf &
                    "**APPOINTMENT & COMPLAINTS**" & vbCrLf &
                    $"Appointment: {student("appointment")}" & vbCrLf &
                    $"Complaint: {student("complain")}" & vbCrLf

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
                    .Location = New Point(20, 20)
                }

                lblDetails.Size = New Size(messageBox.ClientSize.Width - 40, messageBox.ClientSize.Height - 100)

                Dim btnClose As New Button With {
                    .Text = "Close",
                    .Size = New Size(120, 40),
                    .Location = New Point((messageBox.ClientSize.Width - 120) \ 2, lblDetails.Bottom + 10)
                }

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


End Class
