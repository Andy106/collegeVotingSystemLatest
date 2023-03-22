Imports System.Data.SqlClient

Public Class Form3

    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-3CJLEOD\SQLEXPRESS;Initial Catalog=collegeVotingDB;Integrated Security=True")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As SqlCommand = New SqlCommand("
    INSERT INTO [dbo].[userlogin]
           ([student_id]
           ,[username]
           ,[password])
     VALUES
           ('" + TextBoxStudentID.Text + "','" + TextBoxUserName.Text + "','" + TextBoxPassword.Text + "')", con)
        con.Open()
        cmd.ExecuteNonQuery()
        MessageBox.Show("Registration Done!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        con.Close()
    End Sub
End Class