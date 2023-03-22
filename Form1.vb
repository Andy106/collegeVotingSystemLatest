Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class Form1

    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-3CJLEOD\SQLEXPRESS;Initial Catalog=collegeVotingDB;Integrated Security=True")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As SqlCommand = New SqlCommand("SELECT [username]
      ,[password]
  FROM [collegeVotingDB].[dbo].[userLogin] where [username] = '" + TextBoxUserName.Text + "' and [password] = '" + TextBoxPassword.Text + "'", con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)
        If (dt.Rows.Count > 0) Then
            If (TextBoxUserName.Text = "admin") Then
                Form5.Show()
                Me.Hide()
            Else
                Form2.Show()
                Me.Hide()
            End If
        Else
            MessageBox.Show("Error", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub
End Class
