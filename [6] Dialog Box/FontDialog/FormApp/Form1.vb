Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If FontDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Button1.Font = FontDialog1.Font
        End If
    End Sub
End Class
