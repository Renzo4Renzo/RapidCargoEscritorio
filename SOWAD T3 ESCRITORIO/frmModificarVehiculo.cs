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
    public partial class frmModificarVehiculo : Form
    {
        string id;

        public frmModificarVehiculo(string id, string nroPlaca, float capacidad, string tipove)
        {
            InitializeComponent();
            this.id = id;
            txtnroplaca.Text = nroPlaca;
            txtcapacidad.Text = capacidad.ToString();
            cbxtipo.Text = tipove;
        }

        private async void vehiculos_bt_crearNuevoVehiculo_Click(object sender, EventArgs e)
        {
            
            Boolean capacidadMinimaBus = int.Parse(txtcapacidad.Text) < 40;
            Boolean capacidadMinimaMinivan = int.Parse(txtcapacidad.Text) < 20;

            if (capacidadMinimaBus)
            {
                MessageBox.Show("La capacidad del bus debe ser mayor o igual a 40");
            }
            else
            {
                if (capacidadMinimaMinivan)
                {
                    MessageBox.Show("La capacidad de la minivan debe ser mayor o igual a 20");
                }
                else
                {
                    int tipo;
                    if (cbxtipo.Text == "Bus") tipo = 1;
                    else tipo = 2;

                    Boolean inserto = await ModificarVehiculo(Convert.ToInt16(id), txtnroplaca.Text, txtcapacidad.Text, tipo);
                    if (inserto)
                    {
                        MessageBox.Show("Se modificó el vehículo");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar vehículo");
                    }
                }

            }
        }

        public static async Task<Boolean> ModificarVehiculo(int id, String numeroPlaca, String capacidadKilos, int idTipoVehiculo)
        {
            using (HttpClient rest = new HttpClient())
            {
                using (HttpResponseMessage response = await rest.GetAsync("http://localhost:8080/rest/Vehiculo/ModificarVehiculo?idVehiculo=" + id + "&numeroPlaca=" + numeroPlaca + "&idTipoVehiculo=" + idTipoVehiculo + "&capacidadKilos=" + capacidadKilos))
                {
                    using (HttpContent content = response.Content)
                    {
                        String res = await content.ReadAsStringAsync();
                        var objeto = JsonConvert.DeserializeObject<Boolean>(res);
                        Boolean bandera = (Boolean)objeto;
                        
                        return await Task.Run(() => bandera);

                    }

                }

            }
        }
    }
}
