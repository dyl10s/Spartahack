Public Class frmLoginUpdated

    Private Sub frmLoginUpdated_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        txtEmail.Left = (Me.ClientSize.Width / 2) - (txtEmail.Width / 2)
        txtPassword.Left = (Me.ClientSize.Width / 2) - (txtPassword.Width / 2)
        btnLogin.Left = (Me.ClientSize.Width / 2) - (btnLogin.Width / 2)
        btnRegister.Left = (Me.ClientSize.Width / 2) - (btnRegister.Width / 2)

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If (txtEmail.Text = Nothing & txtPassword.Text = Nothing) Then
            MsgBox("Please use an email and password.")
        Else
            Dim sqlCon As New sqlManager

            Try
                Dim rawData As String = sqlCon.getData("Select fName, lName, Email from users where email = " + txtEmail.Text + " and password = " + txtPassword.Text, 3)

                Dim fName As String = rawData.Split("~")(0)
                Dim lName As String = rawData.Split("~")(1)
                Dim email As String = rawData.Split("~")(2)
                Dim bcode As String = rawData.Split("~")(3)

                Dim clsUser As New clsUser(fName, lName, email, bcode)


            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Me.Hide()
        Dim frmReg As New frmRegisterUpdated
        frmReg.Show()
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub
End Class