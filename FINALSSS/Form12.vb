Imports MySql.Data.MySqlClient
Public Class Form12
    Public connection As New MySqlConnection("host=localhost; user=root; password=;database=votenn;")
    Dim command As MySqlCommand
    Dim dataReader As MySqlDataReader
    Private Sub Candidate()
        DataGridView1.Rows.Clear()
        connection.Open()
        command = New MySqlCommand("select Name, Birthdate, Age, Gender, PartyList, YearLevel, Position from nn_candidate where Position = '" & ComboBox1.Text & "'", connection)
        dataReader = command.ExecuteReader

        While dataReader.Read
            Dim colName = dataReader.GetString("Name")
            Dim colBirthdate = dataReader.GetMySqlDateTime("Birthdate")
            Dim colAge = dataReader.GetString("Age")
            Dim colGender = dataReader.GetString("Gender")
            Dim colYearLevel = dataReader.GetString("YearLevel")
            Dim colPartyList = dataReader.GetString("PartyList")
            Dim colPosition = dataReader.GetString("Position")


            DataGridView1.Rows.Add(colName, colBirthdate, colAge, colGender, colYearLevel, colPartyList, colPosition)
        End While
        connection.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form10.Show()

    End Sub
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.CenterToScreen()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Candidate()
    End Sub
End Class