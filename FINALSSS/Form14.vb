Imports MySql.Data.MySqlClient
Public Class Form14
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


    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        DataGridView1.Rows.Clear()
        connection.Open()
        command = New MySqlCommand("Select President, Count(President)as Votes From nn_votedlist GROUP BY President ORDER BY Votes DESC", connection)

        dataReader = command.ExecuteReader

        While dataReader.Read
            Dim colName = dataReader.GetString("President")
            Dim colVotes = dataReader.GetString("Votes")

            DataGridView1.Rows.Add(colName, colVotes)
        End While
        connection.Close()

        '--------------,,..............---------'

        connection.Open()
        command = New MySqlCommand("Select Count(*)as Votes  from nn_votedlist", connection)
        dataReader = command.ExecuteReader

        While dataReader.Read
            TextBox1.Text = dataReader(0)
        End While
        connection.Close()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        DataGridView1.Rows.Clear()
        connection.Open()
        command = New MySqlCommand("Select VicePresident, Count(VicePresident)as Votes From nn_votedlist GROUP BY VicePresident ORDER BY Votes DESC", connection)

        dataReader = command.ExecuteReader

        While dataReader.Read
            Dim colName = dataReader.GetString("VicePresident")
            Dim colVotes = dataReader.GetString("Votes")

            DataGridView1.Rows.Add(colName, colVotes)
        End While
        connection.Close()

        '--------------,,..............---------'

        connection.Open()
        command = New MySqlCommand("Select Count(*)as Votes  from nn_votedlist", connection)
        dataReader = command.ExecuteReader

        While dataReader.Read
            TextBox1.Text = dataReader(0)
        End While
        connection.Close()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        DataGridView1.Rows.Clear()
        connection.Open()
        command = New MySqlCommand("Select Secretary, Count(Secretary)as Votes From nn_votedlist GROUP BY Secretary ORDER BY Votes DESC", connection)

        dataReader = command.ExecuteReader

        While dataReader.Read
            Dim colName = dataReader.GetString("Secretary")
            Dim colVotes = dataReader.GetString("Votes")

            DataGridView1.Rows.Add(colName, colVotes)
        End While
        connection.Close()

        '--------------,,..............---------'

        connection.Open()
        command = New MySqlCommand("Select Count(*)as Votes  from nn_votedlist", connection)
        dataReader = command.ExecuteReader

        While dataReader.Read
            TextBox1.Text = dataReader(0)
        End While
        connection.Close()
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        DataGridView1.Rows.Clear()
        connection.Open()
        command = New MySqlCommand("Select Auditor, Count(Auditor)as Votes From nn_votedlist GROUP BY Auditor ORDER BY Votes DESC", connection)

        dataReader = command.ExecuteReader

        While dataReader.Read
            Dim colName = dataReader.GetString("Auditor")
            Dim colVotes = dataReader.GetString("Votes")

            DataGridView1.Rows.Add(colName, colVotes)
        End While
        connection.Close()

        '--------------,,..............---------'

        connection.Open()
        command = New MySqlCommand("Select Count(*)as Votes  from nn_votedlist", connection)
        dataReader = command.ExecuteReader

        While dataReader.Read
            TextBox1.Text = dataReader(0)
        End While
        connection.Close()
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        DataGridView1.Rows.Clear()
        connection.Open()
        command = New MySqlCommand("Select Treasurer, Count(Treasurer)as Votes From nn_votedlist GROUP BY Treasurer ORDER BY Votes DESC", connection)

        dataReader = command.ExecuteReader

        While dataReader.Read
            Dim colName = dataReader.GetString("Treasurer")
            Dim colVotes = dataReader.GetString("Votes")

            DataGridView1.Rows.Add(colName, colVotes)
        End While
        connection.Close()

        '--------------,,..............---------'

        connection.Open()
        command = New MySqlCommand("Select Count(*)as Votes  from nn_votedlist", connection)
        dataReader = command.ExecuteReader

        While dataReader.Read
            TextBox1.Text = dataReader(0)
        End While
        connection.Close()
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        DataGridView1.Rows.Clear()
        connection.Open()
        command = New MySqlCommand("Select PROmale, Count(PROmale)as Votes From nn_votedlist GROUP BY PROmale ORDER BY Votes DESC", connection)

        dataReader = command.ExecuteReader

        While dataReader.Read
            Dim colName = dataReader.GetString("Promale")
            Dim colVotes = dataReader.GetString("Votes")

            DataGridView1.Rows.Add(colName, colVotes)
        End While
        connection.Close()

        '--------------,,..............---------'

        connection.Open()
        command = New MySqlCommand("Select Count(*)as Votes  from nn_votedlist", connection)
        dataReader = command.ExecuteReader

        While dataReader.Read
            TextBox1.Text = dataReader(0)
        End While
        connection.Close()
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        DataGridView1.Rows.Clear()
        connection.Open()
        command = New MySqlCommand("Select PROfemale, Count(PROfemale)as Votes From nn_votedlist GROUP BY PROfemale ORDER BY Votes DESC", connection)

        dataReader = command.ExecuteReader

        While dataReader.Read
            Dim colName = dataReader.GetString("Profemale")
            Dim colVotes = dataReader.GetString("Votes")

            DataGridView1.Rows.Add(colName, colVotes)
        End While
        connection.Close()

        '--------------,,..............---------'

        connection.Open()
        command = New MySqlCommand("Select Count(*)as Votes  from nn_votedlist", connection)
        dataReader = command.ExecuteReader

        While dataReader.Read
            TextBox1.Text = dataReader(0)
        End While
        connection.Close()
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        DataGridView1.Rows.Clear()
        connection.Open()
        command = New MySqlCommand("Select Muse, Count(Muse)as Votes From nn_votedlist GROUP BY Muse ORDER BY Votes DESC", connection)

        dataReader = command.ExecuteReader

        While dataReader.Read
            Dim colName = dataReader.GetString("Muse")
            Dim colVotes = dataReader.GetString("Votes")

            DataGridView1.Rows.Add(colName, colVotes)
        End While
        connection.Close()

        '--------------,,..............---------'

        connection.Open()
        command = New MySqlCommand("Select Count(*)as Votes  from nn_votedlist", connection)
        dataReader = command.ExecuteReader

        While dataReader.Read
            TextBox1.Text = dataReader(0)
        End While
        connection.Close()
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        DataGridView1.Rows.Clear()
        connection.Open()
        command = New MySqlCommand("Select Escort, Count(Escort)as Votes From nn_votedlist GROUP BY Escort ORDER BY Votes DESC", connection)

        dataReader = command.ExecuteReader

        While dataReader.Read
            Dim colName = dataReader.GetString("Escort")
            Dim colVotes = dataReader.GetString("Votes")

            DataGridView1.Rows.Add(colName, colVotes)
        End While
        connection.Close()

        '--------------,,..............---------'

        connection.Open()
        command = New MySqlCommand("Select Count(*)as Votes  from nn_votedlist", connection)
        dataReader = command.ExecuteReader

        While dataReader.Read
            TextBox1.Text = dataReader(0)
        End While
        connection.Close()
    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        DataGridView1.Rows.Clear()
        connection.Open()
        command = New MySqlCommand("Select FirstRep, Count(FirstRep)as Votes From nn_votedlist GROUP BY FirstRep ORDER BY Votes DESC", connection)

        dataReader = command.ExecuteReader

        While dataReader.Read
            Dim colName = dataReader.GetString("FirstRep")
            Dim colVotes = dataReader.GetString("Votes")

            DataGridView1.Rows.Add(colName, colVotes)
        End While
        connection.Close()

        '--------------,,..............---------'

        connection.Open()
        command = New MySqlCommand("Select Count(*)as Votes  from nn_votedlist", connection)
        dataReader = command.ExecuteReader

        While dataReader.Read
            TextBox1.Text = dataReader(0)
        End While
        connection.Close()
    End Sub

    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton11.CheckedChanged
        DataGridView1.Rows.Clear()
        connection.Open()
        command = New MySqlCommand("Select SecondRep, Count(SecondRep)as Votes From nn_votedlist GROUP BY SecondRep ORDER BY Votes DESC", connection)

        dataReader = command.ExecuteReader

        While dataReader.Read
            Dim colName = dataReader.GetString("SecondRep")
            Dim colVotes = dataReader.GetString("Votes")

            DataGridView1.Rows.Add(colName, colVotes)
        End While
        connection.Close()

        '--------------,,..............---------'

        connection.Open()
        command = New MySqlCommand("Select Count(*)as Votes  from nn_votedlist", connection)
        dataReader = command.ExecuteReader

        While dataReader.Read
            TextBox1.Text = dataReader(0)
        End While
        connection.Close()
    End Sub

    Private Sub RadioButton12_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton12.CheckedChanged
        DataGridView1.Rows.Clear()
        connection.Open()
        command = New MySqlCommand("Select ThirdRep, Count(ThirdRep)as Votes From nn_votedlist GROUP BY ThirdRep ORDER BY Votes DESC", connection)

        dataReader = command.ExecuteReader

        While dataReader.Read
            Dim colName = dataReader.GetString("ThirdRep")
            Dim colVotes = dataReader.GetString("Votes")

            DataGridView1.Rows.Add(colName, colVotes)
        End While
        connection.Close()

        '--------------,,..............---------'

        connection.Open()
        command = New MySqlCommand("Select Count(*)as Votes  from nn_votedlist", connection)
        dataReader = command.ExecuteReader

        While dataReader.Read
            TextBox1.Text = dataReader(0)
        End While
        connection.Close()
    End Sub
End Class