Imports MySql.Data.MySqlClient
Public Class Form2
    Public connection As New MySqlConnection("host=localhost; user=root; password=;database=votenn;")
    Dim command As MySqlCommand
    Dim dataReader As MySqlDataReader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form3.ShowDialog()
    End Sub
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.CenterToScreen()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Need()

    End Sub
    Public Sub Need()
        If TextBox2.Text = Nothing Then
            MessageBox.Show("Need Password")
        ElseIf TextBox1.Text = Nothing Then
            MessageBox.Show("Need Voters ID")
        Else Log()
        End If

    End Sub
    Public Sub clearText()
        TextBox1.Text = Nothing
        TextBox2.Text = Nothing
    End Sub
    Public Sub Log()

        connection.Open()
        command = New MySqlCommand("select * from nn_votersid where VotersID='" & TextBox1.Text & "' and Password='" & TextBox2.Text & "'", connection)
        dataReader = command.ExecuteReader
        Dim Login As Integer
        Login = 0
        While dataReader.Read
            Login = Login + 1
        End While

        If Login = 1 Then
            Me.Hide()
            Form7.ShowDialog()

        Else
            MessageBox.Show("This Username and Password Doesn't Exist!")
        End If
        clearText()
        connection.Close()



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Visible = True
        Me.Hide()
    End Sub
End Class