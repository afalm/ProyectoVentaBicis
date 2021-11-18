
namespace ProyectoVentaBicis
{
    partial class FormNuevoUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNuevoUsuario));
            this.lblContrasenya = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbNombreUsuario = new System.Windows.Forms.TextBox();
            this.tbContrasenya = new System.Windows.Forms.TextBox();
            this.checkSuperUsuario = new System.Windows.Forms.CheckBox();
            this.lblRepetirContrasenya = new System.Windows.Forms.Label();
            this.tbRepetirContrasenya = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblNombreEmpleado = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblContrasenya
            // 
            this.lblContrasenya.AutoSize = true;
            this.lblContrasenya.Location = new System.Drawing.Point(213, 60);
            this.lblContrasenya.Name = "lblContrasenya";
            this.lblContrasenya.Size = new System.Drawing.Size(66, 13);
            this.lblContrasenya.TabIndex = 1;
            this.lblContrasenya.Text = "Contrasenya";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(59, 60);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(98, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre de Usuario";
            // 
            // tbNombreUsuario
            // 
            this.tbNombreUsuario.Location = new System.Drawing.Point(62, 76);
            this.tbNombreUsuario.Name = "tbNombreUsuario";
            this.tbNombreUsuario.Size = new System.Drawing.Size(122, 20);
            this.tbNombreUsuario.TabIndex = 3;
            // 
            // tbContrasenya
            // 
            this.tbContrasenya.Location = new System.Drawing.Point(216, 76);
            this.tbContrasenya.Name = "tbContrasenya";
            this.tbContrasenya.PasswordChar = '*';
            this.tbContrasenya.Size = new System.Drawing.Size(145, 20);
            this.tbContrasenya.TabIndex = 4;
            // 
            // checkSuperUsuario
            // 
            this.checkSuperUsuario.AutoSize = true;
            this.checkSuperUsuario.Location = new System.Drawing.Point(62, 370);
            this.checkSuperUsuario.Name = "checkSuperUsuario";
            this.checkSuperUsuario.Size = new System.Drawing.Size(93, 17);
            this.checkSuperUsuario.TabIndex = 7;
            this.checkSuperUsuario.Text = "Super Usuario";
            this.checkSuperUsuario.UseVisualStyleBackColor = true;
            // 
            // lblRepetirContrasenya
            // 
            this.lblRepetirContrasenya.AutoSize = true;
            this.lblRepetirContrasenya.Location = new System.Drawing.Point(390, 60);
            this.lblRepetirContrasenya.Name = "lblRepetirContrasenya";
            this.lblRepetirContrasenya.Size = new System.Drawing.Size(94, 13);
            this.lblRepetirContrasenya.TabIndex = 8;
            this.lblRepetirContrasenya.Text = "Repita contraseña";
            // 
            // tbRepetirContrasenya
            // 
            this.tbRepetirContrasenya.Location = new System.Drawing.Point(393, 76);
            this.tbRepetirContrasenya.Name = "tbRepetirContrasenya";
            this.tbRepetirContrasenya.PasswordChar = '*';
            this.tbRepetirContrasenya.Size = new System.Drawing.Size(145, 20);
            this.tbRepetirContrasenya.TabIndex = 9;
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnInsertar.CausesValidation = false;
            this.btnInsertar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnInsertar.FlatAppearance.BorderSize = 0;
            this.btnInsertar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnInsertar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnInsertar.Location = new System.Drawing.Point(201, 411);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(200, 33);
            this.btnInsertar.TabIndex = 10;
            this.btnInsertar.Text = "INSERTAR";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.AutoSize = true;
            this.lblNombreEmpleado.Location = new System.Drawing.Point(59, 159);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(44, 13);
            this.lblNombreEmpleado.TabIndex = 11;
            this.lblNombreEmpleado.Text = "Nombre";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(213, 159);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(49, 13);
            this.lblApellidos.TabIndex = 12;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(59, 262);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 13;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(354, 262);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(62, 175);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(122, 20);
            this.tbNombre.TabIndex = 15;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(62, 278);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(122, 20);
            this.tbTelefono.TabIndex = 16;
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(216, 175);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(246, 20);
            this.tbApellidos.TabIndex = 17;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(357, 278);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(206, 20);
            this.tbEmail.TabIndex = 18;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(213, 262);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 19;
            this.lblDni.Text = "DNI";
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(216, 278);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(100, 20);
            this.tbDni.TabIndex = 20;
            // 
            // FormNuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 488);
            this.Controls.Add(this.tbDni);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbApellidos);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombreEmpleado);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.tbRepetirContrasenya);
            this.Controls.Add(this.lblRepetirContrasenya);
            this.Controls.Add(this.checkSuperUsuario);
            this.Controls.Add(this.tbContrasenya);
            this.Controls.Add(this.tbNombreUsuario);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblContrasenya);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNuevoUsuario";
            this.Text = "CREAR USUARIO";
            this.Load += new System.EventHandler(this.FormNuevoUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblContrasenya;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tbNombreUsuario;
        private System.Windows.Forms.TextBox tbContrasenya;
        private System.Windows.Forms.CheckBox checkSuperUsuario;
        private System.Windows.Forms.Label lblRepetirContrasenya;
        private System.Windows.Forms.TextBox tbRepetirContrasenya;
        private System.Windows.Forms.Button btnInsertar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblNombreEmpleado;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox tbDni;
    }
}