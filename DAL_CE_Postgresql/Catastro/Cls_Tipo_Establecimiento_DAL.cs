using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DAL_CE_Postgresql.Catastro
{
    public class Cls_Tipo_Establecimiento_DAL
    {

        Cls_Conexion_Postgresql_DAL conexion = new Cls_Conexion_Postgresql_DAL();

        private int TIPO_ESTABLECIMIENTO_ID;
        private string TIPO_ESTABLECIMIENTO_NOMBRE;
        private string TIPO_ESTABLECIMIENTO_DETALLE;
		private int TIPO_ESTABLECIMIENTO_ESTADO;

        public int TIPO_ESTABLECIMIENTO_ID1 { get => TIPO_ESTABLECIMIENTO_ID; set => TIPO_ESTABLECIMIENTO_ID = value; }
        public string TIPO_ESTABLECIMIENTO_NOMBRE1 { get => TIPO_ESTABLECIMIENTO_NOMBRE; set => TIPO_ESTABLECIMIENTO_NOMBRE = value; }
        public string TIPO_ESTABLECIMIENTO_DETALLE1 { get => TIPO_ESTABLECIMIENTO_DETALLE; set => TIPO_ESTABLECIMIENTO_DETALLE = value; }
        public int TIPO_ESTABLECIMIENTO_ESTADO1 { get => TIPO_ESTABLECIMIENTO_ESTADO; set => TIPO_ESTABLECIMIENTO_ESTADO = value; }

        public DataTable Consultar()
        {
            NpgsqlConnection con = null;
            string query = "select tipo_establecimiento_id, tipo_establecimiento_nombre, tipo_establecimiento_detalle, tipo_establecimiento_estado " +
                "from catastroestablecimiento.cm_tipo_establecimiento " +
                "order by tipo_establecimiento_id asc;";
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
            string query = "select tipo_establecimiento_id, tipo_establecimiento_nombre, tipo_establecimiento_detalle, tipo_establecimiento_estado " +
                "from catastroestablecimiento.cm_tipo_establecimiento where tipo_establecimiento_id = " + id + " order by tipo_establecimiento_id asc;";
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

        public DataTable Tipo_Establecimiento()
        {
            NpgsqlConnection con = null;
            string query = "select tipo_establecimiento_id, tipo_establecimiento_nombre from catastroestablecimiento.cm_tipo_establecimiento order by tipo_establecimiento_id asc";
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


        public void Insertar(string nombre, string detalle, int estado)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query =
                "Insert into catastroestablecimiento.cm_tipo_establecimiento (tipo_establecimiento_nombre, tipo_establecimiento_detalle, tipo_establecimiento_estado) " +
                "values ('" + nombre + "','" + detalle + "'," + estado + ")";
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

        public void Editar(string nombre, string detalle, int estado, int id)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query =
                "update catastroestablecimiento.cm_tipo_establecimiento set tipo_establecimiento_nombre = '" + nombre + "', tipo_establecimiento_detalle = '" + detalle + "', " +
                "tipo_establecimiento_estado = " + estado + " " +
                "where tipo_establecimiento_id = " + id + "";
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
                string query = "delete from catastroestablecimiento.cm_tipo_establecimiento where tipo_establecimiento_id = " + id + "";
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
