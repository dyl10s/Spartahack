Public Class frmLogin
    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click

        Me.Hide()
        Dim frmReg As New frmRegister
        frmReg.Show()

    End Sub
End Class
