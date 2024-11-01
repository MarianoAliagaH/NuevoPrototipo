using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using CapaEntidad;

namespace CapaAccesoDatos
{
    public class datRuta
    {
        #region Singleton
        //Variable estática para la instancia
        private static readonly datRuta _instancia = new datRuta(); //Privado para evitar la instanciación directa
        public static datRuta Instancia
        {
            get
            {
                return datRuta._instancia;
            }
        }
        #endregion Singleton

        #region Metodos
        //Listado de Rutas
        public List<entRuta> ListarRutas()
        {
            List<entRuta> lista = new List<entRuta>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //Singleton
                cmd = new SqlCommand("spListaRutas", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entRuta ruta = new entRuta();
                    ruta.Id = Convert.ToInt32(dr["Id"]);
                    ruta.FechaRegistro = Convert.ToDateTime(dr["Fecha"].ToString());
                    ruta.Ruta = dr["Ruta"].ToString();
                    ruta.Activo = Convert.ToBoolean(dr["Activo"]);
                    lista.Add(ruta);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en datRuta - ListarRutas : " + ex.Message);
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return lista;
        }

        //Inserta Ruta
        public Boolean InsertarRuta(entRuta ruta)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaRuta", cn);
                cmd.CommandType=CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ruta", ruta.Ruta);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception ex)
            {

                // Manejo de excepciones más detallado
                Console.WriteLine("Error en datRuta - InsertarRuta: " + ex.Message);
                throw;
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return inserta;
        }
        #endregion Metodos
    }
}
