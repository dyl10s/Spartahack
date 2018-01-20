Public Class InputBoxUpdated

    Dim title As String
    Public Property TransparencyKey As Color

    Private Sub InputBoxUpdated_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        bunGradPan.GradientTopLeft = ColorTranslator.FromHtml("#191654")
        bunGradPan.GradientTopRight = ColorTranslator.FromHtml("#191654")

        bunGradPan.GradientBottomLeft = ColorTranslator.FromHtml("#43C6AC")
        bunGradPan.GradientBottomRight = ColorTranslator.FromHtml("#43C6AC")

        txtFileLink.BackColor = Color.Transparent
    End Sub

    Public Sub New(str As String)

    End Sub
End Class