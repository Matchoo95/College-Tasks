Module Module1

    Sub Main()
        Dim playerx As Byte = 3
        Dim playery As Byte = 2
        Dim key As ConsoleKeyInfo
        Dim playing As Boolean = True
        Dim x2 As Byte = 1
        Dim y2 As Byte = 1

        Console.BackgroundColor = ConsoleColor.Black
        Console.ForegroundColor = ConsoleColor.Red
        While playing
            key = Console.ReadKey(True)

            If key.Key.ToString = "LeftArrow" And playerx > 1 Then
                playerx -= 1
            End If

            If key.Key.ToString = "RightArrow" And playerx < 200 Then
                playerx += 1
            End If

            If key.Key.ToString = "DownArrow" And playery < 200 Then
                playery += 1
            End If

            If key.Key.ToString = "UpArrow" And playery > 1 Then
                playery -= 1
            End If

            Console.Clear()
            Console.SetCursorPosition(playerx, playery)
            Console.Write("P")
            Console.WriteLine()



        End While
    End Sub
End Module
