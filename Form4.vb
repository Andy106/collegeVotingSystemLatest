Imports System.Data
Imports System.Data.SqlClient


Public Class Form4

    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-3CJLEOD\SQLEXPRESS;Initial Catalog=collegeVotingDB;Integrated Security=True")

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
    
        con.Open()
        
        Dim cmd1 As SqlCommand = New SqlCommand("SELECT [student_id]
        FROM [collegeVotingDB].[dbo].[candidate] where student_id = '" + TextBoxSID.Text + "'", con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd1)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)
        
        If (dt.Rows.Count = 0) Then
        Dim cmd As SqlCommand = New SqlCommand("INSERT INTO [dbo].[candidate]
           ([student_id]
           ,[name]
           ,[party]
           ,[post]
           ,[year])
        VALUES
           ('" + TextBoxSID.Text + "','" + TextBoxName.Text + "','" + TextBoxParty.Text + "','" + ComboBoxPost.SelectedItem.ToString() + "','" + ComboBoxYear.SelectedItem.ToString() + "')", con)
        cmd.ExecuteNonQuery()
            MessageBox.Show("Registration done!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
          MessageBox.Show("Candidate is already registered!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        
        con.Close()
    End Sub

End Class