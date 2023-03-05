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
    public class Cls_Reemplazo_DAL
    {
        Cls_Conexion_Postgresql_DAL conexion = new Cls_Conexion_Postgresql_DAL();

        private int REEMPLAZO_ID;
        private string REEMPLAZO_CEDULA;
        private string REEMPLAZO_APELLIDOS;
        private string REEMPLAZO_NOMBRES;
        private string REEMPLAZO_AUTORIZACION;
        private string REEMPLAZO_NUMERO_OFICIO;
        //private int REEMPLAZO_OFICIO_ARCHIVO;
		private DateTime REEMPLAZO_FECHA_INICIO;
        private DateTime REEMPLAZO_FECHA_FIN;
        private int REEMPLAZO_ESTADO;

        public int REEMPLAZO_ID1 { get => REEMPLAZO_ID; set => REEMPLAZO_ID = value; }
        public string REEMPLAZO_CEDULA1 { get => REEMPLAZO_CEDULA; set => REEMPLAZO_CEDULA = value; }
        public string REEMPLAZO_APELLIDOS1 { get => REEMPLAZO_APELLIDOS; set => REEMPLAZO_APELLIDOS = value; }
        public string REEMPLAZO_NOMBRES1 { get => REEMPLAZO_NOMBRES; set => REEMPLAZO_NOMBRES = value; }
        public string REEMPLAZO_AUTORIZACION1 { get => REEMPLAZO_AUTORIZACION; set => REEMPLAZO_AUTORIZACION = value; }
        public string REEMPLAZO_NUMERO_OFICIO1 { get => REEMPLAZO_NUMERO_OFICIO; set => REEMPLAZO_NUMERO_OFICIO = value; }
        //public int REEMPLAZO_OFICIO_ARCHIVO1 { get => REEMPLAZO_OFICIO_ARCHIVO; set => REEMPLAZO_OFICIO_ARCHIVO = value; }
        public DateTime REEMPLAZO_FECHA_INICIO1 { get => REEMPLAZO_FECHA_INICIO; set => REEMPLAZO_FECHA_INICIO = value; }
        public DateTime REEMPLAZO_FECHA_FIN1 { get => REEMPLAZO_FECHA_FIN; set => REEMPLAZO_FECHA_FIN = value; }
        public int REEMPLAZO_ESTADO1 { get => REEMPLAZO_ESTADO; set => REEMPLAZO_ESTADO = value; }

        public DataTable Consultar()
        {
            NpgsqlConnection con = null;
            string query = "select reemplazo_id, reemplazo_cedula, reemplazo_apellidos, reemplazo_nombres, reemplazo_autorizacion, reemplazo_numero_oficio, reemplazo_fecha_inicio, reemplazo_fecha_fin, reemplazo_estado " +
                "from catastroestablecimiento.cm_reemplazo " +
                "order by reemplazo_id asc";
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
            string query = "select reemplazo_id, reemplazo_cedula, reemplazo_apellidos, reemplazo_nombres, reemplazo_autorizacion, reemplazo_numero_oficio, reemplazo_fecha_inicio, reemplazo_fecha_fin, reemplazo_estado " +
                "from catastroestablecimiento.cm_reemplazo where reemplazo_id = " + id + " order by reemplazo_id asc";
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

        public DataTable Reemplazo()
        {
            NpgsqlConnection con = null;
            string query = "select reemplazo_id, reemplazo_nombres from catastroestablecimiento.cm_reemplazo order by reemplazo_id asc";
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


        public void Insertar(string cedula, string apellidos, string nombres, string autorizacion, string numero, string fechainicio, string fechafin, int estado)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query =
                "Insert into catastroestablecimiento.cm_reemplazo (reemplazo_cedula, reemplazo_apellidos, reemplazo_nombres, reemplazo_autorizacion, reemplazo_numero_oficio, reemplazo_fecha_inicio, reemplazo_fecha_fin, reemplazo_estado) " +
                "values ('" + cedula + "','" + apellidos + "','" + nombres + "','" + autorizacion + "','" + numero + "','" + fechainicio + "','" + fechafin + "'," + estado + ")";
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

        public void Editar(string cedula, string apellidos, string nombres, string autorizacion, string numero, DateTime fechainicio, DateTime fechafin, int estado, int id)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query =
                "update catastroestablecimiento.cm_reemplazo set " +
                "reemplazo_cedula = '" + cedula + "', " +
                "reemplazo_apellidos = '" + apellidos + "', " +
                "reemplazo_nombres = '" + nombres + "', " +
                "reemplazo_autorizacion = '" + autorizacion + "', " +
                "reemplazo_numero_oficio = '" + numero + "', " +
                "reemplazo_fecha_inicio = '" + fechainicio + "', " +
                "reemplazo_fecha_fin = '" + fechafin + "', " +
                "reemplazo_estado = " + estado + " " +
                "where reemplazo_id = " + id + "";
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
                string query = "delete from catastroestablecimiento.cm_reemplazo where reemplazo_id = " + id + "";
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
