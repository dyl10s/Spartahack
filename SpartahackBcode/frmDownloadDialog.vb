Imports System.IO
Imports System.Net

Public Class frmDownloadDialog
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub frmDownloadDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFullName.Left = (Me.ClientSize.Width / 2) - (lblFullName.Width / 2)
        lblAddContact.Left = (Me.ClientSize.Width / 2) - (lblAddContact.Width / 2)
    End Sub
End Class