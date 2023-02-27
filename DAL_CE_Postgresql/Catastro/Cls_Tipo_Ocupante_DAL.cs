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
    public class Cls_Tipo_Ocupante_DAL
    {

        Cls_Conexion_Postgresql_DAL conexion = new Cls_Conexion_Postgresql_DAL();

        private int TIPO_OCUPANTE_ID;
        private string TIPO_OCUPANTE_NOMBRE;
        private string TIPO_OCUPANTE_DETALLE;
		private int TIPO_OCUPANTE_ESTADO;

        public int TIPO_OCUPANTE_ID1 { get => TIPO_OCUPANTE_ID; set => TIPO_OCUPANTE_ID = value; }
        public string TIPO_OCUPANTE_NOMBRE1 { get => TIPO_OCUPANTE_NOMBRE; set => TIPO_OCUPANTE_NOMBRE = value; }
        public string TIPO_OCUPANTE_DETALLE1 { get => TIPO_OCUPANTE_DETALLE; set => TIPO_OCUPANTE_DETALLE = value; }
        public int TIPO_OCUPANTE_ESTADO1 { get => TIPO_OCUPANTE_ESTADO; set => TIPO_OCUPANTE_ESTADO = value; }

        public DataTable Consultar()
        {
            NpgsqlConnection con = null;
            string query = "select tipo_ocupante_id, tipo_ocupante_nombre, tipo_ocupante_detalle, tipo_ocupante_estado " +
                "from catastroestablecimiento.cm_tipo_ocupante " +
                "order by tipo_ocupante_id asc;";
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
            string query = "select tipo_ocupante_id, tipo_ocupante_nombre, tipo_ocupante_detalle, tipo_ocupante_estado " +
                "from catastroestablecimiento.cm_tipo_ocupante where tipo_ocupante_id = " + id + " order by tipo_ocupante_id asc;";
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

        public DataTable Tipo_Ocupante()
        {
            NpgsqlConnection con = null;
            string query = "select tipo_ocupante_id, tipo_ocupante_nombre from catastroestablecimiento.cm_tipo_ocupante order by tipo_ocupante_id asc";
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
                "Insert into catastroestablecimiento.cm_tipo_ocupante (tipo_ocupante_nombre, tipo_ocupante_detalle, tipo_ocupante_estado) " +
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
                "update catastroestablecimiento.cm_tipo_ocupante set tipo_ocupante_nombre = '" + nombre + "', tipo_ocupante_detalle = '" + detalle + "', " +
                "tipo_ocupante_estado = " + estado + " " +
                "where tipo_ocupante_id = " + id + "";
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
                string query = "delete from catastroestablecimiento.cm_tipo_ocupante where tipo_ocupante_id = " + id + "";
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
