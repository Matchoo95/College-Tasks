Module Module1


    Sub Main()
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
