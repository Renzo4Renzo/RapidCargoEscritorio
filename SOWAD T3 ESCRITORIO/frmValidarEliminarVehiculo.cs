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

namespace SOWAD_T3_ESCRITORIO
{
    public partial class frmValidarEliminarVehiculo : Form
    {
        int idVehiculo = 0;
        public frmValidarEliminarVehiculo(int idVehiculo)
        {
            this.idVehiculo = idVehiculo;
            InitializeComponent();
        }

        public static async Task<Boolean> eliminarVehiculo(int idVehiculo)
        {
            using (HttpClient rest = new HttpClient())
            {
                using (HttpResponseMessage response = await rest.GetAsync("http://localhost:8080/rest/Vehiculo/EliminarVehiculo?idVehiculo=" + idVehiculo))
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

        private void validarEliminarVehiculo_tb_ingresarContrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private async void validarEliminarVehiculo_bt_eliminarVehiculo_Click(object sender, EventArgs e)
        {
            if (validarEliminarVehiculo_tb_ingresarContrasena.Text == Global.contrasena)
            {
                Boolean elimino = await eliminarVehiculo(idVehiculo);

                if (elimino)
                {
                    MessageBox.Show("Vehiculo Eliminado");

                }
                else
                    MessageBox.Show("Error al eliminar vehiculo");
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }

            Close();
            
        }
    }
}
