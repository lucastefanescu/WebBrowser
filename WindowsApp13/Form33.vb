Imports System.Net
Imports System.IO
'imports systems for web icons

Public Class Form1

    Private Declare Sub keybd_event Lib "user 32" (ByVal volumeUpOrDown As Byte, ByVal v1 As Byte, ByVal v2 As Integer, ByVal v3 As Integer)
    'takes volume control from "user 32" library


    Private Sub Form1_formclosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        For Each favouritename As String In lstName.Items
            File.AppendAllText("C:\Users\pluto\Desktop\New folder (3)", favouritename & vbNewLine)
        Next

        For Each favouriteURL As String In lstUrl.Items
            File.AppendAllText("C:\Users\pluto\Desktop\New folder (3)", favouriteURL & vbNewLine)
        Next
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        cmbSearchEngines.Items.Add("Google")
        cmbSearchEngines.Items.Add("Youtube")
        cmbSearchEngines.Items.Add("Wikipedia")
        'adding different search engines
        cmbSearchEngines.SelectedIndex = 0
        'sets Index

        addTab(TabControl1)
        'adds tab automatically uponstart up 

        If My.Settings.HomePageOrBlankPage = 0 Then

            Dim browser As Class1 = Me.TabControl1.SelectedTab.Tag
            browser.Navigate(My.Settings.Homepage)

            'go to homepage through advanced options
        Else

        End If

        Try
            For Each url As String In File.ReadAllLines("C:\Users\pluto\Desktop\New folder (3)")
                ListBox3.Items.Add(url)
            Next
        Catch ex As Exception

        End Try

        Try
            ListBox3.SelectedIndex = 0

        Catch ex As Exception

        End Try

        Try
            For Each name As String In File.ReadAllLines("C:\Users\pluto\Desktop\New folder (3)")
                Dim newbookmark As New ToolStripButton
                newbookmark.Text = name

                newbookmark.Tag = ListBox3.SelectedItem.ToString
                ToolStrip1.Items.Add(newbookmark)
                ListBox3.SelectedIndex = ListBox3.SelectedIndex + 1
            Next
        Catch ex As Exception

        End Try

        createdbookclic()
    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim browser As Class1 = Me.TabControl1.SelectedTab.Tag
        browser.GoBack()
        'go back button
    End Sub

    Private Sub btnForward_Click(sender As Object, e As EventArgs) Handles btnForward.Click
        Dim browser As Class1 = Me.TabControl1.SelectedTab.Tag
        browser.GoForward()
        'go forward button
    End Sub

    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        Dim browser As Class1 = Me.TabControl1.SelectedTab.Tag
        browser.Refresh()
        'refresh browser
    End Sub

    Private Sub txturl_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUrl.KeyUp
        Dim browser As Class1 = Me.TabControl1.SelectedTab.Tag
        If e.KeyCode = Keys.Enter Then
            browser.Navigate(txtUrl.Text)
        End If
        'everytime navigate somewhere according to url clicking enter goes to url
    End Sub


    Private Sub txtUrlSearchEngines_KeyUp(sender As Object, e As KeyEventArgs) Handles txtUrlSearchEngines.KeyUp
        Dim browser As Class1 = Me.TabControl1.SelectedTab.Tag
        Select Case (cmbSearchEngines.SelectedIndex)
            Case 0
                If e.KeyCode = Keys.Enter Then
                    browser.Navigate("www.google.com/#q=" + txtUrlSearchEngines.Text)
                End If
            Case 1
                If e.KeyCode = Keys.Enter Then
                    browser.Navigate("http://www.youtube.com/results?search_query=" + txtUrlSearchEngines.Text)
                End If
            Case 2
                If e.KeyCode = Keys.Enter Then
                    browser.Navigate("en.wikipedia.org/wiki" + txtUrlSearchEngines.Text)
                End If
                'allows search through small textbox through different search engines

        End Select
    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        Dim browser As Class1 = Me.TabControl1.SelectedTab.Tag
        browser.Navigate(My.Settings.Homepage)

    End Sub

    Private Sub btnVolumeUp_Click(sender As Object, e As EventArgs) Handles btnVolumeUp.Click

        Call keybd_event(System.Windows.Forms.Keys.VolumeUp, 0, 0, 0)
        'volume up

    End Sub

    Private Sub btnVolumeDown_Click(sender As Object, e As EventArgs) Handles btnVolumeDown.Click

        Call keybd_event(System.Windows.Forms.Keys.VolumeDown, 0, 0, 0)
        'volume down

    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
        frmproperties.Show()

    End Sub

    Private Sub tmrdate_Tick(sender As Object, e As EventArgs) Handles tmrdate.Tick

        lblDate.Text = Now
        'sets date for respected day
    End Sub

    Private Sub HistorytoolstripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoryToolStripMenuItem.Click
        History.Show()
        'when clicked, shows history tab


    End Sub


    Private Sub txtUrl_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtUrl.TextChanged
        txtUrl.AutoCompleteCustomSource.Clear()
        For i As Integer = 0 To History.lstHistory.Items.Count - 1
            txtUrl.AutoCompleteCustomSource.Add(History.lstHistory.Items(i))

            'autocompletes a Url when something is typed in the txt Url
        Next
    End Sub

    Private Sub NewTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewTabToolStripMenuItem.Click
        addTab(TabControl1)
    End Sub

    Private Sub CloseTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseTabToolStripMenuItem.Click

        removetab()

    End Sub

    Public Sub addTab(ByRef TabControl)
        Dim browser As New Class1
        Dim tab As New TabPage
        browser.Tag = tab
        tab.Tag = browser
        TabControl1.TabPages.Add(tab)
        tab.Controls.Add(browser)
        browser.Dock = DockStyle.Fill
        browser.Navigate("www.google.com")
        'adds a new tab

        TabControl1.SelectedTab = tab
        'everytime a new tab is opened, the browser automatically switches to that tab
    End Sub

    Public Sub removetab()
        If TabControl1.TabPages.Count <> 0 Then
            TabControl1.TabPages.Remove(TabControl1.SelectedTab)

        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Dim browser As Class1 = TabControl1.SelectedTab.Tag
        Try
            txtUrl.Text = browser.Url.Tostring
        Catch ex As Exception

        End Try
    End Sub

    Private Sub NewWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewWindowToolStripMenuItem.Click
        Dim newwindow As New Form1
        newwindow.Show()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        txtUrl.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        txtUrl.ClearUndo()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        txtUrl.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        txtUrl.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        txtUrl.Paste()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        txtUrl.SelectAll()
    End Sub

    Private Sub BookmarksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookmarksToolStripMenuItem.Click
        addbookmarks()
    End Sub

    Private Sub addbookmarks()
        Dim browser As WebBrowser = TabControl1.SelectedTab.Tag

        Dim newbookmark As New ToolStripButton
        newbookmark.Text = TabControl1.SelectedTab.Text
        newbookmark.Tag = browser.Url
        ToolStrip1.Items.Add(newbookmark)
        lstName.Items.Add(TabControl1.SelectedTab.Text)
        lstUrl.Items.Add(browser.Url.ToString)
        'adds bookmarks as buttons to toolstrip

        AddHandler newbookmark.Click, AddressOf newbookmarkClick
    End Sub

    Private Sub newbookmarkClick(sender As Object, e As EventArgs)
        Dim browser As WebBrowser = TabControl1.SelectedTab.Tag

        If TypeOf sender Is ToolStripButton Then
            browser.Navigate(CType(sender, ToolStripButton).Tag)
        End If
    End Sub
    Private Sub createdbookclic()
        For Each item As ToolStripButton In ToolStrip1.Items
            AddHandler item.Click, AddressOf bookclick
        Next
    End Sub

    Private Sub bookclick(sender As Object, e As EventArgs)
        txtUrl.Text = CType(sender, ToolStripButton).Tag
        booknav()
    End Sub

    Private Sub booknav()
        Dim browser As WebBrowser = TabControl1.SelectedTab.Tag
        browser.Navigate(txtUrl.Text)
    End Sub
    'All handlers to control toolstrip buttons
End Class



