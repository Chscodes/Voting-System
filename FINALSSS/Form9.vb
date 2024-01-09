Imports MySql.Data.MySqlClient
Public Class Form9
    Public connection As New MySqlConnection("host=localhost; user=root; password=;database=votenn;")
    Dim command As MySqlCommand
    Dim dataReader As MySqlDataReader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Log()
        ClearText()
    End Sub
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.CenterToScreen()

    End Sub
    Public Sub ClearText()
        TextBox1.Text = Nothing
    End Sub
    Public Sub Log()
        connection.Open()
        command = New MySqlCommand("select * from nn_admin where Password='" & TextBox1.Text & "'", connection)
        dataReader = Command.ExecuteReader
        Dim Login As Integer
        Login = 0
        While dataReader.Read
            Login = Login + 1
        End While

        If Login = 1 Then
            Me.Hide()
            Form10.ShowDialog()
        Else
            MessageBox.Show("Please log the admin's passcode!")
        End If
        connection.Close()
    End Sub
End Class