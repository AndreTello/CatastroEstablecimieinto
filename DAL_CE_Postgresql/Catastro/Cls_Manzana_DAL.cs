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
    public class Cls_Manzana_DAL
    {
        Cls_Conexion_Postgresql_DAL conexion = new Cls_Conexion_Postgresql_DAL();

        private int MANZANA_ID;
        private int PARROQUIA_ID;
		private string MANZANA_CODIGO;
        private string MANZANA_NOMBRE;
        private int MANZANA_ESTADO;
		private string MANZANA_OBSERVACION;

        public int MANZANA_ID1 { get => MANZANA_ID; set => MANZANA_ID = value; }
        public int PARROQUIA_ID1 { get => PARROQUIA_ID; set => PARROQUIA_ID = value; }
        public string MANZANA_CODIGO1 { get => MANZANA_CODIGO; set => MANZANA_CODIGO = value; }
        public string MANZANA_NOMBRE1 { get => MANZANA_NOMBRE; set => MANZANA_NOMBRE = value; }
        public int MANZANA_ESTADO1 { get => MANZANA_ESTADO; set => MANZANA_ESTADO = value; }
        public string MANZANA_OBSERVACION1 { get => MANZANA_OBSERVACION; set => MANZANA_OBSERVACION = value; }

        public DataTable Consultar()
        {
            NpgsqlConnection con = null;
            string query = "select manzana_id, parroquia_nombre, manzana_codigo, manzana_nombre, manzana_observacion, manzana_estado " +
                "from catastroestablecimiento.cm_manzana " +
                "join catastroestablecimiento.cm_parroquia " +
                "on catastroestablecimiento.cm_parroquia.parroquia_id = catastroestablecimiento.cm_manzana.parroquia_id " +
                "order by manzana_id asc";
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
            string query = "select manzana_id, parroquia_nombre, manzana_codigo, manzana_nombre, manzana_observacion, manzana_estado " +
                "from catastroestablecimiento.cm_manzana " +
                "join catastroestablecimiento.cm_parroquia " +
                "on catastroestablecimiento.cm_parroquia.parroquia_id = catastroestablecimiento.cm_manzana.parroquia_id where manzana_id = " + id + " order by manzana_id asc";
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

        public DataTable Manzana()
        {
            NpgsqlConnection con = null;
            string query = "select manzana_id, manzana_nombre from catastroestablecimiento.cm_manzana order by manzana_id asc";
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


        public void Insertar(int parroquia, string codigo, string nombre, string observacion, int estado)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query =
                "Insert into catastroestablecimiento.cm_manzana (parroquia_id, manzana_codigo, manzana_nombre, manzana_observacion, manzana_estado) " +
                "values (" + parroquia + ",'" + codigo + "','" + nombre + "','" + observacion + "'," + estado + ")";
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

        public void Editar(int parroquia, string codigo, string nombre, string observacion, int estado, int id)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query = "update catastroestablecimiento.cm_manzana set parroquia_id = " + parroquia + ", manzana_codigo = '" + codigo + "', " +
                "manzana_nombre = '" + nombre + "', manzana_observacion = '" + observacion + "', manzana_estado = " + estado +
                " where manzana_id = " + id + "";
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
                string query = "delete from catastroestablecimiento.cm_manzana where manzana_id = " + id + "";
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
