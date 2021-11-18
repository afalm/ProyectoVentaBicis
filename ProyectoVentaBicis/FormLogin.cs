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

namespace ProyectoVentaBicis
{
    public partial class formLogin : Form
    {
        String nombre;
        String contrasenya;
        public formLogin()
        {
            InitializeComponent();
        }

        private void formLogin_Load(object sender, EventArgs e)
        {

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            logear();
        }
        public void logear() 
        {
            //Con este método lo que hacemos es Conectarnos a la base de datos hacer la consulta y obtener un objeto Empleado
            nombre = tbNombre.Text;
            contrasenya = tbContrasenya.Text;
            Empleado empleadoLogeado = Conexion.login(nombre, contrasenya);
            if (empleadoLogeado != null)
            {
                MessageBox.Show("Credenciales correctas");
                if (empleadoLogeado.getEsSuperUsuario())
                {
                    FormPrincipal frm = new FormPrincipal();
                   
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    FormUsuario frm = new FormUsuario();
                    frm.Show();
                    this.Hide();
                    
                }
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas");
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            logear();
        }

        private void chMostrarContrasenya_CheckedChanged(object sender, EventArgs e)
        {

            if (chMostrarContrasenya.Checked)
                tbContrasenya.UseSystemPasswordChar = false;
            else
                tbContrasenya.UseSystemPasswordChar = true;
        }
    }
}
