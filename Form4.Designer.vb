<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Label5 = New Label()
        TextBoxSID = New TextBox()
        TextBoxName = New TextBox()
        TextBoxParty = New TextBox()
        ComboBoxPost = New ComboBox()
        ComboBoxYear = New ComboBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(104, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 20)
        Label1.TabIndex = 0
        Label1.Text = "Student ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(104, 135)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 1
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(104, 216)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 20)
        Label3.TabIndex = 2
        Label3.Text = "Party"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(104, 299)
        Label4.Name = "Label4"
        Label4.Size = New Size(36, 20)
        Label4.TabIndex = 3
        Label4.Text = "Post"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(104, 388)
        Label5.Name = "Label5"
        Label5.Size = New Size(37, 20)
        Label5.TabIndex = 4
        Label5.Text = "Year"
        ' 
        ' TextBoxSID
        ' 
        TextBoxSID.Location = New Point(294, 63)
        TextBoxSID.Name = "TextBoxSID"
        TextBoxSID.Size = New Size(151, 27)
        TextBoxSID.TabIndex = 5
        ' 
        ' TextBoxName
        ' 
        TextBoxName.Location = New Point(294, 135)
        TextBoxName.Name = "TextBoxName"
        TextBoxName.Size = New Size(151, 27)
        TextBoxName.TabIndex = 6
        ' 
        ' TextBoxParty
        ' 
        TextBoxParty.Location = New Point(294, 216)
        TextBoxParty.Name = "TextBoxParty"
        TextBoxParty.Size = New Size(151, 27)
        TextBoxParty.TabIndex = 7
        ' 
        ' ComboBoxPost
        ' 
        ComboBoxPost.FormattingEnabled = True
        ComboBoxPost.Items.AddRange(New Object() {"President", "Vice President"})
        ComboBoxPost.Location = New Point(294, 302)
        ComboBoxPost.Name = "ComboBoxPost"
        ComboBoxPost.Size = New Size(151, 28)
        ComboBoxPost.TabIndex = 8
        ' 
        ' ComboBoxYear
        ' 
        ComboBoxYear.FormattingEnabled = True
        ComboBoxYear.Items.AddRange(New Object() {"2023", "2022"})
        ComboBoxYear.Location = New Point(294, 367)
        ComboBoxYear.Name = "ComboBoxYear"
        ComboBoxYear.Size = New Size(151, 28)
        ComboBoxYear.TabIndex = 9
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(614, 372)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 10
        Button1.Text = "Submit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(ComboBoxYear)
        Controls.Add(ComboBoxPost)
        Controls.Add(TextBoxParty)
        Controls.Add(TextBoxName)
        Controls.Add(TextBoxSID)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form4"
        Text = "Candidate Registration"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxSID As TextBox
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxParty As TextBox
    Friend WithEvents ComboBoxPost As ComboBox
    Friend WithEvents ComboBoxYear As ComboBox
    Friend WithEvents Button1 As Button
End Class
