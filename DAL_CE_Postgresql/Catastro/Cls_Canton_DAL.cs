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
    public class Cls_Canton_DAL
    {
        Cls_Conexion_Postgresql_DAL conexion = new Cls_Conexion_Postgresql_DAL();

        private int CANTON_ID;
        private int PROVINCIA_ID;
        private string CANTON_CODIGO;
        private string CANTON_NOMBRE;
        private int CANTON_ESTADO;
        private string CANTON_OBSERVACION;

        public int CANTON_ID1 { get => CANTON_ID; set => CANTON_ID = value; }
        public int PROVINCIA_ID1 { get => PROVINCIA_ID; set => PROVINCIA_ID = value; }
        public string CANTON_CODIGO1 { get => CANTON_CODIGO; set => CANTON_CODIGO = value; }
        public string CANTON_NOMBRE1 { get => CANTON_NOMBRE; set => CANTON_NOMBRE = value; }
        public int CANTON_ESTADO1 { get => CANTON_ESTADO; set => CANTON_ESTADO = value; }
        public string CANTON_OBSERVACION1 { get => CANTON_OBSERVACION; set => CANTON_OBSERVACION = value; }

        public DataTable Consultar()
        {
            NpgsqlConnection con = null;
            string query = "select canton_id, provincia_nombre, canton_codigo, canton_nombre, canton_observacion, canton_estado " +
                "from catastroestablecimiento.cm_canton " +
                "join catastroestablecimiento.cm_provincia " +
                "on catastroestablecimiento.cm_canton.provincia_id = catastroestablecimiento.cm_provincia.provincia_id " +
                "order by canton_id asc";
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
            string query = "select canton_id, provincia_nombre, canton_codigo, canton_nombre, canton_observacion, canton_estado " +
                "from catastroestablecimiento.cm_canton " +
                "join catastroestablecimiento.cm_provincia " +
                "on catastroestablecimiento.cm_canton.provincia_id = catastroestablecimiento.cm_provincia.provincia_id where canton_id = " + id + " order by canton_id asc";
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

        public DataTable Canton()
        {
            NpgsqlConnection con = null;
            string query = "select canton_id, canton_nombre from catastroestablecimiento.cm_canton order by canton_id asc";
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


        public void Insertar(int provincia, string codigo, string nombre, string observacion, int estado)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query =
                "Insert into catastroestablecimiento.cm_canton (provincia_id, canton_codigo, canton_nombre, canton_observacion, canton_estado) " +
                "values (" + provincia + ",'" + codigo + "','" + nombre + "','" + observacion + "'," + estado + ")";
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

        public void Editar(int provincia, string codigo, string nombre, string observacion, int estado, int id)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query = "update catastroestablecimiento.cm_canton set provincia_id = " + provincia + ", canton_codigo = '" + codigo + "', " +
                "canton_nombre = '" + nombre + "', canton_observacion = '" + observacion + "', canton_estado = " + estado +
                " where canton_id = " + id + "";
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
                string query = "delete from catastroestablecimiento.cm_canton where canton_id = " + id + "";
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
