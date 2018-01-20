Public Class connections

    Public type As String = ""
    Public textData As String = ""
    Public path As String = ""

    Public mainForm As frmMainUpdated

    Public Sub New(ByRef frm As frmMainUpdated)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        mainForm = frm
    End Sub

    Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

        mainForm.connect = Me

        If type = "file" Then

            mainForm.pFile.Show()
            mainForm.connect = Me
            mainForm.pLink.Hide()

        End If

        If type = "link" Then

            mainForm.pLink.Show()
            mainForm.connect = Me
            mainForm.pFile.Hide()
        End If

    End Sub
End Class
