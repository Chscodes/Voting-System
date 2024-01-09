Imports MySql.Data.MySqlClient
Public Class Form8
    Public connection As New MySqlConnection("host=localhost; user=root; password=;database=votenn;")
    Dim command As MySqlCommand
    Dim dataReader As MySqlDataReader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form9.ShowDialog()
    End Sub
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.CenterToScreen()

    End Sub
    Private Sub Voted()
        DataGridView1.Rows.Clear()
        connection.Open()
        command = New MySqlCommand("select VotersID, Name, President, VicePresident, Secretary, Treasurer, Auditor, ProMale, ProFemale, Muse, Escort, FirstRep, SecondRep, ThirdRep from nn_votedlist", connection)
        dataReader = Command.ExecuteReader

        While dataReader.Read
            Dim colVotersID = dataReader.GetString("VotersID")
            Dim colName = dataReader.GetString("Name")
            Dim colPres = dataReader.GetString("President")
            Dim colVP = dataReader.GetString("VicePresident")
            Dim colSec = dataReader.GetString("Secretary")
            Dim colTreasurer = dataReader.GetString("Treasurer")
            Dim colAuditor = dataReader.GetString("Auditor")
            Dim colPM = dataReader.GetString("ProMale")
            Dim colFM = dataReader.GetString("PRoFemale")
            Dim colMuse = dataReader.GetString("Muse")
            Dim colEscort = dataReader.GetString("Escort")
            Dim col1stRep = dataReader.GetString("FirstRep")
            Dim col2ndRep = dataReader.GetString("SecondRep")
            Dim col3rdRep = dataReader.GetString("Thirdrep")


            DataGridView1.Rows.Add(colVotersID, colName, colPres, colVP, colSec, colTreasurer, colAuditor, colPM, colFM, colMuse, colEscort, col1stRep, col2ndRep, col3rdRep)
        End While
        connection.Close()
    End Sub
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Voted
    End Sub
End Class