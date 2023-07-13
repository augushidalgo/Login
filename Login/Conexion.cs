using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Login
{
    public class Conexion
    {
        public static string cadena = ConfigurationManager.ConnectionStrings["cadenaconexion"].ToString();
    }
}
