Imports System.IO
Imports DataBase
Imports Logica
Imports Modelo
Public Class ALUMNOGRUPOS
    Dim l_alumnogrupo As L_ALUMNOGRUPOS = New L_ALUMNOGRUPOS()
    Public contador As Integer
    Public pagina As Integer = 1
    Public CantidadPaginas As Integer
    Private Sub BTN_REGRESAR_Click(sender As Object, e As EventArgs) Handles BTN_REGRESAR.Click
        pagina -= 1
        CargarDatos()
    End Sub

    Private Sub BTN_SIGUIENTE_Click(sender As Object, e As EventArgs) Handles BTN_SIGUIENTE.Click
        pagina += 1
        CargarDatos()
    End Sub

    Friend Sub CargarDatos(Optional Filtro As String = "")

        Grupo1.Visible = False
        Grupo2.Visible = False
        Grupo3.Visible = False
        Dim Panel_1 As Boolean = False
        Dim Panel_2 As Boolean = False
        Dim Panel_3 As Boolean = False
        If pagina = 1 Then
            BTN_REGRESAR.Visible = False
            BTN_SIGUIENTE.Visible = True
        Else
            BTN_REGRESAR.Visible = True
        End If
        If pagina = CantidadPaginas Then
            BTN_SIGUIENTE.Visible = False
        End If
        For Each fila In l_alumnogrupo.Paginacion(3, pagina, CantidadPaginas, Filtro)
            Dim ID_PANEL = fila.ID_GRUPO
            If Panel_1 = False Then
                Foto1.Image = String_imagen(fila.FOTO)
                Txt1.Text = fila.GRUPO
                Panel_1 = True
                Grupo1.Visible = True
            ElseIf Panel_2 = False Then
                Txt2.Text = fila.GRUPO
                Foto2.Image = String_imagen(fila.FOTO)
                Panel_2 = True
                Grupo2.Visible = True
            ElseIf Panel_3 = False Then
                Txt3.Text = fila.GRUPO
                Foto3.Image = String_imagen(fila.FOTO)
                Panel_3 = True
                Grupo3.Visible = True
            End If
        Next
    End Sub

    Private Sub ALUMNOGRUPOS_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargarDatos()
    End Sub

    Private Sub btnATRAS_Click(sender As Object, e As EventArgs) Handles btnATRAS.Click
        MenuJugador.Show()
        Me.Close()
    End Sub
End Class