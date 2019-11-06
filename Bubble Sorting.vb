Module Module1

    Sub Main()
        Dim NUM(8) As Integer
        Dim i As Integer = 0
        Dim x As String = ""
        Dim y As Integer = 0
        Dim z As Integer = 0

        Console.Write("Enter your values for Array = ")
        For i = 1 To 8
            x = Console.ReadLine
            NUM(i) = x
        Next

        For j = 7 To 0 Step -1
            For i = 1 To j
                If NUM(i) > NUM(i + 1) Then
                    y = NUM(i)
                    NUM(i) = NUM(i + 1)
                    NUM(i + 1) = y
                End If
            Next
        Next
        Console.WriteLine("The values of the array in Assending order is = ")
        For i = 1 To 8
            z = NUM(i)
            Console.WriteLine(z)
        Next
        Console.ReadKey()

    End Sub

End Module
