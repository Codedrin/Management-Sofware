<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        loginbtn = New Button()
        registerbtn = New Button()
        forgotbtn = New Button()
        passtxt = New TextBox()
        emaltxt = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        seepass1 = New CheckBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' loginbtn
        ' 
        loginbtn.Location = New Point(479, 310)
        loginbtn.Name = "loginbtn"
        loginbtn.Size = New Size(224, 37)
        loginbtn.TabIndex = 0
        loginbtn.Text = "Log in "
        loginbtn.UseVisualStyleBackColor = True
        ' 
        ' registerbtn
        ' 
        registerbtn.Location = New Point(479, 353)
        registerbtn.Name = "registerbtn"
        registerbtn.Size = New Size(224, 37)
        registerbtn.TabIndex = 1
        registerbtn.Text = "Register"
        registerbtn.UseVisualStyleBackColor = True
        ' 
        ' forgotbtn
        ' 
        forgotbtn.Location = New Point(479, 396)
        forgotbtn.Name = "forgotbtn"
        forgotbtn.Size = New Size(224, 37)
        forgotbtn.TabIndex = 2
        forgotbtn.Text = "Forgot Password"
        forgotbtn.UseVisualStyleBackColor = True
        ' 
        ' passtxt
        ' 
        passtxt.BackColor = Color.White
        passtxt.BorderStyle = BorderStyle.FixedSingle
        passtxt.Cursor = Cursors.IBeam
        passtxt.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        passtxt.ForeColor = Color.Black
        passtxt.Location = New Point(436, 218)
        passtxt.Name = "passtxt"
        passtxt.PasswordChar = "*"c
        passtxt.Size = New Size(315, 27)
        passtxt.TabIndex = 3
        passtxt.WordWrap = False
        ' 
        ' emaltxt
        ' 
        emaltxt.BackColor = Color.White
        emaltxt.BorderStyle = BorderStyle.FixedSingle
        emaltxt.Cursor = Cursors.IBeam
        emaltxt.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        emaltxt.ForeColor = Color.Black
        emaltxt.ImeMode = ImeMode.NoControl
        emaltxt.Location = New Point(436, 152)
        emaltxt.Name = "emaltxt"
        emaltxt.Size = New Size(315, 27)
        emaltxt.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(436, 124)
        Label1.Name = "Label1"
        Label1.Size = New Size(36, 15)
        Label1.TabIndex = 5
        Label1.Text = "Email"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(436, 200)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 6
        Label2.Text = "Password"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.df4e968f_5a9f_4bc0_bc7d_aba5cedd3f60_removebg_preview__2_
        PictureBox1.Location = New Point(29, 88)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(364, 345)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' seepass1
        ' 
        seepass1.AutoSize = True
        seepass1.Location = New Point(654, 261)
        seepass1.Name = "seepass1"
        seepass1.Size = New Size(97, 19)
        seepass1.TabIndex = 8
        seepass1.Text = "See Password"
        seepass1.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(436, 88)
        Label5.Name = "Label5"
        Label5.Size = New Size(310, 14)
        Label5.TabIndex = 16
        Label5.Text = "Of St. Augustine Colleges School Foundation Inc."
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(445, 59)
        Label4.Name = "Label4"
        Label4.Size = New Size(276, 19)
        Label4.TabIndex = 15
        Label4.Text = "And Student Information System"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(436, 38)
        Label3.Name = "Label3"
        Label3.Size = New Size(299, 19)
        Label3.TabIndex = 14
        Label3.Text = "Counseling, Guidance Management,"
        ' 
        ' Form1
        ' 
        AllowDrop = True
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CausesValidation = False
        ClientSize = New Size(794, 504)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(seepass1)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(emaltxt)
        Controls.Add(passtxt)
        Controls.Add(forgotbtn)
        Controls.Add(registerbtn)
        Controls.Add(loginbtn)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents loginbtn As Button
    Friend WithEvents registerbtn As Button
    Friend WithEvents forgotbtn As Button
    Friend WithEvents passtxt As TextBox
    Friend WithEvents emaltxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents seepass1 As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label

End Class
