Imports System.Threading
Module Module1
    Dim maxX As Integer = 80
    Dim maxY As Integer = 20
    Dim snekposX As Integer
    Dim snekposY As Integer
    Dim pills(100, 100) As Integer
    Dim score As Integer = 0
    Dim hitside As Integer = 0
    Dim key As String
    Dim quit As Integer = 0
    Dim pillnumber As Integer
    Dim up As String = "W"
    Dim down As String = "S"
    Dim right As String = "D"
    Dim snekchar As String = "■"
    Dim left As String = "A"
    Dim startup As String
    Dim maxpills As Integer = 10
    Dim topscore As Integer = 2000


    Sub Main()
        Console.WriteLine("Main Menu")
        Console.WriteLine(" ")
        Console.WriteLine("1. Play Game")
        Console.WriteLine("2. Keybindings")
        Console.WriteLine("3. Board Size")
        Console.WriteLine("4. Number Of Pills")
        startup = Console.ReadLine

        If startup = 1 Then
            game()
        ElseIf startup = 2 Then
            keymapping()
        ElseIf startup = 3 Then
            boundaries()
        ElseIf startup = 4 Then
            pillsnumber()
        End If
    End Sub

    Sub game()


        Console.Clear()

        Console.CursorVisible = False
        drawgamearea(maxX, maxY)
        setsnekpos(snekposX, snekposY, maxX, maxY, snekchar)
        drawpillsstart(pills, maxX, maxY)

        Dim scoreposX As Integer = maxX + 5
        Dim scoreposY As Integer = 1
        Dim timerposX As Integer = maxX + 5
        Dim timerposY As Integer = 2


        Do
            Thread.Sleep(1)
            If Console.KeyAvailable = True Then
                getkey(key, quit, snekposX, snekposY)
                For i = 1 To maxpills
                    If snekposX = pills(i, 0) Then
                        If snekposY = pills(i, 1) Then
                            drawpillsregen(pills, maxX, maxY)
                            score = score + 1

                        End If
                    End If
                Next
                redrawsnek(snekposX, snekposY, snekchar)
                checkborder(snekposX, snekposY, hitside, maxX, maxY)
            End If
            display(scoreposX, scoreposY)

        Loop Until hitside = 1 Or quit = 1 Or score = topscore
        finalmessage(hitside, quit, score)
        Console.ReadLine()
    End Sub

    Sub drawgamearea(ByRef maxX As Integer,
                     ByRef maxY As Integer)
        For i = 0 To maxX
            Console.SetCursorPosition(i, 0)
            Console.WriteLine("_")
            Console.SetCursorPosition(i, maxY)
            Console.WriteLine("_")
        Next
        For i = 1 To maxY
            Console.SetCursorPosition(0, i)
            Console.WriteLine("|")
            Console.SetCursorPosition(maxX, i)
            Console.WriteLine("|")
        Next
    End Sub

    Sub setsnekpos(ByRef snekposX As Integer,
                   ByRef snekposY As Integer,
                   ByRef maxX As Integer,
                   ByRef maxY As Integer,
                   ByRef snekchar As String)
        Dim rndX As Integer
        Dim rndY As Integer
        rndX = maxX - 1
        rndY = maxY - 1
        Rnd()
        Randomize()
        snekposX = Int(rndX * Rnd() + 1)
        snekposY = Int(rndY * Rnd() + 1)
        Console.SetCursorPosition(snekposX, snekposY)
        Console.WriteLine(snekchar)
    End Sub

    Sub drawpillsstart(pills, maxX, maxY)
        For i = 1 To maxpills
            Randomize()
            pills(i, 0) = Int((maxX - 1) * Rnd() + 1)
            pills(i, 1) = Int((maxY - 1) * Rnd() + 1)
            Console.SetCursorPosition(pills(i, 0), pills(i, 1))
            Console.WriteLine("o")
        Next
    End Sub

    Sub drawpillsregen(pills, maxX, maxY)
        For i = 1 To 1
            Randomize()
            pills(i, 0) = Int((maxX - 1) * Rnd() + 1)
            pills(i, 1) = Int((maxY - 1) * Rnd() + 1)
            Console.SetCursorPosition(pills(i, 0), pills(i, 1))
            Console.WriteLine("o")
        Next
    End Sub

    Sub getkey(ByRef key As String,
               ByRef quit As Integer,
               ByRef snekposX As Integer,
               ByRef snekposY As Integer)

        key = Console.ReadKey(True).Key.ToString
        Console.SetCursorPosition(snekposX, snekposY)
        Console.WriteLine(" ")
        Select Case key
            Case = left
                snekposX = snekposX - 1
            Case = right
                snekposX = snekposX + 1
            Case = up
                snekposY = snekposY - 1
            Case = down
                snekposY = snekposY + 1
            Case = "Q"
                quit = 1

        End Select
    End Sub

    Sub checkborder(ByRef snekposX As Integer,
                    ByRef snekposY As Integer,
                    ByRef hitside As Integer,
                    ByRef maxX As Integer,
                    ByRef maxY As Integer)

        If snekposX = 0 Or snekposX = maxX Or snekposY = 0 Or snekposY = maxY Then
            hitside = 1
        End If
    End Sub

    Sub redrawsnek(ByRef snekposX As Integer,
                   ByRef snekposY As Integer,
                   ByRef snekchar As String)
        Console.SetCursorPosition(snekposX, snekposY)
        Console.WriteLine(snekchar)
    End Sub

    Sub keymapping()
        Console.Clear()
        Console.WriteLine("Make sure the keymapping is in capitals or it will not work")
        Console.WriteLine("Which button for up?")
        up = Console.ReadLine()
        Console.WriteLine("Which button for left?")
        left = Console.ReadLine()
        Console.WriteLine("Which button for down?")
        down = Console.ReadLine()
        Console.WriteLine("Which button for right?")
        right = Console.ReadLine()
        Console.Clear()
        Main()
    End Sub

    Sub boundaries()
        Console.Clear()
        Console.WriteLine("How wide shall the screen be?")
        maxX = Console.ReadLine
        Console.WriteLine("How far down would you like it to go?")
        maxY = Console.ReadLine
        Console.Clear()
        Main()
    End Sub

    Sub pillsnumber()
        Do
            Console.Clear()
            Console.WriteLine("How many pills would you like? Make sure it is less than half of " & maxX)
            maxpills = Console.ReadLine
        Loop Until maxpills <= maxX / 2
        Console.Clear()
        Main()
    End Sub

    Sub finalmessage(ByRef hitsdie As Integer,
                         ByRef quit As Integer,
                         ByRef score As Integer)
        Console.Clear()
        If hitside = 1 Then
            Console.WriteLine("You died by crashing into the edge, but you had a score of " & score)
        ElseIf quit = 1 Then
            Console.WriteLine("You quit the game with a score of " & score)
        ElseIf score = topscore Then
            Console.WriteLine("You got the highest score!!!!!! Congrats for getting to " & score & "!!!!!!!!!!!!")
        End If
    End Sub

    Sub display(scoreposX, scoreposY)
        Console.SetCursorPosition(scoreposX, scoreposY)
        Console.WriteLine("Current Score: " & score)
        Console.SetCursorPosition(scoreposX, (scoreposY + 1))
        Console.WriteLine("Keybindings:")
        Console.SetCursorPosition(scoreposX, (scoreposY + 2))
        Console.WriteLine("Up: " & up)
        Console.SetCursorPosition(scoreposX, (scoreposY + 3))
        Console.WriteLine("Left: " & left)
        Console.SetCursorPosition(scoreposX, (scoreposY + 4))
        Console.WriteLine("Down: " & down)
        Console.SetCursorPosition(scoreposX, (scoreposY + 5))
        Console.WriteLine("Right: " & right)
    End Sub

End Module
