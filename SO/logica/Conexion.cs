using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SO
{
    class Conexion
    {
        /// <summary>
        /// realiza la conexion con la base de datos y retorna si  esta conectado o no 
        /// </summary>
        /// <returns></returns>
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conect = new SqlConnection("Data Source=JIMENEZ;Initial Catalog=Navegador ;Integrated Security=True");
            try
            {
                conect.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se realizó la conexion" + ex.ToString());
            }
            return conect;
        }
    }
}
