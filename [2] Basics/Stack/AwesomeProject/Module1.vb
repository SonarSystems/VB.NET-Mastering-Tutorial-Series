Module Module1

    Sub Main()
        Dim stk As Stack = New Stack()

        stk.Push("One")
        stk.Push("Two")
        stk.Push("Three")
        stk.Push("Four")
        stk.Push("Five")

        Dim str As String

        For Each str In stk
            Console.WriteLine(str)
        Next

        stk.Pop()
        stk.Pop()
        stk.Pop()

        Console.WriteLine()
        Console.WriteLine("After popping")

        For Each str In stk
            Console.WriteLine(str)
        Next
    End Sub

End Module
