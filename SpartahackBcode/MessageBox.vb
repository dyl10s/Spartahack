Public Class MessageBox

    Dim title As String
    Public output As String = ""
    Public sentOutput As Boolean = False

    Private Sub MessageBox_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CenterToScreen()

        bunGradPan.GradientTopLeft = ColorTranslator.FromHtml("#191654")
        bunGradPan.GradientTopRight = ColorTranslator.FromHtml("#191654")

        bunGradPan.GradientBottomLeft = ColorTranslator.FromHtml("#43C6AC")
        bunGradPan.GradientBottomRight = ColorTranslator.FromHtml("#43C6AC")
    End Sub

    Public Sub setText(str As String)
        lblFile.Text = str
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class