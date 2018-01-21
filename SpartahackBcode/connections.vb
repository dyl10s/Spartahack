Public Class connections

    Public type As String = ""
    Public textData As String = ""
    Public path As String = ""
    Public id As Integer

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

            mainForm.txtFileLink.Text = ""
            mainForm.txtInfoLink.Text = ""
            mainForm.pLink.Hide()
            mainForm.pFile.Show()
            mainForm.txtFileLink.Text = lblTitle.Text
            mainForm.connect = Me

        End If

        If type = "link" Then

            mainForm.txtFileLink.Text = ""
            mainForm.txtInfoLink.Text = ""
            mainForm.pFile.Hide()
            mainForm.pLink.Show()
            mainForm.connect = Me
            mainForm.txtInfoLink.Text = textData

        End If

    End Sub
End Class
