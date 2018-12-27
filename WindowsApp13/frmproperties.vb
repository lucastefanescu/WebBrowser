Public Class frmproperties

    Private Sub frmproperties_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtHomePage.Text = My.Settings.Homepage
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        My.Settings.Homepage = txtHomePage.Text
        My.Settings.Save()
        My.Settings.Reload()
        'allows to set homepage
    End Sub
End Class