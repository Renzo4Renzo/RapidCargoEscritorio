namespace SOWAD_T3_ESCRITORIO
{
    partial class frmValidarEliminarVehiculo
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
            this.validarEliminarVehiculo_bt_eliminarVehiculo = new System.Windows.Forms.Button();
            this.validarEliminarVehiculo_tb_ingresarContrasena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // validarEliminarVehiculo_bt_eliminarVehiculo
            // 
            this.validarEliminarVehiculo_bt_eliminarVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validarEliminarVehiculo_bt_eliminarVehiculo.Location = new System.Drawing.Point(74, 162);
            this.validarEliminarVehiculo_bt_eliminarVehiculo.Name = "validarEliminarVehiculo_bt_eliminarVehiculo";
            this.validarEliminarVehiculo_bt_eliminarVehiculo.Size = new System.Drawing.Size(125, 45);
            this.validarEliminarVehiculo_bt_eliminarVehiculo.TabIndex = 5;
            this.validarEliminarVehiculo_bt_eliminarVehiculo.Text = "ELIMINAR";
            this.validarEliminarVehiculo_bt_eliminarVehiculo.UseVisualStyleBackColor = true;
            this.validarEliminarVehiculo_bt_eliminarVehiculo.Click += new System.EventHandler(this.validarEliminarVehiculo_bt_eliminarVehiculo_Click);
            // 
            // validarEliminarVehiculo_tb_ingresarContrasena
            // 
            this.validarEliminarVehiculo_tb_ingresarContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validarEliminarVehiculo_tb_ingresarContrasena.Location = new System.Drawing.Point(62, 101);
            this.validarEliminarVehiculo_tb_ingresarContrasena.Name = "validarEliminarVehiculo_tb_ingresarContrasena";
            this.validarEliminarVehiculo_tb_ingresarContrasena.PasswordChar = '•';
            this.validarEliminarVehiculo_tb_ingresarContrasena.Size = new System.Drawing.Size(153, 27);
            this.validarEliminarVehiculo_tb_ingresarContrasena.TabIndex = 4;
            this.validarEliminarVehiculo_tb_ingresarContrasena.TextChanged += new System.EventHandler(this.validarEliminarVehiculo_tb_ingresarContrasena_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese su Contraseña";
            // 
            // frmValidarEliminarVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.validarEliminarVehiculo_bt_eliminarVehiculo);
            this.Controls.Add(this.validarEliminarVehiculo_tb_ingresarContrasena);
            this.Controls.Add(this.label1);
            this.Name = "frmValidarEliminarVehiculo";
            this.Text = "Validacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button validarEliminarVehiculo_bt_eliminarVehiculo;
        private System.Windows.Forms.TextBox validarEliminarVehiculo_tb_ingresarContrasena;
        private System.Windows.Forms.Label label1;
    }
}