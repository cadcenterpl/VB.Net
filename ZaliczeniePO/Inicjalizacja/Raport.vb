Public Class Raport
    Friend Shared Function Tytul(Autor, Przedmiot, Prowadzący)
        Dim Napis As String = $"Zaliczenie | Przedmiot: {Przedmiot} | Prowadzący: {Prowadzący} | Autor: {Autor}"
        Return Napis
    End Function
    Friend Shared Function Status1(status)
        Dim Napis As String = $"1. Wywołanie formularza logowania. Status: {status}"
        Return Napis
    End Function
    Friend Shared Function Status2(status)
        Dim Napis As String = $"2. Konfiguracja formularza logowania. Status: {status}"
        Return Napis
    End Function
    Friend Shared Function Status3(status)
        Dim Napis As String = $"3. Blokada przycisku 'Zaloguj'. Status: {status}"
        Return Napis
    End Function
    Friend Shared Function Status4(status)
        Dim Napis As String = $"4. Sprawdzenie formatu 'Email'. Status: {status}"
        Return Napis
    End Function
    Friend Shared Function Status5(status)
        Dim Napis As String = $"5. Sprawdzanie długości hasła. Status: {status}"
        Return Napis
    End Function
    Friend Shared Function Status6(status)
        Dim Napis As String = $"6. Zgodność długości hasła i formatu Email. Status: {status}"
        Return Napis
    End Function
    Friend Shared Function Status7(status)
        Dim Napis As String = $"7. Przesłanie danych logowania do funkcji Main. Status: {status}"
        Return Napis
    End Function
    Friend Shared Function Status8(status)
        Dim Napis As String = $"8. Sprawdzanie danych logowania w bazie danych PO_Logowanie SQL Azure. Status: {status}"
        Return Napis
    End Function
    Friend Shared Function Status9(status)
        Dim Napis As String = $"9. Połączenie z Bazą Loginów i Haseł na serwerze. Status: {status}"
        Return Napis
    End Function
    Friend Shared Function Status10(status)
        Dim Napis As String = $"10. Weryfikacja Email i Hasła. Status: {status}"
        Return Napis
    End Function
    Friend Shared Function Status11(status)
        Dim Napis As String = $"11. Weryfikacja poziomu dostępu użytkownika. Status: {status}"
        Return Napis
    End Function
    Friend Shared Function Status12(status)
        Dim Napis As String = $"12. Wywołanie Formularza Aplikacji. Status: {status}"
        Return Napis
    End Function
    Friend Shared Function Status13(status)
        Dim Napis As String = $"13. Sprawdzanie bezpieczeństwa połączenia. Status: {status}"
        Return Napis
    End Function
    Friend Shared Function Status14(status)
        Dim Napis As String = $"14. Potwierdzenie zgodności Token ONLINE. Status: {status}"
        Return Napis
    End Function
    Friend Shared Function Status15(status)
        Dim Napis As String = $"15. Wywołanie Formularza Aplikacji. Status: {status}"
        Return Napis
    End Function
End Class
