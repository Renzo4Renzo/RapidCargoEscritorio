namespace SOWAD_T3_ESCRITORIO
{
    partial class frmValidarEliminarRuta
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
            this.label1 = new System.Windows.Forms.Label();
            this.validarEliminarRuta_tb_ingresarContrasena = new System.Windows.Forms.TextBox();
            this.validarEliminarRuta_bt_eliminarRuta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese su Contraseña";
            // 
            // validarEliminarRuta_tb_ingresarContrasena
            // 
            this.validarEliminarRuta_tb_ingresarContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validarEliminarRuta_tb_ingresarContrasena.Location = new System.Drawing.Point(57, 94);
            this.validarEliminarRuta_tb_ingresarContrasena.Name = "validarEliminarRuta_tb_ingresarContrasena";
            this.validarEliminarRuta_tb_ingresarContrasena.PasswordChar = '•';
            this.validarEliminarRuta_tb_ingresarContrasena.Size = new System.Drawing.Size(153, 27);
            this.validarEliminarRuta_tb_ingresarContrasena.TabIndex = 1;
            // 
            // validarEliminarRuta_bt_eliminarRuta
            // 
            this.validarEliminarRuta_bt_eliminarRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validarEliminarRuta_bt_eliminarRuta.Location = new System.Drawing.Point(69, 155);
            this.validarEliminarRuta_bt_eliminarRuta.Name = "validarEliminarRuta_bt_eliminarRuta";
            this.validarEliminarRuta_bt_eliminarRuta.Size = new System.Drawing.Size(125, 45);
            this.validarEliminarRuta_bt_eliminarRuta.TabIndex = 2;
            this.validarEliminarRuta_bt_eliminarRuta.Text = "ELIMINAR";
            this.validarEliminarRuta_bt_eliminarRuta.UseVisualStyleBackColor = true;
            this.validarEliminarRuta_bt_eliminarRuta.Click += new System.EventHandler(this.validarEliminarRuta_bt_eliminarRuta_Click);
            // 
            // frmValidarEliminarRuta
            // 
            this.AcceptButton = this.validarEliminarRuta_bt_eliminarRuta;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 244);
            this.Controls.Add(this.validarEliminarRuta_bt_eliminarRuta);
            this.Controls.Add(this.validarEliminarRuta_tb_ingresarContrasena);
            this.Controls.Add(this.label1);
            this.Name = "frmValidarEliminarRuta";
            this.Text = "Validacion";
            this.Load += new System.EventHandler(this.frmValidarEliminarRuta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox validarEliminarRuta_tb_ingresarContrasena;
        private System.Windows.Forms.Button validarEliminarRuta_bt_eliminarRuta;
    }
}