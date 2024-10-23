namespace TP_2___0._0._1
{
    partial class frmInicioUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicioUsuarios));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBienvenidoAdministrador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TP_2___0._0._1.Properties.Resources.A;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(169, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblBienvenidoAdministrador
            // 
            this.lblBienvenidoAdministrador.AutoSize = true;
            this.lblBienvenidoAdministrador.Font = new System.Drawing.Font("Broadway", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenidoAdministrador.Location = new System.Drawing.Point(165, 252);
            this.lblBienvenidoAdministrador.Name = "lblBienvenidoAdministrador";
            this.lblBienvenidoAdministrador.Size = new System.Drawing.Size(194, 20);
            this.lblBienvenidoAdministrador.TabIndex = 3;
            this.lblBienvenidoAdministrador.Text = "Bienvenido, Usuario";
            // 
            // frmInicioUsuarios
            // 
            this.ClientSize = new System.Drawing.Size(543, 640);
            this.Controls.Add(this.lblBienvenidoAdministrador);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmInicioUsuarios";
            this.Load += new System.EventHandler(this.frmInicioUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBienvenidoAdministrador;
    }
}