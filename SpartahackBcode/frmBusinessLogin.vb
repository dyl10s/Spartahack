Public Class frmBusinessLogin
    Private Sub frmBusinessLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        txtEmail.Left = (Me.ClientSize.Width / 2) - (txtEmail.Width / 2)
        lblBusiness.Left = (Me.ClientSize.Width / 2) - (lblBusiness.Width / 2)
        txtPass.Left = (Me.ClientSize.Width / 2) - (txtPass.Width / 2)
        pbLoader.Left = (Me.ClientSize.Width / 2) - (pbLoader.Width / 2)
        pbLogo.Left = (Me.ClientSize.Width / 2) - (pbLogo.Width / 2)
        lblBus.Left = (Me.ClientSize.Width / 2) - (lblBus.Width / 2)

    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub lblBusiness_Click(sender As Object, e As EventArgs) Handles lblBusiness.Click
        Dim frm As New frmLoginUpdated
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim frm As New frmBusinessRegister
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Dim frm As New frmBusinessBcode
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        pbLoader.Visible = True

        Dim sqlCon As New sqlManager

        Dim rawData As String = sqlCon.getData("Select FirstName, LastName, Email, bCode from users where email = '" + txtEmail.Text + "' and password = '" + txtPass.Text + "' and company = 1", 4)

        Dim fName As String = rawData.Split("~")(0)
        Dim lName As String = rawData.Split("~")(1)
        Dim email As String = rawData.Split("~")(2)
        Dim bCode As String = rawData.Split("~")(3)

        Dim clsUser As New clsUser(fName, lName, email, bCode)
        Dim frmMain As New frmBusinessBcode

        frmMain.user = clsUser
        frmMain.Show()
        Me.Hide()

        sqlCon.close()

    End Sub
End Class