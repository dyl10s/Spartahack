Public Class frmBusinessBcode

    Public user As clsUser

    Private Sub frmBusinessBcode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        pbLogo.Left = (Me.ClientSize.Width / 2) - (pbLogo.Width / 2)
        lblBus.Left = (Me.ClientSize.Width / 2) - (lblBus.Width / 2)
        lblBCODE.Left = (Me.ClientSize.Width / 2) - (lblBCODE.Width / 2)
        btnSubmit.Left = (Me.ClientSize.Width / 2) - (btnSubmit.Width / 2)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim frm As New frmBusinessLogin
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class