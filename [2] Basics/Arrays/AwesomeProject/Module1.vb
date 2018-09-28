Module Module1

    Sub Main()
        Dim arr(5) As Integer

        ' 0 to n - 1
        arr(0) = 1
        arr(1) = 2
        arr(2) = 3
        arr(3) = 4
        arr(4) = 5

        Console.WriteLine(arr(0))
        Console.WriteLine(arr(1))
        Console.WriteLine(arr(2))
        Console.WriteLine(arr(3))
        Console.WriteLine(arr(4))

        Dim multi(2, 2) As Double

        multi(0, 0) = 0
        multi(0, 1) = 1
        multi(1, 0) = 2
        multi(1, 1) = 3

        Console.WriteLine(multi(0, 0))
        Console.WriteLine(multi(0, 1))
        Console.WriteLine(multi(1, 0))
        Console.WriteLine(multi(1, 1))
    End Sub

End Module
