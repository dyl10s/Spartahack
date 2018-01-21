Public Class connections

    Public type As String = ""
    Public textData As String = ""
    Public path As String = ""
    Public id As Integer

    Public typeInt As Integer = 0

    Public mainForm As frmMainUpdated
    Public mainForm2 As frmDownloadDialog

    Public Sub New(ByRef frm As frmMainUpdated)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If typeInt = 0 Then
            mainForm = frm
        End If

    End Sub


    Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click, lblType.Click

        If typeInt = 0 Then

            mainForm.connect = Me

            For Each con As connections In mainForm.cons
                con.lblTitle.BackColor = Color.Navy
                con.lblType.BackColor = Color.Navy
            Next

            Me.lblTitle.BackColor = Color.Blue
            Me.lblType.BackColor = Color.Blue

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

        End If

        If typeInt = 1 Then

            mainForm2.connect = Me

            For Each con As connections In mainForm2.cons
                con.lblTitle.BackColor = Color.Navy
                con.lblType.BackColor = Color.Navy
            Next

            Me.lblTitle.BackColor = Color.Blue
            Me.lblType.BackColor = Color.Blue

        End If


    End Sub

    Private Sub connections_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged

        lblType.Text = "(" + Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(type) + ")"

    End Sub

    Public Sub setText()
        lblType.Text = "(" + Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(type) + ")"
    End Sub
End Class
