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
    public class CD_Matricula
    {
        SqlDataAdapter adaptador;
        DataTable dtestudiantes;
        DataTable dtasignaturas;

        public DataTable leerEstudiantes()
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string consulta = "SELECT * FROM estudiantes;";
                    SqlCommand cmd = new SqlCommand(consulta, oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();
                    adaptador = new SqlDataAdapter();
                    adaptador.SelectCommand = cmd;
                    dtestudiantes = new DataTable();
                    adaptador.Fill(dtestudiantes);
                    oconexion.Close();
                    return dtestudiantes;
                }
                catch (Exception)
                {

                    MessageBox.Show("Error en la consulta", "Error");
                    return null;
                }
            }
        }
        public DataTable leerAsignaturas()
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string consulta = "SELECT * FROM asignaturas;";
                    SqlCommand cmd = new SqlCommand(consulta, oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();
                    adaptador = new SqlDataAdapter();
                    adaptador.SelectCommand = cmd;
                    dtasignaturas = new DataTable();
                    adaptador.Fill(dtasignaturas);
                    oconexion.Close();
                    return dtasignaturas;
                }
                catch (Exception)
                {

                    MessageBox.Show("Error en la consulta", "Error");
                    return null;
                }
            }
        }

        public bool RegistrarMatricula(int idest, int idasig, string f, double n)
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string consulta = "INSERT INTO matricula(idestudiante,idasignatura,fechamatricula,nota)" +
                        " VALUES (" + idest + "," + idasig + ",'" + f + "'," + n + ");";

                    SqlCommand cmd = new SqlCommand(consulta,oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    cmd.ExecuteNonQuery();
                    oconexion.Close();

                    return true;
                }
                catch
                {
                    MessageBox.Show("Error al registrar matricula", "Error");
                    return false;
                }
            }
        }

    }
}
