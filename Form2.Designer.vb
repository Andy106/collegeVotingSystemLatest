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
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        Button1 = New Button()
        Label2 = New Label()
        TextBoxVoteSID = New TextBox()
        Label3 = New Label()
        Button2 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(47, 82)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(695, 223)
        DataGridView1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(47, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 20)
        Label1.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(604, 28)
        Button1.Name = "Button1"
        Button1.Size = New Size(138, 29)
        Button1.TabIndex = 2
        Button1.Text = "Click here"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(47, 32)
        Label2.Name = "Label2"
        Label2.Size = New Size(264, 20)
        Label2.TabIndex = 3
        Label2.Text = "Step 1 - Click button to see candidates"
        ' 
        ' TextBoxVoteSID
        ' 
        TextBoxVoteSID.Location = New Point(604, 342)
        TextBoxVoteSID.Name = "TextBoxVoteSID"
        TextBoxVoteSID.Size = New Size(138, 27)
        TextBoxVoteSID.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(47, 342)
        Label3.Name = "Label3"
        Label3.Size = New Size(374, 20)
        Label3.TabIndex = 5
        Label3.Text = "Step 2 - Enter Student ID of candiate you are voting for"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(634, 398)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 6
        Button2.Text = "Cast Vote"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Label3)
        Controls.Add(TextBoxVoteSID)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Name = "Form2"
        Text = "Vote"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxVoteSID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
End Class
