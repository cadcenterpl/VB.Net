Imports System

Module Program
    Sub Main()
        Dim Aplikacja As App = New App("Konwersja Fahrenheit -> Celsjusz")
        Dim WartoscUzytkownika As Wartosc= New Wartosc (Aplikacja.OdpUzytkownika("Podaj temperaturę w st.F: ", "*"))
        Aplikacja.Wyswietl($"{WartoscUzytkownika.KonwersjaFC} st.C")
    End Sub
End Module
