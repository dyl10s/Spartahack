Public Class frmConnections

    Dim mainForm As frmMain

    Public Sub New(ByRef form As frmMain)

        ' This call is required by the designer.
        InitializeComponent()
        mainForm = form
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If lbConnections.SelectedItem <> Nothing Then

            mainForm.pFile.Visible = True
            mainForm.addNew(lbConnections.SelectedItem.ToString, "file")
        End If

    End Sub

    Private Sub lbConnections_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbConnections.SelectedIndexChanged

    End Sub
End Class