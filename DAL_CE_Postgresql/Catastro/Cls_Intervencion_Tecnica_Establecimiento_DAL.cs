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
    public class Cls_Intervencion_Tecnica_Establecimiento_DAL
    {

        Cls_Conexion_Postgresql_DAL conexion = new Cls_Conexion_Postgresql_DAL();

        private int INTERVENCION_TECNICA_ESTABLECIMIENTO_ID;
        private int TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_ID;
		private string INTERVENCION_TECNICA_ESTABLECIMIENTO_NOMBRE;
        private string INTERVENCION_TECNICA_ESTABLECIMIENTO_FECHA_INICIO; //Declarados como string pero pueden ser de tipo date
        private string INTERVENCION_TECNICA_ESTABLECIMIENTO_FECHA_FIN;
        private int TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_ESTADO;

        public int INTERVENCION_TECNICA_ESTABLECIMIENTO_ID1 { get => INTERVENCION_TECNICA_ESTABLECIMIENTO_ID; set => INTERVENCION_TECNICA_ESTABLECIMIENTO_ID = value; }
        public int TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_ID1 { get => TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_ID; set => TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_ID = value; }
        public string INTERVENCION_TECNICA_ESTABLECIMIENTO_NOMBRE1 { get => INTERVENCION_TECNICA_ESTABLECIMIENTO_NOMBRE; set => INTERVENCION_TECNICA_ESTABLECIMIENTO_NOMBRE = value; }
        public string INTERVENCION_TECNICA_ESTABLECIMIENTO_FECHA_INICIO1 { get => INTERVENCION_TECNICA_ESTABLECIMIENTO_FECHA_INICIO; set => INTERVENCION_TECNICA_ESTABLECIMIENTO_FECHA_INICIO = value; }
        public string INTERVENCION_TECNICA_ESTABLECIMIENTO_FECHA_FIN1 { get => INTERVENCION_TECNICA_ESTABLECIMIENTO_FECHA_FIN; set => INTERVENCION_TECNICA_ESTABLECIMIENTO_FECHA_FIN = value; }
        public int TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_ESTADO1 { get => TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_ESTADO; set => TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_ESTADO = value; }

        public DataTable Consultar()
        {
            NpgsqlConnection con = null;
            string query = "select intervencion_tecnica_establecimiento_id, tipo_intervencion_tecnica_establecimiento_nombre, intervencion_tecnica_establecimiento_nombre, intervencion_tecnica_establecimiento_fecha_inicio, intervencion_tecnica_establecimiento_fecha_fin, intervencion_tecnica_establecimiento_estado " +
                "from catastroestablecimiento.cm_intervencion_tecnica_establecimiento " +
                "join catastroestablecimiento.cm_tipo_intervencion_tecnica_establecimiento " +
                "on catastroestablecimiento.cm_tipo_intervencion_tecnica_establecimiento.tipo_intervencion_tecnica_establecimiento_id = catastroestablecimiento.cm_intervencion_tecnica_establecimiento.tipo_intervencion_tecnica_establecimiento_id " +
                "order by intervencion_tecnica_establecimiento_id asc;";
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
            string query = "select intervencion_tecnica_establecimiento_id, tipo_intervencion_tecnica_establecimiento_nombre, intervencion_tecnica_establecimiento_nombre, intervencion_tecnica_establecimiento_fecha_inicio, intervencion_tecnica_establecimiento_fecha_fin, intervencion_tecnica_establecimiento_estado " +
                "from catastroestablecimiento.cm_intervencion_tecnica_establecimiento " +
                "join catastroestablecimiento.cm_tipo_intervencion_tecnica_establecimiento " +
                "on catastroestablecimiento.cm_tipo_intervencion_tecnica_establecimiento.tipo_intervencion_tecnica_establecimiento_id = catastroestablecimiento.cm_intervencion_tecnica_establecimiento.tipo_intervencion_tecnica_establecimiento_id where intervencion_tecnica_establecimiento_id = " + id + " order by intervencion_tecnica_establecimiento_id asc;";
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

        public DataTable Intervencion_Tecnica()
        {
            NpgsqlConnection con = null;
            string query = "select intervencion_tecnica_establecimiento_id, intervencion_tecnica_establecimiento_nombre from catastroestablecimiento.cm_intervencion_tecnica_establecimiento order by intervencion_tecnica_establecimiento_id asc";
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


        public void Insertar(int tipo, string nombre, string fecha_inicio, string fecha_fin, int estado)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query =
                "Insert into catastroestablecimiento.cm_intervencion_tecnica_establecimiento (tipo_intervencion_tecnica_establecimiento_id, intervencion_tecnica_establecimiento_nombre, intervencion_tecnica_establecimiento_fecha_inicio, intervencion_tecnica_establecimiento_fecha_fin, intervencion_tecnica_establecimiento_estado) " +
                "values (" + tipo + ",'" + nombre + "','" + fecha_inicio+ "','" + fecha_fin+ "'," + estado + ")";
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

        public void Editar(int tipo, string nombre, string fecha_inicio, string fecha_fin, int estado, int id)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query =
                "update catastroestablecimiento.cm_intervencion_tecnica_establecimiento " +
                "set tipo_intervencion_tecnica_establecimiento_id = " + tipo + "' " +
                "intervencion_tecnica_establecimiento_nombre = '" + nombre + "', " +
                "intervencion_tecnica_establecimiento_fecha_inicio = '" + fecha_inicio + "', " +
                "intervencion_tecnica_establecimiento_fecha_fin = '" + fecha_fin + "', " +
                "intervencion_tecnica_establecimiento_estado = " + estado + " " +
                "where intervencion_tecnica_establecimiento_id = " + id + "";
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
                string query = "delete from catastroestablecimiento.cm_intervencion_tecnica_establecimiento where intervencion_tecnica_establecimiento_id = " + id + "";
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
