
Imports System.IO
Imports Newtonsoft.Json

Public Module CONEXIONES

    Public Db As New OleDb.OleDbConnection
    Public T As New DataSet
    Public SQL As String
    Public Ruta_aplicacionDB As String
    Public Tabla_temporal As New DataSet
    Public ID_USUARIO_SESION As Integer
    Private appSettings As AppSettings = New AppSettings
    Public Sub CONECTAR()
        Try

            If (appSettings.ConexionBaseDatos = "") Then
                appSettings = JsonConvert.DeserializeObject(Of AppSettings)(File.ReadAllText($"{Ruta_aplicacionDB}\appsettings.json"))
            End If

            Dim Ruta As String
            Ruta = "File Name=" & Ruta_aplicacionDB & "\CONEX.UDL"
            '  Db.ConnectionString = appSettings.ConexionBaseDatos\
            Db.ConnectionString = Ruta
            Db.Open()
        Catch ex As Exception


        End Try
    End Sub

    Public Sub DESCONECTAR()
        Db.Close()
    End Sub

End Module

