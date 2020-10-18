Module Module1
    Sub Main()
        Call Class1.tytuł()
        Call Class1.zapytanie("a") : Dim A As Integer = Console.ReadLine()
        Call Class1.zapytanie("b") : Dim B As Integer = Console.ReadLine()
        Call Class1.zapytanie("c") : Dim C As Integer = Console.ReadLine()
        Call Class2.wynik(A, B, C) : Console.WriteLine(Class2.delta(A, B, C)) : Console.ReadKey()
    End Sub
End Module
