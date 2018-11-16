using Newtonsoft.Json;
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
using SOWAD_T3_ESCRITORIO.Clases;

namespace SOWAD_T3_ESCRITORIO
{
    public partial class frmValidarEliminarRuta : Form
    {
        int idRuta=0;
        public frmValidarEliminarRuta(int idRuta)
        {
            this.idRuta = idRuta;
            InitializeComponent();
        }

        public static async Task<Boolean> eliminarRuta(int idRuta)
        {
            using (HttpClient rest = new HttpClient())
            {
                using (HttpResponseMessage response = await rest.GetAsync("http://localhost:8080/rest/Ruta/EliminarRuta?idRuta=" + idRuta))
                {
                    using (HttpContent content = response.Content)
                    {
                        String res = await content.ReadAsStringAsync();
                        Boolean elimino = JsonConvert.DeserializeObject<Boolean>(res);

                        return await Task.Run(() => elimino);

                    }

                }

            }

        }
        private void frmValidarEliminarRuta_Load(object sender, EventArgs e)
        {

        }

        private async void validarEliminarRuta_bt_eliminarRuta_Click(object sender, EventArgs e)
        {
            if(validarEliminarRuta_tb_ingresarContrasena.Text == Global.contrasena)
            {
                Boolean elimino = await eliminarRuta(idRuta);

                if (elimino)
                {
                    MessageBox.Show("Ruta Eliminada");

                }
                else
                    MessageBox.Show("Error al eliminar ruta");
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }
            Close();
        }
    }
}
