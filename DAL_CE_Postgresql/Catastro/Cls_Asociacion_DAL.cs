using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENT_CE;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DAL_CE_Postgresql.Catastro
{
    public class Cls_Asociacion_DAL
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
                datos = new NpgsqlDataAdapter("SELECT * FROM catastroestablecimiento.consultar_asociacion()", con);
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

        public DataTable ConsultarID(int a_id)
        {
            DataTable tabla = new DataTable();
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                NpgsqlCommand comando = new NpgsqlCommand("SELECT * FROM catastroestablecimiento.consultar_asociacionid(@a_id)", con);
                comando.Parameters.AddWithValue("@a_id", a_id);
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

        public DataTable Asociacion()
        {
            DataTable tabla = new DataTable();
            NpgsqlConnection con = null;
            NpgsqlDataAdapter datos = null;
            try
            {
                con = conexion.EstablecerConexion();
                datos = new NpgsqlDataAdapter("SELECT * FROM catastroestablecimiento.asociacion()", con);
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


        public void Insertar(string codigo, string nombre, string telefono, string mail, string contacto, string observacion, int estado)
        {
            NpgsqlConnection con = null;
            try
            {
                comando.Connection = conexion.EstablecerConexion();
                comando.CommandText = "catastroestablecimiento.insertar_asociacion";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("a_codigo", codigo);
                comando.Parameters.AddWithValue("a_nombre", nombre);
                comando.Parameters.AddWithValue("a_telefono", telefono);
                comando.Parameters.AddWithValue("a_mail", mail);
                comando.Parameters.AddWithValue("a_contacto", contacto);
                comando.Parameters.AddWithValue("a_observacion", observacion);
                comando.Parameters.AddWithValue("a_estado", estado);
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

        public void Editar(int id, string codigo, string nombre, string telefono, string mail, string contacto, string observacion, int estado)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                NpgsqlCommand comando = new NpgsqlCommand("catastroestablecimiento.editar_asociacion", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("a_id", id);
                comando.Parameters.AddWithValue("a_codigo", codigo);
                comando.Parameters.AddWithValue("a_nombre", nombre);
                comando.Parameters.AddWithValue("a_telefono", telefono);
                comando.Parameters.AddWithValue("a_mail", mail);
                comando.Parameters.AddWithValue("a_contacto", contacto);
                comando.Parameters.AddWithValue("a_observacion", observacion);
                comando.Parameters.AddWithValue("a_estado", estado);
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
                NpgsqlCommand comando = new NpgsqlCommand("catastroestablecimiento.eliminar_asociacion", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("a_id", id);
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
