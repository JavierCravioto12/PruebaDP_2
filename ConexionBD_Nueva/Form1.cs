using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;

namespace ConexionBD_Nueva
{

    public class Conexion
    {
        SqlConnection sqlCon;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public void AbrirConexion()
        {
            string Nombre_Servidor = Dns.GetHostName();

            sqlCon = new SqlConnection("Data Source=" + Nombre_Servidor + ";Initial Catalog=pruebas_dp;Integrated Security=True");
            sqlCon.Open();


        }

        public void CerrarConexion()
        {
            sqlCon.Close();

        }

        public string Cadena()
        {
            return sqlCon.ConnectionString;
        }

        public void RegistrarDistribuidores(String Nombre, String ApPaterno, String ApMaterno, String Calle, String NumeroCasa, String Colonia)
        {
            AbrirConexion();
            cmd = new SqlCommand ("EXEC PROC_AGREGARDISTRIBUIDOR '" + Nombre + "','" + ApPaterno + "','" + ApMaterno + "','" + Calle + "','" + NumeroCasa + "','" + Colonia+"'",sqlCon);
            cmd.ExecuteNonQuery();
            //String cmd = "EXEC PROC_AGREGARDISTRIBUIDOR " + Nombre + "," + ApPaterno + "," + ApMaterno + "," + Calle + "," + NumeroCasa + "," + Colonia;
            MessageBox.Show("Registro Exitoso");
        }

        public void ConsultaDistribuidores(Int16 ID, DataGridView dgv)
            
        {
            try
            {
                da = new SqlDataAdapter("EXEC SP_BuscarDistribuidor " + ID, sqlCon);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al llenar el Datagridview" + ex.ToString());
            }
        }


    }


}
