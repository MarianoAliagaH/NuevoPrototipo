using CapaAccesoDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaLogicaNegocio
{
    public class logRuta
    {
        #region Singleton
        //Variable estática para la instancia
        private static readonly logRuta _instancia = new logRuta(); //Privado para evitar la instanciación directa
        public static logRuta Instancia
        {
            get
            {
                return logRuta._instancia;
            }
        }
        #endregion Singleton

        #region Metodos
        //Listado de Rutas Asignadas al Cliente
        public List<entRuta> ListarRutas()
        {
            return datRuta.Instancia.ListarRutas();
        }
        //Inserta
        public bool InsertaRuta(entRuta ruta)
        {
            return datRuta.Instancia.InsertarRuta(ruta);
        }
        #endregion Metodos
    }
}
