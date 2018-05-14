Module ejercicio203
    Sub main()
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        Dim d As Integer
        Dim e As Integer



        Console.WriteLine("ingrese el primer valor")
        a = Console.ReadLine()
        Console.WriteLine("ingrese el segundo valor")
        b = Console.ReadLine()
        Console.WriteLine("ingrese el tercer valor")
        c = Console.ReadLine()
        Console.WriteLine("ingrese el cuarto valor")
        d = Console.ReadLine()
        Console.WriteLine("ingrese el quinto valor")
        e = Console.ReadLine()


        If (a > b And b > c And c > d And d > e) Then
            Console.WriteLine("el primer valor es el mayor: " & a)

        ElseIf (c > a And a > d And d > e) Then
            Console.WriteLine("el tercer numero es el mayor: " & c)

        ElseIf (b < c And a > c And c > d And d > e) Then
            Console.WriteLine("el segundo valor es el mas grande: " & b)

        ElseIf (d > a And a > b And b > c And c > e) Then
            Console.WriteLine("el cuarto valor es el mas grande: " & d)

        ElseIf (e > a And a > b And b > c And c > d) Then
            Console.WriteLine("el quiento valor es mas grande:" & e)
        End If
        Console.ReadKey()
    End Sub
End Module
