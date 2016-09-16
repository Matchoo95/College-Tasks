Module Module1
    Sub Main()
        Dim Input As Decimal
        Dim num1 As Decimal
        Dim num2 As Decimal
        Input = Menu(num1, num2, Input)
        Console.WriteLine("Please enter two values you wish to use in your calculations")
        num1 = Console.ReadLine
        num2 = Console.ReadLine
        Call mathsMachine(num1, num2, Input)
    End Sub
    Function Menu(ByVal num1 As Decimal, ByVal num2 As Decimal, ByRef Input As Decimal)
        Console.WriteLine("Main Menu")
        Console.WriteLine()
        Console.WriteLine("1. Add two numbers")
        Console.WriteLine("2. Subtract one number from another")
        Console.WriteLine("3. Multiply two numbers")
        Console.WriteLine("4. Divide one number by another")
        Input = Console.ReadLine
        Return Input
    End Function
    Sub mathsMachine(ByVal num1 As Decimal, ByVal num2 As Decimal, ByVal Choice As Decimal)
        Dim total As Decimal
        Select Case Choice
            Case 1
                total = num1 + num2
                Console.WriteLine(num1 & " + " & num2 & " = " & total)
            Case 2
                total = num1 - num2
                Console.WriteLine(num1 & " - " & num2 & " = " & total)
            Case 3
                total = num1 * num2
                Console.WriteLine(num1 & " * " & num2 & " = " & total)
            Case 4
                total = num1 / num2
                Console.WriteLine(num1 & " / " & num2 & " = " & total)
        End Select
        Console.ReadLine()
    End Sub
End Module