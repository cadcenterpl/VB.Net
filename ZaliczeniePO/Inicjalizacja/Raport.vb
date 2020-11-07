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
End Class
