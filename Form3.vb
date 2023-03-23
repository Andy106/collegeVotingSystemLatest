Imports System.Data.SqlClient

Public Class Form3

    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-3CJLEOD\SQLEXPRESS;Initial Catalog=collegeVotingDB;Integrated Security=True")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        con.Open()

        Dim cmd1 As SqlCommand = New SqlCommand("SELECT [student_id]
        FROM [collegeVotingDB].[dbo].[userlogin] where student_id = '" + TextBoxStudentID.Text + "'", con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd1)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)

        If (dt.Rows.Count = 0) Then

            Dim cmd As SqlCommand = New SqlCommand("
    INSERT INTO [dbo].[userlogin]
           ([student_id]
           ,[username]
           ,[password])
     VALUES
           ('" + TextBoxStudentID.Text + "','" + TextBoxUserName.Text + "','" + TextBoxPassword.Text + "')", con)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Registration done!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else

            MessageBox.Show("Voter already registered!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)


        End If

        con.Close()
    End Sub
End Class