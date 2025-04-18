<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Listof_department
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        act = New ListBox()
        bsba = New ListBox()
        bsed = New ListBox()
        beed = New ListBox()
        Label5 = New Label()
        caregiving = New ListBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(55, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 21)
        Label1.TabIndex = 1
        Label1.Text = "BEED "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(230, 29)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 21)
        Label2.TabIndex = 8
        Label2.Text = "BSED"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(403, 29)
        Label3.Name = "Label3"
        Label3.Size = New Size(50, 21)
        Label3.TabIndex = 9
        Label3.Text = "BSBA"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(589, 29)
        Label4.Name = "Label4"
        Label4.Size = New Size(40, 21)
        Label4.TabIndex = 10
        Label4.Text = "ACT"
        ' 
        ' act
        ' 
        act.FormattingEnabled = True
        act.ItemHeight = 15
        act.Location = New Point(528, 63)
        act.Name = "act"
        act.Size = New Size(166, 529)
        act.TabIndex = 4
        ' 
        ' bsba
        ' 
        bsba.FormattingEnabled = True
        bsba.ItemHeight = 15
        bsba.Location = New Point(356, 63)
        bsba.Name = "bsba"
        bsba.Size = New Size(166, 529)
        bsba.TabIndex = 3
        ' 
        ' bsed
        ' 
        bsed.FormattingEnabled = True
        bsed.ItemHeight = 15
        bsed.Location = New Point(184, 63)
        bsed.Name = "bsed"
        bsed.Size = New Size(166, 529)
        bsed.TabIndex = 2
        ' 
        ' beed
        ' 
        beed.FormattingEnabled = True
        beed.ItemHeight = 15
        beed.Location = New Point(12, 63)
        beed.Name = "beed"
        beed.Size = New Size(166, 529)
        beed.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(727, 29)
        Label5.Name = "Label5"
        Label5.Size = New Size(110, 21)
        Label5.TabIndex = 11
        Label5.Text = "CARE GIVING"
        ' 
        ' caregiving
        ' 
        caregiving.FormattingEnabled = True
        caregiving.ItemHeight = 15
        caregiving.Location = New Point(700, 63)
        caregiving.Name = "caregiving"
        caregiving.Size = New Size(166, 529)
        caregiving.TabIndex = 5
        ' 
        ' Listof_department
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MediumSpringGreen
        ClientSize = New Size(876, 610)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(caregiving)
        Controls.Add(act)
        Controls.Add(bsba)
        Controls.Add(bsed)
        Controls.Add(Label1)
        Controls.Add(beed)
        Name = "Listof_department"
        Text = "Listof_department"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents act As ListBox
    Friend WithEvents bsba As ListBox
    Friend WithEvents bsed As ListBox
    Friend WithEvents beed As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents caregiving As ListBox
End Class
