﻿Public Class connections

    Public type As String = ""
    Public textData As String = ""
    Public path As String = ""

    Public mainForm As frmMain

    Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

        mainForm.connect = Me

        If type = "file" Then

            mainForm.pFile.Show()
            mainForm.connect = Me

        End If

        If type = "link" Then

            mainForm.pLink.Show()
            mainForm.connect = Me

        End If

    End Sub
End Class
