using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOWAD_T3_ESCRITORIO.Clases
{
    public class EntregaUnica
    {
        public int idEntregaUnica { get; set; }
        public Encomienda encomienda { get; set; }
        public Usuario nombreUsuario { get; set; }
        public String fechaEntrega { get; set; }
    }
}
