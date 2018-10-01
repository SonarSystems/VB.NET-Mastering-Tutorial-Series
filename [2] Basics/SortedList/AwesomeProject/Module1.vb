Module Module1

    Sub Main()
        Dim sorted As SortedList = New SortedList()

        sorted.Add("1", "One")
        sorted.Add("8", "Two")
        sorted.Add("3", "Three")
        sorted.Add("7", "Four")
        sorted.Add("2", "Five")

        'Console.WriteLine(sorted("2"))

        For Each key In sorted.Keys
            Console.WriteLine(key + " : " + sorted(key))
        Next

        If (sorted.ContainsKey("43")) Then
            Console.WriteLine("Yes it contains this key")
        Else
            Console.WriteLine("No it doesn't contain this key")
        End If
    End Sub

End Module
