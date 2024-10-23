namespace TP_2___0._0._1.forms
{
    partial class frmRegistrar
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
            this.lblNombreYApellido = new System.Windows.Forms.Label();
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txbNombreUsuario = new System.Windows.Forms.TextBox();
            this.txbCorreoElectronico = new System.Windows.Forms.TextBox();
            this.txbContraseña = new System.Windows.Forms.TextBox();
            this.btnAceptarRegistro = new System.Windows.Forms.Button();
            this.btnRegresarAlLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombreYApellido
            // 
            this.lblNombreYApellido.AutoSize = true;
            this.lblNombreYApellido.Location = new System.Drawing.Point(15, 47);
            this.lblNombreYApellido.Name = "lblNombreYApellido";
            this.lblNombreYApellido.Size = new System.Drawing.Size(111, 16);
            this.lblNombreYApellido.TabIndex = 1;
            this.lblNombreYApellido.Text = "Nombre y Apllido";
            this.lblNombreYApellido.Click += new System.EventHandler(this.lblNombreYApellido_Click);
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.Location = new System.Drawing.Point(15, 108);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(115, 16);
            this.lblCorreoElectronico.TabIndex = 2;
            this.lblCorreoElectronico.Text = "CorreoElectronico";
            this.lblCorreoElectronico.Click += new System.EventHandler(this.lblCorreoElectronico_Click);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(15, 158);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(76, 16);
            this.lblContraseña.TabIndex = 3;
            this.lblContraseña.Text = "Contraseña";
            this.lblContraseña.Click += new System.EventHandler(this.lblContraseña_Click);
            // 
            // txbNombreUsuario
            // 
            this.txbNombreUsuario.Location = new System.Drawing.Point(227, 37);
            this.txbNombreUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txbNombreUsuario.Name = "txbNombreUsuario";
            this.txbNombreUsuario.Size = new System.Drawing.Size(132, 22);
            this.txbNombreUsuario.TabIndex = 4;
            this.txbNombreUsuario.TextChanged += new System.EventHandler(this.txbNombreYApellido_TextChanged);
            // 
            // txbCorreoElectronico
            // 
            this.txbCorreoElectronico.Location = new System.Drawing.Point(227, 100);
            this.txbCorreoElectronico.Margin = new System.Windows.Forms.Padding(4);
            this.txbCorreoElectronico.Name = "txbCorreoElectronico";
            this.txbCorreoElectronico.Size = new System.Drawing.Size(132, 22);
            this.txbCorreoElectronico.TabIndex = 5;
            this.txbCorreoElectronico.TextChanged += new System.EventHandler(this.txbCorreoElectronico_TextChanged);
            // 
            // txbContraseña
            // 
            this.txbContraseña.Location = new System.Drawing.Point(227, 158);
            this.txbContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txbContraseña.Name = "txbContraseña";
            this.txbContraseña.Size = new System.Drawing.Size(132, 22);
            this.txbContraseña.TabIndex = 6;
            this.txbContraseña.TextChanged += new System.EventHandler(this.txbContraseña_TextChanged);
            // 
            // btnAceptarRegistro
            // 
            this.btnAceptarRegistro.Location = new System.Drawing.Point(98, 234);
            this.btnAceptarRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptarRegistro.Name = "btnAceptarRegistro";
            this.btnAceptarRegistro.Size = new System.Drawing.Size(202, 69);
            this.btnAceptarRegistro.TabIndex = 7;
            this.btnAceptarRegistro.Text = "Aceptar";
            this.btnAceptarRegistro.UseVisualStyleBackColor = true;
            this.btnAceptarRegistro.Click += new System.EventHandler(this.btnAceptarRegistro_Click);
            // 
            // btnRegresarAlLogin
            // 
            this.btnRegresarAlLogin.Location = new System.Drawing.Point(98, 311);
            this.btnRegresarAlLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresarAlLogin.Name = "btnRegresarAlLogin";
            this.btnRegresarAlLogin.Size = new System.Drawing.Size(202, 69);
            this.btnRegresarAlLogin.TabIndex = 8;
            this.btnRegresarAlLogin.Text = "¿ Ya Estas Registrado ?\r\nRegresa al Login";
            this.btnRegresarAlLogin.UseVisualStyleBackColor = true;
            this.btnRegresarAlLogin.Click += new System.EventHandler(this.btnRegresarAlLogin_Click);
            // 
            // frmRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 450);
            this.Controls.Add(this.btnRegresarAlLogin);
            this.Controls.Add(this.btnAceptarRegistro);
            this.Controls.Add(this.txbContraseña);
            this.Controls.Add(this.txbCorreoElectronico);
            this.Controls.Add(this.txbNombreUsuario);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblCorreoElectronico);
            this.Controls.Add(this.lblNombreYApellido);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmRegistrar";
            this.Text = "Registracion";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreYApellido;
        private System.Windows.Forms.Label lblCorreoElectronico;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txbNombreUsuario;
        private System.Windows.Forms.TextBox txbCorreoElectronico;
        private System.Windows.Forms.TextBox txbContraseña;
        private System.Windows.Forms.Button btnAceptarRegistro;
        private System.Windows.Forms.Button btnRegresarAlLogin;
    }
}