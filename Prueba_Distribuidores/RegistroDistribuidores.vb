Public Class RegistroDistribuidores
    Dim ConexionBD = New ConexionBD_Nueva.Conexion

    Private Sub RegistroDistribuidores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConexionBD.AbrirConexion()
        txtNombre.Focus()
    End Sub

    Public Sub LimpiarControles()
        txtNombre.Text = ""
        txtApellidoP.Text = ""
        txtApellidoM.Text = ""
        txtCalle.Text = ""
        txtNumero.Text = ""
        txtColonia.Text = ""

        txtNombre.BackColor = Color.White
        txtApellidoP.BackColor = Color.White
        txtNombre.Focus()
    End Sub

    Public Sub ConsultarProveedor(ID As Int16)

    End Sub


    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarControles()

    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If txtNombre.Text = "" Then
            MessageBox.Show("Falta Capturar Nombre")
            txtNombre.BackColor = Color.Yellow
            txtNombre.Focus()
            Return
        End If
        If txtApellidoP.Text = "" Then
            MessageBox.Show("Falta Capturar Apellido")
            txtApellidoP.BackColor = Color.Yellow
            txtApellidoP.Focus()
            Return
        End If

        ConexionBD.AbrirConexion()
        ConexionBD.RegistrarDistribuidores(txtNombre.Text, txtApellidoP.Text, txtApellidoM.Text, txtCalle.Text, txtNumero.Text, txtColonia.Text)
        LimpiarControles()

    End Sub
End Class