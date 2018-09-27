Module Module1

    Sub Main()
        Dim input As Integer
        input = Console.ReadLine()

        If (input = 1) Then
            Console.WriteLine("Menu option 1 is selected")
        ElseIf (input = 2) Then
            Console.WriteLine("Menu option 2 is selected")
        ElseIf (input = 3) Then
            Console.WriteLine("Menu option 3 is selected")
            ' IF
        ElseIf (input = 4) Then
            Console.WriteLine("Menu option 4 is selected")
        Else
            Console.WriteLine("Not valid")
        End If
    End Sub

End Module
