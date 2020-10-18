Module Module1
    Sub Main()
        Call Class1.tytuł()
        Call Class1.pytanie_waga() : Dim masa As Integer = Console.ReadLine()
        Call Class1.pytanie_wzrost() : Dim wzrost As Integer = Console.ReadLine()
        Call Class2.wynik(masa, wzrost) : Console.WriteLine(Class2.wzór(masa, wzrost))
        Console.ReadKey()
    End Sub
End Module
