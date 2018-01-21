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
        Dim data As String() = sqlCon.getData("Select * from connections where bCode ='" + txtCode.Text + "'", 5).Split(";")

        Dim connections As New List(Of connections)

        For Each s As String In data
            If s <> "" Then
                connect = New connections(Nothing)
                Dim dataString As String() = s.Split("~")
                connect.type = dataString(0)
                connect.path = dataString(1)
                connect.id = dataString(4)
                connect.lblTitle.Text = dataString(3)
                connections.Add(connect)
            End If
        Next

        Dim userData() = sqlCon.getData("Select FirstName, LastName from users where bCode='" + txtCode.Text + "'", 2).Split("~")
        Dim frmDisplay As New frmDownloadDialog()
        frmDisplay.lblFullName.Text = userData(0) + " " + userData(1)

        For Each c As connections In connections
            c.typeInt = 1
            c.mainForm2 = frmDisplay
            frmDisplay.FlowLayoutPanel1.Controls.Add(c)
            frmDisplay.cons.Add(c)
        Next


        sqlCon.close()
        frmDisplay.Show()
        Me.Hide()

    End Sub
End Class