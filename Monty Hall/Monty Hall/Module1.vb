Module Module1

    Sub Main()
        Dim Choice As Boolean
        Console.WriteLine("Monty Hall")
        Console.WriteLine("1. Play Game")
        Console.WriteLine("2. Simulator")
        Select Case Choice
            Case 1
                Doors()
            Case 2
                Simulator()
        End Select
    End Sub
    Sub Doors()
        Dim Door1 As Byte
        Dim Door2 As Byte
        Dim Door3 As Byte
        Randomize()
        Do Until Door3 <> 0
            Door3 = Int(3 * Rnd() + 1)
        Loop
        Do Until Door2 <> Door3 And Door2 <> 0
            Door2 = Int(3 * Rnd() + 1)
        Loop
        Do Until Door1 <> Door2 And Door1 <> Door3 And Door1 <> 0
            Door1 = Int(3 * Rnd() + 1)
        Loop
        Decision(Door1, Door2, Door3)
    End Sub
    Sub Decision(ByVal Door1 As Byte, ByVal Door2 As Byte, ByVal Door3 As Byte)
        Dim Choice As Byte
        Console.WriteLine("Please enter the door number you believe has the car behind it")
        Console.WriteLine()
        Choice = Console.ReadLine
        System.Threading.Thread.Sleep(1000)
        Console.WriteLine("As I really want you to win the car I will tell you which door contains one of the goats")
        Console.WriteLine()
        If Door1 = 3 Then
            Console.WriteLine("Door 1 contains a goat")
        ElseIf Door2 = 3 Then
            Console.WriteLine("Door 2 contains a goat")
        Else : Door3 = 3
            Console.WriteLine("Door 3 contains a goat")
        End If
        Console.WriteLine()
        Switch(Door1, Door2, Door3, Choice)
    End Sub
    Sub Switch(ByVal Door1 As Byte, ByVal Door2 As Byte, ByVal Door3 As Byte, ByVal Choice As Byte)
        Dim Switch As Byte
        Dim NewChoice As Byte
        Console.WriteLine("Your choice is door " & Choice)
        Console.WriteLine()
        Console.WriteLine("Would you like to change your mind?")
        Console.WriteLine()
        Console.WriteLine("1. Yes")
        Console.WriteLine("2. No")
        Switch = Console.ReadLine
        If Switch = "1" Then
            Console.WriteLine("Please enter your new choice")
            NewChoice = Console.ReadLine
        Else
        End If
        If Door1 = 2 Then
            Console.WriteLine("Door 1 contains a car")
        ElseIf Door2 = 2 Then
            Console.WriteLine("Door 2 contains a car")
        Else : Door3 = 2
            Console.WriteLine("Door 3 contains a car")
        End If
        Console.ReadLine()
    End Sub
    Sub Simulator()
        Dim Door1 As Byte
        Dim Door2 As Byte
        Dim Door3 As Byte
        Randomize()
        Do Until Door3 <> 0
            Door3 = Int(3 * Rnd() + 1)
        Loop
        Do Until Door2 <> Door3 And Door2 <> 0
            Door2 = Int(3 * Rnd() + 1)
        Loop
        Do Until Door1 <> Door2 And Door1 <> Door3 And Door1 <> 0
            Door1 = Int(3 * Rnd() + 1)

        Loop
    End Sub
End Module

