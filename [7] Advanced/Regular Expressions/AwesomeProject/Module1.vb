Imports System.Text.RegularExpressions

Module Module1

    Sub Main()
        Dim str As String = "Hello this is Frahaan"

        Dim expression As String = "\bH\S*"

        Dim matchC As MatchCollection = Regex.Matches(str, expression)
        Dim loopy As Match

        Dim counter As Integer = 0

        For Each loopy In matchC
            Console.WriteLine(loopy)
            counter = counter + 1
        Next

        Console.WriteLine(counter)

    End Sub

End Module
