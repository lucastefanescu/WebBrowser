Public Class frmproperties

    Private Sub frmproperties_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtHomePage.Text = My.Settings.Homepage

        If My.Settings.HomePageOrBlankPage = 0 Then
            cmbStartUp.SelectedIndex = 0
        ElseIf My.Settings.HomePageOrBlankPage = 1 Then
            cmbStartUp.SelectedIndex = 1

            My.Settings.HomePageOrBlankPage = cmbStartUp.SelectedIndex.ToString
            My.Settings.Save()
            My.Settings.Reload()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        My.Settings.Homepage = txtHomePage.Text
        My.Settings.Save()
        My.Settings.Reload()
        'allows to set homepage

        My.Settings.HomePageOrBlankPage = cmbStartUp.SelectedIndex.ToString
        My.Settings.Save()
        My.Settings.Reload()
    End Sub
End Class