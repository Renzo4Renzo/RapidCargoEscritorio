namespace SOWAD_T3_ESCRITORIO
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginBox = new System.Windows.Forms.GroupBox();
            this.login_tb_password = new System.Windows.Forms.TextBox();
            this.login_tb_username = new System.Windows.Forms.TextBox();
            this.contrasena = new System.Windows.Forms.Label();
            this.nombreUsuario = new System.Windows.Forms.Label();
            this.login_bt_ingresar = new System.Windows.Forms.Button();
            this.login_bt_limpiar = new System.Windows.Forms.Button();
            this.loginBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginBox
            // 
            this.loginBox.Controls.Add(this.login_tb_password);
            this.loginBox.Controls.Add(this.login_tb_username);
            this.loginBox.Controls.Add(this.contrasena);
            this.loginBox.Controls.Add(this.nombreUsuario);
            this.loginBox.Location = new System.Drawing.Point(38, 40);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(292, 146);
            this.loginBox.TabIndex = 0;
            this.loginBox.TabStop = false;
            this.loginBox.Text = "Login";
            this.loginBox.Enter += new System.EventHandler(this.loginBox_Enter);
            // 
            // login_tb_password
            // 
            this.login_tb_password.Location = new System.Drawing.Point(114, 89);
            this.login_tb_password.Name = "login_tb_password";
            this.login_tb_password.PasswordChar = '•';
            this.login_tb_password.Size = new System.Drawing.Size(158, 22);
            this.login_tb_password.TabIndex = 3;
            this.login_tb_password.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // login_tb_username
            // 
            this.login_tb_username.Location = new System.Drawing.Point(114, 38);
            this.login_tb_username.Name = "login_tb_username";
            this.login_tb_username.Size = new System.Drawing.Size(158, 22);
            this.login_tb_username.TabIndex = 2;
            // 
            // contrasena
            // 
            this.contrasena.AutoSize = true;
            this.contrasena.Location = new System.Drawing.Point(35, 94);
            this.contrasena.Name = "contrasena";
            this.contrasena.Size = new System.Drawing.Size(73, 17);
            this.contrasena.TabIndex = 1;
            this.contrasena.Text = "Password:";
            // 
            // nombreUsuario
            // 
            this.nombreUsuario.AutoSize = true;
            this.nombreUsuario.Location = new System.Drawing.Point(31, 41);
            this.nombreUsuario.Name = "nombreUsuario";
            this.nombreUsuario.Size = new System.Drawing.Size(77, 17);
            this.nombreUsuario.TabIndex = 0;
            this.nombreUsuario.Text = "Username:";
            this.nombreUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // login_bt_ingresar
            // 
            this.login_bt_ingresar.Location = new System.Drawing.Point(101, 207);
            this.login_bt_ingresar.Name = "login_bt_ingresar";
            this.login_bt_ingresar.Size = new System.Drawing.Size(75, 36);
            this.login_bt_ingresar.TabIndex = 1;
            this.login_bt_ingresar.Text = "Ingresar";
            this.login_bt_ingresar.UseVisualStyleBackColor = true;
            this.login_bt_ingresar.Click += new System.EventHandler(this.login_bt_ingresar_Click);
            // 
            // login_bt_limpiar
            // 
            this.login_bt_limpiar.Location = new System.Drawing.Point(197, 207);
            this.login_bt_limpiar.Name = "login_bt_limpiar";
            this.login_bt_limpiar.Size = new System.Drawing.Size(75, 36);
            this.login_bt_limpiar.TabIndex = 2;
            this.login_bt_limpiar.Text = "Limpiar";
            this.login_bt_limpiar.UseVisualStyleBackColor = true;
            this.login_bt_limpiar.Click += new System.EventHandler(this.login_bt_limpiar_Click);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.login_bt_ingresar;
            this.AccessibleDescription = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(378, 286);
            this.Controls.Add(this.login_bt_limpiar);
            this.Controls.Add(this.login_bt_ingresar);
            this.Controls.Add(this.loginBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RapidCargo";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.loginBox.ResumeLayout(false);
            this.loginBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox loginBox;
        private System.Windows.Forms.Label nombreUsuario;
        private System.Windows.Forms.Label contrasena;
        private System.Windows.Forms.TextBox login_tb_password;
        private System.Windows.Forms.TextBox login_tb_username;
        private System.Windows.Forms.Button login_bt_ingresar;
        private System.Windows.Forms.Button login_bt_limpiar;
    }
}

