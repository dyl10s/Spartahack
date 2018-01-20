Public Class frmMain
    Private Sub btnSignOut_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click

        Dim frmLogin As New frmLogin
        frmLogin.Show()
        Me.Close()

    End Sub
End Class