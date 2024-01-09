Imports MySql.Data.MySqlClient
Public Class Form11
    Public connection As New MySqlConnection("host=localhost; user=root; password=;database=votenn;")
    Dim command As MySqlCommand
    Dim dataReader As MySqlDataReader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Form10.Show()
        Me.Close()
    End Sub
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.CenterToScreen()

    End Sub

    Private Sub Voters()
        DataGridView1.Rows.Clear()
        connection.Open()
        command = New MySqlCommand("select VotersID, Name, Birthdate, Age, Gender, YearLevel from nn_votersid ", connection)
        dataReader = command.ExecuteReader

        While dataReader.Read
            Dim colVotersID = dataReader.GetString("VotersID")
            Dim colName = dataReader.GetString("Name")
            Dim colBirthdate = dataReader.GetMySqlDateTime("Birthdate")
            Dim colAge = dataReader.GetString("Age")
            Dim colGender = dataReader.GetString("Gender")
            Dim colYearLevel = dataReader.GetString("YearLevel")


            DataGridView1.Rows.Add(colVotersID, colName, colBirthdate, colAge, colGender, colYearLevel)
        End While
        connection.Close()
    End Sub

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Voters()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class