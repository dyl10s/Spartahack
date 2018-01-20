Imports System.Net

Public Class frmMainUpdated

    Dim cons As New List(Of connections)
    Dim connect As connections
    Public user As clsUser

    Private Sub frmMainUpdated_Load(sender As Object, e As EventArgs) Handles Me.Load
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
End Class