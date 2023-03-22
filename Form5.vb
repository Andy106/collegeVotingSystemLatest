Imports System.Data
Imports System.Data.SqlClient

Public Class Form5


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (ComboBoxRegister.SelectedItem.ToString() = "Voter") Then
            Form3.Show()
            Me.Hide()
        Else
            Form4.Show()
            Me.Hide()
        End If
    End Sub
End Class