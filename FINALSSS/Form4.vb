Imports MySql.Data.MySqlClient
Public Class Form4
    Public connection As New MySqlConnection("host=localhost; user=root; password=;database=votenn;")
    Dim command As MySqlCommand
    Dim dataReader As MySqlDataReader
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Need()
    End Sub

    Public Sub Need()
        If TextBox1.Text = Nothing Then
            MessageBox.Show("Please Fill The Empty Space!")
        ElseIf TextBox2.Text = Nothing Then
            MessageBox.Show("Please Fill The Empty Space!")
        ElseIf TextBox3.Text = Nothing Then
            MessageBox.Show("Please Fill The Empty Space!")
        ElseIf TextBox4.Text = Nothing Then
            MessageBox.Show("Please Fill The Empty Space!")
        ElseIf ComboBox1.Text = Nothing Then
            MessageBox.Show("Please Fill The Empty Space!")
        ElseIf ComboBox2.Text = Nothing Then
            MessageBox.Show("Please Fill The Empty Space!")
        Else req()
        End If

    End Sub
    Public Sub req()
        connection.Open()
        command = New MySqlCommand("select * from nn_votersid where VotersID='" & TextBox1.Text & "' and Name='" & TextBox3.Text & "'", connection)
        dataReader = command.ExecuteReader
        Dim Regist As Integer
        Regist = 0
        While dataReader.Read
            Regist = Regist + 1
        End While

        If Regist = 1 Then
            MessageBox.Show("You Already Registered As Voter")
            clearText()
            connection.Close()

        Else
            connection.Close()
            Register()
        End If
    End Sub

    Public Sub Register()
        connection.Open()
        command = New MySqlCommand("Insert into nn_votersid (VotersID, Password, Name, Birthdate, Age, Gender, YearLevel) values (@VotersID, @Password, @Name, @Birthdate, @Age, @Gender, @YearLevel)", connection)
            command.Parameters.Add(New MySqlParameter("@VotersID", MySqlDbType.VarChar, 50)).Value = TextBox1.Text
            command.Parameters.Add(New MySqlParameter("@Password", MySqlDbType.VarChar, 50)).Value = TextBox2.Text
            command.Parameters.Add(New MySqlParameter("@Name", MySqlDbType.VarChar, 50)).Value = TextBox3.Text
            command.Parameters.Add(New MySqlParameter("@Birthdate", DateTimePicker1.Value.Date))
            command.Parameters.Add(New MySqlParameter("@Age", MySqlDbType.VarChar, 50)).Value = TextBox4.Text
            command.Parameters.Add(New MySqlParameter("@Gender", MySqlDbType.VarChar, 50)).Value = ComboBox1.Text
            command.Parameters.Add(New MySqlParameter("@YearLevel", MySqlDbType.VarChar, 50)).Value = ComboBox2.Text
            command.ExecuteNonQuery()
        connection.Close()
        MessageBox.Show("Your Data Has Been Saved!")
        clearText()
        Me.Hide()
        Form2.Show()

    End Sub
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.CenterToScreen()

    End Sub
    Public Sub clearText()
        TextBox1.Text = Nothing
        TextBox2.Text = Nothing
        TextBox3.Text = Nothing
        TextBox4.Text = Nothing
        ComboBox1.Text = Nothing
        ComboBox2.Text = Nothing

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim myage As New Integer

        myage = DateTime.Today.Year - DateTimePicker1.Value.Year
        TextBox4.Text = myage.ToString()
    End Sub


End Class