Module Module1

    Sub Main()
        Dim BenHallYo(2, 2) As String
        Dim Count As Integer
        Dim Count1 As Integer
        Dim SwapBenHallYo(2, 2) As String

        BenHallYo(0, 0) = "1"
        BenHallYo(0, 1) = "2"
        BenHallYo(0, 2) = "3"
        BenHallYo(1, 0) = "4"
        BenHallYo(1, 1) = "5"
        BenHallYo(1, 2) = "6"
        BenHallYo(2, 0) = "7"
        BenHallYo(2, 1) = "8"
        BenHallYo(2, 2) = "9"

        SwapBenHallYo(0, 0) = "1"
        SwapBenHallYo(0, 1) = "4"
        SwapBenHallYo(0, 2) = "7"
        SwapBenHallYo(1, 0) = "2"
        SwapBenHallYo(1, 1) = "5"
        SwapBenHallYo(1, 2) = "8"
        SwapBenHallYo(2, 0) = "3"
        SwapBenHallYo(2, 1) = "6"
        SwapBenHallYo(2, 2) = "9"


        For Count = 0 To BenHallYo.Length - 1
            For Count1 = 0 To 1
                BenHallYo(Count, Count1) = Console.ReadLine
            Next
        Next

        For Count = 0 To BenHallYo.Length - 1



        Next


        

        Console.WriteLine(BenHallYo(0, 0))
        Console.WriteLine(BenHallYo(0, 1))
        Console.WriteLine(BenHallYo(0, 2))
        Console.WriteLine(BenHallYo(1, 0))
        Console.WriteLine(BenHallYo(1, 1))
        Console.WriteLine(BenHallYo(1, 2))
        Console.WriteLine(BenHallYo(1, 3))
        Console.WriteLine(BenHallYo(2, 1))
        Console.WriteLine(BenHallYo(2, 2))
        Console.WriteLine(BenHallYo(2, 3))
        Console.WriteLine(BenHallYo(3, 1))
        Console.WriteLine(BenHallYo(3, 2))
        Console.WriteLine(BenHallYo(3, 3))

        Console.ReadLine()

    End Sub

End Module
