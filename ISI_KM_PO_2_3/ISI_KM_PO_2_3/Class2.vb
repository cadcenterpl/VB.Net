Public Class Class2
    Public Shared Function wzór(masa, wzrost)
        Return masa / wzrost
    End Function

    Public Shared Sub wynik(masa, wzrost)
        Console.Write("BMI Przy wadze" + Str(masa) + "kg i wzroscie" + Str(wzrost) + "cm wynosi: ")
    End Sub
End Class
