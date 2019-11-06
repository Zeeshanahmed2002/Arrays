Module Module1

    Sub Main()
        Dim NUM(8) As Integer
        Dim i As Integer = 0
        Dim x As String = ""
        Dim ISFOUND As Boolean = False
        Dim y As Integer = 0


        Console.Write("Enter your values for Array = ")
        For i = 1 To 8
            x = Console.ReadLine
            NUM(i) = x
        Next

        i = 0
        Console.Write("Enter the value to find = ")
        y = Console.ReadLine
        ISFOUND = False

        For i = 1 To 8
            If NUM(i) = y Then
                ISFOUND = True
                Console.WriteLine("The value has been found")
                Console.Write("The position of the value in Array is = " & i)
                Exit For
            End If
        Next

        If ISFOUND = False Then
            Console.WriteLine("The value has NOT been found")
        End If

        Console.ReadKey()

    End Sub


End Module
