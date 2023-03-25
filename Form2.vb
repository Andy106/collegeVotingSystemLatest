Imports System.Data
Imports System.Data.SqlClient

Public Class Form2

    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-3CJLEOD\SQLEXPRESS;Initial Catalog=collegeVotingDB;Integrated Security=True")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.Open()
        Dim cmd As New SqlCommand("SELECT [student_id]
      ,[name]
      ,[party]
      ,[post]
      ,[year]
  FROM [collegeVotingDB].[dbo].[candidate]", con)
        Dim sda As New SqlDataAdapter
        sda.SelectCommand = cmd
        Dim table As New DataTable
        table.Clear()
        sda.Fill(table)
        DataGridView1.DataSource = table
        con.Close()
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        con.Open()



        Dim cmd As SqlCommand = New SqlCommand("INSERT INTO [dbo].[vote]
           ([student_id]
           ,[vote])
     VALUES
           ('" + TextBoxVoteSID.Text + "','1')", con)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Vote submitted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        con.Close()
    End Sub


End Class