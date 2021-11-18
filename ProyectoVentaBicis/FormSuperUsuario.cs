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
    public partial class FormSuperUsuario : Form
    {
        public String nombre;
        public FormSuperUsuario()
        {
            InitializeComponent();
        }


        private void FormSuperUsuario_Load(object sender, EventArgs e)
        {
            formLogin frm = new formLogin();
            

            

            
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNuevoUsuario frm = new FormNuevoUsuario();
            frm.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbEmpleado.Visible = true;
            dtEmpleados.DataSource = Conexion.llenarGridEmpleados();
        }

        public void llenarGrid()
        {
           
        }
    }
}
