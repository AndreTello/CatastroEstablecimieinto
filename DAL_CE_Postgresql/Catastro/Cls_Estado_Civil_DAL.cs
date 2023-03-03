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
    public class Cls_Estado_Civil_DAL
    {
        Cls_Conexion_Postgresql_DAL conexion = new Cls_Conexion_Postgresql_DAL();

        private int ESTADO_CIVIL_ID;
        private string ESTADO_CIVIL_NOMBRE;
        private string ESTADO_CIVIL_DETALLE;
        private int ESTADO_CIVIL_ESTADO;

        public int ESTADO_CIVIL_ID1 { get => ESTADO_CIVIL_ID; set => ESTADO_CIVIL_ID = value; }
        public string ESTADO_CIVIL_NOMBRE1 { get => ESTADO_CIVIL_NOMBRE; set => ESTADO_CIVIL_NOMBRE = value; }
        public string ESTADO_CIVIL_DETALLE1 { get => ESTADO_CIVIL_DETALLE; set => ESTADO_CIVIL_DETALLE = value; }
        public int ESTADO_CIVIL_ESTADO1 { get => ESTADO_CIVIL_ESTADO; set => ESTADO_CIVIL_ESTADO = value; }

        public DataTable Consultar()
        {
            NpgsqlConnection con = null;
            string query = "select estado_civil_id, estado_civil_nombre, estado_civil_detalle, estado_civil_estado " +
                "from catastroestablecimiento.cm_estado_civil " +
                "order by estado_civil_id asc;";
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
            string query = "select estado_civil_id, estado_civil_nombre, estado_civil_detalle, estado_civil_estado " +
                "from catastroestablecimiento.cm_estado_civil " +
                "where estado_civil_id = " + id + " order by estado_civil_id asc;";
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

        public DataTable EstadoCivil()
        {
            NpgsqlConnection con = null;
            string query = "select estado_civil_id, estado_civil_nombre from catastroestablecimiento.cm_estado_civil order by estado_civil_id asc;";
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
                "Insert into catastroestablecimiento.cm_estado_civil (estado_civil_nombre, estado_civil_detalle, estado_civil_estado) " +
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
                string query = "update catastroestablecimiento.cm_estado_civil set " +
                "estado_civil_nombre = '" + nombre + "', " +
                "estado_civil_detalle = '" + detalle + "', " +
                "estado_civil_estado = " + estado +
                " where estado_civil_id = " + id + "";
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
                string query = "delete from catastroestablecimiento.cm_estado_civil where estado_civil_id = " + id + "";
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
