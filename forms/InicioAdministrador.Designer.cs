namespace TP_2___0._0._1.forms
{
    partial class frmInicioAdministrador
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBienvenidoAdministrador = new System.Windows.Forms.Label();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TP_2___0._0._1.Properties.Resources.A;
            this.pictureBox1.InitialImage = global::TP_2___0._0._1.Properties.Resources.A;
            this.pictureBox1.Location = new System.Drawing.Point(674, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblBienvenidoAdministrador
            // 
            this.lblBienvenidoAdministrador.AutoSize = true;
            this.lblBienvenidoAdministrador.Font = new System.Drawing.Font("Broadway", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenidoAdministrador.Location = new System.Drawing.Point(798, 9);
            this.lblBienvenidoAdministrador.Name = "lblBienvenidoAdministrador";
            this.lblBienvenidoAdministrador.Size = new System.Drawing.Size(177, 40);
            this.lblBienvenidoAdministrador.TabIndex = 2;
            this.lblBienvenidoAdministrador.Text = "Bienvenido, \r\nSr. Administrador";
            // 
            // bD_TP_grupal_parte_2DataSet
            // 
            // 
            // usuariosBindingSource
            // 
            // 
            // usuariosTableAdapter
            // 
            // 
            // bD_TP_grupal_parte_2DataSet1
            // 
            // 
            // usuariosBindingSource1
            // 
            // 
            // usuariosTableAdapter1
            // 
            // 
            // dataGridView1
            // 
            // 
            // frmInicioAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 450);
            this.Controls.Add(this.lblBienvenidoAdministrador);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmInicioAdministrador";
            this.Text = "InicioAdministrador";
            this.Load += new System.EventHandler(this.frmInicioAdministrador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBienvenidoAdministrador;
    }
}