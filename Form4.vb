Imports System.Data
Imports System.Data.SqlClient


Public Class Form4

    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-3CJLEOD\SQLEXPRESS;Initial Catalog=collegeVotingDB;Integrated Security=True")

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As SqlCommand = New SqlCommand("INSERT INTO [dbo].[candidate]
           ([student_id]
           ,[name]
           ,[party]
           ,[post]
           ,[year])
     VALUES
           ('" + TextBoxSID.Text + "','" + TextBoxName.Text + "','" + TextBoxParty.Text + "','" + ComboBoxPost.SelectedItem.ToString() + "','" + ComboBoxYear.SelectedItem.ToString() + "')", con)
        con.Open()
        cmd.ExecuteNonQuery()
        MessageBox.Show("Registration Done!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        con.Close()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class