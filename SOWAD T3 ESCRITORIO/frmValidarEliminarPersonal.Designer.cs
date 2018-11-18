namespace SOWAD_T3_ESCRITORIO
{
    partial class frmValidarEliminarPersonal
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
            this.validarEliminarPersonal_bt_eliminarPersonal = new System.Windows.Forms.Button();
            this.validarEliminarPersonal_tb_ingresarContrasena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // validarEliminarPersonal_bt_eliminarPersonal
            // 
            this.validarEliminarPersonal_bt_eliminarPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validarEliminarPersonal_bt_eliminarPersonal.Location = new System.Drawing.Point(68, 132);
            this.validarEliminarPersonal_bt_eliminarPersonal.Margin = new System.Windows.Forms.Padding(2);
            this.validarEliminarPersonal_bt_eliminarPersonal.Name = "validarEliminarPersonal_bt_eliminarPersonal";
            this.validarEliminarPersonal_bt_eliminarPersonal.Size = new System.Drawing.Size(94, 37);
            this.validarEliminarPersonal_bt_eliminarPersonal.TabIndex = 5;
            this.validarEliminarPersonal_bt_eliminarPersonal.Text = "ELIMINAR";
            this.validarEliminarPersonal_bt_eliminarPersonal.UseVisualStyleBackColor = true;
            this.validarEliminarPersonal_bt_eliminarPersonal.Click += new System.EventHandler(this.validarEliminarPersonal_bt_eliminarPersonal_Click);
            this.validarEliminarPersonal_bt_eliminarPersonal.Enter += new System.EventHandler(this.frmValidarEliminarPersonal_Load);
            // 
            // validarEliminarPersonal_tb_ingresarContrasena
            // 
            this.validarEliminarPersonal_tb_ingresarContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validarEliminarPersonal_tb_ingresarContrasena.Location = new System.Drawing.Point(68, 76);
            this.validarEliminarPersonal_tb_ingresarContrasena.Margin = new System.Windows.Forms.Padding(2);
            this.validarEliminarPersonal_tb_ingresarContrasena.Name = "validarEliminarPersonal_tb_ingresarContrasena";
            this.validarEliminarPersonal_tb_ingresarContrasena.PasswordChar = '•';
            this.validarEliminarPersonal_tb_ingresarContrasena.Size = new System.Drawing.Size(252, 23);
            this.validarEliminarPersonal_tb_ingresarContrasena.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese su Contraseña";
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(219, 132);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(94, 37);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // frmValidarEliminarPersonal
            // 
            this.AcceptButton = this.validarEliminarPersonal_bt_eliminarPersonal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 206);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.validarEliminarPersonal_bt_eliminarPersonal);
            this.Controls.Add(this.validarEliminarPersonal_tb_ingresarContrasena);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmValidarEliminarPersonal";
            this.Text = "Validacion";
            this.Load += new System.EventHandler(this.frmValidarEliminarPersonal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button validarEliminarPersonal_bt_eliminarPersonal;
        private System.Windows.Forms.TextBox validarEliminarPersonal_tb_ingresarContrasena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditar;
    }
}