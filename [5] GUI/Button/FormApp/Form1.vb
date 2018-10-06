Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAwesome_Click(sender As Object, e As EventArgs) Handles btnAwesome.Click
        Dim text As String

        text = txtAwesome.Text

        lblAwesome.Text = text
    End Sub
End Class
