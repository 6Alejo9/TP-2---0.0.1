namespace TP_2___0._0._1.forms
{
    partial class RecuperoContraseña
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
            this.txbCorreoElectronico = new System.Windows.Forms.TextBox();
            this.lblCorreoEelctronico = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnValidarCorreoElectronico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txbCorreoElectronico
            // 
            this.txbCorreoElectronico.Location = new System.Drawing.Point(58, 262);
            this.txbCorreoElectronico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbCorreoElectronico.Name = "txbCorreoElectronico";
            this.txbCorreoElectronico.Size = new System.Drawing.Size(240, 22);
            this.txbCorreoElectronico.TabIndex = 8;
            // 
            // lblCorreoEelctronico
            // 
            this.lblCorreoEelctronico.AutoSize = true;
            this.lblCorreoEelctronico.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoEelctronico.Location = new System.Drawing.Point(74, 188);
            this.lblCorreoEelctronico.Name = "lblCorreoEelctronico";
            this.lblCorreoEelctronico.Size = new System.Drawing.Size(214, 52);
            this.lblCorreoEelctronico.TabIndex = 6;
            this.lblCorreoEelctronico.Text = "Por favor ingrese su \r\nCorreo Electronico";
            this.lblCorreoEelctronico.Click += new System.EventHandler(this.lblCorreoEelctronico_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TP_2___0._0._1.Properties.Resources.A;
            this.pictureBox1.InitialImage = global::TP_2___0._0._1.Properties.Resources.A;
            this.pictureBox1.Location = new System.Drawing.Point(79, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnValidarCorreoElectronico
            // 
            this.btnValidarCorreoElectronico.Location = new System.Drawing.Point(58, 304);
            this.btnValidarCorreoElectronico.Name = "btnValidarCorreoElectronico";
            this.btnValidarCorreoElectronico.Size = new System.Drawing.Size(240, 53);
            this.btnValidarCorreoElectronico.TabIndex = 11;
            this.btnValidarCorreoElectronico.Text = "Validad Correo Electronico";
            this.btnValidarCorreoElectronico.UseVisualStyleBackColor = true;
            this.btnValidarCorreoElectronico.Click += new System.EventHandler(this.btnValidarCorreoElectronico_Click);
            // 
            // RecuperoContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 457);
            this.Controls.Add(this.btnValidarCorreoElectronico);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txbCorreoElectronico);
            this.Controls.Add(this.lblCorreoEelctronico);
            this.Name = "RecuperoContraseña";
            this.Text = "RecuperoContraseña";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbCorreoElectronico;
        private System.Windows.Forms.Label lblCorreoEelctronico;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnValidarCorreoElectronico;
    }
}