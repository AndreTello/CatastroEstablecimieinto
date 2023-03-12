using Npgsql;
using Npgsql.Internal.TypeHandlers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL_CE_Postgresql.Catastro
{
    public class Cls_Ayudante_DAL
    {
        Cls_Conexion_Postgresql_DAL conexion = new Cls_Conexion_Postgresql_DAL();

        public DataTable Consultar()
        {
            NpgsqlConnection con = null;
            string query = "select ayudante_id, ayudante_cedula, ayudante_apellidos, ayudante_nombres, ayudante_parentezco, ayudante_autorizacion, ayudante_numero_oficio, ayudante_fecha_oficio, ayudante_estado " +
                "from catastroestablecimiento.cm_ayudante " +
                "order by ayudante_id asc";
            NpgsqlCommand conector = null;
            NpgsqlDataAdapter datos = null;
            DataTable tabla = new DataTable();
            try
            {
                con = conexion.EstablecerConexion();
                conector = new NpgsqlCommand(query, con);
                datos = new NpgsqlDataAdapter(conector);
                tabla = new DataTable();
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

        public DataTable ConsultarID(int id)
        {
            NpgsqlConnection con = null;
            string query = "select ayudante_id, ayudante_cedula, ayudante_apellidos, ayudante_nombres, ayudante_parentezco, ayudante_autorizacion, ayudante_numero_oficio, ayudante_fecha_oficio, ayudante_estado " +
                "from catastroestablecimiento.cm_ayudante where ayudante_id = " + id + " order by ayudante_id asc"; 
            NpgsqlCommand conector = null;
            NpgsqlDataAdapter datos = null;
            DataTable tabla = new DataTable();
            try
            {
                con = conexion.EstablecerConexion();
                conector = new NpgsqlCommand(query, con);
                datos = new NpgsqlDataAdapter(conector);
                tabla = new DataTable();
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

        public DataTable Ayudante()
        {
            NpgsqlConnection con = null;
            string query = "select ayudante_id, ayudante_nombres from catastroestablecimiento.cm_ayudante order by ayudante_id asc";
            NpgsqlCommand conector = null;
            NpgsqlDataAdapter datos = null;
            DataTable tabla = new DataTable();
            try
            {
                con = conexion.EstablecerConexion();
                conector = new NpgsqlCommand(query, con);
                datos = new NpgsqlDataAdapter(conector);
                tabla = new DataTable();
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

         
        public void Insertar(string cedula, string apellidos, string nombres, string parentezco, string autorizacion, string numero, string fecha, int estado)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query =
                "Insert into catastroestablecimiento.cm_ayudante (ayudante_cedula, ayudante_apellidos, ayudante_nombres, ayudante_parentezco, ayudante_autorizacion, ayudante_numero_oficio, ayudante_fecha_oficio, ayudante_estado) " +
                "values ('" + cedula + "','" + apellidos + "','" + nombres + "','" + parentezco + "','" + autorizacion + "','" + numero + "','" + fecha + "'," + estado + ")";
                NpgsqlCommand insert = new NpgsqlCommand(query, con);
                insert.ExecuteNonQuery();
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

        public void Editar(string cedula, string apellidos, string nombres, string parentezco, string autorizacion, string numero, string fecha, int estado, int id)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query =
                "update catastroestablecimiento.cm_ayudante set " +
                "ayudante_cedula = '" + cedula + "', " +
                "ayudante_apellidos = '" + apellidos + "', " +
                "ayudante_nombres = '" + nombres + "', " +
                "ayudante_parentezco = '" + parentezco + "', " +
                "ayudante_autorizacion = '" + autorizacion + "', " +
                "ayudante_numero_oficio = '" + numero + "', " +
                "ayudante_fecha_oficio = '" + fecha + "', " +
                "ayudante_estado = " + estado + " " +
                "where ayudante_id = " + id + "";
                NpgsqlCommand update = new NpgsqlCommand(query, con);
                update.ExecuteNonQuery();
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
                string query = "delete from catastroestablecimiento.cm_ayudante where ayudante_id = " + id + "";
                NpgsqlCommand delete = new NpgsqlCommand(query, con);
                delete.ExecuteNonQuery();
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
