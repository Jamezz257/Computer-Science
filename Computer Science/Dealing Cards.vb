Module Module1

    Sub Main()

        Dim suitnumber As Integer
        Dim cardvalue As Integer
        Dim suit As String
        Dim card As String
        Dim deal As Integer



        For deal = 1 To 6


            Randomize()
            suitnumber = Int((4 * Rnd()) + 1)
            cardvalue = Int((13 * Rnd()) + 1)



            If suitnumber = 1 Then
                suit = " of Clubs"
            ElseIf suitnumber = 2 Then
                suit = " of Hearts"
            ElseIf suitnumber = 3 Then
                suit = " of Diamonds"
            ElseIf suitnumber = 4 Then
                suit = " of Spades"
            End If



            If cardvalue = 1 Then
                card = "Ace"
            ElseIf cardvalue = 2 Then
                card = "2"
            ElseIf cardvalue = 3 Then
                card = "3"
            ElseIf cardvalue = 4 Then
                card = "4"
            ElseIf cardvalue = 5 Then
                card = "5"
            ElseIf cardvalue = 6 Then
                card = "6"
            ElseIf cardvalue = 7 Then
                card = "7"
            ElseIf cardvalue = 8 Then
                card = "8"
            ElseIf cardvalue = 9 Then
                card = "9"
            ElseIf cardvalue = 10 Then
                card = "10"
            ElseIf cardvalue = 11 Then
                card = "Jack"
            ElseIf cardvalue = 12 Then
                card = "Queen"
            ElseIf cardvalue = 13 Then
                card = "King"
            End If


            Console.WriteLine("You have been dealt the ")
            Console.WriteLine(card & suit)
            Console.ReadLine()

        Next
    End Sub

End Module
