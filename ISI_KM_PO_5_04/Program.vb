Imports System

Module Program
    Sub Main()
        Dim Aplikacja As App = New App("Wymnażanie Tablicy tab1 INT przez liczbę n.")
        Dim x As Integer = 0 : Do : x = Aplikacja.Odp("Podaj wielkość tablicy (>0): ", "*") : Loop Until x > 0
        Try
            Dim tab1(x-1) As Integer : For i As Integer = 0 To tab1.Count -1
                tab1(i) = Aplikacja.Odp($"Podaj wartość {i+1}. wyrazu tab1: " , "*") : Next
            Aplikacja.Wydrukuj("Wprowadzono tablicę (")
            For i As Integer = 0 To tab1.Count - 1
                Aplikacja.Wydrukuj($"{tab1(i)}") : If i <> tab1.Count-1 Then Aplikacja.Wydrukuj(",")
            Next : Aplikacja.Wyswietl(")")
            Dim n As Integer = Aplikacja.Odp("Podaj wartość mnożnika n: ", "*")
            Dim tab2() As Integer = Dzialania.NowaTabWymno(tab1,n) 
            Aplikacja.Wydrukuj("a) Nowa wymnożona tablica tab2 zawiera wartosci (")
            For i As Integer = 0 To tab2.Count -1 
                    Aplikacja.Wydrukuj($"{tab2(i)}") : If i <> tab2.Count-1 Then Aplikacja.Wydrukuj(",")
            Next : Aplikacja.Wyswietl(")")
            Dzialania.Wymno(tab1,n)
            Aplikacja.Wydrukuj("b) Tablica tab1 po wymnożeniu zawiera wartosci (")
            For i As Integer = 0 To tab1.Count -1
                    Aplikacja.Wydrukuj($"{tab1(i)}") : If i <> tab1.Count-1 Then Aplikacja.Wydrukuj(",")
            Next : Aplikacja.Wyswietl(")")
        Catch ex As Exception
            Aplikacja.Wyswietl(" - Blad przetwarzania danych! Restart Aplikacji" + vbCrLf) : Program.Main()
        End Try
    End Sub
End Module
