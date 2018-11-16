using Newtonsoft.Json;
using SOWAD_T3_ESCRITORIO.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Reflection;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using System.Globalization;

namespace SOWAD_T3_ESCRITORIO
{
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
           
            InitializeComponent();
        }

        

        public static async Task<List<Encomienda>> ListarEncomiendasGerente(String fechaInicio, String fechaFin)
        {
            using (HttpClient rest = new HttpClient())
            {
                using (HttpResponseMessage response = await rest.GetAsync("http://localhost:8080/rest/Encomienda/ListarEncomiendaGerente?fechaInicio=" + 
                    fechaInicio + "&fechaFin="+fechaFin))
                {
                    using (HttpContent content = response.Content)
                    {
                        String res = await content.ReadAsStringAsync();
                        var settings = new JsonSerializerSettings
                        {
                            NullValueHandling = NullValueHandling.Ignore
                            //MissingMemberHandling = MissingMemberHandling.Ignore
                        };
                        var objeto = JsonConvert.DeserializeObject<List<Encomienda>>(res, settings);
                        List<Encomienda> lista = objeto.ToList();
                        if (lista != null)
                        {
                            return await Task.Run(() => lista);
                        }
                        else
                            return await Task.FromResult<List<Encomienda>>(null);
                    }

                }

            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rutas_dgv_listarRutas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void reportes_bt_generarReporte_Click(object sender, EventArgs e)
        {
            List<Encomienda> encomiendas = new List<Encomienda>();
            String inicio = reportes_dtp_fechaInicio.Value.ToString("MM/dd/yyyy");
            String fin = reportes_dtp_fechaFin.Value.ToString("MM/dd/yyyy");

            encomiendas = await ListarEncomiendasGerente(inicio, fin);
            reportes_dgv_listarReportes.Rows.Clear();
            foreach (Encomienda encomienda in encomiendas)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(reportes_dgv_listarReportes);
                row.Cells[0].Value = encomienda.codigoEncomienda;
                row.Cells[1].Value = encomienda.cliente.persona.nombres;
                row.Cells[2].Value = encomienda.ruta.nombreRuta;
                row.Cells[3].Value = encomienda.nombreDestinatario;
                row.Cells[4].Value = encomienda.fechaRegistro; 
                row.Cells[5].Value = encomienda.entregaUnica.fechaEntrega;
                row.Cells[6].Value = encomienda.montoPago;
                row.Cells[7].Value = encomienda.estadoEncomienda.descripcionEstadoEncomienda;
                reportes_dgv_listarReportes.Rows.Add(row);
            }
        }

        /*INICIO REFACTORIZACIÓN 3: Reemplazar Números Mágicos con Constantes Simbólicas*/
        const int DEFAULT_CELL_PADDING = 3;
        const int CELL_WIDH_PERCENTAGE = 90;
        const int CELL_BORDER_WIDTH = 3;
        const int CELL_PADDING = 6;

        const int PADDING_TOP = 20;
        const int ALIGNMENT = 1;

        private void reportes_bt_guardarPDF_Click(object sender, EventArgs e)
        {
            DateTime thisDay = DateTime.Now;
            //Creating iTextSharp Table from the DataTable data

            PdfPTable pdfTable = new PdfPTable(reportes_dgv_listarReportes.ColumnCount);
            pdfTable.DefaultCell.Padding = DEFAULT_CELL_PADDING;
            pdfTable.WidthPercentage = CELL_WIDH_PERCENTAGE;
            pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTable.DefaultCell.BorderWidth = CELL_BORDER_WIDTH;

            //Adding Header row
            for (int j = 0; j < reportes_dgv_listarReportes.Columns.Count; j++)
            {

                PdfPCell cell = new PdfPCell(new Phrase(reportes_dgv_listarReportes.Columns[j].HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(255, 140, 0);
                cell.BorderWidth = CELL_BORDER_WIDTH;

                cell.Padding = CELL_PADDING;
                cell.VerticalAlignment = Element.ALIGN_CENTER;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfTable.AddCell(cell);
            }

            for (int i = 0; i < reportes_dgv_listarReportes.Rows.Count; i++)
            {
                for (int k = 0; k < reportes_dgv_listarReportes.Columns.Count; k++)
                {
                    if (reportes_dgv_listarReportes[k, i].Value != null){
                        pdfTable.AddCell(new Phrase(reportes_dgv_listarReportes[k, i].Value.ToString()));
                    }
                    else{
                        pdfTable.AddCell(new Phrase(" "));
                    }
                }

            }

            //Exporting to PDF

            //string folderPath = "C:\\ReportesEncomienda\\";
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+ "\\ReportesEncomienda\\";

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "Reporte" + thisDay.ToString().Replace("/","-").Replace(":","-") + ".pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A4.Rotate(), 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();

                iTextSharp.text.Font contentFont = FontFactory.GetFont("Segoe UI", 30.0f, BaseColor.BLACK);

                Paragraph p = new Paragraph("REPORTE DE ENCOMIENDAS", contentFont);
                p.PaddingTop = PADDING_TOP;
                p.Alignment = ALIGNMENT;

                Chunk linebreak = new Chunk(new LineSeparator(4f, 100f, BaseColor.ORANGE, Element.ALIGN_CENTER, 0));

                iTextSharp.text.Font contentFont2 = FontFactory.GetFont("Segoe UI", 14.0f, BaseColor.BLACK);

                Paragraph fecha = new Paragraph("FECHA DEL REPORTE: " + thisDay, contentFont2);
                fecha.PaddingTop = PADDING_TOP;
                fecha.Alignment = ALIGNMENT;

                pdfDoc.Add(p);
                pdfDoc.Add(fecha);
                pdfDoc.Add(linebreak);
                pdfDoc.Add(pdfTable);

                   
            pdfDoc.Close();
                stream.Close();
                System.Diagnostics.Process.Start(folderPath + "Reporte" + thisDay.ToString().Replace("/", "-").Replace(":", "-") + ".pdf");

            }
            MessageBox.Show("El PDF se exportó correctamente. Está disponible en la Carpeta " +
                            "'Reportes Encomienda' creada en su escritorio."); 
        }
        /*FIN REFACTORIZACIÓN 3: Reemplazar Números Mágicos con Constantes Simbólicas*/


        private void reportes_btn_verChart_Click(object sender, EventArgs e)
        {
            frmChart crearChart = new frmChart();
            crearChart.Tag = this;
            crearChart.ShowDialog(this);
        }
    }
}

