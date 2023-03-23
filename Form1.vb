Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class Form1

    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-3CJLEOD\SQLEXPRESS;Initial Catalog=collegeVotingDB;Integrated Security=True")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.Open()
        Dim cmd As SqlCommand = New SqlCommand("SELECT [username]
      ,[password]
  FROM [collegeVotingDB].[dbo].[userLogin] where [username] = '" + TextBoxUserName.Text + "' and [password] = '" + TextBoxPassword.Text + "' and [login_count] IS NULL", con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)
        If (dt.Rows.Count > 0) Then
            If (TextBoxUserName.Text = "admin") Then
                Form5.Show()
                Me.Hide()
            Else
                Dim cmd2 As SqlCommand = New SqlCommand("UPDATE [collegeVotingDB].[dbo].[userLogin] SET [login_count] = 1 where [username] = '" + TextBoxUserName.Text + "'", con)
                cmd2.ExecuteNonQuery()

                Form2.Show()
                Me.Hide()
            End If
        Else
            MessageBox.Show("You are either not registered or have already cast your vote!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form6.Show()
        Me.Hide()
    End Sub
End Class
