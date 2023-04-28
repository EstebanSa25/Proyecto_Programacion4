Imports System.Text.RegularExpressions
Imports DataBase
Imports Guna.UI2.WinForms
Imports Logica
Imports Modelo
Imports OpenQA.Selenium
Imports OpenQA.Selenium.DevTools.V109.IndexedDB

Public Class Reporte_preguntas
    Public LOGICA As L_REPORTE_ALUMNO = New L_REPORTE_ALUMNO
    Public ID_JUEGO_F As Integer = 64
    Public Procedimiento As Integer
    Public ID_DEL_ALUMNO As Integer

    Private Sub Reporte_preguntas_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim LST = LOGICA.CONSULTA_PREGUNTA(ID_JUEGO_F, ID_DEL_ALUMNO)
        Dim ID_PREGUNTA As Integer = 0
        Dim agrupar = LST.GroupBy(Function(x) x.ID_PREGUNTA).ToList

        For Each DATOS In agrupar
            Dim FRM_pantalla As New C_Preguntas
            Dim CONTADOR As Integer = 0
            Dim RESPONDIDO As Boolean = True
            If DATOS.Where(Function(X) X.RESPUESTA_ALUMNO = True).Count = 0 Then
                FRM_pantalla.R1.ForeColor = System.Drawing.Color.Red
                FRM_pantalla.R2.ForeColor = System.Drawing.Color.Red
                FRM_pantalla.R3.ForeColor = System.Drawing.Color.Red
                FRM_pantalla.R4.ForeColor = System.Drawing.Color.Red
                RESPONDIDO = False
            End If
            For Each DATOS2 In DATOS

                FRM_pantalla.TXT1.Text = DATOS2.PREGUNTA
                If RESPONDIDO = False Then
                    FRM_pantalla.PUNTAJE.Text = $"Puntaje:0/{DATOS2.PUNTAJE}"
                End If

                Select Case CONTADOR

                    Case 0
                        FRM_pantalla.R1.Text = DATOS2.OPCION
                        If DATOS2.CORRECTA = True Then
                            FRM_pantalla.R1.ForeColor = System.Drawing.Color.Green
                        End If
                        If DATOS2.RESPUESTA_ALUMNO = True And DATOS2.CORRECTA = False Then
                            FRM_pantalla.R1.ForeColor = System.Drawing.Color.Red
                            FRM_pantalla.PUNTAJE.Text = $"Puntaje:0/{DATOS2.PUNTAJE}"
                        ElseIf DATOS2.RESPUESTA_ALUMNO = True And DATOS2.CORRECTA = True Then
                            FRM_pantalla.PUNTAJE.Text = $"Puntaje:{DATOS2.PUNTAJE}/{DATOS2.PUNTAJE}"
                        End If
                        If DATOS2.RESPUESTA_ALUMNO = True Then
                            FRM_pantalla.CHK1.BackgroundImage = My.Resources.checked
                        End If
                    Case 1
                        FRM_pantalla.R2.Text = DATOS2.OPCION
                        If DATOS2.CORRECTA = True Then
                            FRM_pantalla.R2.ForeColor = System.Drawing.Color.Green
                        End If
                        If DATOS2.RESPUESTA_ALUMNO = True And DATOS2.CORRECTA = False Then
                            FRM_pantalla.R2.ForeColor = System.Drawing.Color.Red
                            FRM_pantalla.PUNTAJE.Text = $"Puntaje:0/{DATOS2.PUNTAJE}"
                        ElseIf DATOS2.RESPUESTA_ALUMNO = True And DATOS2.CORRECTA = True Then
                            FRM_pantalla.PUNTAJE.Text = $"Puntaje:{DATOS2.PUNTAJE}/{DATOS2.PUNTAJE}"
                        End If
                        If DATOS2.RESPUESTA_ALUMNO = True Then
                            FRM_pantalla.CHK2.BackgroundImage = My.Resources.checked
                        End If
                    Case 2
                        FRM_pantalla.R3.Text = DATOS2.OPCION
                        If DATOS2.CORRECTA = True Then
                            FRM_pantalla.R3.ForeColor = System.Drawing.Color.Green
                        End If
                        If DATOS2.RESPUESTA_ALUMNO = True And DATOS2.CORRECTA = False Then
                            FRM_pantalla.R3.ForeColor = System.Drawing.Color.Red
                            FRM_pantalla.PUNTAJE.Text = $"Puntaje:0/{DATOS2.PUNTAJE}"
                        ElseIf DATOS2.RESPUESTA_ALUMNO = True And DATOS2.CORRECTA = True Then
                            FRM_pantalla.PUNTAJE.Text = $"Puntaje:{DATOS2.PUNTAJE}/{DATOS2.PUNTAJE}"
                        End If
                        If DATOS2.RESPUESTA_ALUMNO = True Then
                            FRM_pantalla.CHK3.BackgroundImage = My.Resources.checked
                        End If
                    Case 3
                        FRM_pantalla.R4.Text = DATOS2.OPCION
                        If DATOS2.CORRECTA = True Then
                            FRM_pantalla.R4.ForeColor = System.Drawing.Color.Green
                        End If
                        If DATOS2.RESPUESTA_ALUMNO = True And DATOS2.CORRECTA = False Then
                            FRM_pantalla.R4.ForeColor = System.Drawing.Color.Red
                            FRM_pantalla.PUNTAJE.Text = $"Puntaje:0/{DATOS2.PUNTAJE}"
                        ElseIf DATOS2.RESPUESTA_ALUMNO = True And DATOS2.CORRECTA = True Then
                            FRM_pantalla.PUNTAJE.Text = $"Puntaje:{DATOS2.PUNTAJE}/{DATOS2.PUNTAJE}"
                        End If
                        If DATOS2.RESPUESTA_ALUMNO = True Then
                            FRM_pantalla.CHK4.BackgroundImage = My.Resources.checked
                        End If
                End Select
                CONTADOR += 1

            Next
            Dim LST_RETO = LOGICA.CONSULTA_RETO(DATOS.Key)

            If LST_RETO.Count > 0 Then

                Dim CONTADOR2 As Integer = 0
                Dim FRM_pantalla2 As New C_Preguntas
                FRM_pantalla2.TXT_RETO.Visible = True
                FRM_pantalla2.PUNTAJE.Visible = False
                If LST_RETO.Where(Function(X) X.RESPUESTA_ALUMNO = True).Count = 0 Then
                    FRM_pantalla2.R1.ForeColor = System.Drawing.Color.Red
                    FRM_pantalla2.R2.ForeColor = System.Drawing.Color.Red
                    FRM_pantalla2.R3.ForeColor = System.Drawing.Color.Red
                    FRM_pantalla2.R4.ForeColor = System.Drawing.Color.Red
                    RESPONDIDO = False
                End If
                For Each DATOS3 In LST_RETO
                    FRM_pantalla2.TXT1.Text = DATOS3.RETO

                    Select Case CONTADOR2

                        Case 0
                            FRM_pantalla2.R1.Text = DATOS3.OPCION
                            If DATOS3.CORRECTA = True Then
                                FRM_pantalla2.R1.ForeColor = System.Drawing.Color.Green
                            End If
                            If DATOS3.RESPUESTA_ALUMNO = True And DATOS3.CORRECTA = False Then
                                FRM_pantalla2.R1.ForeColor = System.Drawing.Color.Red
                            End If
                            If DATOS3.RESPUESTA_ALUMNO = True Then
                                FRM_pantalla2.CHK1.BackgroundImage = My.Resources.checked
                            End If
                        Case 1
                            FRM_pantalla2.R2.Text = DATOS3.OPCION
                            If DATOS3.CORRECTA = True Then
                                FRM_pantalla2.R2.ForeColor = System.Drawing.Color.Green
                            End If
                            If DATOS3.RESPUESTA_ALUMNO = True And DATOS3.CORRECTA = False Then
                                FRM_pantalla2.R2.ForeColor = System.Drawing.Color.Red
                            End If
                            If DATOS3.RESPUESTA_ALUMNO = True Then
                                FRM_pantalla2.CHK2.BackgroundImage = My.Resources.checked
                            End If
                        Case 2
                            FRM_pantalla2.R3.Text = DATOS3.OPCION
                            If DATOS3.CORRECTA = True Then
                                FRM_pantalla2.R3.ForeColor = System.Drawing.Color.Green
                            End If
                            If DATOS3.RESPUESTA_ALUMNO = True And DATOS3.CORRECTA = False Then
                                FRM_pantalla2.R3.ForeColor = System.Drawing.Color.Red
                            End If
                            If DATOS3.RESPUESTA_ALUMNO = True Then
                                FRM_pantalla2.CHK3.BackgroundImage = My.Resources.checked
                            End If
                        Case 3
                            FRM_pantalla2.R4.Text = DATOS3.OPCION
                            If DATOS3.CORRECTA = True Then
                                FRM_pantalla2.R4.ForeColor = System.Drawing.Color.Green
                            End If
                            If DATOS3.RESPUESTA_ALUMNO = True And DATOS3.CORRECTA = False Then
                                FRM_pantalla2.R4.ForeColor = System.Drawing.Color.Red
                            End If
                            If DATOS3.RESPUESTA_ALUMNO = True Then
                                FRM_pantalla2.CHK4.BackgroundImage = My.Resources.checked
                            End If
                    End Select
                    CONTADOR2 += 1
                Next
                Me.Contenedor.Controls.Add(FRM_pantalla2)
            End If
            Me.Contenedor.Controls.Add(FRM_pantalla)


        Next
    End Sub

    Private Sub btnATRAS_Click(sender As Object, e As EventArgs) Handles btnATRAS.Click
        If Procedimiento = 1 Then
            Stats.Show()
            Me.Close()
        Else
            ReporteGrupo.Show()
            Me.Close()
        End If

    End Sub


End Class