<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        ComboBoxRegister = New ComboBox()
        Label1 = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' ComboBoxRegister
        ' 
        ComboBoxRegister.FormattingEnabled = True
        ComboBoxRegister.Items.AddRange(New Object() {"Candidate", "Voter"})
        ComboBoxRegister.Location = New Point(444, 140)
        ComboBoxRegister.Name = "ComboBoxRegister"
        ComboBoxRegister.Size = New Size(151, 28)
        ComboBoxRegister.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(181, 140)
        Label1.Name = "Label1"
        Label1.Size = New Size(175, 20)
        Label1.TabIndex = 1
        Label1.Text = "Who are you registering?"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(498, 328)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 2
        Button1.Text = "Submit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(ComboBoxRegister)
        Name = "Form5"
        Text = "Registration Choice"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBoxRegister As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
