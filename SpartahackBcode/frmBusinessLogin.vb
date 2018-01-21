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
End Class