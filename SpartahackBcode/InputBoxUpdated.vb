﻿Public Class InputBoxUpdated

    Dim title As String
    Public output As String = ""
    Public sentOutput As Boolean = False

    Private Sub InputBoxUpdated_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        bunGradPan.GradientTopLeft = ColorTranslator.FromHtml("#191654")
        bunGradPan.GradientTopRight = ColorTranslator.FromHtml("#191654")

        bunGradPan.GradientBottomLeft = ColorTranslator.FromHtml("#43C6AC")
        bunGradPan.GradientBottomRight = ColorTranslator.FromHtml("#43C6AC")

        'txtFileLink.BackColor = Color.Transparent
    End Sub

    Public Sub setText(str As String)
        lblFile.Text = str
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click

        sentOutput = True
        output = txtFileLink.Text
        Me.Close()

    End Sub

End Class