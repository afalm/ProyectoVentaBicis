using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVentaBicis
{
    public class Empleado
    {
        private int id;
        private bool esSuperUsuario;
        private String nombreUsuario; 
        private String contrasenya;
        private String nombre;
        private String email;
        private String apellidos;
        private String dni;
        private String telefono;
        public Empleado() { }
        public Empleado(String nombreUsuario, String contrasenya) 
        {
            this.nombreUsuario = nombreUsuario;
            this.contrasenya = contrasenya;
        }
        public Empleado(bool esSuperUsuario, String nombre, String contrasenya) 
        {
            this.esSuperUsuario = esSuperUsuario;
            this.nombre = nombre;
            this.contrasenya = contrasenya;
        }
        public Empleado(bool esSuperUsuario, String nombreUsuario, String contrasenya, String nombre, String apellidos, String dni, String email, String telefono)
        {
            this.telefono = telefono;
            this.email = email;
            this.dni = dni;
            this.apellidos = apellidos;
            this.nombre = nombre;
            this.esSuperUsuario = esSuperUsuario;
            this.nombreUsuario = nombreUsuario;
            this.contrasenya = contrasenya;
        }
        public String getTelefono()
        {
            return telefono;
        }
        public void setTelefono(String telefono)
        {
            this.telefono = telefono;
        }
        public String getNombre() {
            return nombre;
        }
        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }
        public String getApellidos()
        {
            return apellidos;
        }
        public void setApellidos(String apellidos)
        {
            this.apellidos = apellidos;
        }
        public String getDni()
        {
            return dni;
        }
        public void setDni(String dni)
        {
            this.dni = dni;
        }
        public String getEmail()
        {
            return email;
        }
        public void setEmail(String email)
        {
            this.email = email;
        }
        public int getId() 
        {
            return id;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public bool getEsSuperUsuario()
        {
            return esSuperUsuario;

        }
        public void setEsSuperUsuario(bool esSuperUsuario)
        {
            this.esSuperUsuario = esSuperUsuario;
        }
        public String getNombreUsuario()
        {
            return nombreUsuario;
        }
        public void setNombreUsuario(String nombre)
        {
            this.nombreUsuario = nombreUsuario;
        }
        public String getContrasenya()
        {
            return contrasenya;
        }
        public void setContrasenya(String contrasenya)
        {
            this.contrasenya = contrasenya;
        }

    }
}
