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
    public class Cls_Nacionalidad_DAL
    {
        Cls_Conexion_Postgresql_DAL conexion = new Cls_Conexion_Postgresql_DAL();

        private int NACIONALIDAD_ID;
        private string NACIONALIDAD_CODIGO;
        private string NACIONALIDAD_NOMBRE;
        private string NACIONALIDAD_DETALLE;
        private int NACIONALIDAD_ESTADO;

        public int NACIONALIDAD_ID1 { get => NACIONALIDAD_ID; set => NACIONALIDAD_ID = value; }
        public string NACIONALIDAD_CODIGO1 { get => NACIONALIDAD_CODIGO; set => NACIONALIDAD_CODIGO = value; }
        public string NACIONALIDAD_NOMBRE1 { get => NACIONALIDAD_NOMBRE; set => NACIONALIDAD_NOMBRE = value; }
        public string NACIONALIDAD_DETALLE1 { get => NACIONALIDAD_DETALLE; set => NACIONALIDAD_DETALLE = value; }
        public int NACIONALIDAD_ESTADO1 { get => NACIONALIDAD_ESTADO; set => NACIONALIDAD_ESTADO = value; }

        public DataTable Consultar()
        {
            NpgsqlConnection con = null;
            string query = "select nacionalidad_id, nacionalidad_codigo, nacionalidad_nombre, nacionalidad_detalle, nacionalidad_estado " +
                "from catastroestablecimiento.cm_nacionalidad " +
                "order by nacionalidad_id asc;";
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
            string query = "select nacionalidad_id, nacionalidad_codigo, nacionalidad_nombre, nacionalidad_detalle, nacionalidad_estado " +
                "from catastroestablecimiento.cm_nacionalidad " +
                "where nacionalidad_id = " + id + " order by nacionalidad_id asc;";
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

        public DataTable Nacionalidad()
        {
            NpgsqlConnection con = null;
            string query = "select nacionalidad_id, nacionalidad_nombre from catastroestablecimiento.cm_nacionalidad order by nacionalidad_id asc;";
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

        public void Insertar(string codigo, string nombre, string detalle, int estado)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query =
                "Insert into catastroestablecimiento.cm_nacionalidad (nacionalidad_codigo, nacionalidad_nombre, nacionalidad_detalle, nacionalidad_estado) " +
                "values ('" + codigo + "','" + nombre + "','" + detalle + "'," + estado + ")";
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


        public void Editar(string codigo, string nombre, string detalle, int estado, int id)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query = "update catastroestablecimiento.cm_nacionalidad set " +
                "nacionalidad_codigo = '" + codigo + "', " +
                "nacionalidad_nombre = '" + nombre + "', " +
                "nacionalidad_detalle = '" + detalle + "', " +
                "nacionalidad_estado = " + estado +
                " where nacionalidad_id = " + id + "";
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
                string query = "delete from catastroestablecimiento.cm_nacionalidad where nacionalidad_id = " + id + "";
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
