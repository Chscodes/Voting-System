Public Class Form3
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If RadioButton1.Checked = True Then
            Me.Hide()
            Form4.ShowDialog()

        ElseIf RadioButton2.Checked = True Then
            Me.Hide()
            Form5.ShowDialog()
        ElseIf RadioButton3.Checked = True Then
            Me.Hide()
            Form6.ShowDialog()
        Else
            MessageBox.Show("Please Select one to Proceed!!")

        End If

    End Sub
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.CenterToScreen()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Hide()
    End Sub

End Class