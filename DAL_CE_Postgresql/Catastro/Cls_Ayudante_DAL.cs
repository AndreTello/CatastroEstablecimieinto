using Npgsql;
using Npgsql.Internal.TypeHandlers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL_CE_Postgresql.Catastro
{
    public class Cls_Ayudante_DAL
    {
        Cls_Conexion_Postgresql_DAL conexion = new Cls_Conexion_Postgresql_DAL();

        private int AYUDANTE_ID;
        private string AYUDANTE_CEDULA;
        private string AYUDANTE_APELLIDOS;
        private string AYUDANTE_NOMBRES;
        private string AYUDANTE_PARENTEZCO;
        private string AYUDANTE_AUTORIZACION;
        private string AYUDANTE_NUMERO_OFICIO;
        //private byte [] AYUDANTE_OFICIO_ARCHIVO;
		private DateTime AYUDANTE_FECHA_OFICIO;
        private int AYUDANTE_ESTADO;

        public int AYUDANTE_ID1 { get => AYUDANTE_ID; set => AYUDANTE_ID = value; }
        public string AYUDANTE_CEDULA1 { get => AYUDANTE_CEDULA; set => AYUDANTE_CEDULA = value; }
        public string AYUDANTE_APELLIDOS1 { get => AYUDANTE_APELLIDOS; set => AYUDANTE_APELLIDOS = value; }
        public string AYUDANTE_NOMBRES1 { get => AYUDANTE_NOMBRES; set => AYUDANTE_NOMBRES = value; }
        public string AYUDANTE_PARENTEZCO1 { get => AYUDANTE_PARENTEZCO; set => AYUDANTE_PARENTEZCO = value; }
        public string AYUDANTE_AUTORIZACION1 { get => AYUDANTE_AUTORIZACION; set => AYUDANTE_AUTORIZACION = value; }
        public string AYUDANTE_NUMERO_OFICIO1 { get => AYUDANTE_NUMERO_OFICIO; set => AYUDANTE_NUMERO_OFICIO = value; }
        //public byte[] AYUDANTE_OFICIO_ARCHIVO1 { get => AYUDANTE_OFICIO_ARCHIVO; set => AYUDANTE_OFICIO_ARCHIVO = value; }
        public DateTime AYUDANTE_FECHA_OFICIO1 { get => AYUDANTE_FECHA_OFICIO; set => AYUDANTE_FECHA_OFICIO = value; }
        public int AYUDANTE_ESTADO1 { get => AYUDANTE_ESTADO; set => AYUDANTE_ESTADO = value; }

        public DataTable Consultar()
        {
            NpgsqlConnection con = null;
            string query = "select ayudante_id, ayudante_cedula, ayudante_apellidos, ayudante_nombres, ayudante_parentezco, ayudante_autorizacion, ayudante_numero_oficio, ayudante_fecha_oficio, ayudante_estado " +
                "from catastroestablecimiento.cm_ayudante " +
                "order by ayudante_id asc";
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
            string query = "select ayudante_id, ayudante_cedula, ayudante_apellidos, ayudante_nombres, ayudante_parentezco, ayudante_autorizacion, ayudante_numero_oficio, ayudante_fecha_oficio, ayudante_estado " +
                "from catastroestablecimiento.cm_ayudante where ayudante_id = " + id + " order by ayudante_id asc"; 
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

        public DataTable Ayudante()
        {
            NpgsqlConnection con = null;
            string query = "select ayudante_id, ayudante_nombres from catastroestablecimiento.cm_ayudante order by ayudante_id asc";
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

         
        public void Insertar(string cedula, string apellidos, string nombres, string parentezco, string autorizacion, string numero, string fecha, int estado)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query =
                "Insert into catastroestablecimiento.cm_ayudante (ayudante_cedula, ayudante_apellidos, ayudante_nombres, ayudante_parentezco, ayudante_autorizacion, ayudante_numero_oficio, ayudante_fecha_oficio, ayudante_estado) " +
                "values ('" + cedula + "','" + apellidos + "','" + nombres + "','" + parentezco + "','" + autorizacion + "','" + numero + "','" + fecha + "'," + estado + ")";
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

        public void Editar(string cedula, string apellidos, string nombres, string parentezco, string autorizacion, string numero, string fecha, int estado, int id)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query =
                "update catastroestablecimiento.cm_ayudante set " +
                "ayudante_cedula = '" + cedula + "', " +
                "ayudante_apellidos = '" + apellidos + "', " +
                "ayudante_nombres = '" + nombres + "', " +
                "ayudante_parentezco = '" + parentezco + "', " +
                "ayudante_autorizacion = '" + autorizacion + "', " +
                "ayudante_numero_oficio = '" + numero + "', " +
                "ayudante_fecha_oficio = '" + fecha + "', " +
                "ayudante_estado = " + estado + " " +
                "where ayudante_id = " + id + "";
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
                string query = "delete from catastroestablecimiento.cm_ayudante where ayudante_id = " + id + "";
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
