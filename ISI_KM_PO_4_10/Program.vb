Module Program
    Sub Main()
        Dim Aplikacja As App = New App("Wyświetlanie słownie miesiąca")
        Dim DataUżytkownika As Łańcuch = New Łańcuch(Aplikacja.OdpUżytkownika("Wpisz dowolną datę w formacie DD-MM-RRRR: ", "*-*-*"))
        Dim MiesiącUżytkownika As Miesiąc = New Miesiąc(DataUżytkownika.Pobierz(3, 2))
        Aplikacja.Wydrukuj($"Wskazany miesiąc to {MiesiącUżytkownika.Nazwa}")
        Aplikacja.Zatrzymaj()
    End Sub
End Module
