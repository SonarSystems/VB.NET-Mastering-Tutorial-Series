Module Module1

    Sub AwesomeSub()
        Console.WriteLine("Hello")
    End Sub

    Sub Add(ByVal num1 As Integer, ByVal num2 As Integer)
        Dim result As Integer
        result = num1 + num2

        Console.WriteLine(result)
    End Sub

    Function AddFun(ByVal num1 As Integer, ByVal num2 As Integer) As Integer
        Dim result As Integer
        result = num1 + num2

        AddFun = result
    End Function

    Sub ByRefSub(ByRef num1 As Double)
        num1 = 8
    End Sub

    Sub ByValSub(ByVal num1 As Double)
        num1 = 8
    End Sub

    Sub Main()
        'AwesomeSub()
        'AwesomeSub()

        'Add(4, 7)

        Dim i As Double
        Dim j As Double
        i = 7.8
        j = 7.8

        'ByValSub(i)
        'ByRefSub(j)

        'Console.WriteLine(i)
        'Console.WriteLine(j)

        Dim var1 As Integer
        var1 = AddFun(6, 7)

        Console.WriteLine(AddFun(5, 6))
        Console.WriteLine(var1)
    End Sub

End Module
