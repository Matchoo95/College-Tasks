Module Module1

    Sub Main()
        Dim Array1(2)
        Dim Array2(2)
        Dim LoopCounter As Integer
        Dim Temp As String

        Array1(0) = "A"
        Array1(1) = "B"
        Array1(2) = "C"

        Array2(0) = "C"
        Array2(1) = "B"
        Array2(2) = "A"

        For LoopCounter = 0 To Array1.Length - 1

            Temp = Array1(LoopCounter)
            Array1(LoopCounter) = Array2(LoopCounter)
            Array2(LoopCounter) = Temp


        Next
        Console.WriteLine(Array1(0))
        Console.WriteLine(Array1(1))
        Console.WriteLine(Array1(2))
        Console.ReadLine()

    End Sub

End Module
