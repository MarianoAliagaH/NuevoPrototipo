using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaAccesoDatos
{
    public class Conexion
    {
        //Patron de Diseño Singleton
        private static readonly Conexion _instancia = new Conexion();
        public static Conexion Instancia
        {
            get { return Conexion._instancia; }
        }
        public SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=DESKTOP-8FGQC22; Initial Catalog=dbTRC; User ID=sa; Password=123456; Integrated Security=true";
            try
            {
                cn.Open();

                Console.WriteLine("Conexión establecida correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al establecer la conexión: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
            return cn;
        }
    }
}
