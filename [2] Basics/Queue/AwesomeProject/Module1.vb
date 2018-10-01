Module Module1

    Sub Main()
        Dim queue As Queue = New Queue()

        queue.Enqueue("One")
        queue.Enqueue("Two")
        queue.Enqueue("Three")
        queue.Enqueue("Four")
        queue.Enqueue("Five")

        Dim str As String

        For Each str In queue
            Console.WriteLine(str)
        Next

        queue.Dequeue()
        queue.Dequeue()
        queue.Dequeue()

        Console.WriteLine()
        Console.WriteLine("After dequeuing")

        For Each str In queue
            Console.WriteLine(str)
        Next
    End Sub

End Module
