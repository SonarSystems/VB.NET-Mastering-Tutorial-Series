Module Module1

    Sub Main()
        Dim i As Integer

        ' For Loop
        Console.WriteLine("For Loop")
        Console.WriteLine("--------")
        For i = 0 To 100 Step 1
            Console.WriteLine(i)
        Next

        Console.WriteLine()

        ' While Loop
        Console.WriteLine("While Loop")
        Console.WriteLine("----------")
        i = 0
        While i <= 100
            Console.WriteLine(i)
            i += 1
        End While

        Console.WriteLine()

        ' While Loop
        Console.WriteLine("Do While Loop")
        Console.WriteLine("----------")
        i = 0
        Do
            Console.WriteLine(i)
            i += 1
        Loop While (i <= 100)
    End Sub

End Module
