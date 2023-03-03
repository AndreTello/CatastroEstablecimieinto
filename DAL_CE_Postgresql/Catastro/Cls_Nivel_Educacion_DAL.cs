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
    public class Cls_Nivel_Educacion_DAL
    {

        Cls_Conexion_Postgresql_DAL conexion = new Cls_Conexion_Postgresql_DAL();

        private int NIVEL_EDUCACION_ID;
        private string NIVEL_EDUCACION_NOMBRE;
        private string NIVEL_EDUCACION_DETALLE;
		private int NIVEL_EDUCACION_ESTADO;

        public int NIVEL_EDUCACION_ID1 { get => NIVEL_EDUCACION_ID; set => NIVEL_EDUCACION_ID = value; }
        public string NIVEL_EDUCACION_NOMBRE1 { get => NIVEL_EDUCACION_NOMBRE; set => NIVEL_EDUCACION_NOMBRE = value; }
        public string NIVEL_EDUCACION_DETALLE1 { get => NIVEL_EDUCACION_DETALLE; set => NIVEL_EDUCACION_DETALLE = value; }
        public int NIVEL_EDUCACION_ESTADO1 { get => NIVEL_EDUCACION_ESTADO; set => NIVEL_EDUCACION_ESTADO = value; }

        public DataTable Consultar()
        {
            NpgsqlConnection con = null;
            string query = "select nivel_educacion_id, nivel_educacion_nombre, nivel_educacion_detalle, nivel_educacion_estado " +
                "from catastroestablecimiento.cm_nivel_educacion " +
                "order by nivel_educacion_id asc;";
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
            string query = "select nivel_educacion_id, nivel_educacion_nombre, nivel_educacion_detalle, nivel_educacion_estado " +
                "from catastroestablecimiento.cm_nivel_educacion " +
                "where nivel_educacion_id = " + id + " order by nivel_educacion_id asc;";
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

        public DataTable Nivel_Educacion()
        {
            NpgsqlConnection con = null;
            string query = "select nivel_educacion_id, nivel_educacion_nombre from catastroestablecimiento.cm_nivel_educacion order by nivel_educacion_id asc;";
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
                "Insert into catastroestablecimiento.cm_nivel_educacion (nivel_educacion_nombre, nivel_educacion_detalle, nivel_educacion_estado) " +
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
                string query = "update catastroestablecimiento.cm_nivel_educacion set " +
                "nivel_educacion_nombre = '" + nombre + "', " +
                "nivel_educacion_detalle = '" + detalle + "', " +
                "nivel_educacion_estado = " + estado +
                " where nivel_educacion_id = " + id + "";
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
                string query = "delete from catastroestablecimiento.cm_nivel_educacion where nivel_educacion_id = " + id + "";
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
