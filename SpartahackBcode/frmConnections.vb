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

            mainForm.Panel2.Visible = True

        End If

    End Sub
End Class