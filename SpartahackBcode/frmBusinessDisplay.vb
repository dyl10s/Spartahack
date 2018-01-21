Imports System.IO
Imports System.Net

Public Class frmBusinessDisplay

    Public myConnections As New List(Of connections)

    Private Sub frmBusinessDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each c As connections In myConnections

            lbItems.Items.Add(c.lblTitle.Text)

        Next


    End Sub

    Public Sub New(dataList As List(Of connections))

        ' This call is required by the designer.
        InitializeComponent()

        For Each c As connections In dataList
            myConnections.Add(c)
        Next

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click

        For Each c As connections In myConnections
            If lbItems.SelectedItem.ToString = c.lblTitle.Text Then

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
End Class