using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entCliente
    {
        public int Id { get; set; }
        public string RazonSocial { get; set; }
        public string RUC { get; set; }
        public int IdTipoPersona { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public string Ubigeo { get; set; }
        public Boolean Estado { get; set; }
    }
}
