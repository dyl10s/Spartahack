Imports System.Text.RegularExpressions

Public Class frmRegisterUpdated
    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs)
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub frmRegisterUpdated_Load(sender As Object, e As EventArgs) Handles Me.Load
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
        frmLoginUpdated.Show()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If (txtBCODE.Text = Nothing Or txtEmail.Text = Nothing Or txtFirstName.Text = Nothing Or txtLastName.Text = Nothing Or txtPass.Text = Nothing Or txtRetryPass.Text = Nothing) Then
            Dim m As New MessageBox("Please fill out all fields.")
        Else
            If (IsEmail(txtEmail.Text) = True) Then
                If (txtPass.Text = txtRetryPass.Text) Then
                    Dim sqlCon As New sqlManager
                    Try
                        sqlCon.sendData(String.Format("Call register('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", txtEmail.Text, txtPass.Text, txtFirstName.Text, txtLastName.Text, txtBCODE.Text, 0))
                        Dim form As New frmLoginUpdated
                        form.Show()
                        Me.Hide()
                    Catch ex As Exception
                        Dim m As New MessageBox("Registration Failed")
                    End Try
                Else
                    Dim m As New MessageBox("Passwords do not match.")
                End If
            Else
                Dim m As New MessageBox("Please enter a valid email.")
            End If
        End If
    End Sub

    Private Sub btnExit_Click_1(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Function IsEmail(ByVal email As String) As Boolean
        Static emailExpression As New Regex("^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$")

        Return emailExpression.IsMatch(email)
    End Function
End Class