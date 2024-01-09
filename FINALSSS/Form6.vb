Imports MySql.Data.MySqlClient
Public Class Form6
    Public connection As New MySqlConnection("host=localhost; user=root; password=;database=votenn;")
    Dim command As MySqlCommand
    Dim dataReader As MySqlDataReader
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Need()

    End Sub
    Public Sub Need()
        If TextBox1.Text = Nothing Then
            MessageBox.Show("Please Fill The Empty Space!")
        ElseIf richTextBox1.Text = Nothing Then
            MessageBox.Show("Please Fill The Empty Space!")
        ElseIf richTextBox2.Text = Nothing Then
            MessageBox.Show("Please Fill The Empty Space!")
        Else Register()
        End If

    End Sub
    Public Sub clearText()
        TextBox1.Text = Nothing
        RichTextBox1.Text = Nothing
        RichTextBox2.Text = Nothing
    End Sub
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CenterToScreen()

    End Sub
    Public Sub Register()
        connection.Open()
        command = New MySqlCommand("Insert into nn_partylist (Name, Description, Info) values (@Name, @Description, @Info)", connection)
        command.Parameters.Add(New MySqlParameter("@Name", MySqlDbType.VarChar, 50)).Value = TextBox1.Text
        command.Parameters.Add(New MySqlParameter("@Description", MySqlDbType.VarChar, 50)).Value = RichTextBox1.Text
        command.Parameters.Add(New MySqlParameter("@Info", MySqlDbType.VarChar, 50)).Value = RichTextBox2.Text
        command.ExecuteNonQuery()
        connection.Close()
        MessageBox.Show("Your Data Has Been Saved!")
        clearText()
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form3.Show()
        Me.Hide()
    End Sub
End Class