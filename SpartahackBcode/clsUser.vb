Public Class clsUser

    Public fName As String = ""
    Public lName As String = ""
    Public email As String = ""

    Public Sub New(firstName As String, LastName As String, Email As String)

        fName = firstName
        lName = LastName
        Me.email = Email

    End Sub

End Class
