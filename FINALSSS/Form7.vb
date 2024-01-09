Imports MySql.Data.MySqlClient
Public Class Form7
    Public connection As New MySqlConnection("host=localhost; user=root; password=;database=votenn;")
    Dim command As MySqlCommand
    Dim dataReader As MySqlDataReader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Need()



    End Sub
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CenterToScreen()


    End Sub

    Public Sub req()
        connection.Open()
        command = New MySqlCommand("select * from nn_votedlist where VotersID='" & TextBox1.Text & "' and Name='" & TextBox2.Text & "'", connection)
        dataReader = command.ExecuteReader
        Dim Regist As Integer
        Regist = 0
        While dataReader.Read
            Regist = Regist + 1
        End While

        If Regist = 1 Then
            MessageBox.Show("You Can Only Vote Once!")
            ClearText()
            connection.Close()

        Else
            connection.Close()
            Vote()
        End If
    End Sub
    Public Sub Need()
        If TextBox1.Text = Nothing Then
            MessageBox.Show("Please Fill The Empty Space!")
        ElseIf TextBox2.Text = Nothing Then
            MessageBox.Show("Please Fill The Empty Space!")
        ElseIf ComboBox1.Text = Nothing Then
            MessageBox.Show("Please Fill The Empty Space!")
        ElseIf Combobox2.Text = Nothing Then
            MessageBox.Show("Please Fill The Empty Space!")
        ElseIf ComboBox3.Text = Nothing Then
            MessageBox.Show("Please Fill The Empty Space!")
        ElseIf ComboBox4.Text = Nothing Then
            MessageBox.Show("Please Fill The Empty Space!")
        ElseIf ComboBox5.Text = Nothing Then
            MessageBox.Show("Please Fill The Empty Space!")
        ElseIf ComboBox6.Text = Nothing Then
            MessageBox.Show("Please Fill The Empty Space!")
        ElseIf ComboBox7.Text = Nothing Then
            MessageBox.Show("Please Fill The Empty Space!")
        ElseIf ComboBox8.Text = Nothing Then
            MessageBox.Show("Please Fill The Empty Space!")
        ElseIf ComboBox9.Text = Nothing Then
            MessageBox.Show("Please Fill The Empty Space!")
        ElseIf ComboBox10.Text = Nothing Then
            MessageBox.Show("Please Fill The Empty Space!")
        ElseIf ComboBox11.Text = Nothing Then
            MessageBox.Show("Please Fill The Empty Space!")
        ElseIf ComboBox12.Text = Nothing Then
            MessageBox.Show("Please Fill The Empty Space!")
        Else req()
        End If

    End Sub
    Public Sub ClearText()
        TextBox1.Text = Nothing
        TextBox2.Text = Nothing
        ComboBox1.Text = Nothing
        ComboBox2.Text = Nothing
        ComboBox3.Text = Nothing
        ComboBox4.Text = Nothing
        ComboBox5.Text = Nothing
        ComboBox6.Text = Nothing
        ComboBox7.Text = Nothing
        ComboBox8.Text = Nothing
        ComboBox9.Text = Nothing
        ComboBox11.Text = Nothing
        ComboBox10.Text = Nothing
        ComboBox12.Text = Nothing
    End Sub


    Public Sub Vote()
        connection.Open()
        command = New MySqlCommand("Insert into nn_votedlist (VotersID, Name, President, VicePresident, Secretary, Treasurer, Auditor, ProMale, ProFemale, Muse, Escort, FirstRep, SecondRep, ThirdRep) values (@VotersID, @Name, @President, @VicePresident, @Secretary, @Treasurer, @Auditor, @ProMale, @ProFemale, @Muse, @Escort, @FirstRep, @SecondRep, @ThirdRep)", connection)
        command.Parameters.Add(New MySqlParameter("@VotersID", MySqlDbType.VarChar, 50)).Value = TextBox1.Text
        command.Parameters.Add(New MySqlParameter("@Name", MySqlDbType.VarChar, 50)).Value = TextBox2.Text
        command.Parameters.Add(New MySqlParameter("@President", MySqlDbType.VarChar, 50)).Value = ComboBox1.Text
        command.Parameters.Add(New MySqlParameter("@VicePresident", MySqlDbType.VarChar, 50)).Value = ComboBox2.Text
        command.Parameters.Add(New MySqlParameter("@Secretary", MySqlDbType.VarChar, 50)).Value = ComboBox3.Text
        command.Parameters.Add(New MySqlParameter("@Treasurer", MySqlDbType.VarChar, 50)).Value = ComboBox4.Text
        command.Parameters.Add(New MySqlParameter("@Auditor", MySqlDbType.VarChar, 50)).Value = ComboBox5.Text
        command.Parameters.Add(New MySqlParameter("@ProMale", MySqlDbType.VarChar, 50)).Value = ComboBox6.Text
        command.Parameters.Add(New MySqlParameter("@ProFemale", MySqlDbType.VarChar, 50)).Value = ComboBox7.Text
        command.Parameters.Add(New MySqlParameter("@Muse", MySqlDbType.VarChar, 50)).Value = ComboBox8.Text
        command.Parameters.Add(New MySqlParameter("@Escort", MySqlDbType.VarChar, 50)).Value = ComboBox9.Text
        command.Parameters.Add(New MySqlParameter("@FirstRep", MySqlDbType.VarChar, 50)).Value = ComboBox10.Text
        command.Parameters.Add(New MySqlParameter("@SecondRep", MySqlDbType.VarChar, 50)).Value = ComboBox11.Text
        command.Parameters.Add(New MySqlParameter("@ThirdRep", MySqlDbType.VarChar, 50)).Value = ComboBox12.Text
        command.ExecuteNonQuery()
        connection.Close()
        MessageBox.Show("Your Vote is The key for Sucess")
        ClearText()
        Me.Hide()
        Form8.ShowDialog()

    End Sub
    Private Sub UsersForms_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'President'
        ComboBox1.Items.Clear()
        connection.Open()
        command = New MySqlCommand("select Name from nn_candidate where Position = 'President'", connection)
        dataReader = command.ExecuteReader

        While dataReader.Read
            Dim colName = dataReader.GetString("Name")
            ComboBox1.Items.Add(colName)
        End While
        connection.Close()

        'Vice President'
        ComboBox2.Items.Clear()
        connection.Open()
        command = New MySqlCommand("select Name from nn_candidate where Position = 'Vice President'", connection)
        dataReader = command.ExecuteReader

        While dataReader.Read
            Dim colName = dataReader.GetString("Name")
            ComboBox2.Items.Add(colName)
        End While
        connection.Close()

        'Secretary'
        ComboBox3.Items.Clear()
        connection.Open()
        command = New MySqlCommand("select Name from nn_candidate where Position = 'Secretary'", connection)
        dataReader = command.ExecuteReader

        While dataReader.Read
            Dim colName = dataReader.GetString("Name")
            ComboBox3.Items.Add(colName)
        End While
        connection.Close()

        'Treasurer'
        ComboBox4.Items.Clear()
        connection.Open()
        command = New MySqlCommand("select Name from nn_candidate where Position = 'Treasurer'", connection)
        dataReader = command.ExecuteReader

        While dataReader.Read
            Dim colName = dataReader.GetString("Name")
            ComboBox4.Items.Add(colName)
        End While
        connection.Close()

        'Auditor'
        ComboBox5.Items.Clear()
        connection.Open()
        command = New MySqlCommand("select Name from nn_candidate where Position = 'Auditor'", connection)
        dataReader = command.ExecuteReader

        While dataReader.Read
            Dim colName = dataReader.GetString("Name")
            ComboBox5.Items.Add(colName)
        End While
        connection.Close()

        'Pro Male'
        ComboBox6.Items.Clear()
        connection.Open()
        command = New MySqlCommand("select Name from nn_candidate where Position = 'Pro-Male'", connection)
        dataReader = command.ExecuteReader

        While dataReader.Read
            Dim colName = dataReader.GetString("Name")
            ComboBox6.Items.Add(colName)
        End While
        connection.Close()

        'Pro FeMale'
        ComboBox7.Items.Clear()
        connection.Open()
        command = New MySqlCommand("select Name from nn_candidate where Position = 'Pro-Female'", connection)
        dataReader = command.ExecuteReader

        While dataReader.Read
            Dim colName = dataReader.GetString("Name")
            ComboBox7.Items.Add(colName)
        End While
        connection.Close()


        'Muse'
        ComboBox8.Items.Clear()
        connection.Open()
        command = New MySqlCommand("select Name from nn_candidate where Position = 'Muse'", connection)
        dataReader = command.ExecuteReader

        While dataReader.Read
            Dim colName = dataReader.GetString("Name")
            ComboBox8.Items.Add(colName)
        End While
        connection.Close()


        'Escort'
        ComboBox9.Items.Clear()
        connection.Open()
        command = New MySqlCommand("select Name from nn_candidate where Position = 'Escort'", connection)
        dataReader = command.ExecuteReader

        While dataReader.Read
            Dim colName = dataReader.GetString("Name")
            ComboBox9.Items.Add(colName)
        End While
        connection.Close()

        '1st Representative'
        ComboBox10.Items.Clear()
        connection.Open()
        command = New MySqlCommand("select Name from nn_candidate where Position = '1st Year Representative'", connection)
        dataReader = command.ExecuteReader

        While dataReader.Read
            Dim colName = dataReader.GetString("Name")
            ComboBox10.Items.Add(colName)
        End While
        connection.Close()

        '2nd Representative'
        ComboBox11.Items.Clear()
        connection.Open()
        command = New MySqlCommand("select Name from nn_candidate where Position = '2nd Year Representative'", connection)
        dataReader = command.ExecuteReader

        While dataReader.Read
            Dim colName = dataReader.GetString("Name")
            ComboBox11.Items.Add(colName)
        End While
        connection.Close()

        '3rd Representative'
        ComboBox12.Items.Clear()
        connection.Open()
        command = New MySqlCommand("select Name from nn_candidate where Position = '3rd Year Representative'", connection)
        dataReader = command.ExecuteReader

        While dataReader.Read
            Dim colName = dataReader.GetString("Name")
            ComboBox12.Items.Add(colName)
        End While
        connection.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Public Sub ID()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
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
        End If
        connection.Close()

    End Sub
End Class