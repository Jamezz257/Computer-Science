Module Module1

    Sub Main()

        Dim input As String 'input is what the player puts in e.g H or L
        Dim randomnumber1 As Integer
        Dim randomnumber2 As Integer
        Dim counter As Integer
        Dim points As Integer
        Dim round As Integer

        round = 1
        points = 0


        For counter = 1 To 10

            Randomize()
            randomnumber1 = Int((13 * Rnd()) + 1) 'This Generates the random number between 1 and 13
            Console.WriteLine("Round " & round & " - The Random Number is " & randomnumber1)

            Console.WriteLine("Do you think the following number will be Higher (H) or Lower (L)")
            input = Console.ReadLine

            randomnumber2 = Int((13 * Rnd()) + 1)
            Console.WriteLine("The number was: " & randomnumber2)

            If randomnumber1 > randomnumber2 Then 'This is if the first random number is bigger than the next
                If input = "H" Then
                    Console.WriteLine("You Were Incorrect
")
                ElseIf input = "L" Then
                    Console.WriteLine("You Were Correct!
")
                    points = points + 1
                Else
                    Console.WriteLine("Answer Not Recognised. Please Try Again.")


                End If

            ElseIf randomnumber1 < randomnumber2 Then 'This is if the first number is less than the second
                If input = "L" Then
                    Console.WriteLine("You Were Incorrect
")

                ElseIf input = "H" Then
                    Console.WriteLine("You Were Correct!
")
                    points = points + 1
                Else
                    Console.WriteLine("Answer Not Recognised. Please Try Again")
                End If
            ElseIf randomnumber1 = randomnumber2 Then
                Console.WriteLine("The Numbers Were The Same. 0 Points")

            End If

            round = round + 1
        Next

        Console.WriteLine("You got " & points & "/10 points") 'This Tells you the number of points at the end, and whether you won or lost
        If points < 10 Then
            Console.WriteLine("You Lose")
        ElseIf points = 10 Then
            Console.WriteLine("You Win!!!!")
        End If



        Console.ReadLine()
    End Sub

End Module
