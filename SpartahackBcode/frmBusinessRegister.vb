Public Class frmBusinessRegister
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub frmBusinessRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        txtEmail.Left = (Me.ClientSize.Width / 2) - (txtEmail.Width / 2)
        lblEmail.Left = (Me.ClientSize.Width / 2) - (lblEmail.Width / 2)

        txtPass.Left = (Me.ClientSize.Width / 2) - (txtPass.Width) - 10
        txtRetryPass.Left = (Me.ClientSize.Width / 2) + 10

        txtFirstName.Left = (Me.ClientSize.Width / 2) - (txtFirstName.Width) - 10
        txtLastName.Left = (Me.ClientSize.Width / 2) + 10

        lblBCODE.Left = (Me.ClientSize.Width / 2) - (lblBCODE.Width / 2)
        txtBCODE.Left = (Me.ClientSize.Width / 2) - (txtBCODE.Width / 2)

        btnRegister.Left = (Me.ClientSize.Width / 2) - (btnRegister.Width / 2)
        lblBCODE.Left = (Me.ClientSize.Width / 2) - (lblBCODE.Width / 2)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        frmBusinessLogin.Show()
    End Sub
End Class