<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class forgotpassword
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
        changepass = New Button()
        emalfor = New TextBox()
        newpass = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        backbutton = New Button()
        PictureBox1 = New PictureBox()
        seepass3 = New CheckBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' changepass
        ' 
        changepass.Location = New Point(604, 298)
        changepass.Name = "changepass"
        changepass.Size = New Size(133, 48)
        changepass.TabIndex = 1
        changepass.Text = "Change Password"
        changepass.UseVisualStyleBackColor = True
        ' 
        ' emalfor
        ' 
        emalfor.Location = New Point(446, 147)
        emalfor.Name = "emalfor"
        emalfor.Size = New Size(291, 23)
        emalfor.TabIndex = 2
        ' 
        ' newpass
        ' 
        newpass.Location = New Point(446, 215)
        newpass.Name = "newpass"
        newpass.PasswordChar = "*"c
        newpass.Size = New Size(291, 23)
        newpass.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(446, 126)
        Label1.Name = "Label1"
        Label1.Size = New Size(36, 15)
        Label1.TabIndex = 4
        Label1.Text = "Email"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(446, 189)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 5
        Label2.Text = "Password"
        ' 
        ' backbutton
        ' 
        backbutton.Location = New Point(446, 298)
        backbutton.Name = "backbutton"
        backbutton.Size = New Size(110, 48)
        backbutton.TabIndex = 6
        backbutton.Text = "Back To Main"
        backbutton.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.df4e968f_5a9f_4bc0_bc7d_aba5cedd3f60_removebg_preview__2_
        PictureBox1.Location = New Point(34, 55)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(364, 345)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' seepass3
        ' 
        seepass3.AutoSize = True
        seepass3.Location = New Point(640, 252)
        seepass3.Name = "seepass3"
        seepass3.Size = New Size(97, 19)
        seepass3.TabIndex = 10
        seepass3.Text = "See Password"
        seepass3.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(438, 38)
        Label3.Name = "Label3"
        Label3.Size = New Size(299, 19)
        Label3.TabIndex = 11
        Label3.Text = "Counseling, Guidance Management,"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(447, 59)
        Label4.Name = "Label4"
        Label4.Size = New Size(276, 19)
        Label4.TabIndex = 12
        Label4.Text = "And Student Information System"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(438, 88)
        Label5.Name = "Label5"
        Label5.Size = New Size(310, 14)
        Label5.TabIndex = 13
        Label5.Text = "Of St. Augustine Colleges School Foundation Inc."
        ' 
        ' forgotpassword
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(786, 450)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(seepass3)
        Controls.Add(PictureBox1)
        Controls.Add(backbutton)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(newpass)
        Controls.Add(emalfor)
        Controls.Add(changepass)
        Name = "forgotpassword"
        Text = "forgotpassword"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents changepass As Button
    Friend WithEvents emalfor As TextBox
    Friend WithEvents newpass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents backbutton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents seepass3 As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
