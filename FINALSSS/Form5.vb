Imports MySql.Data.MySqlClient
Public Class Form5
    Public connection As New MySqlConnection("host=localhost; user=root; password=;database=votenn;")
    Dim command As MySqlCommand
    Dim dataReader As MySqlDataReader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Ready()
    End Sub

    Public Sub clearText()
        TextBox1.Text = Nothing
        TextBox2.Text = Nothing
        TextBox3.Text = Nothing
        ComboBox4.Text = Nothing
        ComboBox3.Text = Nothing
        ComboBox1.Text = Nothing
        ComboBox2.Text = Nothing
    End Sub
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CenterToScreen()
    End Sub
    Public Sub Ready()

        If ComboBox2.Text = "President" And ComboBox4.Text = "1st Year" Then
            MessageBox.Show("The Position is not Suitable For 1st Year! ")
        ElseIf ComboBox2.Text = "Vice President" And ComboBox4.Text = "1st Year" Then
            MessageBox.Show("The Position is not Suitable For 1st Year! ")
        ElseIf ComboBox2.Text = "Secretary" And ComboBox4.Text = "1st Year" Then
            MessageBox.Show("The Position is not Suitable For 1st Year! ")
        ElseIf ComboBox2.Text = "Auditor" And ComboBox4.Text = "1st Year" Then
            MessageBox.Show("The Position is not Suitable For 1st Year! ")
        ElseIf ComboBox2.Text = "Treasurer" And ComboBox4.Text = "1st Year" Then
            MessageBox.Show("The Position is not Suitable For 1st Year! ")
        ElseIf ComboBox2.Text = "PRO-Male" And ComboBox4.Text = "1st Year" Then
            MessageBox.Show("The Position is not Suitable For 1st Year! ")
        ElseIf ComboBox2.Text = "PRO-Female" And ComboBox4.Text = "1st Year" Then
            MessageBox.Show("The Position is not Suitable For 1st Year! ")

        ElseIf ComboBox2.Text = "President" And ComboBox4.Text = "2nd Year" Then
            MessageBox.Show("The Position is not Suitable For 2nd Year! ")
        ElseIf ComboBox2.Text = "Vice President" And ComboBox4.Text = "2nd Year" Then
            MessageBox.Show("The Position is not Suitable For 2nd Year! ")
        ElseIf ComboBox2.Text = "Secretary" And ComboBox4.Text = "2nd Year" Then
            MessageBox.Show("The Position is not Suitable For 2nd Year! ")
        ElseIf ComboBox2.Text = "Auditor" And ComboBox4.Text = "2nd Year" Then
            MessageBox.Show("The Position is not Suitable For 2nd Year! ")
        ElseIf ComboBox2.Text = "Treasurer" And ComboBox4.Text = "2nd Year" Then
            MessageBox.Show("The Position is not Suitable For 2nd Year! ")
        ElseIf ComboBox2.Text = "PRO-Male" And ComboBox4.Text = "2nd Year" Then
            MessageBox.Show("The Position is not Suitable For 2nd Year! ")
        ElseIf ComboBox2.Text = "PRO-Female" And ComboBox4.Text = "2nd Year" Then
            MessageBox.Show("The Position is not Suitable For 2nd Year! ")
        Else
            Partylist()
        End If
    End Sub
    Public Sub Need()
        If TextBox1.Text = Nothing Then
            MessageBox.Show("Please Fill The Empty Space!")
        ElseIf TextBox2.Text = Nothing Then
            MessageBox.Show("Please Fill The Empty Space!")
        ElseIf TextBox3.Text = Nothing Then
            MessageBox.Show("Please Fill The Empty Space!")
        ElseIf ComboBox4.Text = Nothing Then
            MessageBox.Show("Please Fill The Empty Space!")
        ElseIf ComboBox1.Text = Nothing Then
            MessageBox.Show("Please Fill The Empty Space!")
        ElseIf ComboBox2.Text = Nothing Then
            MessageBox.Show("Please Fill The Empty Space!")
        ElseIf ComboBox3.Text = Nothing Then
            MessageBox.Show("Please Fill The Empty Space!")
        Else Register()
        End If
    End Sub
    Public Sub Partylist()
        connection.Open()
        command = New MySqlCommand("select * from nn_candidate  where Partylist='" & ComboBox1.Text & "' and Position='" & ComboBox2.Text & "'", connection)
        dataReader = command.ExecuteReader
        Dim Ready As Integer
        Ready = 0
        While dataReader.Read
            Ready = Ready + 1
        End While

        If Ready = 1 Then
            MessageBox.Show("ONLY ONE CANDIDATE EVERY POSITION PER PARTYLIST")

            connection.Close()

        Else
            connection.Close()
            Need()
        End If
    End Sub


    'DITO ako NAg Edit
    'VotersID='" & TextBox1.Text & "' and Name='" & TextBox2.Text & "' and Age='" & TextBox3.Text & "'
    Public Sub Register()

        connection.Open()
        command = New MySqlCommand("Insert into nn_candidate (CandidateID, Name, Birthdate, Age, Gender, YearLevel, PartyList, Position) values (@CandidateID, @Name, @Birthdate, @Age, @Gender, @YearLevel, @PartyList, @Position)", connection)
        command.Parameters.Add(New MySqlParameter("@CandidateID", MySqlDbType.VarChar, 50)).Value = TextBox1.Text
        command.Parameters.Add(New MySqlParameter("@Name", MySqlDbType.VarChar, 50)).Value = TextBox2.Text
        command.Parameters.Add(New MySqlParameter("@Birthdate", DateTimePicker1.Value.Date))
        command.Parameters.Add(New MySqlParameter("@Age", MySqlDbType.VarChar, 50)).Value = TextBox3.Text
        command.Parameters.Add(New MySqlParameter("@Gender", MySqlDbType.VarChar, 50)).Value = ComboBox3.Text
        command.Parameters.Add(New MySqlParameter("@YearLevel", MySqlDbType.VarChar, 50)).Value = ComboBox4.Text
        command.Parameters.Add(New MySqlParameter("@PartyList", MySqlDbType.VarChar, 50)).Value = ComboBox1.Text
        command.Parameters.Add(New MySqlParameter("@Position", MySqlDbType.VarChar, 50)).Value = ComboBox2.Text
        command.ExecuteNonQuery()
        connection.Close()
        MessageBox.Show("Your Entry Now Saved!")
        clearText()
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Hide()
    End Sub
    Private Sub UsersForms_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        viewer()
    End Sub
    Private Sub viewer()
        ComboBox1.Items.Clear()
        connection.Open()
        command = New MySqlCommand("select Name from nn_partylist", connection)
        dataReader = command.ExecuteReader

        While dataReader.Read
            Dim colName = dataReader.GetString("Name")
            ComboBox1.Items.Add(colName)
        End While
        connection.Close()
    End Sub


    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim myage As New Integer

        myage = DateTime.Today.Year - DateTimePicker1.Value.Year
        TextBox3.Text = myage.ToString()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click

        connection.Open()
        command = New MySqlCommand("select * from nn_votersid where VotersID='" & TextBox1.Text & "'", connection)
        dataReader = command.ExecuteReader
        Dim Regist As Integer
        Regist = 0
        While dataReader.Read
            Regist = Regist + 1
        End While

        If Regist = 1 Then
            TextBox2.Text = dataReader.GetString("Name")
            TextBox3.Text = dataReader.GetString("Age")
            DateTimePicker1.Text = dataReader.GetMySqlDateTime("Birthdate")
            ComboBox3.Text = dataReader.GetString("Gender")
            ComboBox4.Text = dataReader.GetString("Yearlevel")
        End If
        connection.Close()
    End Sub
End Class