Module Module1

    Sub Main()
        Dim Column As Integer = 8
        Dim Answer As Integer = 0
        Dim Bit As Integer

        Do
            Console.WriteLine("Enter bit value:")
            Bit = Console.ReadLine
            Answer = Answer + (Column * Bit)
            Column = Column / 2
        Loop Until Column < 1
        Console.WriteLine("Decimal value is:")
        Console.Write(Answer)
        Console.ReadLine()

    End Sub

End Module
