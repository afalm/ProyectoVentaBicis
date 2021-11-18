using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVentaBicis
{
    public partial class FormNuevoUsuario : Form
    {
        String nombre;
        String nombreUsuario;
        String apellidos;
        String dni;
        String email;
        String contrasenya;
        String repetirContrasenya;
        String telefono;
        bool esSuperUsuario = false;
        public FormNuevoUsuario()
        {
            InitializeComponent();
        }
        private void crearNuevoUsuario() 
        {
            nombreUsuario = tbNombreUsuario.Text;
            contrasenya = tbContrasenya.Text;
            repetirContrasenya = tbRepetirContrasenya.Text;
            nombre = tbNombre.Text;
            dni = tbDni.Text;
            apellidos = tbApellidos.Text;
            email = tbEmail.Text;
            telefono = tbTelefono.Text;
            if (contrasenya.Equals(repetirContrasenya))
            {
                if (checkSuperUsuario.Checked) esSuperUsuario = true;
                
                Empleado nuevoEmpleado = new Empleado(esSuperUsuario, nombreUsuario, contrasenya,  nombre,  apellidos,  dni,  email, telefono);
                if (Conexion.InsertarUsuario(nuevoEmpleado))
                    MessageBox.Show("Usuario " + nombre + " insertado");
                else MessageBox.Show("Error al insertar Usuario");

            }
            else if (contrasenya.Equals("") || nombreUsuario.Equals("") || repetirContrasenya.Equals("") || nombre.Equals("") || apellidos.Equals("") || dni.Equals("") || email.Equals("")) MessageBox.Show("Datos incompletos");
            else if(!contrasenya.Equals(repetirContrasenya)) MessageBox.Show("Las contraseñas no coinciden");
            esSuperUsuario = false;
        }

        private void FormNuevoUsuario_Load(object sender, EventArgs e)
        {
           
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            crearNuevoUsuario();
        }
    }
}
