Module Module1

    Sub Main()
        Dim arrList As ArrayList = New ArrayList()

        arrList.Add(90)
        arrList.Add(3)
        arrList.Add(56)

        Console.WriteLine(arrList.Count)

        Dim val As Integer

        For Each val In arrList
            Console.WriteLine(val)
        Next
    End Sub

End Module
