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
    public partial class frmCrearVehiculo : Form
    {
        public frmCrearVehiculo()
        {
            InitializeComponent();
        }

        public static async Task<Boolean> CrearVehiculo(String numeroPlaca, String capacidadKilos, int idTipoVehiculo)
        {
            using (HttpClient rest = new HttpClient())
            {
                using (HttpResponseMessage response = await rest.GetAsync("http://localhost:8080/rest/Vehiculo/CrearVehiculo?numeroPlaca=" + numeroPlaca + "&capacidadKilos=" + capacidadKilos + "&idTipoVehiculo=" + idTipoVehiculo))
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

        public static async Task<List<TipoVehiculo>> ListarTipoVehiculo()
        {
            using (HttpClient rest = new HttpClient())
            {
                using (HttpResponseMessage response = await rest.GetAsync("http://localhost:8080/rest/TipoVehiculo/ListarTipoVehiculo?"))
                {
                    using (HttpContent content = response.Content)
                    {
                        String res = await content.ReadAsStringAsync();
                        var settings = new JsonSerializerSettings
                        {
                            NullValueHandling = NullValueHandling.Ignore,
                            //MissingMemberHandling = MissingMemberHandling.Ignore
                        };
                        var objeto = JsonConvert.DeserializeObject<List<TipoVehiculo>>(res, settings);
                        List<TipoVehiculo> lista = objeto.ToList();
                        if (lista != null)
                        {
                            return await Task.Run(() => lista);
                        }
                        else
                            return await Task.FromResult<List<TipoVehiculo>>(null);
                    }

                }

            }

        }
        

        private async void frmCrearVehiculo_Load(object sender, EventArgs e)
        {
            List<TipoVehiculo> tiposVehiculo = new List<TipoVehiculo>();

            tiposVehiculo = await ListarTipoVehiculo();
            vehiculos_cb_tipoVehiculo.Items.Clear();
            vehiculos_cb_tipoVehiculo.DataSource = tiposVehiculo;
            vehiculos_cb_tipoVehiculo.DisplayMember = "descripcion";
            vehiculos_cb_tipoVehiculo.ValueMember = "idTipoVehiculo";
            vehiculos_cb_tipoVehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        /*INICIO REFACTORIZACIÓN 5: Extraer Variable*/
        private async void vehiculos_bt_crearNuevoVehiculo_Click(object sender, EventArgs e)
        {

            Boolean tipoBus = (int) vehiculos_cb_tipoVehiculo.SelectedValue == 1;
            Boolean tipoMinivan = (int)vehiculos_cb_tipoVehiculo.SelectedValue == 2;
            Boolean capacidadMinimaBus = int.Parse(vehiculos_tb_capacidad.Text) < 40;
            Boolean capacidadMinimaMinivan = int.Parse(vehiculos_tb_capacidad.Text) < 20;

            if (tipoBus && capacidadMinimaBus)
            {
                MessageBox.Show("La capacidad del bus debe ser mayor o igual a 40");
            }
            else
            {
                if(tipoMinivan && capacidadMinimaMinivan)
                {
                    MessageBox.Show("La capacidad de la minivan debe ser mayor o igual a 20");
                }
                else
                {
                    Boolean inserto = await CrearVehiculo(vehiculos_tb_numeroPlaca.Text, vehiculos_tb_capacidad.Text, (int)vehiculos_cb_tipoVehiculo.SelectedValue);
                    if (inserto)
                    {
                        MessageBox.Show("Se agregó el vehículo");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al insertar vehículo");
                    }
                }
                
            }
            
        }

        private void vehiculos_tb_capacidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Boolean antesQueCero = e.KeyChar < 48;
            Boolean despuesdeNueve = e.KeyChar > 57;
            Boolean noBackSpace = e.KeyChar != 8;

            // allows 0-9, backspace, and decimal
            if (((antesQueCero || despuesdeNueve) && noBackSpace))
            {
                e.Handled = true;
                return;
            }
        }
        /*FIN REFACTORIZACIÓN 5: Extraer Variable*/

        private void vehiculos_cb_tipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
