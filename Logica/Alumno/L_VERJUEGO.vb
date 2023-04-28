Imports DataBase
Imports Modelo
Public Class L_VERJUEGO
    Dim verjuegodb As DBVERJUEGO = New DBVERJUEGO
    Public Function CONSULTAR_POR_ID() As List(Of FORMULARIO)
        Dim lst = verjuegodb.CONSULTAR(ID_USUARIO_SESION)
        Return lst.Where(
                   Function(x) x.VISIBILIDAD = True Or (x.FECHA_INICIO <> Nothing And Convert.ToDateTime($"{Format(x.FECHA_INICIO, "yyyy-MM-dd")} {x.HORA_INICIO.ToString("HH:mm:ss")}") <= Format(Now, "yyyy-MM-dd HH:mm:ss") And
                   Convert.ToDateTime($"{Format(x.FECHA_FIN, "yyyy-MM-dd")} {x.HORA_FIN.ToString("HH:mm:ss")}") >= Format(Now, "yyyy-MM-dd HH:mm:ss"))
                 ).ToList()

    End Function
End Class
