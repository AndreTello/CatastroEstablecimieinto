using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENT_CE;
using System.Security.Policy;

namespace DAL_CE_Postgresql.Catastro
{
    public class Cls_Manzana_DAL
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
                datos = new NpgsqlDataAdapter("SELECT * FROM catastroestablecimiento.consultar_manzana()", con);
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

        public DataTable ConsultarID(int m_id)
        {
            DataTable tabla = new DataTable();
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                NpgsqlCommand comando = new NpgsqlCommand("SELECT * FROM catastroestablecimiento.consultar_manzanaid(@m_id)", con);
                comando.Parameters.AddWithValue("@m_id", m_id);
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

        public DataTable Manzana()
        {
            DataTable tabla = new DataTable();
            NpgsqlConnection con = null;
            NpgsqlDataAdapter datos = null;
            try
            {
                con = conexion.EstablecerConexion();
                datos = new NpgsqlDataAdapter("SELECT * FROM catastroestablecimiento.manzana()", con);
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


        public void Insertar(int parroquia, string codigo, string nombre, string observacion, int estado)
        {
            NpgsqlConnection con = null;
            try
            {
                comando.Connection = conexion.EstablecerConexion();
                comando.CommandText = "catastroestablecimiento.insertar_manzana";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("p_id", parroquia);
                comando.Parameters.AddWithValue("m_codigo", codigo);
                comando.Parameters.AddWithValue("m_nombre", nombre);
                comando.Parameters.AddWithValue("m_observacion", observacion);
                comando.Parameters.AddWithValue("m_estado", estado);
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

        public void Editar(int id, int parroquia, string codigo, string nombre, string observacion, int estado)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                NpgsqlCommand comando = new NpgsqlCommand("catastroestablecimiento.editar_manzana", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("m_id", id);
                comando.Parameters.AddWithValue("p_id", parroquia);
                comando.Parameters.AddWithValue("m_codigo", codigo);
                comando.Parameters.AddWithValue("m_nombre", nombre);
                comando.Parameters.AddWithValue("m_observacion", observacion);
                comando.Parameters.AddWithValue("m_estado", estado);
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
                NpgsqlCommand comando = new NpgsqlCommand("catastroestablecimiento.eliminar_manzana", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("m_id", id);
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
