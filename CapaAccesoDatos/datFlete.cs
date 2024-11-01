using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using CapaEntidad;

namespace CapaAccesoDatos
{
    public class datFlete
    {
        #region Singleton
        //Variable estática para la instancia
        private static readonly datFlete _instancia = new datFlete(); //Privado para evitar la instanciación directa
        public static datFlete Instancia
        {
            get
            {
                return datFlete._instancia;
            }
        }
        #endregion Singleton

        #region Metodos
        //Listado de Rutas
        public List<entFlete> ListarRutas()
        {
            List<entFlete> lista = new List<entFlete>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //Singleton
                cmd = new SqlCommand("", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entFlete flete = new entFlete();
                    flete.Id = Convert.ToInt32(dr["Id"]);
                    //flete.FechaRegistro = Convert.ToDateTime(dr["Fecha"].ToString());
                    flete.DescripcionRuta = dr["Ruta"].ToString();
                    flete.Activo = Convert.ToBoolean(dr["Activo"]);
                    lista.Add(flete);
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
        public Boolean InsertarRuta(entFlete flete)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaRuta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ruta", flete.DescripcionRuta);
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
