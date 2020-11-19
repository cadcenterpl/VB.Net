Imports System

Module Program
    Sub Main()
        Dim Aplikacja As App = New App("Liczenie lat od czasu zakupu Srodkow Trwalych")
        Dim IloscSrodkow As String = 0
        Do
            IloscSrodkow = Aplikacja.OdpUzytkownika("Liczba Srodkow Trwalych: (0-999): ", "*")
        Loop Until (IsNumeric(IloscSrodkow) AndAlso Integer.Parse(IloscSrodkow)<1000)
        Dim ListaSrodkowUzytkownika As New List (of String) : Dim Symbol As String
        Try
            For i as Integer = 0 To IloscSrodkow -1
                Do
                    Symbol = Aplikacja.OdpUzytkownika($"Podaj symbol srodka nr {i+1}: ", "*-*")
                    If Integer.Parse(Symbol.Substring(Symbol.Length - 4)) <= Date.Today.Year Then
                        ListaSrodkowUzytkownika.Add(Symbol)
                    End If
                Loop Until (IsNumeric(Symbol.Substring(Symbol.Length - 4)) AndAlso Integer.Parse(Symbol.Substring(Symbol.Length - 4)) <= Date.Today.Year)
            Next
            For i As Integer = 0 To IloscSrodkow -1
                Aplikacja.Wyswietl($"{ListaSrodkowUzytkownika(i)} zostal zakupiony {Date.Today.Year - Integer.Parse(ListaSrodkowUzytkownika(i).ToString.Substring(ListaSrodkowUzytkownika(i).Length - 4))} lat/a temu.")
            Next
        Catch ex As Exception
            Aplikacja.Wyswietl(" - Blad przetwarzania danych! Restart Aplikacji") : Program.Main()
        End Try
        Aplikacja.Zatrzymaj()
    End Sub
End Module
