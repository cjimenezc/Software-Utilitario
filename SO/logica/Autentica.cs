using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using SO.logica;

namespace SO
{
    class Autentica
    {
        public static Usuario dato = new Usuario();
        SqlDataReader dr;
        /// <summary>
        /// Busar a los usuarios con sus respectiva contraseña en la base de datos
        /// </summary>
        /// <param name="Usuario"></param>
        /// <param name="contraseña"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Busca todos los usuarios 
        /// </summary>
        /// <param name="Dato"></param>
        /// <returns></returns>
        public Usuario usuario(string Dato)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand Usu = new SqlCommand(("Select * from usuarios where usuario ='" + Dato + "' "), cn);
                SqlDataReader reader = Usu.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dato.usuario = reader.GetString(1);
                        dato.perfil = reader.GetInt32(3);
                        dato.nombre = reader.GetString(4);
                        dato.apellido1 = reader.GetString(5);
                        dato.apellido2 = reader.GetString(6);
                    }
                }
                return dato;
            }
        }
        public void BuscarUsu(DataGridView dgv, string Usu)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlDataAdapter usuario = new SqlDataAdapter("select usuario From usuarios  Where usuario = '" + Usu + "'", cn);
                DataSet dsusu = new DataSet();
                usuario.Fill(dsusu, "usuarios");
                dgv.DataSource = dsusu;
                dgv.DataMember = "usuarios";
            }
        }
        /// <summary>
        /// inserta el Historial en la base de datos 
        /// </summary>
        /// <param name="Usuario"></param>
        public void Historial(string Usuario)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("insert into Historial(id_Usuario,FechaIngreso) values ((select id_Usuario from usuarios where usuario = '" + Usuario + "'),GETDATE())", cn);
                cmd.ExecuteNonQuery();
            }
        }
        /// <summary>
        /// Busca el historial de la bases que el usuario a ingresado al
        /// sistema para ser mostrado
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="Usu"></param>
        public void BuscarHistorial(DataGridView dgv, string Usu)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlDataAdapter historial = new SqlDataAdapter("select FechaIngreso as [Fecha y hora] From historial  Where id_Usuario = (select id_Usuario from usuarios where usuario = '" + Usu + "')", cn);
                DataSet hist = new DataSet();
                historial.Fill(hist, "historial");
                dgv.DataSource = hist;
                dgv.DataMember = "historial";
            }
        }
        /// <summary>
        /// Inserta el usuario en la base de datos 
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="contraseña"></param>
        /// <param name="perfil"></param>
        /// <param name="Nombre"></param>
        /// <param name="Apellido1"></param>
        /// <param name="Apellido2"></param>
        public void InsetUsu(string usuario, string contraseña, int perfil, string Nombre, string Apellido1, string Apellido2)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Insert into usuarios(usuario,contraseña,perfil,Nombre,Apellido1,Apellido2)values('" + usuario + "','" + contraseña + "','" + perfil + "','" + Nombre + "','" + Apellido1 + "','" + Apellido2 + "')", cn);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se realizaron Inserción" + ex.ToString());
                }
            }
        }
        /// <summary>
        /// Verifica si el usuario es administrador o usuario para poder dar permisos
        /// </summary>
        /// <param name="Usuario"></param>
        /// <param name="contraseña"></param>
        /// <returns></returns>
        public int PermisosRol(String Usuario)
        {
            int contador = 0;
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM usuarios WHERE   usuario ='" + Usuario + "'and perfil = '1'", cn);

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
