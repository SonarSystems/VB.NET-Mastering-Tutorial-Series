Module Module1

    Sub Main()
        Dim num1 As Integer
        Dim num2 As Integer

        Dim val As Integer

        num1 = 5
        num2 = 1

        Try
            val = num1 / num2
        Catch ex As Exception
            Console.WriteLine("Naughty naughty, division by zero not allowed")
        Finally
            Console.WriteLine("Finally block")
        End Try

        Console.WriteLine("Hello")
    End Sub

End Module
