Public Class frmRegister
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim sqlCon As New sqlManager

        sqlCon.sendData(String.Format("Call register('{0}', '{1}', '{2}', '{3}', '{4}')", txtEmail.Text, txtPassword.Text, txtfName.Text, txtlName.Text, txtbCode.Text))

    End Sub
End Class