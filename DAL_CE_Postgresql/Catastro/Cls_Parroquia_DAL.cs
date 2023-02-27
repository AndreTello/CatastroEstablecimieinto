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
    public class Cls_Parroquia_DAL
    {
        Cls_Conexion_Postgresql_DAL conexion = new Cls_Conexion_Postgresql_DAL();

        private int PARROQUIA_ID;
        private int ZONA_ID;
		private string PARROQUIA_CODIGO;
        private string PARROQUIA_NOMBRE;
        private int PARROQUIA_ESTADO;
		private string PARROQUIA_OBSERVACION;

        public int PARROQUIA_ID1 { get => PARROQUIA_ID; set => PARROQUIA_ID = value; }
        public int ZONA_ID1 { get => ZONA_ID; set => ZONA_ID = value; }
        public string PARROQUIA_CODIGO1 { get => PARROQUIA_CODIGO; set => PARROQUIA_CODIGO = value; }
        public string PARROQUIA_NOMBRE1 { get => PARROQUIA_NOMBRE; set => PARROQUIA_NOMBRE = value; }
        public int PARROQUIA_ESTADO1 { get => PARROQUIA_ESTADO; set => PARROQUIA_ESTADO = value; }
        public string PARROQUIA_OBSERVACION1 { get => PARROQUIA_OBSERVACION; set => PARROQUIA_OBSERVACION = value; }

        public DataTable Consultar()
        {
            NpgsqlConnection con = null;
            string query = "select parroquia_id, zona_nombre, parroquia_codigo, parroquia_nombre, parroquia_observacion, parroquia_estado " +
                "from catastroestablecimiento.cm_parroquia " +
                "join catastroestablecimiento.cm_zona " +
                "on catastroestablecimiento.cm_parroquia.zona_id = catastroestablecimiento.cm_zona.zona_id " +
                "order by parroquia_id asc";
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
            string query = "select parroquia_id, zona_nombre, parroquia_codigo, parroquia_nombre, parroquia_observacion, parroquia_estado " +
                "from catastroestablecimiento.cm_parroquia " +
                "join catastroestablecimiento.cm_zona " +
                "on catastroestablecimiento.cm_parroquia.zona_id = catastroestablecimiento.cm_zona.zona_id where parroquia_id = " + id + " order by parroquia_id asc";
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

        public DataTable Parroquia()
        {
            NpgsqlConnection con = null;
            string query = "select parroquia_id, parroquia_nombre from catastroestablecimiento.cm_parroquia order by parroquia_id asc";
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


        public void Insertar(int zona, string codigo, string nombre, string observacion, int estado)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query =
                "Insert into catastroestablecimiento.cm_parroquia (zona_id, parroquia_codigo, parroquia_nombre, parroquia_observacion, parroquia_estado) " +
                "values (" + zona + ",'" + codigo + "','" + nombre + "','" + observacion + "'," + estado + ")";
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

        public void Editar(int zona, string codigo, string nombre, string observacion, int estado, int id)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query = "update catastroestablecimiento.cm_parroquia set zona_id = " + zona + ", parroquia_codigo = '" + codigo + "', " +
                "parroquia_nombre = '" + nombre + "', parroquia_observacion = '" + observacion + "', parroquia_estado = " + estado +
                " where parroquia_id = " + id + "";
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
                string query = "delete from catastroestablecimiento.cm_parroquia where parroquia_id = " + id + "";
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
