Module Module1

    Class Car
        Public speed As Integer
        Public health As Double

        Public Sub DamageCar(ByVal amount As Integer)
            health = health - amount
        End Sub

        Public Sub New()
            speed = 120
            health = 100
        End Sub

        Protected Overrides Sub Finalize()
            Console.WriteLine("This is the end")
        End Sub
    End Class

    Sub Main()
        Dim c1 As Car = New Car()
        Dim c2 As Car = New Car()

        Console.WriteLine(c1.speed)
        Console.WriteLine(c1.health)
        Console.WriteLine(c2.speed)
        Console.WriteLine(c2.health)

        c1.DamageCar(14)

        Console.WriteLine(c1.health)
        Console.WriteLine(c2.health)
    End Sub

End Module
