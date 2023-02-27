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
    public class Cls_Tipo_Identificacion_DAL
    {
        Cls_Conexion_Postgresql_DAL conexion = new Cls_Conexion_Postgresql_DAL();

        private int TIPO_IDENTIFICACION_ID;
        private string TIPO_IDENTIFICACION_NOMBRE;
        private string TIPO_IDENTIFICACION_DETALLE;
        private int TIPO_IDENTIFICACION_ESTADO;

        public int TIPO_IDENTIFICACION_ID1 { get => TIPO_IDENTIFICACION_ID; set => TIPO_IDENTIFICACION_ID = value; }
        public string TIPO_IDENTIFICACION_NOMBRE1 { get => TIPO_IDENTIFICACION_NOMBRE; set => TIPO_IDENTIFICACION_NOMBRE = value; }
        public string TIPO_IDENTIFICACION_DETALLE1 { get => TIPO_IDENTIFICACION_DETALLE; set => TIPO_IDENTIFICACION_DETALLE = value; }
        public int TIPO_IDENTIFICACION_ESTADO1 { get => TIPO_IDENTIFICACION_ESTADO; set => TIPO_IDENTIFICACION_ESTADO = value; }

        public DataTable Consultar()
        {
            NpgsqlConnection con = null;
            string query = "select tipo_identificacion_id, tipo_identificacion_nombre, tipo_identificacion_detalle, tipo_identificacion_estado " +
                "from catastroestablecimiento.cm_tipo_identificacion " +
                "order by tipo_identificacion_id asc;";
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
            string query = "select tipo_identificacion_id, tipo_identificacion_nombre, tipo_identificacion_detalle, tipo_identificacion_estado " +
                "from catastroestablecimiento.cm_tipo_identificacion where tipo_identificacion_id = " + id + " order by tipo_identificacion_id asc;";
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

        public DataTable Tipo_Identificacion()
        {
            NpgsqlConnection con = null;
            string query = "select tipo_identificacion_id, tipo_identificacion_nombre from catastroestablecimiento.cm_tipo_identificacion order by tipo_identificacion_id asc";
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
                "Insert into catastroestablecimiento.cm_tipo_identificacion (tipo_identificacion_nombre, tipo_identificacion_detalle, tipo_identificacion_estado) " +
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
                "update catastroestablecimiento.cm_tipo_identificacion set tipo_identificacion_nombre = '" + nombre + "', tipo_identificacion_detalle = '" + detalle + "', " +
                "tipo_identificacion_estado = " + estado + " " +
                "where tipo_identificacion_id = " + id + "";
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
                string query = "delete from catastroestablecimiento.cm_tipo_identificacion where tipo_identificacion_id = " + id + "";
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
