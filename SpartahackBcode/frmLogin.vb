Public Class frmLogin
    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click

        Me.Hide()
        Dim frmReg As New frmRegister
        frmReg.Show()

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim sqlCon As New sqlManager

        Try
            Dim rawData As String = sqlCon.getData("Select fName, lName, Email, bCode from users where email = " + txtEmail.Text + " and password = " + txtPassword.Text, 4)

            Dim fName As String = rawData.Split("~")(0)
            Dim lName As String = rawData.Split("~")(1)
            Dim email As String = rawData.Split("~")(2)
            Dim bCode As String = rawData.Split("~")(3)

            Dim clsUser As New clsUser(fName, lName, email, bCode)
            Dim frmMain As New frmMain
            frmMain.user = clsUser
            frmMain.Show()
            Me.Close()

        Catch ex As Exception

        End Try

    End Sub
End Class
