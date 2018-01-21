Public Class frmLoginUpdated

    Private Sub frmLoginUpdated_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        txtEmail.Left = (Me.ClientSize.Width / 2) - (txtEmail.Width / 2)
        lblBusiness.Left = (Me.ClientSize.Width / 2) - (lblBusiness.Width / 2)
        txtPassword.Left = (Me.ClientSize.Width / 2) - (txtPassword.Width / 2)
        btnLogin.Left = (Me.ClientSize.Width / 2) - (btnLogin.Width / 2)
        btnRegister.Left = (Me.ClientSize.Width / 2) - (btnRegister.Width / 2)
        pbLoader.Left = (Me.ClientSize.Width / 2) - (pbLoader.Width / 2)
        pbLogo.Left = (Me.ClientSize.Width / 2) - (pbLogo.Width / 2)

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        pbLoader.Visible = True

        Dim sqlCon As New sqlManager

        Dim rawData As String = sqlCon.getData("Select FirstName, LastName, Email, bCode from users where email = '" + txtEmail.Text + "' and password = '" + txtPassword.Text + "'", 4)

        Dim fName As String = rawData.Split("~")(0)
        Dim lName As String = rawData.Split("~")(1)
        Dim email As String = rawData.Split("~")(2)
        Dim bCode As String = rawData.Split("~")(3)

        Dim clsUser As New clsUser(fName, lName, email, bCode)
        Dim frmMain As New frmMainUpdated

        frmMain.user = clsUser
        frmMain.Show()
        Me.Hide()

        sqlCon.close()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtEmail.Text = "achlebek17@gmail.com"
        txtPassword.Text = "adam4"
    End Sub

    Private Sub lblBusiness_Click(sender As Object, e As EventArgs) Handles lblBusiness.Click
        Dim frm As New frmBusinessLogin
        frm.Show()
        Me.Hide()
    End Sub
End Class