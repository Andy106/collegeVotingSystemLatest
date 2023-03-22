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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBoxStudentID = New TextBox()
        TextBoxUserName = New TextBox()
        TextBoxPassword = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(237, 71)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 20)
        Label1.TabIndex = 0
        Label1.Text = "Student ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(237, 168)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 20)
        Label2.TabIndex = 1
        Label2.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(242, 283)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 20)
        Label3.TabIndex = 2
        Label3.Text = "Password"
        ' 
        ' TextBoxStudentID
        ' 
        TextBoxStudentID.Location = New Point(398, 71)
        TextBoxStudentID.Name = "TextBoxStudentID"
        TextBoxStudentID.Size = New Size(125, 27)
        TextBoxStudentID.TabIndex = 3
        ' 
        ' TextBoxUserName
        ' 
        TextBoxUserName.Location = New Point(398, 165)
        TextBoxUserName.Name = "TextBoxUserName"
        TextBoxUserName.Size = New Size(125, 27)
        TextBoxUserName.TabIndex = 4
        ' 
        ' TextBoxPassword
        ' 
        TextBoxPassword.Location = New Point(398, 280)
        TextBoxPassword.Name = "TextBoxPassword"
        TextBoxPassword.Size = New Size(125, 27)
        TextBoxPassword.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(630, 377)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 6
        Button1.Text = "Submit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(TextBoxPassword)
        Controls.Add(TextBoxUserName)
        Controls.Add(TextBoxStudentID)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form3"
        Text = "Voter Registration"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxStudentID As TextBox
    Friend WithEvents TextBoxUserName As TextBox
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents Button1 As Button
End Class
