Imports System

Module Program
    Sub Main()
        Dim Aplikacja As App = New App("Wymnażanie wyrazów Tablicy tab1 String przez liczbę n. (Met. przeładowane)")
        Dim x As Integer : Do : x = Aplikacja.Odp("Podaj wielkość tablicy (>0): ", "*") : Loop Until x > 0
     '   Try
            Dim tab1(x-1) As String : For i As Integer = 0 To tab1.Count -1
                tab1(i) = Aplikacja.Odp($"Podaj wartość {i+1}. wyrazu tab1: " , "*") : Next
            Aplikacja.Wydrukuj("Wprowadzono tablicę (")
            For i As Integer = 0 To tab1.Count - 1
                Aplikacja.Wydrukuj($"{tab1(i)}") : If i < tab1.Count-1 Then Aplikacja.Wydrukuj(",")
            Next : Aplikacja.Wyswietl(")")
            Dim n As Integer = Aplikacja.Odp("Podaj wartość mnożnika n: ", "*")
            Dzialania.Wymno(tab1,n)
            Aplikacja.Wydrukuj("Tablica tab1 po wymnożeniu zawiera wartosci (")
            For i As Integer = 0 To tab1.Count - 1
                Aplikacja.Wydrukuj($"{tab1(i)}") : If i < tab1.Count-2 Then Aplikacja.Wydrukuj(",")
            Next : Aplikacja.Wyswietl(")")
    '    Catch ex As Exception
    '        Aplikacja.Wyswietl(" - Blad przetwarzania danych! Restart Aplikacji" + vbCrLf) : Program.Main()
   '     End Try
    End Sub
End Module
