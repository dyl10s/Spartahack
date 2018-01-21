Imports System.Net

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

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Dim connect As connections
        Dim sqlCon As New sqlManager
        Dim data As String() = sqlCon.getData("Select * from connections where bCode ='" + txtCode.Text + "'", 5).Split(":")

        Dim type As String
        Dim url As String
        Dim name As String

        For Each s As String In data
            Dim dataString As String() = s.Split("~")
            type = dataString(0)
            url = dataString(1)
            name = dataString(3)
        Next

        If type = "link" Then
            Dim fw As New System.IO.StreamWriter(System.IO.Directory.GetCurrentDirectory + "")
        End If

        If type = "file" Then
            Dim client As WebClient = New WebClient
            client.Credentials = New NetworkCredential("1969568_admin", "soccer2121")
            'Dim ftpLocation As String = "ftp://spartaack.atwebpages.com/" + connect.lblTitle.Text + "." + txtFileLink.Text.Split(".")(txtFileLink.Text.Split(".").Count - 1)
            client.DownloadFile(url, System.IO.Directory.GetCurrentDirectory)
        End If

    End Sub
End Class