Module Module1
    Dim X, Y As Integer
    Enum Months
        Jan
        Feb
        Mar
        Apr
        May
        Jun
        Jul
        Aug
        Sep
        Oct
        Nov
        Dec
    End Enum
    Sub Main()
        X = Months.Jun
        Y = Months.Jan
        Console.WriteLine("June = {0}", X + 1)
        Console.WriteLine("January = {0}", Y + 1)
        Console.ReadLine()
    End Sub
End Module
