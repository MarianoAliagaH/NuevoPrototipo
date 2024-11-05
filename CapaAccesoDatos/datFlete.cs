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
        public List<entFlete> ListaRutas(int idCliente)
        {
            List<entFlete> lista = new List<entFlete>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //Singleton
                cmd = new SqlCommand("spListaFletesCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClienteId", idCliente);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entFlete flete = new entFlete();
                    flete.Id = Convert.ToInt32(dr["Id"]);
                    //flete.FechaRegistro = Convert.ToDateTime(dr["Fecha"].ToString());
                    flete.DescripcionRuta = dr["Ruta"].ToString();
                    flete.Monto = Convert.ToDecimal(dr["Flete"]);
                    flete.ValorFleteRetorno = Convert.ToSingle(dr["PorcentajeRet"]);
                    flete.MontoFleteRetorno = Convert.ToDecimal(dr["MontoFleteRetorno"]);
                    flete.TipoServicio = dr["TipoServicio"].ToString();
                    flete.Activo = Convert.ToBoolean(dr["Activo"]);
                    lista.Add(flete);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en datFlete- ListaFletesAsignados : " + ex.Message);
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
        public Boolean AsignaFlete(entFlete flete)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spAsignaFlete", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClienteId", flete.ClienteId);
                cmd.Parameters.AddWithValue("@DescripcionRuta", flete.DescripcionRuta);
                cmd.Parameters.AddWithValue("@Monto", flete.Monto);
                cmd.Parameters.AddWithValue("@ValorFleteRetorno", flete.ValorFleteRetorno);
                cmd.Parameters.AddWithValue("@MontoFleteRetorno", flete.MontoFleteRetorno);
                cmd.Parameters.AddWithValue("@TipoServicio", flete.TipoServicio);

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
                Console.WriteLine("Error en datFlete - spAsignaFlete: " + ex.Message);
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
