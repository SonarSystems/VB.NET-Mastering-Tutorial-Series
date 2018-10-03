Module Module1

    Class Car
        Public speed As Integer
        Public health As Double

        Public Sub DamageCar(ByVal amount As Integer)
            health = health - amount
        End Sub
    End Class

    Sub Main()
        Dim c1 As Car = New Car()
        Dim c2 As Car = New Car()

        c1.speed = 60
        c1.health = 100
        c2.speed = 60
        c2.health = 100

        Console.WriteLine(c1.speed)
        Console.WriteLine(c1.health)
        Console.WriteLine(c2.speed)
        Console.WriteLine(c2.health)

        c1.DamageCar(14)

        Console.WriteLine(c1.health)
        Console.WriteLine(c2.health)
    End Sub

End Module
