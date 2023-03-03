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
    public class Cls_Tipo_Area_DAL
    {
        Cls_Conexion_Postgresql_DAL conexion = new Cls_Conexion_Postgresql_DAL();

        private int TIPO_AREA_ID; 
        private string TIPO_AREA_IDENTIFICACION;
        private string TIPO_AREA_NOMBRE;
        private string TIPO_AREA_OBSERVACION;
        private int TIPO_AREA_ESTADO;

        public int TIPO_AREA_ID1 { get => TIPO_AREA_ID; set => TIPO_AREA_ID = value; }
        public string TIPO_AREA_IDENTIFICACION1 { get => TIPO_AREA_IDENTIFICACION; set => TIPO_AREA_IDENTIFICACION = value; }
        public string TIPO_AREA_NOMBRE1 { get => TIPO_AREA_NOMBRE; set => TIPO_AREA_NOMBRE = value; }
        public string TIPO_AREA_OBSERVACION1 { get => TIPO_AREA_OBSERVACION; set => TIPO_AREA_OBSERVACION = value; }
        public int TIPO_AREA_ESTADO1 { get => TIPO_AREA_ESTADO; set => TIPO_AREA_ESTADO = value; }

        public DataTable Consultar()
        {
            NpgsqlConnection con = null;
            string query = "select tipo_area_id, tipo_area_identificacion, tipo_area_nombre, tipo_area_observacion, tipo_area_estado " +
                "from catastroestablecimiento.cm_tipo_area " +
                "order by tipo_area_id asc;";
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
            string query = "select tipo_area_id, tipo_area_identificacion, tipo_area_nombre, tipo_area_observacion, tipo_area_estado " +
                "from catastroestablecimiento.cm_tipo_area " +
                "where tipo_area_id = " + id + " order by tipo_area_id asc;";
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

        public DataTable Tipo_Area()
        {
            NpgsqlConnection con = null;
            string query = "select tipo_area_id, tipo_area_nombre from catastroestablecimiento.cm_tipo_area order by tipo_area_id asc;";
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

        public void Insertar(string identificacion, string nombre, string observaciones, int estado)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query =
                "Insert into catastroestablecimiento.cm_tipo_area (tipo_area_identificacion, tipo_area_nombre, tipo_area_observacion, tipo_area_estado) " +
                "values ('" + identificacion + "','" + nombre + "','" + observaciones + "'," + estado + ")";
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


        public void Editar(string identificacion, string nombre, string observaciones, int estado, int id)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query = "update catastroestablecimiento.cm_tipo_area set " +
                "tipo_area_identificacion = '" + identificacion + "', " +
                "tipo_area_nombre = '" + nombre + "', " +
                "tipo_area_observacion = '" + observaciones + "', " +
                "tipo_area_estado = " + estado +
                " where tipo_area_id = " + id + "";
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
                string query = "delete from catastroestablecimiento.cm_tipo_area where tipo_area_id = " + id + "";
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
