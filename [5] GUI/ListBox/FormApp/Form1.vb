Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim text As String

        text = ListBox1.SelectedItem.ToString

        Label1.Text = text
    End Sub
End Class
