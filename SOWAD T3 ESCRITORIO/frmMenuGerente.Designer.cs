namespace SOWAD_T3_ESCRITORIO
{
    partial class frmMenuGerente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuGerente));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rutasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rutasToolStripMenuItem,
            this.vehiculosToolStripMenuItem,
            this.personalToolStripMenuItem,
            this.reporteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(89, 502);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rutasToolStripMenuItem
            // 
            this.rutasToolStripMenuItem.Name = "rutasToolStripMenuItem";
            this.rutasToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.rutasToolStripMenuItem.Text = "Rutas";
            this.rutasToolStripMenuItem.Click += new System.EventHandler(this.rutasToolStripMenuItem_Click);
            // 
            // vehiculosToolStripMenuItem
            // 
            this.vehiculosToolStripMenuItem.Name = "vehiculosToolStripMenuItem";
            this.vehiculosToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.vehiculosToolStripMenuItem.Text = "Vehiculos";
            this.vehiculosToolStripMenuItem.Click += new System.EventHandler(this.vehiculosToolStripMenuItem_Click);
            // 
            // personalToolStripMenuItem
            // 
            this.personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            this.personalToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.personalToolStripMenuItem.Text = "Personal";
            this.personalToolStripMenuItem.Click += new System.EventHandler(this.personalToolStripMenuItem_Click);
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.reporteToolStripMenuItem.Text = "Reporte";
            this.reporteToolStripMenuItem.Click += new System.EventHandler(this.reporteToolStripMenuItem_Click);
            // 
            // frmMenuGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(785, 502);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMenuGerente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Gerente";
            this.Load += new System.EventHandler(this.MenuGerente_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rutasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
    }
}