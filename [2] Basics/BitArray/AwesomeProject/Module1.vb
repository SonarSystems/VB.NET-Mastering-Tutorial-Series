Module Module1

    Sub Main()
        Dim bit As BitArray = New BitArray(8)

        Dim bytey() As Byte = {167}

        bit = New BitArray(bytey)

        Dim itr As Integer

        For itr = 0 To bit.Count
            Console.WriteLine(bit(itr))
        Next itr
    End Sub

End Module
