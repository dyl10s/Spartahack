Imports System.Net

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
        connect.textData = name
        connect.type = type

        If type = "link" Then

            lblType.Text = "Link:"
            pLink.Show()

        End If

        If type = "file" Then

            lblType.Text = "File:"
            pFile.Show()

        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim client As WebClient = New WebClient
        client.Credentials = New NetworkCredential("1969568_admin", "soccer2121")
        Dim ftpLocation As String = "ftp://spartaack.atwebpages.com/" + connect.lblTitle.Text + "." + txtInfo.Text.Split(".")(txtInfo.Text.Split(".").Count - 1)
        client.UploadFile("ftp://spartaack.atwebpages.com/" + connect.lblTitle.Text + "." + txtInfo.Text.Split(".")(txtInfo.Text.Split(".").Count - 1), txtInfo.Text)

        Dim sqlCon As New sqlManager
        sqlCon.sendData("Insert Into connections (type, url, bCode, name) VALUES ('" + connect.type + "', '" + ftpLocation + "', '" + user.bCode + "' , '" + connect.textData + "')")

        MsgBox("Upload Complete")
        pFile.Visible = False
        pLink.Visible = False
        Me.cons.Add(connect)
        FlowLayoutPanel1.Controls.Add(connect)
        sqlCon.close()

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim sqlCon As New sqlManager

        Dim cons As String() = sqlCon.getData("select * from connections where bCode = '" + user.bCode + "'", 4).Split(";")

        Dim client As WebClient = New WebClient
        client.Credentials = New NetworkCredential("1969568_admin", "soccer2121")

        For Each i As String In cons
            If i <> "" Then
                Dim item As New connections
                item.type = i.Split("~")(0)

                If item.type = "file" Then
                    item.lblTitle.Text = i.Split("~")(3)
                End If

                If item.type = "link" Then
                    item.lblTitle.Text = i.Split("~")(3)
                End If

                FlowLayoutPanel1.Controls.Add(item)
                Me.cons.Add(item)
            End If
        Next
        sqlCon.close()


    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            txtInfo.Text = OpenFileDialog1.FileName
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnFile.Click

        addNew(InputBox("What would you like your file named (Ex. Resume, Buisiness Card)"), "file")

    End Sub

    Private Sub btnLink_Click(sender As Object, e As EventArgs) Handles btnLink.Click

        addNew(InputBox("What would you like your link named (Ex. Linked In, Personal Website)"), "link")

    End Sub

    Private Sub btnSubmitLink_Click(sender As Object, e As EventArgs) Handles btnSubmitLink.Click

        Dim client As WebClient = New WebClient
        client.Credentials = New NetworkCredential("1969568_admin", "soccer2121")

        Dim sqlCon As New sqlManager
        sqlCon.sendData("Insert Into connections (type, url, bCode, name) VALUES ('" + connect.type + "', '" + txtInfoLink.Text + "', '" + user.bCode + "' , '" + connect.textData + "')")

        MsgBox("Upload Complete")
        pFile.Visible = False
        pLink.Visible = False
        Me.cons.Add(connect)
        FlowLayoutPanel1.Controls.Add(connect)
        sqlCon.close()

    End Sub
End Class