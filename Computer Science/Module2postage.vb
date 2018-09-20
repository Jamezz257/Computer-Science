Module Module2.-Postage.vb

    Sub Main()
        Dim Ordervalue As Decimal
        Dim Postage As String
        Console.WriteLine(" What is the value of the item?")
        Ordervalue = Console.ReadLine()
        Select Case Ordervalue
            Case Ordervalue > 100
                Postage = "No Postage"
            Case Ordervalue > 60
                Postage = "£5.00 Postage"
            Case Ordervalue > 40
                Postage = "£7.50 Postage"
            Case Ordervalue <= 40
                Postage = "£10 Postage"
        End Select
        Console.WriteLine("You have to pay ")
        Console.ReadLine()

    End Sub

End Module
