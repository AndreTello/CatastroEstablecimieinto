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
    public class Cls_Discapacidad_DAL
    {

        Cls_Conexion_Postgresql_DAL conexion = new Cls_Conexion_Postgresql_DAL();

        private int DISCAPACIDAD_ID;
        private string DISCAPACIDAD_CARNET;
        private string DISCAPACIDAD_NOMBRE;
        //private decimal DISCAPACIDAD_PORCENTAJE;
        private int DISCAPACIDAD_ESTADO;

        public int DISCAPACIDAD_ID1 { get => DISCAPACIDAD_ID; set => DISCAPACIDAD_ID = value; }
        public string DISCAPACIDAD_CARNET1 { get => DISCAPACIDAD_CARNET; set => DISCAPACIDAD_CARNET = value; }
        public string DISCAPACIDAD_NOMBRE1 { get => DISCAPACIDAD_NOMBRE; set => DISCAPACIDAD_NOMBRE = value; }
        //public decimal DISCAPACIDAD_PORCENTAJE1 { get => DISCAPACIDAD_PORCENTAJE; set => DISCAPACIDAD_PORCENTAJE = value; }
        public int DISCAPACIDAD_ESTADO1 { get => DISCAPACIDAD_ESTADO; set => DISCAPACIDAD_ESTADO = value; }

        public DataTable Consultar()
        {
            NpgsqlConnection con = null;
            string query = "select discapacidad_id, discapacidad_carnet, discapacidad_nombre, discapacidad_estado " +
                "from catastroestablecimiento.cm_discapacidad " +
                "order by discapacidad_id asc;";
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
            string query = "select discapacidad_id, discapacidad_carnet, discapacidad_nombre, discapacidad_estado " +
                "from catastroestablecimiento.cm_discapacidad " +
                "where discapacidad_id = " + id + " order by discapacidad_id asc;";
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

        public DataTable Discapacidad()
        {
            NpgsqlConnection con = null;
            string query = "select discapacidad_id, discapacidad_nombre from catastroestablecimiento.cm_discapacidad order by discapacidad_id asc;";
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

        public void Insertar(string carnet, string nombre, int estado)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query =
                "Insert into catastroestablecimiento.cm_discapacidad (discapacidad_carnet, discapacidad_nombre, discapacidad_estado) " +
                "values ('" + carnet + "','" + nombre + "'," + estado + ")";
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

       
        public void Editar(string carnet, string nombre, int estado, int id)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query = "update catastroestablecimiento.cm_discapacidad set " +
                "discapacidad_carnet = '" + carnet + "', " +
                "discapacidad_nombre = '" + nombre + "', " +
                "discapacidad_estado = " + estado +
                " where discapacidad_id = " + id + "";
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
                string query = "delete from catastroestablecimiento.cm_discapacidad where discapacidad_id = " + id + "";
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
