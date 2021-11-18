using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ProyectoVentaBicis;

namespace ProyectoVentaBicis
{
    class Conexion
    {
        public static SqlConnection conectar()
        {
            SqlConnection cn = new SqlConnection("SERVER=AFALM;DATABASE=VENTASBICIS; integrated security=true");
            cn.Open();
            return cn;
        }
      
        public static DataTable llenarGridEmpleados()
        {
            SqlConnection cn = conectar();
            DataTable dt = new DataTable();
            String consulta = "SELECT super_usuario, nombre_usuario, nombre, apellidos, DNI, email, telefono FROM EMPLEADO;";
            SqlCommand sql_cmd = new SqlCommand(consulta, cn);

            SqlDataAdapter adapter = new SqlDataAdapter(sql_cmd);

            adapter.Fill(dt);
            return dt;
        }
       
        public static bool InsertarUsuario(Empleado e)
        {
            int val = e.getEsSuperUsuario() ? 1 : 0;
            bool insertado = false;
           
            String nombreUsuario = e.getNombreUsuario();
            String nombre = e.getNombre();
            String contrasenya = e.getContrasenya();
            String apellidos = e.getApellidos();
            String dni = e.getDni();
            String email = e.getEmail();
            String telefono = e.getTelefono();
            Conexion.conectar();
            String insertar = "INSERT INTO EMPLEADO (super_usuario, nombre_usuario, contrasenya, nombre, apellidos, DNI, email, telefono) VALUES (" + val +
                ",'" + nombreUsuario + "','" + contrasenya + "', '" + nombre + "','" + apellidos + "','" + dni + "','" + email + "','" + telefono + "');";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.conectar());
            try
            {
                cmd1.ExecuteNonQuery();
                insertado = true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return insertado;
        }
        public static Empleado login(String nombreUsuario, String contrasenya)
        {
            //Se crea la conexión a la base de datos
            SqlConnection cn = conectar();
            Empleado empleado = new Empleado();
            //String con la consulta
            String consulta = "SELECT * FROM EMPLEADO WHERE nombre_usuario=@vnombreUsuario AND contrasenya=@vcontrasenya;";
           
            //Se crea el comando que necesitamos para ejecutar el SELECT
            SqlCommand cmdLogin = new SqlCommand(consulta, cn);
            //Pasar parámetros de las variables
            cmdLogin.Parameters.AddWithValue("@vnombreUsuario", nombreUsuario);
            cmdLogin.Parameters.AddWithValue("@vcontrasenya", contrasenya);
            SqlDataReader reader = cmdLogin.ExecuteReader();// Se ejecuta el comando y el resultado se almacena en una variable de tipo SqlDataReader
            //Si hay resultados devuelve El objeto empleado si no devuelve un null 
            if (reader.Read())
            {
                empleado.setId(reader.GetInt32(0));
                empleado.setEsSuperUsuario(reader.GetBoolean(1));
                empleado.setNombreUsuario(reader.GetString(2));
                empleado.setContrasenya(reader.GetString(3));
                return empleado;
            }
            else
                return null;
            cn.Close();
        }
      
    }
}
