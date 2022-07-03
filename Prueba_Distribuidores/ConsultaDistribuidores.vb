Imports System.ComponentModel

Public Class ConsultaDistribuidores

    Dim ConexionBD = New ConexionBD_Nueva.Conexion
    Public IDConsulta As Int16



    Private Sub ConsultaDistribuidores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConexionBD.AbrirConexion()
    End Sub

    Private Sub btnConsulta_Click(sender As Object, e As EventArgs) Handles btnConsulta.Click
        ConsultaID.Show()
    End Sub

    Private Sub grdConsulta_GotFocus(sender As Object, e As EventArgs) Handles grdConsulta.GotFocus

        If Not ConsultaID.txtID.Text.Length > 0 Then
            Return
        Else
            IDConsulta = ConsultaID.txtID.Text
        End If

        'If ConsultaID.txtID.Text.Length > 0 Then
        '    IDConsulta = ConsultaID.txtID.Text
        'End If
    End Sub

    'Private Sub ConsultaDistribuidores_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
    '    If Not ConsultaID.txtID.Text.Length > 0 Then
    '        Return
    '    Else
    '        IDConsulta = ConsultaID.txtID.Text
    '    End If
    'End Sub
End Class