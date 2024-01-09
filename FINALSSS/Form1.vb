Imports MySql.Data.MySqlClient
Public Class Form1
    Public connection As New MySqlConnection("host=localhost; user=root; password=;database=votenn;")
    Dim command As MySqlCommand
    Dim dataReader As MySqlDataReader

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form9.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.ShowDialog()
    End Sub
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.CenterToScreen()

    End Sub

End Class
