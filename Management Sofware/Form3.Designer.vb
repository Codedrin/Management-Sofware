<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        saved = New Button()
        Panel2 = New Panel()
        Button1 = New Button()
        Button2 = New Button()
        logo = New PictureBox()
        Label4 = New Label()
        Label5 = New Label()
        clear = New Button()
        logout = New Button()
        list = New Button()
        emaildisplay = New Label()
        pfpname = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        namefillup = New TextBox()
        lastnamefillup = New TextBox()
        middlenamefillup = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        year = New TextBox()
        Label8 = New Label()
        section = New TextBox()
        status = New ComboBox()
        Label9 = New Label()
        male = New RadioButton()
        female = New RadioButton()
        Label10 = New Label()
        id = New TextBox()
        Label11 = New Label()
        Label12 = New Label()
        height = New TextBox()
        weight = New TextBox()
        Label13 = New Label()
        mobileno = New TextBox()
        Label14 = New Label()
        complexion = New TextBox()
        Label15 = New Label()
        cityadds = New TextBox()
        Label16 = New Label()
        provincialadds = New TextBox()
        Label17 = New Label()
        genave = New TextBox()
        Label18 = New Label()
        religion = New TextBox()
        Label19 = New Label()
        employer = New TextBox()
        Label20 = New Label()
        incident = New TextBox()
        Label21 = New Label()
        address = New TextBox()
        Label22 = New Label()
        relationship = New TextBox()
        Label23 = New Label()
        contactno = New TextBox()
        Label24 = New Label()
        Label25 = New Label()
        placeofbirth = New TextBox()
        calendar = New MonthCalendar()
        datebirth = New TextBox()
        Label26 = New Label()
        emailadds = New TextBox()
        Label27 = New Label()
        telephoneno = New TextBox()
        gender = New TextBox()
        course = New ComboBox()
        appointment = New TextBox()
        appointmentcalendar = New MonthCalendar()
        Label28 = New Label()
        Label29 = New Label()
        complain = New TextBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(logo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Panel1.Controls.Add(saved)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(clear)
        Panel1.Controls.Add(logout)
        Panel1.Controls.Add(list)
        Panel1.Controls.Add(emaildisplay)
        Panel1.Controls.Add(pfpname)
        Panel1.Location = New Point(-5, -4)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(249, 929)
        Panel1.TabIndex = 0
        ' 
        ' saved
        ' 
        saved.Location = New Point(18, 609)
        saved.Margin = New Padding(3, 4, 3, 4)
        saved.Name = "saved"
        saved.Size = New Size(214, 59)
        saved.TabIndex = 6
        saved.Text = "Save"
        saved.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(logo)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label5)
        Panel2.Location = New Point(29, 27)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(195, 229)
        Panel2.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(23, 511)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(173, 59)
        Button1.TabIndex = 4
        Button1.Text = "Log Out"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(23, 427)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(173, 59)
        Button2.TabIndex = 3
        Button2.Text = "List of Student"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' logo
        ' 
        logo.Image = My.Resources.Resources.df4e968f_5a9f_4bc0_bc7d_aba5cedd3f60_removebg_preview__2_
        logo.Location = New Point(9, 13)
        logo.Margin = New Padding(3, 4, 3, 4)
        logo.Name = "logo"
        logo.Size = New Size(177, 199)
        logo.SizeMode = PictureBoxSizeMode.StretchImage
        logo.TabIndex = 2
        logo.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.ForeColor = Color.White
        Label4.Location = New Point(23, 364)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 20)
        Label4.TabIndex = 1
        Label4.Text = "email"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(23, 308)
        Label5.Name = "Label5"
        Label5.Size = New Size(78, 32)
        Label5.TabIndex = 0
        Label5.Text = "Name"
        ' 
        ' clear
        ' 
        clear.BackColor = Color.Snow
        clear.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        clear.ForeColor = Color.Black
        clear.Location = New Point(18, 683)
        clear.Margin = New Padding(3, 4, 3, 4)
        clear.Name = "clear"
        clear.Size = New Size(214, 55)
        clear.TabIndex = 7
        clear.Text = "Clear"
        clear.UseVisualStyleBackColor = False
        ' 
        ' logout
        ' 
        logout.Location = New Point(18, 833)
        logout.Margin = New Padding(3, 4, 3, 4)
        logout.Name = "logout"
        logout.Size = New Size(214, 59)
        logout.TabIndex = 4
        logout.Text = "Log Out"
        logout.UseVisualStyleBackColor = True
        ' 
        ' list
        ' 
        list.Location = New Point(18, 753)
        list.Margin = New Padding(3, 4, 3, 4)
        list.Name = "list"
        list.Size = New Size(214, 59)
        list.TabIndex = 3
        list.Text = "List of Student"
        list.UseVisualStyleBackColor = True
        ' 
        ' emaildisplay
        ' 
        emaildisplay.AutoSize = True
        emaildisplay.BackColor = Color.Transparent
        emaildisplay.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        emaildisplay.ForeColor = Color.White
        emaildisplay.Location = New Point(18, 340)
        emaildisplay.Name = "emaildisplay"
        emaildisplay.Size = New Size(51, 23)
        emaildisplay.TabIndex = 1
        emaildisplay.Text = "email"
        emaildisplay.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pfpname
        ' 
        pfpname.AutoSize = True
        pfpname.BackColor = Color.Transparent
        pfpname.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        pfpname.ForeColor = Color.White
        pfpname.Location = New Point(18, 299)
        pfpname.Name = "pfpname"
        pfpname.Size = New Size(78, 32)
        pfpname.TabIndex = 0
        pfpname.Text = "Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(257, 71)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 20)
        Label1.TabIndex = 1
        Label1.Text = "Fistname"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(473, 71)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 20)
        Label2.TabIndex = 2
        Label2.Text = "Lastname"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(703, 71)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 20)
        Label3.TabIndex = 3
        Label3.Text = "Middlename"
        ' 
        ' namefillup
        ' 
        namefillup.Location = New Point(325, 67)
        namefillup.Margin = New Padding(3, 4, 3, 4)
        namefillup.Name = "namefillup"
        namefillup.Size = New Size(121, 27)
        namefillup.TabIndex = 4
        ' 
        ' lastnamefillup
        ' 
        lastnamefillup.Location = New Point(560, 67)
        lastnamefillup.Margin = New Padding(3, 4, 3, 4)
        lastnamefillup.Name = "lastnamefillup"
        lastnamefillup.Size = New Size(125, 27)
        lastnamefillup.TabIndex = 5
        ' 
        ' middlenamefillup
        ' 
        middlenamefillup.Location = New Point(794, 67)
        middlenamefillup.Margin = New Padding(3, 4, 3, 4)
        middlenamefillup.Name = "middlenamefillup"
        middlenamefillup.Size = New Size(142, 27)
        middlenamefillup.TabIndex = 6
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(257, 127)
        Label6.Name = "Label6"
        Label6.Size = New Size(54, 20)
        Label6.TabIndex = 7
        Label6.Text = "Course"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(257, 176)
        Label7.Name = "Label7"
        Label7.Size = New Size(37, 20)
        Label7.TabIndex = 9
        Label7.Text = "Year"
        ' 
        ' year
        ' 
        year.Location = New Point(325, 176)
        year.Margin = New Padding(3, 4, 3, 4)
        year.Name = "year"
        year.Size = New Size(103, 27)
        year.TabIndex = 10
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(255, 231)
        Label8.Name = "Label8"
        Label8.Size = New Size(58, 20)
        Label8.TabIndex = 11
        Label8.Text = "Section"
        ' 
        ' section
        ' 
        section.Location = New Point(325, 227)
        section.Margin = New Padding(3, 4, 3, 4)
        section.Name = "section"
        section.Size = New Size(103, 27)
        section.TabIndex = 12
        ' 
        ' status
        ' 
        status.FormattingEnabled = True
        status.Location = New Point(560, 123)
        status.Margin = New Padding(3, 4, 3, 4)
        status.Name = "status"
        status.Size = New Size(125, 28)
        status.TabIndex = 13
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(473, 127)
        Label9.Name = "Label9"
        Label9.Size = New Size(81, 20)
        Label9.TabIndex = 14
        Label9.Text = "Civil Status"
        ' 
        ' male
        ' 
        male.AutoSize = True
        male.Location = New Point(639, 20)
        male.Margin = New Padding(3, 4, 3, 4)
        male.Name = "male"
        male.Size = New Size(63, 24)
        male.TabIndex = 15
        male.TabStop = True
        male.Text = "Male"
        male.UseVisualStyleBackColor = True
        ' 
        ' female
        ' 
        female.AutoSize = True
        female.Location = New Point(715, 20)
        female.Margin = New Padding(3, 4, 3, 4)
        female.Name = "female"
        female.Size = New Size(78, 24)
        female.TabIndex = 16
        female.TabStop = True
        female.Text = "Female"
        female.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(257, 23)
        Label10.Name = "Label10"
        Label10.Size = New Size(79, 20)
        Label10.TabIndex = 17
        Label10.Text = "Student ID"
        ' 
        ' id
        ' 
        id.Location = New Point(335, 16)
        id.Margin = New Padding(3, 4, 3, 4)
        id.Name = "id"
        id.Size = New Size(279, 27)
        id.TabIndex = 18
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(473, 176)
        Label11.Name = "Label11"
        Label11.Size = New Size(81, 20)
        Label11.TabIndex = 19
        Label11.Text = "Height (m)"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(703, 176)
        Label12.Name = "Label12"
        Label12.Size = New Size(56, 20)
        Label12.TabIndex = 20
        Label12.Text = "Weight"
        ' 
        ' height
        ' 
        height.Location = New Point(560, 172)
        height.Margin = New Padding(3, 4, 3, 4)
        height.Name = "height"
        height.Size = New Size(125, 27)
        height.TabIndex = 21
        ' 
        ' weight
        ' 
        weight.Location = New Point(773, 172)
        weight.Margin = New Padding(3, 4, 3, 4)
        weight.Name = "weight"
        weight.Size = New Size(164, 27)
        weight.TabIndex = 22
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(703, 127)
        Label13.Name = "Label13"
        Label13.Size = New Size(77, 20)
        Label13.TabIndex = 23
        Label13.Text = "Mobile no"
        ' 
        ' mobileno
        ' 
        mobileno.Location = New Point(794, 123)
        mobileno.Margin = New Padding(3, 4, 3, 4)
        mobileno.Name = "mobileno"
        mobileno.Size = New Size(142, 27)
        mobileno.TabIndex = 24
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(473, 231)
        Label14.Name = "Label14"
        Label14.Size = New Size(89, 20)
        Label14.TabIndex = 25
        Label14.Text = "Complexion"
        ' 
        ' complexion
        ' 
        complexion.Location = New Point(560, 231)
        complexion.Margin = New Padding(3, 4, 3, 4)
        complexion.Name = "complexion"
        complexion.Size = New Size(377, 27)
        complexion.TabIndex = 26
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(257, 283)
        Label15.Name = "Label15"
        Label15.Size = New Size(91, 20)
        Label15.TabIndex = 27
        Label15.Text = "City Address"
        ' 
        ' cityadds
        ' 
        cityadds.Location = New Point(347, 279)
        cityadds.Margin = New Padding(3, 4, 3, 4)
        cityadds.Name = "cityadds"
        cityadds.Size = New Size(589, 27)
        cityadds.TabIndex = 28
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(257, 331)
        Label16.Name = "Label16"
        Label16.Size = New Size(130, 20)
        Label16.TabIndex = 29
        Label16.Text = "Provincial Address"
        ' 
        ' provincialadds
        ' 
        provincialadds.Location = New Point(383, 327)
        provincialadds.Margin = New Padding(3, 4, 3, 4)
        provincialadds.Name = "provincialadds"
        provincialadds.Size = New Size(554, 27)
        provincialadds.TabIndex = 30
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(257, 387)
        Label17.Name = "Label17"
        Label17.Size = New Size(198, 20)
        Label17.TabIndex = 31
        Label17.Text = "Highschool General Average"
        ' 
        ' genave
        ' 
        genave.Location = New Point(443, 383)
        genave.Margin = New Padding(3, 4, 3, 4)
        genave.Name = "genave"
        genave.Size = New Size(110, 27)
        genave.TabIndex = 32
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(585, 387)
        Label18.Name = "Label18"
        Label18.Size = New Size(64, 20)
        Label18.TabIndex = 33
        Label18.Text = "Religion"
        ' 
        ' religion
        ' 
        religion.Location = New Point(649, 383)
        religion.Margin = New Padding(3, 4, 3, 4)
        religion.Name = "religion"
        religion.Size = New Size(287, 27)
        religion.TabIndex = 34
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(257, 436)
        Label19.Name = "Label19"
        Label19.Size = New Size(414, 20)
        Label19.TabIndex = 35
        Label19.Text = "If working please indicate the name and address of employer"
        ' 
        ' employer
        ' 
        employer.Location = New Point(649, 432)
        employer.Margin = New Padding(3, 4, 3, 4)
        employer.Name = "employer"
        employer.Size = New Size(287, 27)
        employer.TabIndex = 36
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(257, 488)
        Label20.Name = "Label20"
        Label20.Size = New Size(400, 20)
        Label20.TabIndex = 37
        Label20.Text = "Person to be contacted in case of accident or serious illness"
        ' 
        ' incident
        ' 
        incident.Location = New Point(649, 484)
        incident.Margin = New Padding(3, 4, 3, 4)
        incident.Name = "incident"
        incident.Size = New Size(287, 27)
        incident.TabIndex = 38
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Location = New Point(257, 553)
        Label21.Name = "Label21"
        Label21.Size = New Size(62, 20)
        Label21.TabIndex = 39
        Label21.Text = "Address"
        ' 
        ' address
        ' 
        address.Location = New Point(326, 547)
        address.Margin = New Padding(3, 4, 3, 4)
        address.Name = "address"
        address.Size = New Size(611, 27)
        address.TabIndex = 40
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Location = New Point(257, 615)
        Label22.Name = "Label22"
        Label22.Size = New Size(91, 20)
        Label22.TabIndex = 41
        Label22.Text = "Relationship"
        ' 
        ' relationship
        ' 
        relationship.Location = New Point(346, 611)
        relationship.Margin = New Padding(3, 4, 3, 4)
        relationship.Name = "relationship"
        relationship.Size = New Size(191, 27)
        relationship.TabIndex = 42
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Location = New Point(571, 615)
        Label23.Name = "Label23"
        Label23.Size = New Size(81, 20)
        Label23.TabIndex = 43
        Label23.Text = "Contact no"
        ' 
        ' contactno
        ' 
        contactno.Location = New Point(655, 611)
        contactno.Margin = New Padding(3, 4, 3, 4)
        contactno.Name = "contactno"
        contactno.Size = New Size(282, 27)
        contactno.TabIndex = 44
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Location = New Point(974, 131)
        Label24.Name = "Label24"
        Label24.Size = New Size(94, 20)
        Label24.TabIndex = 45
        Label24.Text = "Date of birth"
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Location = New Point(575, 671)
        Label25.Name = "Label25"
        Label25.Size = New Size(97, 20)
        Label25.TabIndex = 47
        Label25.Text = "Place of birth"
        ' 
        ' placeofbirth
        ' 
        placeofbirth.Location = New Point(670, 667)
        placeofbirth.Margin = New Padding(3, 4, 3, 4)
        placeofbirth.Name = "placeofbirth"
        placeofbirth.Size = New Size(267, 27)
        placeofbirth.TabIndex = 48
        ' 
        ' calendar
        ' 
        calendar.Location = New Point(1082, 172)
        calendar.Margin = New Padding(10, 12, 10, 12)
        calendar.Name = "calendar"
        calendar.TabIndex = 49
        ' 
        ' datebirth
        ' 
        datebirth.Location = New Point(1082, 125)
        datebirth.Margin = New Padding(3, 4, 3, 4)
        datebirth.Name = "datebirth"
        datebirth.Size = New Size(257, 27)
        datebirth.TabIndex = 50
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Location = New Point(974, 67)
        Label26.Name = "Label26"
        Label26.Size = New Size(101, 20)
        Label26.TabIndex = 51
        Label26.Text = "Email address"
        ' 
        ' emailadds
        ' 
        emailadds.Location = New Point(1082, 60)
        emailadds.Margin = New Padding(3, 4, 3, 4)
        emailadds.Name = "emailadds"
        emailadds.Size = New Size(257, 27)
        emailadds.TabIndex = 52
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Location = New Point(257, 677)
        Label27.Name = "Label27"
        Label27.Size = New Size(99, 20)
        Label27.TabIndex = 53
        Label27.Text = "Telephone no"
        ' 
        ' telephoneno
        ' 
        telephoneno.Location = New Point(354, 673)
        telephoneno.Margin = New Padding(3, 4, 3, 4)
        telephoneno.Name = "telephoneno"
        telephoneno.Size = New Size(185, 27)
        telephoneno.TabIndex = 54
        ' 
        ' gender
        ' 
        gender.Location = New Point(794, 16)
        gender.Margin = New Padding(3, 4, 3, 4)
        gender.Name = "gender"
        gender.Size = New Size(142, 27)
        gender.TabIndex = 55
        ' 
        ' course
        ' 
        course.FormattingEnabled = True
        course.Location = New Point(325, 123)
        course.Margin = New Padding(3, 4, 3, 4)
        course.Name = "course"
        course.Size = New Size(121, 28)
        course.TabIndex = 56
        ' 
        ' appointment
        ' 
        appointment.Location = New Point(1085, 435)
        appointment.Margin = New Padding(3, 4, 3, 4)
        appointment.Name = "appointment"
        appointment.Size = New Size(257, 27)
        appointment.TabIndex = 59
        ' 
        ' appointmentcalendar
        ' 
        appointmentcalendar.Location = New Point(1085, 481)
        appointmentcalendar.Margin = New Padding(10, 12, 10, 12)
        appointmentcalendar.Name = "appointmentcalendar"
        appointmentcalendar.TabIndex = 58
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Location = New Point(976, 440)
        Label28.Name = "Label28"
        Label28.Size = New Size(88, 20)
        Label28.TabIndex = 57
        Label28.Text = "Apointment"
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.Location = New Point(259, 731)
        Label29.Name = "Label29"
        Label29.Size = New Size(134, 20)
        Label29.TabIndex = 60
        Label29.Text = "Student Complains"
        ' 
        ' complain
        ' 
        complain.BorderStyle = BorderStyle.FixedSingle
        complain.Location = New Point(383, 731)
        complain.Margin = New Padding(3, 4, 3, 4)
        complain.Multiline = True
        complain.Name = "complain"
        complain.Size = New Size(961, 157)
        complain.TabIndex = 61
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1363, 919)
        Controls.Add(complain)
        Controls.Add(Label29)
        Controls.Add(appointment)
        Controls.Add(appointmentcalendar)
        Controls.Add(Label28)
        Controls.Add(course)
        Controls.Add(gender)
        Controls.Add(telephoneno)
        Controls.Add(Label27)
        Controls.Add(emailadds)
        Controls.Add(Label26)
        Controls.Add(datebirth)
        Controls.Add(calendar)
        Controls.Add(placeofbirth)
        Controls.Add(Label25)
        Controls.Add(Label24)
        Controls.Add(contactno)
        Controls.Add(Label23)
        Controls.Add(relationship)
        Controls.Add(Label22)
        Controls.Add(address)
        Controls.Add(Label21)
        Controls.Add(incident)
        Controls.Add(Label20)
        Controls.Add(employer)
        Controls.Add(Label19)
        Controls.Add(religion)
        Controls.Add(Label18)
        Controls.Add(genave)
        Controls.Add(Label17)
        Controls.Add(provincialadds)
        Controls.Add(Label16)
        Controls.Add(cityadds)
        Controls.Add(Label15)
        Controls.Add(complexion)
        Controls.Add(Label14)
        Controls.Add(mobileno)
        Controls.Add(Label13)
        Controls.Add(weight)
        Controls.Add(height)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(id)
        Controls.Add(Label10)
        Controls.Add(female)
        Controls.Add(male)
        Controls.Add(Label9)
        Controls.Add(status)
        Controls.Add(section)
        Controls.Add(Label8)
        Controls.Add(year)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(middlenamefillup)
        Controls.Add(lastnamefillup)
        Controls.Add(namefillup)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form3"
        StartPosition = FormStartPosition.Manual
        Text = "Form3"
        WindowState = FormWindowState.Minimized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(logo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents pfpname As Label
    Friend WithEvents emaildisplay As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents namefillup As TextBox
    Friend WithEvents lastnamefillup As TextBox
    Friend WithEvents middlenamefillup As TextBox
    Friend WithEvents logout As Button
    Friend WithEvents list As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents logo As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents year As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents section As TextBox
    Friend WithEvents status As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents male As RadioButton
    Friend WithEvents female As RadioButton
    Friend WithEvents Label10 As Label
    Friend WithEvents id As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents height As TextBox
    Friend WithEvents weight As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents mobileno As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents complexion As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cityadds As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents provincialadds As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents saved As Button
    Friend WithEvents genave As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents religion As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents employer As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents incident As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents address As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents relationship As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents contactno As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents placeofbirth As TextBox
    Friend WithEvents calendar As MonthCalendar
    Friend WithEvents datebirth As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents emailadds As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents telephoneno As TextBox
    Friend WithEvents clear As Button
    Friend WithEvents gender As TextBox
    Friend WithEvents course As ComboBox
    Friend WithEvents appointment As TextBox
    Friend WithEvents appointmentcalendar As MonthCalendar
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents complain As TextBox
End Class


