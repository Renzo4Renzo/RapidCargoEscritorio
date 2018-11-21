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
    public partial class frmEditarPersonal : Form
    {
        List<TipoUsuario> tiposUsuario;
        List<Sucursal> sucursales;
        int idPersonal;
        public frmEditarPersonal(int idPersonal)
        {
            this.idPersonal = idPersonal;
            InitializeComponent();
            mostrarTiposUsuario();
            mostrarSucursales();
            setValues();
        }

        private async void setValues() {
            Personal personal = await ObtenerPersonal(idPersonal);
            personal_tb_DNI.Text = personal.persona.DNI;
            personal_tb_nombres.Text = personal.persona.nombres;
            personal_tb_apellidos.Text = personal.persona.apellidos;
            personal_tb_telefono.Text = personal.persona.telefono;
            personal_tb_direccion.Text = personal.persona.direccion;
            crearPersonal_tb_nombreUsuario.Text = personal.usuario.nombreUsuario;
            crearPersonal_tb_contrasena.Text = personal.usuario.contrasena;
            personal_tb_correoCorporativo.Text = personal.correoCorporativo;

            foreach (TipoUsuario t in tiposUsuario) {
                if (t.descripcion.Equals(personal.usuario.tipoUsuario.descripcion.Trim())) {
                    crearPersonal_cb_tipoUsuario.SelectedValue = t.idTipoUsuario;
                }
            }

            foreach (Sucursal s in sucursales)
            {
                if (s.nombreAgencia.Equals(personal.usuario.sucursal.nombreAgencia.Trim()))
                {
                    crearPersonal_cb_sucursal.SelectedValue = s.idSucursal;
                }
            }

            if (personal.persona.genero.Equals("F"))
            {
                crearPersonal_rb_femenino.Checked = true;
            }
            else {
                crearPersonal_rb_masculino.Checked = true;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void mostrarTiposUsuario()
        {
            tiposUsuario = new List<TipoUsuario>();
            tiposUsuario = await ListarTipoUsuario();
            crearPersonal_cb_tipoUsuario.Items.Clear();
            crearPersonal_cb_tipoUsuario.DataSource = tiposUsuario;
            crearPersonal_cb_tipoUsuario.DisplayMember = "descripcion";
            crearPersonal_cb_tipoUsuario.ValueMember = "idTipoUsuario";
            crearPersonal_cb_tipoUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async void mostrarSucursales()
        {
            sucursales = new List<Sucursal>();
            sucursales = await ListarSucursales();
            crearPersonal_cb_sucursal.Items.Clear();
            crearPersonal_cb_sucursal.DataSource = sucursales;
            crearPersonal_cb_sucursal.DisplayMember = "nombreAgencia";
            crearPersonal_cb_sucursal.ValueMember = "idSucursal";
            crearPersonal_cb_sucursal.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        public static async Task<List<TipoUsuario>> ListarTipoUsuario()
        {
            using (HttpClient rest = new HttpClient())
            {
                using (HttpResponseMessage response = await rest.GetAsync("http://localhost:8080/rest/TipoUsuario/ListarTipoUsuario?"))
                {
                    using (HttpContent content = response.Content)
                    {
                        String res = await content.ReadAsStringAsync();
                        var settings = new JsonSerializerSettings
                        {
                            NullValueHandling = NullValueHandling.Ignore,
                            //MissingMemberHandling = MissingMemberHandling.Ignore
                        };
                        var objeto = JsonConvert.DeserializeObject<List<TipoUsuario>>(res, settings);
                        List<TipoUsuario> lista = objeto.ToList();
                        if (lista != null)
                        {
                            return await Task.Run(() => lista);
                        }
                        else
                            return await Task.FromResult<List<TipoUsuario>>(null);
                    }

                }

            }

        }

        public static async Task<List<Sucursal>> ListarSucursales()
        {
            using (HttpClient rest = new HttpClient())
            {
                using (HttpResponseMessage response = await rest.GetAsync("http://localhost:8080/rest/Sucursal/ListarSucursalGerente?"))
                {
                    using (HttpContent content = response.Content)
                    {
                        String res = await content.ReadAsStringAsync();
                        var settings = new JsonSerializerSettings
                        {
                            NullValueHandling = NullValueHandling.Ignore,
                            //MissingMemberHandling = MissingMemberHandling.Ignore
                        };
                        var objeto = JsonConvert.DeserializeObject<List<Sucursal>>(res, settings);
                        List<Sucursal> lista = objeto.ToList();
                        if (lista != null)
                        {
                            return await Task.Run(() => lista);
                        }
                        else
                            return await Task.FromResult<List<Sucursal>>(null);
                    }

                }

            }

        }

        public static async Task<Personal> ObtenerPersonal(int idPersonal)
        {
            using (HttpClient rest = new HttpClient())
            {
                using (HttpResponseMessage response = await rest.GetAsync("http://localhost:8080/rest/Personal/ObtenerPersonal?idPersonal=" + idPersonal))
                {
                    using (HttpContent content = response.Content)
                    {
                        String res = await content.ReadAsStringAsync();
                        var settings = new JsonSerializerSettings
                        {
                            NullValueHandling = NullValueHandling.Ignore,
                            //MissingMemberHandling = MissingMemberHandling.Ignore
                        };
                        var objeto = JsonConvert.DeserializeObject<Personal>(res, settings);
                        Personal lista = (Personal)objeto;
                        if (lista != null)
                        {
                            return await Task.Run(() => lista);
                        }
                        else
                            return await Task.FromResult<Personal>(null);
                    }

                }

            }

        }

        public static async Task<Boolean> ActualizarPersonal(int idPersonal,String DNI, String nombres, String apellidos, String telefono,
    String direccion, String correoCorporativo, int idTipoUsuario, String nombreUsuario, String contrasena,
    int idSucursal, String genero)
        {
            using (HttpClient rest = new HttpClient())
            {
                using (HttpResponseMessage response = await rest.GetAsync("http://localhost:8080/rest/Personal/ActualizarPersonal?idPersonal="+idPersonal+"&dniPersonal="
                    + DNI + "&nombresPersonal=" + nombres + "&apellidosPersonal=" + apellidos + "&telefono=" + telefono + "&direccionPersonal=" + direccion +
                    "&correoCorporativo=" + correoCorporativo + "&idTipoUsuario=" + idTipoUsuario + "&nombreUsuario=" + nombreUsuario +
                    "&contrasena=" + contrasena + "&idSucursal=" + idSucursal + "&generoPersonal=" + genero))
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

        private async void crearPersonal_bt_crearPersonal_Click(object sender, EventArgs e)
        {
            String value = "";
            bool isChecked = crearPersonal_rb_femenino.Checked;
            value = (isChecked) ? crearPersonal_rb_femenino.Text : crearPersonal_rb_masculino.Text;

            Boolean inserto = await ActualizarPersonal(idPersonal,personal_tb_DNI.Text, personal_tb_nombres.Text, personal_tb_apellidos.Text,
                personal_tb_telefono.Text, personal_tb_direccion.Text, personal_tb_correoCorporativo.Text, (int)crearPersonal_cb_tipoUsuario.SelectedValue,
                crearPersonal_tb_nombreUsuario.Text, crearPersonal_tb_contrasena.Text, (int)crearPersonal_cb_sucursal.SelectedValue, value);
            if (inserto)
            {
                MessageBox.Show("Se actualizó el personal");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al actualizar personal");
            }
        }
    }
}
