Imports System.Data.SqlClient

Public Class Form6

    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-3CJLEOD\SQLEXPRESS;Initial Catalog=collegeVotingDB;Integrated Security=True")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.Open()
        Dim cmd As New SqlCommand("SELECT
        b.post,
        b.student_id,
        b.name,
        b.party,
        a.NoOfVotes
        FROM [collegeVotingDB].[dbo].[candidate] b 
        LEFT JOIN (SELECT student_id, sum(1) as NoOfVotes FROM [collegeVotingDB].[dbo].[vote] GROUP BY student_id) a 
        ON b.student_id = a.student_id 
        WHERE b.year = '2023'
        ORDER BY post, NoOfVotes DESC", con)
        Dim sda As New SqlDataAdapter
        sda.SelectCommand = cmd
        Dim table As New DataTable
        table.Clear()
        sda.Fill(table)
        DataGridView1.DataSource = table
        con.Close()
    End Sub
End Class