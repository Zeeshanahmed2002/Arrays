Module Module1

    Sub Main()

        Dim NoArr(10) As Integer
        Dim alreadyfound As Boolean = False
        Dim i, j, c, x As Integer

        i = 0
        j = 0
        c = 0
        x = 0

        Randomize()


        For i = 1 To 10
            NoArr(i) = 0
        Next

        For i = 1 To 10
            Do
                alreadyfound = False
                x = Int(Rnd() * 100) + 1
                c = c + 1
                For j = i To 1 Step -1
                    If NoArr(j) = x Then alreadyfound = True
                Next
            Loop Until alreadyfound = False
            NoArr(i) = x
        Next

        For i = 1 To 10
            Console.WriteLine(NoArr(i))
        Next

        Console.WriteLine("The loop worked for " & c & " Times")
        Console.ReadKey()

    End Sub

End Module
