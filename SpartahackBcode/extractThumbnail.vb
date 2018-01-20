Imports System.IO
Imports System.Drawing.Imaging

Public Class extractThumbnail

    Public Const THUMBNAIL_DATA As Integer = 20507

    Public Shared Function GetThumbnail(ByVal path As String) As Image
        Dim stream1 As FileStream = File.OpenRead(path)
        Dim image1 As Image = Image.FromStream(stream1, False, False)
        Dim flag1 As Boolean = False
        Dim num1 As Integer
        For num1 = 0 To image1.PropertyIdList.Length - 1
            If (image1.PropertyIdList(num1) = THUMBNAIL_DATA) Then
                flag1 = True
                Exit For
            End If
        Next num1
        If Not flag1 Then
            Return Nothing
        End If
        Dim item1 As PropertyItem = image1.GetPropertyItem(THUMBNAIL_DATA)
        stream1.Close()
        image1.Dispose()
        Dim buffer1 As Byte() = item1.Value
        Dim stream2 As New MemoryStream(buffer1.Length)
        stream2.Write(buffer1, 0, buffer1.Length)
        Return Image.FromStream(stream2)
    End Function

End Class
