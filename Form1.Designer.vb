<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        TextBoxUserName = New TextBox()
        TextBoxPassword = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(165, 90)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 20)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(165, 219)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 20)
        Label2.TabIndex = 1
        Label2.Text = "Password"
        ' 
        ' TextBoxUserName
        ' 
        TextBoxUserName.Location = New Point(378, 84)
        TextBoxUserName.Name = "TextBoxUserName"
        TextBoxUserName.Size = New Size(125, 27)
        TextBoxUserName.TabIndex = 2
        ' 
        ' TextBoxPassword
        ' 
        TextBoxPassword.Location = New Point(380, 216)
        TextBoxPassword.Name = "TextBoxPassword"
        TextBoxPassword.Size = New Size(125, 27)
        TextBoxPassword.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(619, 360)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 4
        Button1.Text = "Submit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(25, 402)
        Button2.Name = "Button2"
        Button2.Size = New Size(210, 29)
        Button2.TabIndex = 5
        Button2.Text = "Click to see Voting Results"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBoxPassword)
        Controls.Add(TextBoxUserName)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxUserName As TextBox
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
