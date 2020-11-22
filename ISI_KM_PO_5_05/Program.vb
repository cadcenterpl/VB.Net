Imports System

Module Program
    Sub Main()
        Dim Aplikacja As App = New App("Tworzenie prostokątów ze znaków według podanych wymiarów boku a i b")
        Dim a As Integer : Do : a = Aplikacja.Odp("Podaj długość boku a: ", "*") : Loop Until a > 0
        Dim b As Integer : Do : b = Aplikacja.Odp("Podaj długość boku b: ", "*") : Loop Until b > 0
        Dim znk As String : Do : znk = Aplikacja.Odp("Zadeklaruj znak wypełnienia: ", "*") : Loop Until znk <> ""
        Try
            Akcja.Rysuj(a,b,znk) : Aplikacja.Wyswietl("")
            Akcja.Rysuj(b,a,znk) : Aplikacja.Wyswietl("")
        Catch ex As Exception
            Aplikacja.Wyswietl(" - Blad przetwarzania danych! Restart Aplikacji" + vbCrLf) : Program.Main()
        End Try
    End Sub
End Module
