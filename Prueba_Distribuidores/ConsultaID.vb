Public Class ConsultaID

    Dim ConexionBD = New ConexionBD_Nueva.Conexion

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        ConexionBD.AbrirConexion()
        'ConsultaDistribuidores.IDConsulta = txtID.Text
        ConexionBD.ConsultaDistribuidores(txtID.Text, ConsultaDistribuidores.grdConsulta)
        If Not ConsultaDistribuidores.grdConsulta.RowCount > 0 Then
            MessageBox.Show("No existen registros seleccionados")
        End If
        Me.Close()
    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
End Class