Imports System.Net

Public Class frmMainUpdated

    Dim cons As New List(Of connections)
    Dim connect As connections
    Public user As clsUser

    Private Sub frmMainUpdated_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CenterToScreen()

        bunGradPan.GradientTopLeft = ColorTranslator.FromHtml("#191654")
        bunGradPan.GradientTopRight = ColorTranslator.FromHtml("#191654")

        bunGradPan.GradientBottomLeft = ColorTranslator.FromHtml("#43C6AC")
        bunGradPan.GradientBottomRight = ColorTranslator.FromHtml("#43C6AC")

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

                'extractThumbnail.GetThumbnail(System.AppDomain.CurrentDomain.BaseDirectory() + i.Split("~")(1).Split("/")(i.Split("~")(1).Split("/").Length - 1))
                FlowLayoutPanel1.Controls.Add(item)
                Me.cons.Add(item)
            End If
        Next
        sqlCon.close()

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
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

    Private Sub btnSignOut_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        Dim frmLogin As New frmLoginUpdated
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub btnUploadFile_Click(sender As Object, e As EventArgs)
        addNew(InputBoxUpdated("What would you like your file named (Ex. Resume, Buisiness Card)"), "file")
    End Sub

    Public Sub addNew(name As String, type As String)

        connect = New connections
        connect.lblTitle.Text = name
        connect.textData = name
        connect.type = type

        If type = "link" Then
            pLink.Show()
        End If

        If type = "file" Then
            pFile.Show()
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblUploadFile.Click
        addNew(InputBoxUpdated("What would you like your link named (Ex. Linked In, Personal Website)"), "link")
    End Sub

    Private Sub lblConnectLink_Click(sender As Object, e As EventArgs) Handles lblConnectLink.Click
        addNew(InputBoxUpdated("What would you like your file named (Ex. Resume, Buisiness Card)"), "file")
    End Sub

    Private Sub btnFileUpload_Click(sender As Object, e As EventArgs) Handles btnFileUpload.Click
        addNew(InputBoxUpdated("What would you like your file named (Ex. Resume, Buisiness Card)"), "file")
    End Sub

    Private Sub BunifuImageButton4_Click(sender As Object, e As EventArgs) Handles btnLink.Click
        addNew(InputBoxUpdated("What would you like your link named (Ex. Linked In, Personal Website)"), "link")
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
            txtInfo.Text = OpenFileDialog1.FileName
        End If
    End Sub
End Class