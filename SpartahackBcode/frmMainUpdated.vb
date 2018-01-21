Imports System.IO
Imports System.Net

Public Class frmMainUpdated

    Public cons As New List(Of connections)
    Public connect As connections
    Public user As clsUser

    Private Sub frmMainUpdated_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CenterToScreen()

        Me.cons.Clear()
        FlowLayoutPanel1.Controls.Clear()
        connect = Nothing

        Dim sqlCon As New sqlManager

        Dim cons As String() = sqlCon.getData("select * from connections where bCode = '" + user.bCode + "'", 5).Split(";")

        Dim client As WebClient = New WebClient
        client.Credentials = New NetworkCredential("1969568_admin", "soccer2121")

        For Each i As String In cons
            If i <> "" Then
                Dim item As New connections(Me)
                item.type = i.Split("~")(0)

                If item.type = "file" Then
                    item.lblTitle.Text = i.Split("~")(3)
                End If

                If item.type = "link" Then
                    item.lblTitle.Text = i.Split("~")(3)
                End If
                item.textData = i.Split("~")(1)
                item.id = Integer.Parse(i.Split("~")(4))

                'extractThumbnail.GetThumbnail(System.AppDomain.CurrentDomain.BaseDirectory() + i.Split("~")(1).Split("/")(i.Split("~")(1).Split("/").Length - 1))
                FlowLayoutPanel1.Controls.Add(item)
                Me.cons.Add(item)
            End If
        Next
        sqlCon.close()

        For Each c As connections In Me.cons
            c.setText()
        Next


    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim client As WebClient = New WebClient
        client.Credentials = New NetworkCredential("1969568_admin", "soccer2121")

        Me.cons.Remove(connect)
        FlowLayoutPanel1.Controls.Remove(connect)

        Dim sqlCon As New sqlManager
        sqlCon.sendData("Delete from connections where id = " + connect.id.ToString)
        sqlCon.sendData("Insert Into connections (type, url, bCode, name) VALUES ('" + connect.type + "', '" + txtInfoLink.Text + "', '" + user.bCode + "' , '" + connect.lblTitle.Text + "')")

        Dim m As New MessageBox("Upload Complete")

        pFile.Visible = False
        pLink.Visible = False
        Me.cons.Add(connect)
        FlowLayoutPanel1.Controls.Add(connect)
        sqlCon.close()

        frmMainUpdated_Load(sender, e)

    End Sub

    Private Sub btnSignOut_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        Dim frmLogin As New frmLoginUpdated
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub btnUploadFile_Click(sender As Object, e As EventArgs)

        Dim ib As New InputBoxUpdated()
        ib.setText("What would you like your file name to be (Ex. Resume, Business Card)")
        ib.ShowDialog()

        If ib.sentOutput = True Then
            addNew(ib.output, "file")
        End If

    End Sub

    Public Sub addNew(name As String, type As String)

        connect = New connections(Me)
        connect.lblTitle.Text = name
        connect.textData = name
        connect.type = type
        connect.path = ""

        If type = "link" Then
            txtInfoLink.Text = ""
            pLink.Show()
            pFile.Hide()
        End If

        If type = "file" Then
            txtInfoLink.Text = ""
            pFile.Show()
            pLink.Hide()
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblUploadFile.Click

        Dim ib As New InputBoxUpdated()
        ib.setText("What would you like your file name to be (Ex. Resume, Business Card)")
        ib.ShowDialog()

        If ib.sentOutput = True Then
            addNew(ib.output, "file")
        End If

    End Sub

    Private Sub lblConnectLink_Click(sender As Object, e As EventArgs) Handles lblConnectLink.Click

        Dim ib As New InputBoxUpdated()
        ib.setText("What would you like your link name to be (Ex. Linked In, Personal Website)")
        ib.ShowDialog()

        If ib.sentOutput = True Then
            addNew(ib.output, "link")
        End If

    End Sub

    Private Sub btnFileUpload_Click(sender As Object, e As EventArgs) Handles btnFileUpload.Click

        Dim ib As New InputBoxUpdated()
        ib.setText("What would you like your file name to be (Ex. Resume, Business Card)")
        ib.ShowDialog()

        If ib.sentOutput = True Then
            addNew(ib.output, "file")
        End If

    End Sub

    Private Sub BunifuImageButton4_Click(sender As Object, e As EventArgs) Handles btnLink.Click

        Dim ib As New InputBoxUpdated()
        ib.setText("What would you like your link named (Ex. Linked In, Personal Website)")
        ib.ShowDialog()

        If ib.sentOutput = True Then
            addNew(ib.output, "link")
        End If

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click
        Dim frmLogin As New frmLoginUpdated
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub btnFindFile_Click(sender As Object, e As EventArgs) Handles btnFindFile.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            txtFileLink.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click

        Dim client As WebClient = New WebClient
        client.Credentials = New NetworkCredential("1969568_admin", "soccer2121")
        Dim ftpLocation As String = "ftp://spartaack.atwebpages.com/" + connect.lblTitle.Text + "." + txtFileLink.Text.Split(".")(txtFileLink.Text.Split(".").Count - 1)
        client.UploadFile("ftp://spartaack.atwebpages.com/" + connect.lblTitle.Text + "." + txtFileLink.Text.Split(".")(txtFileLink.Text.Split(".").Count - 1), txtFileLink.Text)

        Dim sqlCon As New sqlManager
        sqlCon.sendData("delete from connections where id =" + connect.id.ToString)
        sqlCon.sendData("Insert Into connections (type, url, bCode, name) VALUES ('" + connect.type + "', '" + ftpLocation + "', '" + user.bCode + "' , '" + connect.lblTitle.Text + "')")

        Dim m As New MessageBox("Upload Complete")
        pFile.Visible = False
        pLink.Visible = False
        Me.cons.Add(connect)
        FlowLayoutPanel1.Controls.Add(connect)
        sqlCon.close()

        frmMainUpdated_Load(sender, e)

    End Sub

    Private Sub FlowLayoutPanel1_Click(sender As Object, e As EventArgs) Handles FlowLayoutPanel1.Click

        For Each con As connections In cons
            con.lblTitle.BackColor = Color.Navy
            con.lblType.BackColor = Color.Navy
        Next

        pLink.Hide()
        pFile.Hide()
        connect = Nothing

    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click

        If connect IsNot Nothing Then

            Dim sqlCon As New sqlManager
            Dim data As String = sqlCon.getData("select * from connections where id =" + connect.id.ToString, 5)

            Dim type As String = data.Split("~")(0)
            Dim url As String = data.Split("~")(1)

            If type = "link" Then

                Process.Start(url)

            End If

            If type = "file" Then

                Dim client As WebClient = New WebClient
                client.Credentials = New NetworkCredential("1969568_admin", "soccer2121")
                Dim ftpLocation As String = "ftp://spartaack.atwebpages.com/" + connect.lblTitle.Text + "." + txtFileLink.Text.Split(".")(txtFileLink.Text.Split(".").Count - 1)
                client.DownloadFile("ftp://spartaack.atwebpages.com/" + connect.lblTitle.Text + "." + url.Split(".")(url.Split(".").Count - 1), Directory.GetCurrentDirectory() + connect.lblTitle.Text + "." + url.Split(".")(url.Split(".").Count - 1))
                Process.Start(Directory.GetCurrentDirectory() + connect.lblTitle.Text + "." + url.Split(".")(url.Split(".").Count - 1))

            End If



        End If

    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click

        If connect IsNot Nothing Then

            Dim sqlCon As New sqlManager
            sqlCon.sendData("delete from connections where id =" + connect.id.ToString)

            Me.cons.Remove(connect)
            FlowLayoutPanel1.Controls.Remove(connect)
            connect = Nothing
            pFile.Visible = False
            pLink.Visible = False
        End If

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles btnDeleteLink.Click

        If connect IsNot Nothing Then

            Dim sqlCon As New sqlManager
            sqlCon.sendData("delete from connections where id =" + connect.id.ToString)

            Me.cons.Remove(connect)
            FlowLayoutPanel1.Controls.Remove(connect)
            connect = Nothing
            pFile.Visible = False
            pLink.Visible = False
        End If

    End Sub

    Private Sub BunifuFlatButton2(sender As Object, e As EventArgs) Handles btnOpenLink.Click

        If connect IsNot Nothing Then

            Dim sqlCon As New sqlManager
            Dim data As String = sqlCon.getData("select * from connections where id =" + connect.id.ToString, 5)

            Dim type As String = data.Split("~")(0)
            Dim url As String = data.Split("~")(1)

            If type = "link" Then

                Process.Start(url)

            End If

            If type = "file" Then

                Dim client As WebClient = New WebClient
                client.Credentials = New NetworkCredential("1969568_admin", "soccer2121")
                Dim ftpLocation As String = "ftp://spartaack.atwebpages.com/" + connect.lblTitle.Text + "." + txtFileLink.Text.Split(".")(txtFileLink.Text.Split(".").Count - 1)
                client.DownloadFile("ftp://spartaack.atwebpages.com/" + connect.lblTitle.Text + "." + url.Split(".")(url.Split(".").Count - 1), Directory.GetCurrentDirectory() + connect.lblTitle.Text + "." + url.Split(".")(url.Split(".").Count - 1))
                Process.Start(Directory.GetCurrentDirectory() + connect.lblTitle.Text + "." + url.Split(".")(url.Split(".").Count - 1))

            End If



        End If

    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs)
        Dim webAddress As String = txtInfoLink.Text

        Process.Start(webAddress)
    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub
End Class