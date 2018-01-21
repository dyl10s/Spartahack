Imports MySql.Data.MySqlClient

Public Class sqlManager

    Public serverName As String = "den1.mysql6.gear.host"
    Public serverPass As String = "Gp7xVu_UKU!W"
    Public serverUsername As String = "spartahack"

    Dim db As New MySqlConnection()

    Public Sub New()

        db.ConnectionString = "SSLMode=none;server=" & serverName & ";uid=" & serverUsername & ";pwd=" & serverPass & ";database=" & "spartahack"
        db.Open()

    End Sub

    Public Sub sendData(cmd As String)

        Dim command As New MySqlCommand
        command.Connection = db
        command.CommandText = cmd
        command.ExecuteScalar()

    End Sub

    Public Function getData(cmd As String, itemCount As Integer) As String

        Dim command As New MySqlCommand
        command.Connection = db
        command.CommandText = cmd

        Dim dataReader As MySqlDataReader = command.ExecuteReader()

        Dim returnValue As String = ""

        While (dataReader.Read())

            For i As Integer = 0 To itemCount - 1

                Dim data = dataReader.Item(i)
                returnValue += data.ToString + "~"

            Next

            returnValue += ";"

        End While

        dataReader.Close()

        Return returnValue

    End Function

    Public Sub close()

        db.Close()

    End Sub


End Class
