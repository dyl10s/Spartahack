Public Class frmRegister
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim sqlCon As New sqlManager

        Try
            sqlCon.sendData(String.Format("Call register('{0}', '{1}', '{2}', '{3}', '{4}')", txtEmail.Text, txtPassword.Text, txtfName.Text, txtlName.Text, txtbCode.Text))
        Catch ex As Exception
            Dim m As New MessageBox("Registration Failed")
        End Try

        Dim login As New frmLogin
        login.Show()
        Me.Close()


    End Sub
End Class