Public Class clsUser

    Dim fName As String = ""
    Dim lName As String = ""
    Dim email As String = ""

    Public Sub New(firstName As String, LastName As String, Email As String)

        fName = firstName
        lName = LastName
        Me.email = Email

    End Sub

End Class
