Imports System.Net
Imports System.IO
'imports systems for web icons

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbSearchEngines.Items.Add("Google")
        cmbSearchEngines.Items.Add("Youtube")
        cmbSearchEngines.Items.Add("Wikipedia")
        'adding different search engines
        cmbSearchEngines.SelectedIndex = 0
        'sets Index

    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        WebBrowserEscape.GoBack()
        'go back button
    End Sub

    Private Sub btnForward_Click(sender As Object, e As EventArgs) Handles btnForward.Click
        WebBrowserEscape.GoForward()
        'go forward button
    End Sub

    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        WebBrowserEscape.Refresh()
        'refresh browser
    End Sub

    Private Sub WebBrowserEscape_Navigated(sender As Object, e As WebBrowserNavigatedEventArgs) Handles WebBrowserEscape.Navigated
        txtUrl.Text = WebBrowserEscape.Url.ToString
        webIcons()


        TabControl1.SelectedTab.Text = WebBrowserEscape.DocumentTitle.ToString
        'says the page name on the tab
    End Sub
    Private Sub txturl_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUrl.KeyUp
        If e.KeyCode = Keys.Enter Then
            WebBrowserEscape.Navigate(txtUrl.Text)
        End If
        'everytime navigate somewhere according to url clicking enter goes to url
    End Sub
    Private Sub webIcons()
        Dim wc As New WebClient
        Dim memorystream As New MemoryStream(wc.DownloadData("http://" & New Uri(WebBrowserEscape.Url.ToString).Host & "/favicon.ico"))
        Dim icon As New Icon(memorystream)

        If ImageList1.Images.Count = -1 Then
            ImageList1.Images.Add(icon.ToBitmap)
            TabControl1.SelectedTab.ImageIndex = 0

        Else
            ImageList1.Images.Clear()
            ImageList1.Images.Add(icon.ToBitmap)
            TabControl1.SelectedTab.ImageIndex = 0
        End If
    End Sub

    Private Sub txtUrlSearchEngines_KeyUp(sender As Object, e As KeyEventArgs) Handles txtUrlSearchEngines.KeyUp
        Select Case (cmbSearchEngines.SelectedIndex)
            Case 0
                If e.KeyCode = Keys.Enter Then
                    WebBrowserEscape.Navigate("www.google.com/#q=" + txtUrlSearchEngines.Text)
                End If
            Case 1
                If e.KeyCode = Keys.Enter Then
                    WebBrowserEscape.Navigate("http://www.youtube.com/results?search_query=" + txtUrlSearchEngines.Text)
                End If
            Case 2
                If e.KeyCode = Keys.Enter Then
                    WebBrowserEscape.Navigate("en.wikipedia.org/wiki" + txtUrlSearchEngines.Text)
                End If
                'allows search through small textbox through different search engines

        End Select
    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click

        WebBrowserEscape.Navigate(My.Settings.Homepage)
    End Sub
End Class
