Imports System.Data.SqlClient
Imports System.Data.SqlDbType

Public Class Menu
    Dim ConexionBD = New ConexionBD_Nueva.Conexion
    Public FormActual As Form = Nothing



    Private Sub Registro_Distribuidores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConexionBD.AbrirConexion()
        OcultarSubmenu()
    End Sub

    Public Sub OcultarSubmenu()
        PanelSubmenu.Visible = False
    End Sub

    Public Sub MostrarSubmenu(submenu As Panel)
        If submenu.Visible = False Then
            OcultarSubmenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub

    Private Sub BtnSubmenuDistribuidores_Click(sender As Object, e As EventArgs) Handles BtnSubmenuDistribuidores.Click
        MostrarSubmenu(PanelSubmenu)
    End Sub

    Private Sub AbrirFormulario(FormHijo As Form)
        If FormActual IsNot Nothing Then
            If FormHijo.Text = FormActual.Text Then
                Return
            End If
            FormActual.Close()
        End If


        FormActual = FormHijo
        FormHijo.TopLevel = False
        FormHijo.FormBorderStyle = FormBorderStyle.None
        FormHijo.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(FormHijo)
        PanelContenedor.Tag = FormHijo
        FormHijo.BringToFront()
        FormHijo.Show()
    End Sub

    Private Sub BtnRegistroDistribuidores_Click(sender As Object, e As EventArgs) Handles BtnRegistroDistribuidores.Click
        AbrirFormulario(RegistroDistribuidores)
    End Sub

    Private Sub BtnConsultaDistribuidores_Click(sender As Object, e As EventArgs) Handles BtnConsultaDistribuidores.Click
        AbrirFormulario(ConsultaDistribuidores)
    End Sub
End Class
