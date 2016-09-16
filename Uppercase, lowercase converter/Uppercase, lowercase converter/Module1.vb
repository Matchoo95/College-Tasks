Module Module1

    Sub Main()
        Dim Input As String
        Dim Converter As Integer
        Console.WriteLine("Enter the letter you wish to convert.")
        Input = Console.ReadLine
        Converter = Asc(Input)
        Console.WriteLine(Chr(Converter Xor 32))
        Console.ReadLine()
    End Sub

End Module
