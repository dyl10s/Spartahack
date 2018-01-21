Imports System.IO
Imports System.Net

Public Class frmDownloadDialog

    Public connect As connections
    Public cons As New List(Of connections)

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub frmDownloadDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFullName.Left = (Me.ClientSize.Width / 2) - (lblFullName.Width / 2)
        lblAddContact.Left = (Me.ClientSize.Width / 2) - (lblAddContact.Width / 2)
        Me.CenterToScreen()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then

            Dim c As connections = connect

            Dim saveDir As String = FolderBrowserDialog1.SelectedPath + "/"
            My.Computer.FileSystem.CreateDirectory(saveDir)

            If c.type = "link" Then

                My.Computer.FileSystem.WriteAllText((saveDir + c.lblTitle.Text + ".url").Replace("/", "\"), String.Format("[InternetShortcut]{0}URL={1}{0}", vbCrLf, c.path), False)

            End If

            If c.type = "file" Then

                Dim client As WebClient = New WebClient
                client.Credentials = New NetworkCredential("1969568_admin", "soccer2121")
                saveDir = (saveDir + c.path.Split("/")(c.path.Split("/").Count - 1)).Replace("/", "\")
                client.DownloadFile(c.path, saveDir)

            End If

        End If





    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click

        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then



            For Each c As connections In cons
                Dim saveDir As String = FolderBrowserDialog1.SelectedPath + "/" + lblFullName.Text.Replace(" ", "") + "/"
                My.Computer.FileSystem.CreateDirectory(saveDir)

                If c.type = "link" Then

                    My.Computer.FileSystem.WriteAllText((saveDir + c.lblTitle.Text + ".url").Replace("/", "\"), String.Format("[InternetShortcut]{0}URL={1}{0}", vbCrLf, c.path), False)

                End If

                If c.type = "file" Then

                    Dim client As WebClient = New WebClient
                    client.Credentials = New NetworkCredential("1969568_admin", "soccer2121")
                    saveDir = (saveDir + c.path.Split("/")(c.path.Split("/").Count - 1)).Replace("/", "\")
                    client.DownloadFile(c.path, saveDir)

                End If

            Next

        End If

    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click

        For Each c As connections In cons
            If connect.lblTitle.Text = c.lblTitle.Text Then

                If c.type = "link" Then

                    Process.Start(c.path)

                End If

                If c.type = "file" Then

                    Dim client As WebClient = New WebClient
                    client.Credentials = New NetworkCredential("1969568_admin", "soccer2121")
                    client.DownloadFile(c.path, Directory.GetCurrentDirectory() + c.path.Split("/")(c.path.Split("/").Count - 1))
                    Process.Start(Directory.GetCurrentDirectory() + c.path.Split("/")(c.path.Split("/").Count - 1))

                End If

            End If
        Next

    End Sub

    Private Sub FlowLayoutPanel1_Click(sender As Object, e As EventArgs) Handles FlowLayoutPanel1.Click

        connect = Nothing

        For Each con As connections In cons
            con.lblTitle.BackColor = Color.Navy
            con.lblType.BackColor = Color.Navy
        Next

    End Sub
End Class