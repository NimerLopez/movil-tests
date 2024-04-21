Imports System.Text.RegularExpressions
Public Class Utilidades
    Public Function Dividir(ByVal dividendo As Integer, ByVal divisor As Integer)
        If divisor <> 0 Then
            Return dividendo / divisor
        Else
            Return 0
        End If
    End Function
    Public Function ExtraerNumero(ByVal cadena As String) As Integer
        Dim numeroComoTexto As String = ""

        For Each caracter As Char In cadena
            If Char.IsDigit(caracter) Then
                numeroComoTexto &= caracter
            ElseIf numeroComoTexto <> "" Then
                Exit For
            End If
        Next

        'Convierte el texto a numero'
        If Integer.TryParse(numeroComoTexto, ExtraerNumero) Then
            ' Devuelve el número entero si la conversión es exitosa.
            Return ExtraerNumero
        Else
            Return 0
        End If
    End Function

End Class
