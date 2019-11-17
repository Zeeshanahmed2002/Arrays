Module Module1

    Sub Main()
        Dim MyArr(5, 5) As String
        Dim x As String = ""
        Dim y As String = ""
        Dim a As String = ""
        Dim b As String = ""
        Dim c As String = ""
        Dim d As String = ""

        Randomize()


        For col = 1 To 5
            For row = 1 To 5
                MyArr(col, row) = "x"
            Next
        Next

        For col = 1 To 5
            For row = 1 To 5
                Console.Write(MyArr(col, row) & " ")
            Next
            Console.WriteLine()
        Next


        x = Int(Rnd() * 5) + 1
        y = Int(Rnd() * 5) + 1

        MyArr(y, x) = "T"

        c = Int(Rnd() * 5) + 1
        d = Int(Rnd() * 5) + 1

        MyArr(d, c) = "T"

        Console.WriteLine()
        Console.WriteLine()


        Console.WriteLine("Please enter number between 1 and 5")
        Console.Write("Enter column number = ")
        a = Console.ReadLine


        While a > 5 Or a < 1


            Console.WriteLine("The Number is out of range! Please Re-enter number between 1 and 5")
            Console.Write("Enter column number = ")
            a = Console.ReadLine

        End While



        Console.Write("Enter row number = ")
        b = Console.ReadLine


        While b > 5 Or b < 1
            Console.WriteLine("The Number is out of range! Please Re-enter number between 1 and 5")
            Console.Write("Enter row number = ")
            b = Console.ReadLine

        End While

        Console.WriteLine()

        If MyArr(a, b) = "T" Then
            Console.WriteLine("Hurray!! You have found the treasure!")
        Else
            Console.WriteLine("Alas! treasure was not found!")
        End If

        Console.WriteLine()



        Console.WriteLine("First treasure was at : " & y & " , " & x)
        Console.Write("Second tresure was at :" & " " & d & " , " & c)

        Console.WriteLine()
        Console.WriteLine()

        For col = 1 To 5
            For row = 1 To 5
                Console.Write(MyArr(col, row) & " ")
            Next
            Console.WriteLine()
        Next


        Console.ReadKey()


    End Sub

End Module
