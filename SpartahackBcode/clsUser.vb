Public Class clsUser

    Public fName As String = ""
    Public lName As String = ""
    Public email As String = ""
    Public bCode As String = ""

    Public Sub New(firstName As String, LastName As String, Email As String, bCode As String)

        fName = firstName
        lName = LastName
        Me.email = Email
        Me.bCode = bCode

    End Sub

End Class
