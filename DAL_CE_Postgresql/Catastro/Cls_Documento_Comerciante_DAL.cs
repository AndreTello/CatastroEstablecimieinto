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
    public class Cls_Documento_Comerciante_DAL
    {
        Cls_Conexion_Postgresql_DAL conexion = new Cls_Conexion_Postgresql_DAL(); 
                
        public DataTable Consultar()
        {
            NpgsqlConnection con = null;
            string query = "select documento_comerciante_id, tipo_documento_comerciante_nombre, comerciante_nombres_representante_legal, documento_comerciante_nombre, documento_comerciante_fecha, documento_comerciante_detalle, documento_comerciante_observacion, documento_comerciante_estado " +
                "from catastroestablecimiento.cm_documento_comerciante " +
                "join catastroestablecimiento.cm_tipo_documento_comerciante " +
                "on catastroestablecimiento.cm_tipo_documento_comerciante.tipo_documento_comerciante_id = catastroestablecimiento.cm_documento_comerciante.tipo_documento_comerciante_id " +
                 "join catastroestablecimiento.cm_comerciante " +
                "on catastroestablecimiento.cm_comerciante.comerciante_id = catastroestablecimiento.cm_documento_comerciante.comerciante_id " +
                "order by documento_comerciante_id asc";
            NpgsqlCommand conector = null;
            NpgsqlDataAdapter datos = null;
            DataTable tabla = null;
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
            string query = "select documento_comerciante_id, tipo_documento_comerciante_nombre, comerciante_nombres_representante_legal, documento_comerciante_nombre, documento_comerciante_fecha, documento_comerciante_detalle, documento_comerciante_observacion, documento_comerciante_estado " +
                "from catastroestablecimiento.cm_documento_comerciante " +
                "join catastroestablecimiento.cm_tipo_documento_comerciante " +
                "on catastroestablecimiento.cm_tipo_documento_comerciante.tipo_documento_comerciante_id = catastroestablecimiento.cm_documento_comerciante.tipo_documento_comerciante_id " +
                 "join catastroestablecimiento.cm_comerciante " +
                "on catastroestablecimiento.cm_comerciante.comerciante_id = catastroestablecimiento.cm_documento_comerciante.comerciante_id " +
                "where documento_comerciante_id = " + id + " " +
                "order by documento_comerciante_id asc";
            NpgsqlCommand conector = null;
            NpgsqlDataAdapter datos = null;
            DataTable tabla = null;
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

        public DataTable Documento_Comerciante()
        {
            NpgsqlConnection con = null;
            string query = "select documento_comerciante_id, documento_comerciante_nombre from catastroestablecimiento.cm_documento_comerciante order by documento_comerciante_id asc";
            NpgsqlCommand conector = null;
            NpgsqlDataAdapter datos = null;
            DataTable tabla = null;
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


        public void Insertar(int tipo, int comerciante, string nombre, string fecha, string detalle, string observacion, int estado)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query =
                "Insert into catastroestablecimiento.cm_documento_comerciante (tipo_documento_comerciante_id, comerciante_id, documento_comerciante_nombre, documento_comerciante_fecha, documento_comerciante_detalle, documento_comerciante_observacion, documento_comerciante_estado) " +
                "values (" + tipo + "," + comerciante + ",'" + nombre + "','" + fecha + "','" + detalle + "','" + observacion + "'," + estado + ")";
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

        public void Editar(int tipo, int comerciante, string nombre, string fecha, string detalle, string observacion, int estado, int id)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query = "update catastroestablecimiento.cm_documento_comerciante set " +
                "tipo_documento_comerciante_id = " + tipo + ", " +
                "comerciante_id = " + comerciante + ", " +
                "documento_comerciante_nombre = '" + nombre + "', " +
                "documento_comerciante_fecha = '" + fecha + "', " +
                "documento_comerciante_detalle = '" + detalle + "', " +
                "documento_comerciante_observacion = '" + observacion + "', " +
                "documento_comerciante_estado = " + estado +
                " where documento_comerciante_id = " + id + "";
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
                string query = "delete from catastroestablecimiento.cm_documento_comerciante where documento_comerciante_id = " + id + "";
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
