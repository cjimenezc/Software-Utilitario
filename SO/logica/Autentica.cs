using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SO
{
    class Autentica
    {
            SqlDataReader dr;
            public int Autenticar(String Usuario, String contraseña)
            {
                int contador = 0;
                using (SqlConnection cn = Conexion.ObtenerConexion())
                {

                    try
                    {

                        SqlCommand cmd = new SqlCommand("SELECT * FROM usuarios WHERE   usuario ='" + Usuario + "'and contraseña = '" + contraseña + "'", cn);

                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                            contador++;
                        dr.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se realizo la consulta " + ex.ToString());
                    }
                }
                return contador;
            }
        }
    }
