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

namespace DAL_CE_Postgresql.Catastro
{
    public class Cls_Documento_Puesto_DAL
    {
        Cls_Conexion_Postgresql_DAL conexion = new Cls_Conexion_Postgresql_DAL();

        public DataTable Consultar()
        {
            NpgsqlConnection con = null;
            string query = "select documento_puesto_id, tipo_documento_puesto_nombre, documento_puesto_nombre, documento_puesto_fecha, documento_puesto_detalle, documento_puesto_observacion, documento_puesto_estado " +
                "from catastroestablecimiento.cm_documento_puesto " +
                "join catastroestablecimiento.cm_tipo_documento_puesto " +
                "on catastroestablecimiento.cm_tipo_documento_puesto.tipo_documento_puesto_id = catastroestablecimiento.cm_documento_puesto.tipo_documento_puesto_id " +
                "order by documento_puesto_id asc;";
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
            string query = "select documento_puesto_id, tipo_documento_puesto_nombre, documento_puesto_nombre, documento_puesto_fecha, documento_puesto_detalle, documento_puesto_observacion, documento_puesto_estado " +
                "from catastroestablecimiento.cm_documento_puesto " +
                "join catastroestablecimiento.cm_tipo_documento_puesto " +
                "on catastroestablecimiento.cm_tipo_documento_puesto.tipo_documento_puesto_id = catastroestablecimiento.cm_documento_puesto.tipo_documento_puesto_id " +
                "where documento_puesto_id = " + id + " " +
                "order by documento_puesto_id asc";
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

        public DataTable Documento_Puesto()
        {
            NpgsqlConnection con = null;
            string query = "select documento_puesto_id, documento_puesto_nombre from catastroestablecimiento.cm_documento_puesto order by documento_puesto_id asc";
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

        public void Insertar(int tipo, string nombre, string fecha, string detalle, string observacion, int estado)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query =
                "Insert into catastroestablecimiento.cm_documento_puesto (tipo_documento_puesto_id, documento_puesto_nombre, documento_puesto_fecha, documento_puesto_detalle, documento_puesto_observacion, documento_puesto_estado) " +
                "values (" + tipo + ",'" + nombre + "','" + fecha + "','" + detalle + "','" + observacion + "'," + estado + ")";
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

        public void Editar(int tipo, string nombre, string fecha, string detalle, string observacion, int estado, int id)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query = "update catastroestablecimiento.cm_documento_puesto set " +
                "tipo_documento_puesto_id = " + tipo + ", " +
                "documento_puesto_nombre = '" + nombre + "', " +
                "documento_puesto_fecha = '" + fecha + "', " +
                "documento_puesto_detalle = '" + detalle + "', " +
                "documento_puesto_observacion = '" + observacion + "', " +
                "documento_puesto_estado = " + estado + " " +
                "where documento_puesto_id = " + id + "";
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
                string query = "delete from catastroestablecimiento.cm_documento_puesto where documento_puesto_id = " + id + "";
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
