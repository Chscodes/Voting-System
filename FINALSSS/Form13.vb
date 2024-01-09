Imports MySql.Data.MySqlClient
Public Class Form13
    Public connection As New MySqlConnection("host=localhost; user=root; password=;database=votenn;")
    Dim command As MySqlCommand
    Dim dataReader As MySqlDataReader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form10.Show()

    End Sub
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.CenterToScreen()

    End Sub
    Private Sub VotersRegister()
        DataGridView1.Rows.Clear()
        connection.Open()
        command = New MySqlCommand("select VotersID, Name from nn_votedlist ", connection)
        dataReader = command.ExecuteReader

        While dataReader.Read
            Dim colVotersID = dataReader.GetString("VotersID")
            Dim colName = dataReader.GetString("Name")
            DataGridView1.Rows.Add(colVotersID, colName)
        End While
        connection.Close()
    End Sub

    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VotersRegister()

    End Sub
End Class