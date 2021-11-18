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
    public partial class FormListadoEmpleados : Form
    {
        public FormListadoEmpleados()
        {
            InitializeComponent();
        }

        private void FormListadoEmpleados_Load(object sender, EventArgs e)
        {
            dtEmpleados.DataSource = Conexion.llenarGridEmpleados();
        }
    }
}
