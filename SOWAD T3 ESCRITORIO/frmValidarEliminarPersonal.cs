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
    public partial class frmValidarEliminarPersonal : Form
    {
        int idPersonal = 0;
        public frmValidarEliminarPersonal(int idPersonal)
        {
            this.idPersonal = idPersonal;
            InitializeComponent();
        }

        public static async Task<Boolean> eliminarPersonal(int idPersonal)
        {
            using (HttpClient rest = new HttpClient())
            {
                using (HttpResponseMessage response = await rest.GetAsync("http://localhost:8080/rest/Personal/EliminarPersonal?idPersonal=" + idPersonal))
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
        private void frmValidarEliminarPersonal_Load(object sender, EventArgs e)
        {

        }

        private async void validarEliminarPersonal_bt_eliminarPersonal_Click(object sender, EventArgs e)
        {
            if (validarEliminarPersonal_tb_ingresarContrasena.Text == Global.contrasena)
            {
                Boolean elimino = await eliminarPersonal(idPersonal);

                if (elimino)
                {
                    MessageBox.Show("Personal Eliminado");

                }
                else
                    MessageBox.Show("Error al eliminar personal");
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (validarEliminarPersonal_tb_ingresarContrasena.Text == Global.contrasena)
            {
                frmEditarPersonal frmEditar = new frmEditarPersonal(idPersonal);
                frmEditar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }

        }
    }
}
