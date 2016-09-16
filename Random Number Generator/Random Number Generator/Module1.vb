Module Module1

    Sub Main()
        Dim Guess As Byte
        Dim NumberToGuess As Byte

        Randomize()
        NumberToGuess = Int(100 * Rnd() + 1)
        Console.WriteLine(NumberToGuess)
        Console.WriteLine("Try and guess the number I'm thinking off, the number is between 1 and 100")

        Do
            Guess = Console.ReadLine
            If Guess = NumberToGuess Then
                Console.WriteLine("Correct! " & NumberToGuess & "  s the correct number!")
            ElseIf Guess < NumberToGuess Then
                Console.WriteLine("Nope! Your guess is less than the number I'm thinking of!")
            ElseIf Guess > NumberToGuess Then
                Console.WriteLine("Nope! Your guess is more than the number I'm thinking of!")
            End If
        Loop Until Guess = NumberToGuess

        Console.ReadLine()

    End Sub

End Module
