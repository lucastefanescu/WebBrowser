Public Class Class1
    Inherits WebBrowser

    Private Sub webBrowserDocCompl() Handles Me.DocumentCompleted
        Dim tabPage As TabPage = Me.Tag

        If Me.DocumentTitle.Length > 25 Then

            tabPage.Text = Me.DocumentTitle.Substring(0, 25)
            'If Doc title is greater than 25 char. then, display only up to 25 char in the title.

        Else
            tabPage.Text = Me.DocumentTitle

        End If





        Form1.txtUrl.Text = Me.Url.ToString



    End Sub
End Class
