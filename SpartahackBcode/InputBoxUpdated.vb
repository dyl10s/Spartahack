Public Class InputBoxUpdated

    Dim title As String

    Private Sub InputBoxUpdated_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        bunGradPan.GradientTopLeft = ColorTranslator.FromHtml("#191654")
        bunGradPan.GradientTopRight = ColorTranslator.FromHtml("#191654")

        bunGradPan.GradientBottomLeft = ColorTranslator.FromHtml("#43C6AC")
        bunGradPan.GradientBottomRight = ColorTranslator.FromHtml("#43C6AC")
    End Sub

    Public Sub New(str As String)

    End Sub
End Class