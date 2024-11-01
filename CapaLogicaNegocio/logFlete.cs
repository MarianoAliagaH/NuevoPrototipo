using CapaAccesoDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaLogicaNegocio
{
    public class logFlete
    {
        #region Singleton
        //Variable estática para la instancia
        private static readonly logFlete _instancia = new logFlete(); //Privado para evitar la instanciación directa
        public static logFlete Instancia
        {
            get
            {
                return logFlete._instancia;
            }
        }
        #endregion Singleton

        #region Metodos
        //Listado de Rutas Asignadas al Cliente
        public List<entFlete> ListarRutas()
        {
            return datFlete.Instancia.ListarRutas();
        }
        //Inserta
        public bool InsertaRuta(entFlete flete)
        {
            return datFlete.Instancia.InsertarRuta(flete);
        }
        #endregion Metodos
    }
}
