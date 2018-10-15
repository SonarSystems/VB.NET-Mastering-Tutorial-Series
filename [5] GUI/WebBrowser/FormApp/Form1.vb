Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub btnForward_Click(sender As Object, e As EventArgs) Handles btnForward.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim url As String = txtURL.Text

        WebBrowser1.Navigate(url)
    End Sub
End Class
