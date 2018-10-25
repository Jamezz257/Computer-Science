Module Module1

    Sub Main()

        Dim x As Integer = 6
        Dim y As Integer = 1
        Dim number As Integer = 1


        Console.SetCursorPosition(0, 0)
        Console.Write(ChrW(&H250C))

        'Top row
        For i = 1 To 10

            Console.Write(ChrW(&H2500))
            Console.Write(ChrW(&H2500))
            Console.Write(ChrW(&H2500))
            Console.Write(ChrW(&H252C))
        Next
        Console.Write(ChrW(&H2500))
        Console.Write(ChrW(&H2500))
        Console.Write(ChrW(&H2500))
        Console.WriteLine(ChrW(&H2510))
        'End of top row

        'Middle rows
        For q = 1 To 10
            For o = 1 To 11
                Console.Write(ChrW(&H2502))
                Console.Write("   ")
            Next
            Console.WriteLine(ChrW(&H2502))

            Console.Write(ChrW(&H251C))
            For p = 1 To 10
                Console.Write(ChrW(&H2500))
                Console.Write(ChrW(&H2500))
                Console.Write(ChrW(&H2500))
                Console.Write(ChrW(&H253C))
            Next
            Console.Write(ChrW(&H2500))
            Console.Write(ChrW(&H2500))
            Console.Write(ChrW(&H2500))
            Console.WriteLine(ChrW(&H2524))
        Next
        'End of middle rows
        For i = 1 To 12
            Console.Write(ChrW(&H2502))
            Console.Write("   ")
        Next
        Console.WriteLine("")
        Console.Write(ChrW(&H2514))
        For i = 1 To 10
            Console.Write(ChrW(&H2500))
            Console.Write(ChrW(&H2500))
            Console.Write(ChrW(&H2500))
            Console.Write(ChrW(&H2534))
        Next

        Console.Write(ChrW(&H2500))
        Console.Write(ChrW(&H2500))
        Console.Write(ChrW(&H2500))
        Console.Write(ChrW(&H2518))



        For i = 1 To 10

            Console.SetCursorPosition(x, y)
            x = x + 4
            Console.Write(number)
            number = number + 1
        Next

        y = y + 2
        number = 1
        x = 2
        For i = 1 To 10

            Console.SetCursorPosition(x, y)
            y = y + 2
            Console.Write(number)
            number = number + 1
        Next

        Console.ReadLine()
    End Sub

End Module
