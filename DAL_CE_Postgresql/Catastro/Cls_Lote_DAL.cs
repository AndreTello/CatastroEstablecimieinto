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
    public class Cls_Lote_DAL
    {
        Cls_Conexion_Postgresql_DAL conexion = new Cls_Conexion_Postgresql_DAL();

        private int LOTE_ID;
        private int MANZANA_ID;
	    private string LOTE_CODIGO;
        private string LOTE_NOMBRE;
        private int LOTE_ESTADO;
		private string LOTE_OBSERVACION;

        public int LOTE_ID1 { get => LOTE_ID; set => LOTE_ID = value; }
        public int MANZANA_ID1 { get => MANZANA_ID; set => MANZANA_ID = value; }
        public string LOTE_CODIGO1 { get => LOTE_CODIGO; set => LOTE_CODIGO = value; }
        public string LOTE_NOMBRE1 { get => LOTE_NOMBRE; set => LOTE_NOMBRE = value; }
        public int LOTE_ESTADO1 { get => LOTE_ESTADO; set => LOTE_ESTADO = value; }
        public string LOTE_OBSERVACION1 { get => LOTE_OBSERVACION; set => LOTE_OBSERVACION = value; }

        public DataTable Consultar()
        {
            NpgsqlConnection con = null;
            string query = "select lote_id, manzana_nombre, lote_codigo, lote_nombre, lote_observacion, lote_estado " +
                "from catastroestablecimiento.cm_lote " +
                "join catastroestablecimiento.cm_manzana " +
                "on catastroestablecimiento.cm_manzana.manzana_id = catastroestablecimiento.cm_lote.manzana_id " +
                "order by lote_id asc";
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
            string query = "select lote_id, manzana_nombre, lote_codigo, lote_nombre, lote_observacion, lote_estado " +
                "from catastroestablecimiento.cm_lote " +
                "join catastroestablecimiento.cm_manzana " +
                "on catastroestablecimiento.cm_manzana.manzana_id = catastroestablecimiento.cm_lote.manzana_id where lote_id = " + id + " order by lote_id asc";
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

        public DataTable Lote()
        {
            NpgsqlConnection con = null;
            string query = "select lote_id, lote_nombre from catastroestablecimiento.cm_lote order by lote_id asc";
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

        public void Insertar(int manzana, string codigo, string nombre, string observacion, int estado)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query =
                "Insert into catastroestablecimiento.cm_lote (manzana_id, lote_codigo, lote_nombre, lote_observacion, lote_estado) " +
                "values (" + manzana + ",'" + codigo + "','" + nombre + "','" + observacion + "'," + estado + ")";
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

        public void Editar(int manzana, string codigo, string nombre, string observacion, int estado, int id)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query = "update catastroestablecimiento.cm_lote set manzana_id = " + manzana + ", lote_codigo = '" + codigo + "', " +
                "lote_nombre = '" + nombre + "', lote_observacion = '" + observacion + "', lote_estado = " + estado +
                " where lote_id = " + id + "";
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
                string query = "delete from catastroestablecimiento.cm_lote where lote_id = " + id + "";
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
