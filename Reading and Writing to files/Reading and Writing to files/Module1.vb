Module Module1

    Sub Main()

        Dim Choice As Byte
        Console.WriteLine("Welcome to the peoples database, please select an option.")
        Console.WriteLine("1) Read the database and make changes.")
        Console.WriteLine("2) Write to the database.")
        Choice = Console.ReadLine
        If Choice = "1" Then
            Call Read()
        ElseIf Choice = "2" Then
            Call Write()
        End If
    End Sub
    Sub Read()
        Dim Surnames(10) As String
        Dim FirstNames(10) As String
        Dim Counter As Byte
        FileOpen(1, "N:\My Documents\Computing\COMP 1\ListOfNames.txt", OpenMode.Input)
        Do While Not (EOF(1))
            Input(1, Surnames(Counter))
            Input(1, FirstNames(Counter))
            Console.WriteLine(Surnames(Counter) & " " & (FirstNames(Counter)))
        Loop
        FileClose(1)
        Console.ReadLine()
    End Sub
    Sub Write()
        Dim Surname(10), FirstName(10) As String
        Dim Y As Integer

        FileOpen(1, "N:\My Documents\Computing\COMP 1\ListOfNames.txt", OpenMode.Output)
        Do
            Y = Y + 1
            Console.WriteLine("What is your first name?")
            FirstName(Y) = Console.ReadLine
            Console.WriteLine("What is your surname?")
            Surname(Y) = Console.ReadLine

        Loop Until Y = 10

        Dim X As Byte
        For X = 1 To 10
            PrintLine(1, Surname(X) & "," & FirstName(X))
        Next
    End Sub
End Module
