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
        connect.type = type

        If type = "link" Then

            lblType.Text = "Link:"

        End If

        If type = "file" Then

            lblType.Text = "File:"

        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim client As WebClient = New WebClient
        client.Credentials = New NetworkCredential("1969568_admin", "soccer2121")
        Dim ftpLocation As String = "ftp://spartaack.atwebpages.com/" + connect.lblTitle.Text + "." + txtInfo.Text.Split(".")(txtInfo.Text.Split(".").Count - 1)
        client.UploadFile("ftp://spartaack.atwebpages.com/" + connect.lblTitle.Text + "." + txtInfo.Text.Split(".")(txtInfo.Text.Split(".").Count - 1), txtInfo.Text)

        Dim sqlCon As New sqlManager
        sqlCon.sendData("Insert Into connections (type, url, bCode) VALUES ('" + connect.type + "', '" + ftpLocation + "', '" + user.bCode + "')")

        MsgBox("Upload Complete")
        Panel2.Visible = False
        Me.cons.Add(connect)
        FlowLayoutPanel1.Controls.Add(connect)
        sqlCon.close()

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim sqlCon As New sqlManager

        Dim cons As String() = sqlCon.getData("select * from connections where bCode = '" + user.bCode + "'", 3).Split(";")

        Dim client As WebClient = New WebClient
        client.Credentials = New NetworkCredential("1969568_admin", "soccer2121")

        For Each i As String In cons
            If i <> "" Then
                Dim item As New connections
                item.type = i.Split("~")(0)
                item.lblTitle.Text = i.Split("~")(1).Split("/")(i.Split("~")(1).Split("/").Length - 1).Split(".")(0)
                My.Computer.FileSystem.CreateDirectory(System.AppDomain.CurrentDomain.BaseDirectory())
                client.DownloadFile("ftp://spartaack.atwebpages.com/" + i.Split("~")(1).Split("/")(i.Split("~")(1).Split("/").Length - 1), System.AppDomain.CurrentDomain.BaseDirectory() + i.Split("~")(1).Split("/")(i.Split("~")(1).Split("/").Length - 1))
                Try
                    item.pbPreview.Image = Image.FromFile(System.AppDomain.CurrentDomain.BaseDirectory() + i.Split("~")(1).Split("/")(i.Split("~")(1).Split("/").Length - 1))
                Catch ex As Exception

                End Try
                'extractThumbnail.GetThumbnail(System.AppDomain.CurrentDomain.BaseDirectory() + i.Split("~")(1).Split("/")(i.Split("~")(1).Split("/").Length - 1))
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim frmCons As New frmConnections(Me)
        frmCons.Show()

    End Sub
End Class