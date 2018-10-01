Module Module1

    Sub Main()
        Dim hash As Hashtable = New Hashtable()

        hash.Add("1", "One")
        hash.Add("2", "Two")
        hash.Add("3", "Three")
        hash.Add("4", "Four")
        hash.Add("5", "Five")

        Console.WriteLine(hash("2"))

        For Each key In hash.Keys
            Console.WriteLine(hash(key))
        Next

        If (hash.ContainsKey("43")) Then
            Console.WriteLine("Yes it contains this key")
        Else
            Console.WriteLine("No it doesn't contain this key")
        End If
    End Sub

End Module
