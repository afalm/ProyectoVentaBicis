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
    public partial class FormPrincipal : Form
    {
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            formLogin frm = new formLogin();
            ocultarSubmenu();
           
        }
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void ocultarSubmenu() 
        {
            subpanelEmpleados.Visible = false;
            subpanelProductos.Visible = false;
            subpanelAlmacen.Visible = false;
        
        }
        public void hideSubmenu()
        {
            if (subpanelAlmacen.Visible == true)
                subpanelAlmacen.Visible = false;
          
            if (subpanelEmpleados.Visible == true)
                subpanelEmpleados.Visible = false;
            if (subpanelProductos.Visible == true)
                subpanelProductos.Visible = false;
          

        }
        public void mostrarSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void AbrirFormInPanel(object formHijo)
        {
            if (panelContendor.Controls.Count > 0)
                this.panelContendor.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContendor.Controls.Add(fh);
            this.panelContendor.Tag = fh;

            fh.Show();
        }
        // botón Empleados menú principal
        private void button1_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(subpanelEmpleados);
        }
        // botón nuevo empleado
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormNuevoUsuario());
            hideSubmenu();
        }
        //botón LISTADO empleado
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FormListadoEmpleados());
            hideSubmenu();

        }


        private void btnProductos_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(subpanelProductos);
        }

        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(subpanelAlmacen);
        }
     
    }
}
