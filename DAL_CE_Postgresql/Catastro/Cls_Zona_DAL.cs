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
    public class Cls_Zona_DAL
    {
        Cls_Conexion_Postgresql_DAL conexion = new Cls_Conexion_Postgresql_DAL();

        private int ZONA_ID;
        private int CANTON_ID;
		private string ZONA_CODIGO;
        private string ZONA_NOMBRE;
        private int ZONA_ESTADO;
		private string ZONA_OBSERVACION;

        public int ZONA_ID1 { get => ZONA_ID; set => ZONA_ID = value; }
        public int CANTON_ID1 { get => CANTON_ID; set => CANTON_ID = value; }
        public string ZONA_CODIGO1 { get => ZONA_CODIGO; set => ZONA_CODIGO = value; }
        public string ZONA_NOMBRE1 { get => ZONA_NOMBRE; set => ZONA_NOMBRE = value; }
        public int ZONA_ESTADO1 { get => ZONA_ESTADO; set => ZONA_ESTADO = value; }
        public string ZONA_OBSERVACION1 { get => ZONA_OBSERVACION; set => ZONA_OBSERVACION = value; }

        public DataTable Consultar()
        {
            NpgsqlConnection con = null;
            string query = "select zona_id, canton_nombre, zona_codigo, zona_nombre, zona_observacion, zona_estado " +
                "from catastroestablecimiento.cm_zona " +
                "join catastroestablecimiento.cm_canton " +
                "on catastroestablecimiento.cm_zona.canton_id = catastroestablecimiento.cm_canton.canton_id " +
                "order by zona_id asc";
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
            string query = "select zona_id, canton_nombre, zona_codigo, zona_nombre, zona_observacion, zona_estado " +
                "from catastroestablecimiento.cm_zona " +
                "join catastroestablecimiento.cm_canton " +
                "on catastroestablecimiento.cm_zona.canton_id = catastroestablecimiento.cm_canton.canton_id where zona_id = " + id + " order by zona_id asc";
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

        public DataTable Zona()
        {
            NpgsqlConnection con = null;
            string query = "select zona_id, zona_nombre from catastroestablecimiento.cm_zona order by zona_id asc";
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


        public void Insertar(int canton, string codigo, string nombre, string observacion, int estado)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query =
                "Insert into catastroestablecimiento.cm_zona (canton_id, zona_codigo, zona_nombre, zona_observacion, zona_estado) " +
                "values (" + canton + ",'" + codigo + "','" + nombre + "','" + observacion + "'," + estado + ")";
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

        public void Editar(int canton, string codigo, string nombre, string observacion, int estado, int id)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query = "update catastroestablecimiento.cm_zona set canton_id = " + canton + ", zona_codigo = '" + codigo + "', " +
                "zona_nombre = '" + nombre + "', zona_observacion = '" + observacion + "', zona_estado = " + estado +
                " where zona_id = " + id + "";
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
                string query = "delete from catastroestablecimiento.cm_zona where zona_id = " + id + "";
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
