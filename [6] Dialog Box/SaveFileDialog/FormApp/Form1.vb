Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SaveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"

        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, RichTextBox1.Text, True)
        End If
    End Sub
End Class
