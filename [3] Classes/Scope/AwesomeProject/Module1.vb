Module Module1

    Class Vehicle
        Private speed As Integer
        Protected health As Double
        Public Shared owner As String

        Public Sub DamageCar(ByVal amount As Integer)
            health = health - amount
        End Sub


    End Class

    ' Public
    ' Protected
    ' Private

    Class Car : Inherits Vehicle

        Public Sub New()
            speed = 120
            health = 100
        End Sub

        Public Sub HelloCar()
            Console.WriteLine("Hello I am a car")
        End Sub

        Protected Overrides Sub Finalize()
            Console.WriteLine("This is the end for the car")
        End Sub
    End Class

    Sub Main()
        Dim c1 As Car = New Car()
        Dim c2 As Car = New Car()

        c1.owner = "Frahaan"

        Console.WriteLine(c1.owner)
        Console.WriteLine(c2.owner)

        c2.owner = "Batman"

        Console.WriteLine(c1.owner)
        Console.WriteLine(c2.owner)

        Console.WriteLine(c1.speed)
        Console.WriteLine(c1.health)
        Console.WriteLine(c2.speed)
        Console.WriteLine(c2.health)

        c1.DamageCar(14)

        Console.WriteLine(c1.health)
        Console.WriteLine(c2.health)
    End Sub

End Module
