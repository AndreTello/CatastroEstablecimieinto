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
    public class Cls_Asociacion_DAL
    {
        Cls_Conexion_Postgresql_DAL conexion = new Cls_Conexion_Postgresql_DAL();

        private int ASOCIACION_ID;
        private string ASOCIACION_CODIGO;
        private string ASOCIACION_NOMBRE;
        private string ASOCIACION_TELEFONO;
        private string ASOCIACION_MAIL;
        private string ASOCIACION_CONTACTO;
        private int ASOCIACION_ESTADO;
        private string ASOCIACION_OBSERVACION;

        public int ASOCIACION_ID1 { get => ASOCIACION_ID; set => ASOCIACION_ID = value; }
        public string ASOCIACION_CODIGO1 { get => ASOCIACION_CODIGO; set => ASOCIACION_CODIGO = value; }
        public string ASOCIACION_NOMBRE1 { get => ASOCIACION_NOMBRE; set => ASOCIACION_NOMBRE = value; }
        public string ASOCIACION_TELEFONO1 { get => ASOCIACION_TELEFONO; set => ASOCIACION_TELEFONO = value; }
        public string ASOCIACION_MAIL1 { get => ASOCIACION_MAIL; set => ASOCIACION_MAIL = value; }
        public string ASOCIACION_CONTACTO1 { get => ASOCIACION_CONTACTO; set => ASOCIACION_CONTACTO = value; }
        public int ASOCIACION_ESTADO1 { get => ASOCIACION_ESTADO; set => ASOCIACION_ESTADO = value; }
        public string ASOCIACION_OBSERVACION1 { get => ASOCIACION_OBSERVACION; set => ASOCIACION_OBSERVACION = value; }

        public DataTable Consultar()
        {
            NpgsqlConnection con = null;
            string query = "select asociacion_id, asociacion_codigo, asociacion_nombre, asociacion_telefono, asociacion_mail, asociacion_contacto, asociacion_observacion, asociacion_estado " +
                "from catastroestablecimiento.cm_asociacion " +
                "order by asociacion_id asc;";
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
            string query = "select asociacion_id, asociacion_codigo, asociacion_nombre, asociacion_telefono, asociacion_mail, asociacion_contacto, asociacion_observacion, asociacion_estado " +
                "from catastroestablecimiento.cm_asociacion where asociacion_id = " + id + " order by asociacion_id asc;";
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

        public DataTable Asociacion()
        {
            NpgsqlConnection con = null;
            string query = "select asociacion_id, asociacion_nombre from catastroestablecimiento.cm_asociacion order by asociacion_id asc";
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


        public void Insertar(string codigo, string nombre, string telefono, string mail, string contacto, string observacion, int estado)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query =
                "Insert into catastroestablecimiento.cm_asociacion (asociacion_codigo, asociacion_nombre, asociacion_telefono, asociacion_mail, asociacion_contacto, asociacion_observacion, asociacion_estado) " +
                "values ('" + codigo + "','" + nombre + "','" + telefono + "','" + mail + "','" + contacto + "','" + observacion + "'," + estado + ")";
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

        public void Editar(string codigo, string nombre, string telefono, string mail, string contacto, string observacion, int estado, int id)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query =
                "update catastroestablecimiento.cm_asociacion set asociacion_codigo = '" + codigo + "', asociacion_nombre = '" + nombre + "', " +
                "asociacion_telefono = '" + telefono + "', asociacion_mail = '" + mail + "', asociacion_contacto = '" + contacto + "', " +
                "asociacion_observacion = '" + observacion + "', asociacion_estado = " + estado + " " +
                "where asociacion_id = " + id + "";
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
                string query = "delete from catastroestablecimiento.cm_asociacion where asociacion_id = " + id + "";
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
