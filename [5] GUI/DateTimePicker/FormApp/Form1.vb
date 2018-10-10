Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim date1 As DateTime

        date1 = DateTimePicker1.Value

        Label1.Text = date1

    End Sub
End Class
