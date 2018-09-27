Module Module1

    Sub Main()
        Dim str As String
        Dim str2 As String
        str = "Hello"
        str2 = "World"

        Dim newStr = str + " " + str2

        Console.WriteLine(newStr)

        Dim len As Integer
        len = newStr.Length

        Console.WriteLine(len)


        Console.WriteLine(newStr.ToUpper())
    End Sub

End Module
