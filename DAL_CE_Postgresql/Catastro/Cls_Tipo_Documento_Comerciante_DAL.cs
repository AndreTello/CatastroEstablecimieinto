using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL_CE_Postgresql.Catastro
{
    public class Cls_Tipo_Documento_Comerciante_DAL
    {
        Cls_Conexion_Postgresql_DAL conexion = new Cls_Conexion_Postgresql_DAL();

        private int TIPO_DOCUMENTO_COMERCIANTE_ID;
        private string TIPO_DOCUMENTO_COMERCIANTE_NOMBRE;
        private int TIPO_DOCUMENTO_COMERCIANTE_ESTADO;

        public int TIPO_DOCUMENTO_COMERCIANTE_ID1 { get => TIPO_DOCUMENTO_COMERCIANTE_ID; set => TIPO_DOCUMENTO_COMERCIANTE_ID = value; }
        public string TIPO_DOCUMENTO_COMERCIANTE_NOMBRE1 { get => TIPO_DOCUMENTO_COMERCIANTE_NOMBRE; set => TIPO_DOCUMENTO_COMERCIANTE_NOMBRE = value; }
        public int TIPO_DOCUMENTO_COMERCIANTE_ESTADO1 { get => TIPO_DOCUMENTO_COMERCIANTE_ESTADO; set => TIPO_DOCUMENTO_COMERCIANTE_ESTADO = value; }

        public DataTable Consultar()
        {
            NpgsqlConnection con = null;
            string query = "select tipo_documento_comerciante_id, tipo_documento_comerciante_nombre, tipo_documento_comerciante_estado " +
                "from catastroestablecimiento.cm_tipo_documento_comerciante " +
                "order by tipo_documento_comerciante_id asc;";
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
            string query = "select tipo_documento_comerciante_id, tipo_documento_comerciante_nombre, tipo_documento_comerciante_estado " +
                "from catastroestablecimiento.cm_tipo_documento_comerciante " +
                "where tipo_documento_comerciante_id = " + id + " order by tipo_documento_comerciante_id asc;";
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

        public DataTable Tipo_Documento_Comerciante()
        {
            NpgsqlConnection con = null;
            string query = "select tipo_documento_comerciante_id, tipo_documento_comerciante_nombre from catastroestablecimiento.cm_tipo_documento_comerciante order by tipo_documento_comerciante_id asc;";
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

        public void Insertar(string nombre, int estado)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query =
                "Insert into catastroestablecimiento.cm_tipo_documento_comerciante (tipo_documento_comerciante_nombre, tipo_documento_comerciante_estado) " +
                "values ('" + nombre + "'," + estado + ")";
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


        public void Editar(string nombre, int estado, int id)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query = "update catastroestablecimiento.cm_tipo_documento_comerciante set " +
                "tipo_documento_comerciante_nombre = '" + nombre + "', " +
                "tipo_documento_comerciante_estado = " + estado +
                " where tipo_documento_comerciante_id = " + id + "";
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
                string query = "delete from catastroestablecimiento.cm_tipo_documento_comerciante where tipo_documento_comerciante_id = " + id + "";
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
