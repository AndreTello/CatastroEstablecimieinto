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

namespace DAL_CE_Postgresql.Administracion
{
    public class Cls_Rol_Permiso_DAL
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
                datos = new NpgsqlDataAdapter("SELECT * FROM administracion.consultar_rol_permiso()", con);
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

        public DataTable ConsultarID(int rp_id)
        {
            DataTable tabla = new DataTable();
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                NpgsqlCommand comando = new NpgsqlCommand("SELECT * FROM administracion.consultar_rol_permisoid(@rp_id)", con);
                comando.Parameters.AddWithValue("@rp_id", rp_id);
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

        public void Insertar(int rol, int permiso, int estado)
        {
            NpgsqlConnection con = null;
            try
            {
                comando.Connection = conexion.EstablecerConexion();
                comando.CommandText = "administracion.insertar_rol_permiso";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("r_id", rol);
                comando.Parameters.AddWithValue("p_id", permiso);
                comando.Parameters.AddWithValue("rp_estado", estado);
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

        public void Editar(int id, int rol, int permiso, int estado)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                NpgsqlCommand comando = new NpgsqlCommand("administracion.editar_rol_permiso", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("rp_id", id);
                comando.Parameters.AddWithValue("r_id", rol);
                comando.Parameters.AddWithValue("p_id", permiso);
                comando.Parameters.AddWithValue("rp_estado", estado);
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
                NpgsqlCommand comando = new NpgsqlCommand("administracion.eliminar_rol_permiso", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("rp_id", id);
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
