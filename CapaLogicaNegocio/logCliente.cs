using CapaAccesoDatos;
using CapaEntidad;
using System.Collections.Generic;
namespace CapaLogicaNegocio
{
    public class logCliente
    {
        #region Singleton
        //Variable estática para la instancia
        private static readonly logCliente _instancia = new logCliente(); //Privado para evitar la instanciación directa
        public static logCliente Instancia
        {
            get
            {
                return logCliente._instancia;
            }
        }
        #endregion Singleton

        #region Metodos

        /*Listado de Clientes*/

        public List<entCliente> ListarClientes()
        {
            return datCliente.Instancia.ListarCliente();
        }
        //Inserta
        public bool InsertarCliente(entCliente Cli)
        {
            return datCliente.Instancia.InsertarCliente(Cli);
        }
        //Edita
        public bool EditarCliente(entCliente Cli)
        {
            return datCliente.Instancia.EditarCliente(Cli);
        }
        //Deshabilita
        public void DeshabilitarCliente(entCliente Cli)
        {
            datCliente.Instancia.DeshabilitarCliente(Cli);
        }

        //Obtiene Informacion Cliente por ID
        public entCliente InformacionClienteID(int idCliente)
        {
            return datCliente.Instancia.ObtenerInfoCliente(idCliente);
        }
        //Obtiene Informacion Cliente por RUC 
        public entCliente InformacionClienteRUC(string clienteRUC)
        {
            return datCliente.Instancia.ObtenerInfoCliente(clienteRUC);
        }
        #endregion Metodos
    }
}
