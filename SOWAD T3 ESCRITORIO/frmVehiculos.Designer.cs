namespace SOWAD_T3_ESCRITORIO
{
    partial class frmVehiculos
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.vehiculos_dgv_listarVehiculos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vehiculos_cb_listarTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.vehiculos_bt_nuevaVehiculo = new System.Windows.Forms.Button();
            this.vehiculos_bt_buscarVehiculo = new System.Windows.Forms.Button();
            this.vehiculos_tb_buscarVehiculo = new System.Windows.Forms.TextBox();
            this.btnModificarVehiculo = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculos_dgv_listarVehiculos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.vehiculos_dgv_listarVehiculos);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(26, 164);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(757, 268);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LISTA DE VEHICULOS";
            // 
            // vehiculos_dgv_listarVehiculos
            // 
            this.vehiculos_dgv_listarVehiculos.AllowUserToAddRows = false;
            this.vehiculos_dgv_listarVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehiculos_dgv_listarVehiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Placa,
            this.Capacidad,
            this.TipoVehiculo});
            this.vehiculos_dgv_listarVehiculos.Location = new System.Drawing.Point(14, 30);
            this.vehiculos_dgv_listarVehiculos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vehiculos_dgv_listarVehiculos.Name = "vehiculos_dgv_listarVehiculos";
            this.vehiculos_dgv_listarVehiculos.RowHeadersVisible = false;
            this.vehiculos_dgv_listarVehiculos.RowTemplate.Height = 24;
            this.vehiculos_dgv_listarVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vehiculos_dgv_listarVehiculos.Size = new System.Drawing.Size(728, 224);
            this.vehiculos_dgv_listarVehiculos.TabIndex = 9;
            this.vehiculos_dgv_listarVehiculos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vehiculos_dgv_listarVehiculos_CellContentClick);
            this.vehiculos_dgv_listarVehiculos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vehiculos_dgv_listarVehiculos_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Placa
            // 
            this.Placa.HeaderText = "Placa";
            this.Placa.Name = "Placa";
            this.Placa.Width = 200;
            // 
            // Capacidad
            // 
            this.Capacidad.HeaderText = "Capacidad";
            this.Capacidad.Name = "Capacidad";
            this.Capacidad.Width = 240;
            // 
            // TipoVehiculo
            // 
            this.TipoVehiculo.HeaderText = "TipoVehiculo";
            this.TipoVehiculo.Name = "TipoVehiculo";
            this.TipoVehiculo.Width = 240;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(278, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "VEHICULOS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnModificarVehiculo);
            this.groupBox1.Controls.Add(this.vehiculos_cb_listarTipoVehiculo);
            this.groupBox1.Controls.Add(this.vehiculos_bt_nuevaVehiculo);
            this.groupBox1.Controls.Add(this.vehiculos_bt_buscarVehiculo);
            this.groupBox1.Controls.Add(this.vehiculos_tb_buscarVehiculo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 63);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(757, 84);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GESTIONAR VEHICULOS";
            // 
            // vehiculos_cb_listarTipoVehiculo
            // 
            this.vehiculos_cb_listarTipoVehiculo.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.vehiculos_cb_listarTipoVehiculo.FormattingEnabled = true;
            this.vehiculos_cb_listarTipoVehiculo.Location = new System.Drawing.Point(26, 33);
            this.vehiculos_cb_listarTipoVehiculo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vehiculos_cb_listarTipoVehiculo.Name = "vehiculos_cb_listarTipoVehiculo";
            this.vehiculos_cb_listarTipoVehiculo.Size = new System.Drawing.Size(142, 24);
            this.vehiculos_cb_listarTipoVehiculo.TabIndex = 5;
            this.vehiculos_cb_listarTipoVehiculo.Text = "Tipo de vehiculo";
            this.vehiculos_cb_listarTipoVehiculo.SelectedIndexChanged += new System.EventHandler(this.vehiculos_cb_listarTipoVehiculo_SelectedIndexChanged);
            // 
            // vehiculos_bt_nuevaVehiculo
            // 
            this.vehiculos_bt_nuevaVehiculo.Location = new System.Drawing.Point(485, 21);
            this.vehiculos_bt_nuevaVehiculo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vehiculos_bt_nuevaVehiculo.Name = "vehiculos_bt_nuevaVehiculo";
            this.vehiculos_bt_nuevaVehiculo.Size = new System.Drawing.Size(121, 46);
            this.vehiculos_bt_nuevaVehiculo.TabIndex = 2;
            this.vehiculos_bt_nuevaVehiculo.Text = "NUEVO VEHICULO";
            this.vehiculos_bt_nuevaVehiculo.UseVisualStyleBackColor = true;
            this.vehiculos_bt_nuevaVehiculo.Click += new System.EventHandler(this.vehiculos_bt_nuevaVehiculo_Click);
            // 
            // vehiculos_bt_buscarVehiculo
            // 
            this.vehiculos_bt_buscarVehiculo.Location = new System.Drawing.Point(356, 21);
            this.vehiculos_bt_buscarVehiculo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vehiculos_bt_buscarVehiculo.Name = "vehiculos_bt_buscarVehiculo";
            this.vehiculos_bt_buscarVehiculo.Size = new System.Drawing.Size(121, 46);
            this.vehiculos_bt_buscarVehiculo.TabIndex = 3;
            this.vehiculos_bt_buscarVehiculo.Text = "BUSCAR VEHICULO";
            this.vehiculos_bt_buscarVehiculo.UseVisualStyleBackColor = true;
            this.vehiculos_bt_buscarVehiculo.Click += new System.EventHandler(this.vehiculos_bt_buscarVehiculo_Click);
            // 
            // vehiculos_tb_buscarVehiculo
            // 
            this.vehiculos_tb_buscarVehiculo.AccessibleDescription = "Placa";
            this.vehiculos_tb_buscarVehiculo.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.vehiculos_tb_buscarVehiculo.Location = new System.Drawing.Point(187, 35);
            this.vehiculos_tb_buscarVehiculo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vehiculos_tb_buscarVehiculo.Name = "vehiculos_tb_buscarVehiculo";
            this.vehiculos_tb_buscarVehiculo.Size = new System.Drawing.Size(137, 23);
            this.vehiculos_tb_buscarVehiculo.TabIndex = 4;
            this.vehiculos_tb_buscarVehiculo.Text = "Placa";
            this.vehiculos_tb_buscarVehiculo.TextChanged += new System.EventHandler(this.vehiculos_tb_buscarVehiculo_TextChanged);
            this.vehiculos_tb_buscarVehiculo.Enter += new System.EventHandler(this.vehiculos_tb_buscarVehiculo_Enter);
            // 
            // btnModificarVehiculo
            // 
            this.btnModificarVehiculo.Location = new System.Drawing.Point(621, 21);
            this.btnModificarVehiculo.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarVehiculo.Name = "btnModificarVehiculo";
            this.btnModificarVehiculo.Size = new System.Drawing.Size(121, 46);
            this.btnModificarVehiculo.TabIndex = 6;
            this.btnModificarVehiculo.Text = "MODIFICAR VEHICULO";
            this.btnModificarVehiculo.UseVisualStyleBackColor = true;
            this.btnModificarVehiculo.Click += new System.EventHandler(this.btnModificarVehiculo_Click);
            // 
            // frmVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmVehiculos";
            this.Text = "Vehiculos";
            this.Load += new System.EventHandler(this.frmVehiculos_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vehiculos_dgv_listarVehiculos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView vehiculos_dgv_listarVehiculos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button vehiculos_bt_nuevaVehiculo;
        private System.Windows.Forms.Button vehiculos_bt_buscarVehiculo;
        private System.Windows.Forms.TextBox vehiculos_tb_buscarVehiculo;
        private System.Windows.Forms.ComboBox vehiculos_cb_listarTipoVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoVehiculo;
        private System.Windows.Forms.Button btnModificarVehiculo;
    }
}
