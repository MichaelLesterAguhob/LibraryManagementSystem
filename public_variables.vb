Module public_variables


    Public account_type_loggedin As String
    Public loggedin As Integer = 0

    Public Function MD5(ByVal sPassword As String) As String
        Dim p As New Security.Cryptography.MD5CryptoServiceProvider()
        Dim bs As Byte() = Text.Encoding.UTF8.GetBytes(sPassword)
        bs = p.ComputeHash(bs)
        Dim s As New Text.StringBuilder()
        For Each b As Byte In bs
            s.Append(b.ToString("x²").ToLower())
        Next
        Return s.ToString()
    End Function


End Module
