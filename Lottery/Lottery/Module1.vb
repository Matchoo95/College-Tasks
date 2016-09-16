Module Module1
    Dim PlayerNumbers2(6) As Integer
    Dim PlayerNumbers(5) As Integer
    Sub Main()
        Dim Play As String
        Dim Choice As String
        Randomize()
        Console.WriteLine("Welcome to the Lottery.")
        Console.WriteLine("You must get the numbers correct to win if you don't you will lose the jackpot and also die. If you win you will win the jackpot and life, life is good, not as good as cake but still good.")
        Console.WriteLine("Please Enter Yes or No.")
        Play = UCase(Console.ReadLine)
        If Play = "YES" Then
            Console.WriteLine("Please select the day you wish to play by entering the number that corresponds with the list below.")
            Console.WriteLine("1. Wednesday")
            Console.WriteLine("2. Weekend")
            Choice = Console.ReadLine
            If Choice = "1" Then
                Call Lottery1()
            ElseIf Choice = "2" Then
                Call Lottery2()
            End If
        ElseIf Play = "NO" Then
            Console.WriteLine("You have no choice but to play, death or life, may the odds be forever in your favour.")
            Console.WriteLine("Please select the day you wish to play by entering the number that corresponds with the list below.")
            Console.WriteLine("1. Wednesday")
            Console.WriteLine("2. Weekend")
            Choice = Console.ReadLine
            If Choice = "1" Then
                Call Lottery1()
            ElseIf Choice = "2" Then
                Call Lottery2()
            End If
        End If
        Console.ReadLine()
    End Sub
    Sub Lottery1()

        Dim LoopCounter As Integer

        Console.WriteLine("Please enter 5 numbers that will allow you to win.")
        Console.WriteLine("No. 1")
        PlayerNumbers(1) = Console.ReadLine()
        Console.WriteLine("No. 2")
        PlayerNumbers(2) = Console.ReadLine
        Console.WriteLine("No. 3")
        PlayerNumbers(3) = Console.ReadLine
        Console.WriteLine("No. 4")
        PlayerNumbers(4) = Console.ReadLine
        Console.WriteLine("No. 5")
        PlayerNumbers(5) = Console.ReadLine
        LoopCounter = 1

        If PlayerNumbers(LoopCounter) < "30" Then
            Call RandomNumber1()
        Else
            Console.WriteLine("Your numbers do not meet the parameters set, please retry.")
            Call Lottery1()
        End If
        Call RandomNumber1()
    End Sub
    Sub RandomNumber1()

        Dim RandomValue(5) As Integer
        Dim Sorter As Integer
        Dim Sorter2 As Integer
        Dim Sorter3 As Integer
        Dim Counter As Integer
        Dim Match As Integer
        Dim Tempstore As Integer
        Dim Choice As String

        Do
            Randomize()

            RandomValue(1) = Int(CInt(30 * Rnd() + 1))
            RandomValue(2) = Int(CInt(30 * Rnd() + 1))
            RandomValue(3) = Int(CInt(30 * Rnd() + 1))
            RandomValue(4) = Int(CInt(30 * Rnd() + 1))
            RandomValue(5) = Int(CInt(30 * Rnd() + 1))

        Loop Until RandomValue(1) <> RandomValue(2) And RandomValue(1) <> RandomValue(3) And RandomValue(1) <> RandomValue(4) And RandomValue(1) <> RandomValue(5) And RandomValue(2) <> RandomValue(1) And RandomValue(2) <> RandomValue(3) And RandomValue(2) <> RandomValue(4) And RandomValue(3) <> RandomValue(1) And RandomValue(3) <> RandomValue(2) And RandomValue(3) <> RandomValue(4) And RandomValue(3) <> RandomValue(5) And RandomValue(2) <> RandomValue(5) And RandomValue(3) <> RandomValue(5) And RandomValue(4) <> RandomValue(5) And RandomValue(1) <> RandomValue(5)
2:

        Do
            For Sorter = 1 To 4
                If RandomValue(Sorter) > RandomValue(Sorter + 1) Then
                    Tempstore = RandomValue(Sorter)
                    RandomValue(Sorter) = RandomValue(Sorter + 1)
                    RandomValue(Sorter + 1) = Tempstore
                End If
            Next
            Sorter2 = Sorter2 + 1
        Loop Until Sorter2 = 5

        Console.WriteLine("Your numbers for the Wednesday draw are: " & PlayerNumbers(1) & " " & PlayerNumbers(2) & " " & PlayerNumbers(3) & " " & PlayerNumbers(4) & " " & PlayerNumbers(5))
        Console.WriteLine("The winning numbers are: " & RandomValue(1) & " " & RandomValue(2) & " " & RandomValue(3) & " " & RandomValue(4) & " " & RandomValue(5))
        Console.ReadLine()
        Counter = 1
        Do
            For Sorter3 = 1 To 5
                If PlayerNumbers(Counter) = RandomValue(Sorter3) Then
                    Match = Match + 1
                End If
            Next
            Counter = Counter + 1

        Loop Until Counter = 6
        If Match = 1 Or 2 Or 3 Or 4 Or 5 Then
            Console.WriteLine("You have " & Match & (" Matches"))
        End If
        Console.WriteLine("Would you like to play again?")
        Choice = UCase(Console.ReadLine)
        If Choice = "YES" Then
            Call Main()
        ElseIf Choice = "NO" Then
            Console.WriteLine("Fuck you then.")
            System.Threading.Thread.Sleep(2000)
            End
        End If




        '        If PlayerNumbers(1 / 2 / 3 / 4 / 5) = RandomValue(1 / 2 / 3 / 4 / 5) Then
        'Console.WriteLine("Congratulations one or more of your numbers matched! You have won!.")
        ' ElseIf PlayerNumbers(1 / 2 / 3 / 4 / 5) <> RandomValue(1 / 2 / 3 / 4 / 5) Then
        ' Console.WriteLine("You have lost! Death will come in the form of a homicidal cheese. Congratulations.")
        ' End If
        ' Call Main()
    End Sub
    Sub Lottery2()

        Dim Number As Integer

        Console.WriteLine("Please enter 6 numbers that will allow you to win.")
        Console.WriteLine("No. 1")
        PlayerNumbers2(1) = Console.ReadLine()
        Console.WriteLine("No. 2")
        PlayerNumbers2(2) = Console.ReadLine
        Console.WriteLine("No. 3")
        PlayerNumbers2(3) = Console.ReadLine
        Console.WriteLine("No. 4")
        PlayerNumbers2(4) = Console.ReadLine
        Console.WriteLine("No. 5")
        PlayerNumbers2(5) = Console.ReadLine
        Console.WriteLine("No. 6")
        PlayerNumbers2(6) = Console.ReadLine


        If PlayerNumbers(Number) < "30" Then
            Call RandomNumber2()
        Else
            Console.WriteLine("Your numbers do not meet the parameters set, please retry.")
            Call Lottery2()
            
        End If

        Call RandomNumber2()
    End Sub
    Sub RandomNumber2()

        Dim RandomValue(6) As Integer
        Dim Sorter As Integer
        Dim Sorter2 As Integer
        Dim Sorter3 As Integer
        Dim Counter As Integer
        Dim Match As Integer
        Dim Tempstore As Integer
        Dim Choice As String

        Do
            Randomize()

            RandomValue(1) = Int(CInt(30 * Rnd() + 1))
            RandomValue(2) = Int(CInt(30 * Rnd() + 1))
            RandomValue(3) = Int(CInt(30 * Rnd() + 1))
            RandomValue(4) = Int(CInt(30 * Rnd() + 1))
            RandomValue(5) = Int(CInt(30 * Rnd() + 1))
            RandomValue(6) = Int(CInt(30 * Rnd() + 1))

        Loop Until RandomValue(1) <> RandomValue(2) And RandomValue(1) <> RandomValue(3) And RandomValue(1) <> RandomValue(4) And RandomValue(1) <> RandomValue(5) And RandomValue(2) <> RandomValue(1) And RandomValue(2) <> RandomValue(3) And RandomValue(2) <> RandomValue(4) And RandomValue(3) <> RandomValue(1) And RandomValue(3) <> RandomValue(2) And RandomValue(3) <> RandomValue(4) And RandomValue(3) <> RandomValue(5) And RandomValue(2) <> RandomValue(5) And RandomValue(3) <> RandomValue(5) And RandomValue(4) <> RandomValue(5) And RandomValue(1) <> RandomValue(5) And RandomValue(1) <> RandomValue(2) And RandomValue(1) <> RandomValue(3) And RandomValue(1) <> RandomValue(4) And RandomValue(5) <> RandomValue(1) And RandomValue(1) <> RandomValue(6)
2:

        Do
            For Sorter = 1 To 5
                If RandomValue(Sorter) > RandomValue(Sorter + 1) Then
                    Tempstore = RandomValue(Sorter)
                    RandomValue(Sorter) = RandomValue(Sorter + 1)
                    RandomValue(Sorter + 1) = Tempstore
                End If
            Next
            Sorter2 = Sorter2 + 1
        Loop Until Sorter2 = 6

        Console.WriteLine("Your numbers for the Wednesday draw are: " & PlayerNumbers2(1) & " " & PlayerNumbers2(2) & " " & PlayerNumbers2(3) & " " & PlayerNumbers2(4) & " " & PlayerNumbers2(5) & " " & PlayerNumbers2(6))
        Console.WriteLine("The winning numbers are: " & RandomValue(1) & " " & RandomValue(2) & " " & RandomValue(3) & " " & RandomValue(4) & " " & RandomValue(5) & " " & RandomValue(6))
        Console.ReadLine()
        Counter = 1
        Do
            For Sorter3 = 1 To 6
                If PlayerNumbers(Counter) = RandomValue(Sorter3) Then
                    Match = Match + 1
                End If
            Next
            Counter = Counter + 1

        Loop Until Counter = 6
        If Match = 1 Or 2 Or 3 Or 4 Or 5 Or 6 Then
            Console.WriteLine("You have " & Match & (" Matches"))
        End If
        Console.WriteLine("Would you like to play again?")
        Choice = UCase(Console.ReadLine)
        If Choice = "YES" Then
            Call Main()
        ElseIf Choice = "NO" Then
            Console.WriteLine("Fuck you then.")
            System.Threading.Thread.Sleep(2000)
            End
        End If
    End Sub
End Module
'Do
'
'            For sorter = 1 To 5
'                If frinums(sorter) > frinums(sorter + 1) Then
'                    tempstore = frinums(sorter)
'                    frinums(sorter) = frinums(sorter + 1)
'                    frinums(sorter + 1) = tempstore
'
'                End If
'            Next
'            sorter2 = sorter2 + 1
'        Loop Until sorter2 = 6
'