using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProyectoVentaBicis
{
    class Conexión
    {
        public static SqlConnection conectar()
        {
            SqlConnection cn = new SqlConnection("SERVER=DESKTOP-GTNO6RA;DATABASE=REGISTRO; integrated security=true");
            cn.Open();
            return cn;
        }
        public static void cerrar()
        {
            conectar().Close();
        }
    }
}
