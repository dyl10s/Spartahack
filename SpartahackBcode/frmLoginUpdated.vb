Public Class frmLoginUpdated

    Private Sub frmLoginUpdated_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        txtEmail.Left = (Me.ClientSize.Width / 2) - (txtEmail.Width / 2)
        txtPassword.Left = (Me.ClientSize.Width / 2) - (txtPassword.Width / 2)
        btnLogin.Left = (Me.ClientSize.Width / 2) - (btnLogin.Width / 2)
        btnRegister.Left = (Me.ClientSize.Width / 2) - (btnRegister.Width / 2)

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim sqlCon As New sqlManager

        Try
            Dim rawData As String = sqlCon.getData("Select fName, lName, Email from users where email = " + txtEmail.Text + " and password = " + txtPassword.Text, 3)

            Dim fName As String = rawData.Split("~")(0)
            Dim lName As String = rawData.Split("~")(1)
            Dim email As String = rawData.Split("~")(2)

            Dim clsUser As New clsUser(fName, lName, email)


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Me.Hide()
        Dim frmReg As New frmRegister
        frmReg.Show()
    End Sub
End Class