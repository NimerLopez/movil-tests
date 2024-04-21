
Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function
    <HttpPost>
    Function Division(ByVal dividendo As Integer, ByVal divisor As Integer) As ActionResult
        Dim _utilidades As New Utilidades()
        Dim resultado As Integer = _utilidades.Dividir(dividendo, divisor)
        ViewBag.Resultado = resultado

        Return View("Index")
    End Function
    <HttpPost>
    Function ExtraerNumero(cadena As String) As ActionResult
        Dim _utilidades As New Utilidades()

        Dim resultado As Integer = _utilidades.ExtraerNumero(cadena)
        ViewBag.ResultadoExtraccionNumero = resultado
        Return View("Index")
    End Function
End Class
