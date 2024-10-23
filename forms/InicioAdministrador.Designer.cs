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
            this.bD_TP_grupal_parte_2DataSet = new TP_2___0._0._1.BD_TP_grupal_parte_2DataSet();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new TP_2___0._0._1.BD_TP_grupal_parte_2DataSetTableAdapters.UsuariosTableAdapter();
            this.bD_TP_grupal_parte_2DataSet1 = new TP_2___0._0._1.BD_TP_grupal_parte_2DataSet1();
            this.usuariosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter1 = new TP_2___0._0._1.BD_TP_grupal_parte_2DataSet1TableAdapters.UsuariosTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_TP_grupal_parte_2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_TP_grupal_parte_2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.bD_TP_grupal_parte_2DataSet.DataSetName = "BD_TP_grupal_parte_2DataSet";
            this.bD_TP_grupal_parte_2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.bD_TP_grupal_parte_2DataSet;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // bD_TP_grupal_parte_2DataSet1
            // 
            this.bD_TP_grupal_parte_2DataSet1.DataSetName = "BD_TP_grupal_parte_2DataSet1";
            this.bD_TP_grupal_parte_2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosBindingSource1
            // 
            this.usuariosBindingSource1.DataMember = "Usuarios";
            this.usuariosBindingSource1.DataSource = this.bD_TP_grupal_parte_2DataSet1;
            // 
            // usuariosTableAdapter1
            // 
            this.usuariosTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(656, 426);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frmInicioAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblBienvenidoAdministrador);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmInicioAdministrador";
            this.Text = "InicioAdministrador";
            this.Load += new System.EventHandler(this.frmInicioAdministrador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_TP_grupal_parte_2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_TP_grupal_parte_2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBienvenidoAdministrador;
        private BD_TP_grupal_parte_2DataSet bD_TP_grupal_parte_2DataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private BD_TP_grupal_parte_2DataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private BD_TP_grupal_parte_2DataSet1 bD_TP_grupal_parte_2DataSet1;
        private System.Windows.Forms.BindingSource usuariosBindingSource1;
        private BD_TP_grupal_parte_2DataSet1TableAdapters.UsuariosTableAdapter usuariosTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}