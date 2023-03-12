using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using ENT_CE;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DAL_CE_Postgresql.Administracion
{
    public class Cls_Usuario_DAL
    {
        Cls_Conexion_Postgresql_DAL conexion = new Cls_Conexion_Postgresql_DAL();
        NpgsqlCommand comando = new NpgsqlCommand();

        public DataTable Consultar()
        {
            DataTable tabla = new DataTable();
            NpgsqlConnection con = null;
            NpgsqlDataAdapter datos = null;
            try
            {
                con = conexion.EstablecerConexion();
                datos = new NpgsqlDataAdapter("SELECT * FROM administracion.consultar_usuario()", con);
                datos.Fill(tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show("HA OCURRIDO UN ERROR:  " + ex.ToString());
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
            return tabla;
        }

        public DataTable ConsultarID(int u_id)
        {
            DataTable tabla = new DataTable();
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                NpgsqlCommand comando = new NpgsqlCommand("SELECT * FROM administracion.consultar_usuarioid(@u_id)", con);
                comando.Parameters.AddWithValue("@u_id", u_id);
                NpgsqlDataAdapter datos = new NpgsqlDataAdapter(comando);
                datos.Fill(tabla);
            }
            catch (Exception ex)
            {
                MessageBox.Show("HA OCURRIDO UN ERROR:  " + ex.ToString());
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
            return tabla;
        }

        public void Insertar(int rol, string login, string clave, string cedula, string apellidos, string nombres, string email, string direccion, string telefono, int estado)
        {
            NpgsqlConnection con = null;
            try
            {
                comando.Connection = conexion.EstablecerConexion();
                comando.CommandText = "administracion.insertar_usuario";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("r_id", rol);
                comando.Parameters.AddWithValue("u_login", login);
                comando.Parameters.AddWithValue("u_clave", clave);
                comando.Parameters.AddWithValue("u_cedula", cedula);
                comando.Parameters.AddWithValue("u_apellidos", apellidos);
                comando.Parameters.AddWithValue("u_nombres", nombres);
                comando.Parameters.AddWithValue("u_mail", email);
                comando.Parameters.AddWithValue("u_direccion", direccion);
                comando.Parameters.AddWithValue("u_telefono", telefono);
                comando.Parameters.AddWithValue("u_estado", estado);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("HA OCURRIDO UN ERROR:  " + ex.ToString());
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        public void Editar(int id, int rol, string login, string clave, string cedula, string apellidos, string nombres, string email, string direccion, string telefono, int estado)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                NpgsqlCommand comando = new NpgsqlCommand("administracion.editar_usuario", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("u_id", id);
                comando.Parameters.AddWithValue("r_id", rol);
                comando.Parameters.AddWithValue("u_login", login);
                comando.Parameters.AddWithValue("u_clave", clave);
                comando.Parameters.AddWithValue("u_cedula", cedula);
                comando.Parameters.AddWithValue("u_apellidos", apellidos);
                comando.Parameters.AddWithValue("u_nombres", nombres);
                comando.Parameters.AddWithValue("u_mail", email);
                comando.Parameters.AddWithValue("u_direccion", direccion);
                comando.Parameters.AddWithValue("u_telefono", telefono);
                comando.Parameters.AddWithValue("u_estado", estado);
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("HA OCURRIDO UN ERROR:  " + ex.ToString());
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        public void Eliminar(int id)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                NpgsqlCommand comando = new NpgsqlCommand("administracion.eliminar_usuario", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("u_id", id);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("HA OCURRIDO UN ERROR:  " + ex.ToString());
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }
    }
}
