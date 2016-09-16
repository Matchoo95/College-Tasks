Module Module1
    Sub Main()
        Dim Choice As Integer
        Console.WriteLine("Welcome to Caeser Cipher, please choose an option from the list below.")
        Console.WriteLine()
        Console.WriteLine("1) Input plain text to be encoded.")
        Console.WriteLine("2) Input encrypted text to be decoded.")
        Choice = Console.ReadLine
        If Choice = "1" Then
            Call Encoder()
        ElseIf Choice = "2" Then
            Call Decoder()
        End If
    End Sub
    Sub Encoder()
        Dim EncryptionKey As Integer
        Dim Input As String
        Dim Counter As Integer
        Console.WriteLine("Please choose an encryption key to be used to convert your text to.")
        EncryptionKey = Console.ReadLine
        Console.WriteLine("Now enter the text you wish to encrypt.")
        Input = Console.ReadLine
        Counter = -1
        Do
            Counter += 1
            Console.Write(Chr((Asc(Input(Counter))) + EncryptionKey))
        Loop Until Counter + 1 = Input.Length
        Console.ReadLine()
    End Sub
    Sub Decoder()
        Dim EncryptionKey As Integer
        Dim Input As String
        Dim Counter As Integer
        Console.WriteLine("Please type in the correct encryption key being used in the cipher.")
        EncryptionKey = Console.ReadLine
        Console.WriteLine("Now enter the text you wish to decode.")
        Input = Console.ReadLine
        Counter = -1
        Do
            Counter += 1
            Console.Write(Chr((Asc(Input(Counter))) - EncryptionKey))
        Loop Until Counter + 1 = Input.Length
        Console.ReadLine()
    End Sub

End Module
