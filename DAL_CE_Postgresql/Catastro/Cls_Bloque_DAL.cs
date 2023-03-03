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
    public class Cls_Bloque_DAL
    {
        Cls_Conexion_Postgresql_DAL conexion = new Cls_Conexion_Postgresql_DAL();

        private int BLOQUE_ID;
        private int ESTABLECIMIENTO_ID;
		private string BLOQUE_CODIGO;
        private string BLOQUE_NOMBRE;
        private int BLOQUE_ESTADO;
		private string BLOQUE_OBSERVACION;

        public int BLOQUE_ID1 { get => BLOQUE_ID; set => BLOQUE_ID = value; }
        public int ESTABLECIMIENTO_ID1 { get => ESTABLECIMIENTO_ID; set => ESTABLECIMIENTO_ID = value; }
        public string BLOQUE_CODIGO1 { get => BLOQUE_CODIGO; set => BLOQUE_CODIGO = value; }
        public string BLOQUE_NOMBRE1 { get => BLOQUE_NOMBRE; set => BLOQUE_NOMBRE = value; }
        public int BLOQUE_ESTADO1 { get => BLOQUE_ESTADO; set => BLOQUE_ESTADO = value; }
        public string BLOQUE_OBSERVACION1 { get => BLOQUE_OBSERVACION; set => BLOQUE_OBSERVACION = value; }

        public DataTable Consultar()
        {
            NpgsqlConnection con = null;
            string query = "select bloque_id, establecimiento_clave_catastral, bloque_codigo, bloque_nombre, bloque_observacion, bloque_estado " +
                "from catastroestablecimiento.cm_bloque " +
                "join catastroestablecimiento.cm_establecimiento " +
                "on catastroestablecimiento.cm_establecimiento.establecimiento_id = catastroestablecimiento.cm_bloque.establecimiento_id " +
                "order by bloque_id asc";
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
            string query = "select bloque_id, establecimiento_clave_catastral, bloque_codigo, bloque_nombre, bloque_observacion, bloque_estado " +
                "from catastroestablecimiento.cm_bloque " +
                "join catastroestablecimiento.cm_establecimiento " +
                "on catastroestablecimiento.cm_establecimiento.establecimiento_id = catastroestablecimiento.cm_bloque.establecimiento_id " +
                "where bloque_id = " + id + " " +
                "order by bloque_id asc";
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

        public DataTable Bloque()
        {
            NpgsqlConnection con = null;
            string query = "select bloque_id, bloque_nombre from catastroestablecimiento.cm_bloque order by bloque_id asc";
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


        public void Insertar(int establecimiento, string codigo, string nombre, string observacion, int estado)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query =
                "Insert into catastroestablecimiento.cm_bloque (establecimiento_id, bloque_codigo, bloque_nombre, bloque_observacion, bloque_estado) " +
                "values (" + establecimiento + ",'" + codigo + "','" + nombre + "','" + observacion + "'," + estado + ")";
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

        public void Editar(int establecimiento, string codigo, string nombre, string observacion, int estado, int id)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query = "update catastroestablecimiento.cm_bloque set " +
                "establecimiento_id = " + establecimiento + ", " +
                "bloque_codigo = '" + codigo + "', " +
                "bloque_nombre = '" + nombre + "', " +
                "bloque_observacion = '" + observacion + "', " +
                "bloque_estado = " + estado +
                " where bloque_id = " + id + "";
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
                string query = "delete from catastroestablecimiento.cm_bloque where bloque_id = " + id + "";
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
