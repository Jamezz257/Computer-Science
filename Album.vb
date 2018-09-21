Module Module1

    Sub Main()
        Dim track As Integer
        Dim album(0 To 12) As String
        Dim song As String
        Dim counter As Integer


        For counter = 1 To 2
            album(0) = "I Want It That Way"
            album(1) = "twnkltwnklllstr"
            album(2) = "bily"
            album(3) = "bred"
            album(4) = "englshfl"
            album(5) = "ltrbmb(lv)"
            album(6) = "shnaispnkrkr"
            album(7) = "wlcmtblckprde"
            album(8) = "crtnfmly"
            album(9) = "kkktkmbbywy"
            album(10) = "sfrisng"
            album(11) = "gmegmeshktrtmnt"
            album(12) = "imssu"
            Console.WriteLine("Enter the track number you wish to choose (1-13)")
            track = Console.ReadLine

            If track = 0 Then
                Console.WriteLine("eroor")
            ElseIf track > 13 Then
                Console.WriteLine("erore")
            Else
                track = track - 1

            song = album(track)

                track = track + 1
                Console.WriteLine("Track " & track & " is " & song)
            End If







            counter = counter * 0

        Next
        Console.ReadLine()
    End Sub

End Module
