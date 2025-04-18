<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        backbtn = New Button()
        regbtn = New Button()
        username = New TextBox()
        email = New TextBox()
        password = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        seepass2 = New CheckBox()
        Label5 = New Label()
        Label4 = New Label()
        Label6 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' backbtn
        ' 
        backbtn.Location = New Point(433, 377)
        backbtn.Name = "backbtn"
        backbtn.Size = New Size(117, 38)
        backbtn.TabIndex = 0
        backbtn.Text = "Back"
        backbtn.UseVisualStyleBackColor = True
        ' 
        ' regbtn
        ' 
        regbtn.Location = New Point(584, 377)
        regbtn.Name = "regbtn"
        regbtn.Size = New Size(117, 38)
        regbtn.TabIndex = 1
        regbtn.Text = "Register now"
        regbtn.UseVisualStyleBackColor = True
        ' 
        ' username
        ' 
        username.Location = New Point(430, 176)
        username.Name = "username"
        username.Size = New Size(271, 23)
        username.TabIndex = 2
        ' 
        ' email
        ' 
        email.Location = New Point(430, 231)
        email.Name = "email"
        email.Size = New Size(271, 23)
        email.TabIndex = 3
        ' 
        ' password
        ' 
        password.Location = New Point(430, 289)
        password.Name = "password"
        password.PasswordChar = "*"c
        password.Size = New Size(271, 23)
        password.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(430, 149)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 15)
        Label1.TabIndex = 5
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(430, 204)
        Label2.Name = "Label2"
        Label2.Size = New Size(36, 15)
        Label2.TabIndex = 6
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(433, 266)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 15)
        Label3.TabIndex = 7
        Label3.Text = "Password"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.df4e968f_5a9f_4bc0_bc7d_aba5cedd3f60_removebg_preview__2_
        PictureBox1.Location = New Point(21, 70)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(364, 345)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' seepass2
        ' 
        seepass2.AutoSize = True
        seepass2.Location = New Point(604, 327)
        seepass2.Name = "seepass2"
        seepass2.Size = New Size(97, 19)
        seepass2.TabIndex = 9
        seepass2.Text = "See Password"
        seepass2.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(429, 99)
        Label5.Name = "Label5"
        Label5.Size = New Size(310, 14)
        Label5.TabIndex = 16
        Label5.Text = "Of St. Augustine Colleges School Foundation Inc."
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(438, 70)
        Label4.Name = "Label4"
        Label4.Size = New Size(276, 19)
        Label4.TabIndex = 15
        Label4.Text = "And Student Information System"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(429, 49)
        Label6.Name = "Label6"
        Label6.Size = New Size(299, 19)
        Label6.TabIndex = 14
        Label6.Text = "Counseling, Guidance Management,"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(786, 501)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label6)
        Controls.Add(seepass2)
        Controls.Add(PictureBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(password)
        Controls.Add(email)
        Controls.Add(username)
        Controls.Add(regbtn)
        Controls.Add(backbtn)
        Name = "Form2"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents backbtn As Button
    Friend WithEvents regbtn As Button
    Friend WithEvents username As TextBox
    Friend WithEvents email As TextBox
    Friend WithEvents password As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents seepass2 As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
End Class
