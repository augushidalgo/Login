using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public class CD_Usuariosistema
    {
        SqlDataAdapter adaptador;
        DataTable dtusuariosistema;
        // Método para leer de la tabla usuariosistema
        public DataTable leerUsuarioSistema(string nombre)
        {
            

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string consulta = "SELECT clave FROM usuariosistema WHERE nombre='" + nombre + "';";
                    SqlCommand cmd  = new SqlCommand(consulta,oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();
                    adaptador = new SqlDataAdapter();
                    adaptador.SelectCommand = cmd;
                    dtusuariosistema = new DataTable();
                    adaptador.Fill(dtusuariosistema);
                    oconexion.Close();
                    return dtusuariosistema;
                }
                catch (Exception)
                {

                    MessageBox.Show("Error en la consulta","Error");
                    return null;
                }
            }

        }
    }
}
