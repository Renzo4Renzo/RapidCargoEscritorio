namespace SOWAD_T3_ESCRITORIO
{
    partial class frmChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.frmVerChart_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.frmVerChart_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // frmVerChart_chart
            // 
            chartArea1.Name = "ChartArea1";
            this.frmVerChart_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.frmVerChart_chart.Legends.Add(legend1);
            this.frmVerChart_chart.Location = new System.Drawing.Point(25, 88);
            this.frmVerChart_chart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.frmVerChart_chart.Name = "frmVerChart_chart";
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            series1.IsValueShownAsLabel = true;
            series1.LabelForeColor = System.Drawing.Color.DodgerBlue;
            series1.Legend = "Legend1";
            series1.Name = "Rutas";
            this.frmVerChart_chart.Series.Add(series1);
            this.frmVerChart_chart.Size = new System.Drawing.Size(591, 318);
            this.frmVerChart_chart.TabIndex = 0;
            this.frmVerChart_chart.Text = "chart1";
            this.frmVerChart_chart.Click += new System.EventHandler(this.frmVerChart_chart__Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(576, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "CANTIDAD DE ENCOMIENDAS ENVIADAS POR CADA RUTA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 416);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.frmVerChart_chart);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmChart";
            this.Text = "frmChart";
            this.Load += new System.EventHandler(this.frmChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.frmVerChart_chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart frmVerChart_chart;
        private System.Windows.Forms.Label label1;
    }
}