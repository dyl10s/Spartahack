Public Class frmMain

    Dim cons As New List(Of connections)
    Dim connect As connections
    Public user As clsUser

    Private Sub btnSignOut_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click

        Dim frmLogin As New frmLogin
        frmLogin.Show()
        Me.Close()

    End Sub

    Public Sub addNew(name As String, type As String)

        connect = New connections
        connect.lblTitle.Text = name

        If type = "link" Then

            lblType.Text = "Link:"

        End If

        If type = "file" Then

            lblType.Text = "File:"

        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim sqlCon As New sqlManager
        sqlCon.sendData("Insert Into connections (type, url, bCode) VALUES ('" + connect.type + "', '" + txtInfo.Text + "', " + user.bCode + "')")

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class