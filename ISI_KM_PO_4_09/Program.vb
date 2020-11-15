Module Program
    Sub Main()
        Dim Aplikacja As App = New App("Suma wyrazów w łańcuchu znaków")
        Dim ŁańcuchUżytkownika As Łańcuch = New Łańcuch(Aplikacja.OdpUżytkownika("Wpisz ciąg wyrazów: "))
        Aplikacja.Wydrukuj("Ilość wyrazów w łańcuchu to: ")
        Aplikacja.Wyświetl(ŁańcuchUżytkownika.LiczWyrazy)
        Aplikacja.Zatrzymaj()
    End Sub
End Module