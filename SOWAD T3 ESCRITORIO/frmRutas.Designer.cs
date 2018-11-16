namespace SOWAD_T3_ESCRITORIO
{
    partial class frmRutas
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rutas_bt_nuevaRuta = new System.Windows.Forms.Button();
            this.rutas_bt_buscarRuta = new System.Windows.Forms.Button();
            this.rutas_tb_buscarRuta = new System.Windows.Forms.TextBox();
            this.rutas_dgv_listarRutas = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CiudadOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CiudadDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rutas_dgv_listarRutas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(401, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "RUTAS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rutas_bt_nuevaRuta);
            this.groupBox1.Controls.Add(this.rutas_bt_buscarRuta);
            this.groupBox1.Controls.Add(this.rutas_tb_buscarRuta);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(823, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GESTIONAR RUTAS";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rutas_bt_nuevaRuta
            // 
            this.rutas_bt_nuevaRuta.Location = new System.Drawing.Point(653, 38);
            this.rutas_bt_nuevaRuta.Name = "rutas_bt_nuevaRuta";
            this.rutas_bt_nuevaRuta.Size = new System.Drawing.Size(150, 32);
            this.rutas_bt_nuevaRuta.TabIndex = 2;
            this.rutas_bt_nuevaRuta.Text = "NUEVA RUTA";
            this.rutas_bt_nuevaRuta.UseVisualStyleBackColor = true;
            this.rutas_bt_nuevaRuta.Click += new System.EventHandler(this.rutas_bt_nuevaRuta_Click);
            // 
            // rutas_bt_buscarRuta
            // 
            this.rutas_bt_buscarRuta.Location = new System.Drawing.Point(477, 38);
            this.rutas_bt_buscarRuta.Name = "rutas_bt_buscarRuta";
            this.rutas_bt_buscarRuta.Size = new System.Drawing.Size(161, 32);
            this.rutas_bt_buscarRuta.TabIndex = 3;
            this.rutas_bt_buscarRuta.Text = "BUSCAR RUTA";
            this.rutas_bt_buscarRuta.UseVisualStyleBackColor = true;
            this.rutas_bt_buscarRuta.Click += new System.EventHandler(this.rutas_bt_buscarRuta_Click);
            // 
            // rutas_tb_buscarRuta
            // 
            this.rutas_tb_buscarRuta.Location = new System.Drawing.Point(19, 41);
            this.rutas_tb_buscarRuta.Name = "rutas_tb_buscarRuta";
            this.rutas_tb_buscarRuta.Size = new System.Drawing.Size(438, 26);
            this.rutas_tb_buscarRuta.TabIndex = 4;
            // 
            // rutas_dgv_listarRutas
            // 
            this.rutas_dgv_listarRutas.AllowUserToAddRows = false;
            this.rutas_dgv_listarRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rutas_dgv_listarRutas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.CiudadOrigen,
            this.CiudadDestino});
            this.rutas_dgv_listarRutas.Location = new System.Drawing.Point(19, 37);
            this.rutas_dgv_listarRutas.Name = "rutas_dgv_listarRutas";
            this.rutas_dgv_listarRutas.RowHeadersVisible = false;
            this.rutas_dgv_listarRutas.RowTemplate.Height = 24;
            this.rutas_dgv_listarRutas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rutas_dgv_listarRutas.Size = new System.Drawing.Size(784, 276);
            this.rutas_dgv_listarRutas.TabIndex = 9;
            this.rutas_dgv_listarRutas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rutas_dgv_listarRutas_CellContentClick);
            this.rutas_dgv_listarRutas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rutas_dgv_listarRutas_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 200;
            // 
            // CiudadOrigen
            // 
            this.CiudadOrigen.HeaderText = "CiudadOrigen";
            this.CiudadOrigen.Name = "CiudadOrigen";
            this.CiudadOrigen.Width = 240;
            // 
            // CiudadDestino
            // 
            this.CiudadDestino.HeaderText = "CiudadDestino";
            this.CiudadDestino.Name = "CiudadDestino";
            this.CiudadDestino.Width = 240;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rutas_dgv_listarRutas);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(35, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(823, 330);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LISTA DE RUTAS";
            // 
            // frmRutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 552);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRutas";
            this.Text = "Rutas";
            this.Load += new System.EventHandler(this.frmRutas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rutas_dgv_listarRutas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button rutas_bt_nuevaRuta;
        private System.Windows.Forms.Button rutas_bt_buscarRuta;
        private System.Windows.Forms.TextBox rutas_tb_buscarRuta;
        private System.Windows.Forms.DataGridView rutas_dgv_listarRutas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CiudadOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn CiudadDestino;
    }
}