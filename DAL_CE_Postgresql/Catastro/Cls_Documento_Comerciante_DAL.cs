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
    public class Cls_Documento_Comerciante_DAL
    {
        Cls_Conexion_Postgresql_DAL conexion = new Cls_Conexion_Postgresql_DAL();

        private int DOCUMENTO_COMERCIANTE_ID;
        private int TIPO_DOCUMENTO_COMERCIANTE_ID;
		private int COMERCIANTE_ID;
        private string DOCUMENTO_COMERCIANTE_NOMBRE;
        private DateTime DOCUMENTO_COMERCIANTE_FECHA;
        //private int DOCUMENTO_COMERCIANTE_ARCHIVO; //bytea
        private string DOCUMENTO_COMERCIANTE_DETALLE;
        private string DOCUMENTO_COMERCIANTE_OBSERVACION;
        private int DOCUMENTO_COMERCIANTE_ESTADO;

        public int DOCUMENTO_COMERCIANTE_ID1 { get => DOCUMENTO_COMERCIANTE_ID; set => DOCUMENTO_COMERCIANTE_ID = value; }
        public int TIPO_DOCUMENTO_COMERCIANTE_ID1 { get => TIPO_DOCUMENTO_COMERCIANTE_ID; set => TIPO_DOCUMENTO_COMERCIANTE_ID = value; }
        public int COMERCIANTE_ID1 { get => COMERCIANTE_ID; set => COMERCIANTE_ID = value; }
        public string DOCUMENTO_COMERCIANTE_NOMBRE1 { get => DOCUMENTO_COMERCIANTE_NOMBRE; set => DOCUMENTO_COMERCIANTE_NOMBRE = value; }
        public DateTime DOCUMENTO_COMERCIANTE_FECHA1 { get => DOCUMENTO_COMERCIANTE_FECHA; set => DOCUMENTO_COMERCIANTE_FECHA = value; }
       // public int DOCUMENTO_COMERCIANTE_ARCHIVO1 { get => DOCUMENTO_COMERCIANTE_ARCHIVO; set => DOCUMENTO_COMERCIANTE_ARCHIVO = value; }
        public string DOCUMENTO_COMERCIANTE_DETALLE1 { get => DOCUMENTO_COMERCIANTE_DETALLE; set => DOCUMENTO_COMERCIANTE_DETALLE = value; }
        public string DOCUMENTO_COMERCIANTE_OBSERVACION1 { get => DOCUMENTO_COMERCIANTE_OBSERVACION; set => DOCUMENTO_COMERCIANTE_OBSERVACION = value; }
        public int DOCUMENTO_COMERCIANTE_ESTADO1 { get => DOCUMENTO_COMERCIANTE_ESTADO; set => DOCUMENTO_COMERCIANTE_ESTADO = value; }

        public DataTable Consultar()
        {
            NpgsqlConnection con = null;
            string query = "select documento_comerciante_id, tipo_documento_comerciante_nombre, comerciante_nombres_representante_legal, documento_comerciante_nombre, documento_comerciante_fecha, documento_comerciante_detalle, documento_comerciante_observacion, documento_comerciante_estado " +
                "from catastroestablecimiento.cm_documento_comerciante " +
                "join catastroestablecimiento.cm_tipo_documento_comerciante " +
                "on catastroestablecimiento.cm_tipo_documento_comerciante.tipo_documento_comerciante_id = catastroestablecimiento.cm_documento_comerciante.tipo_documento_comerciante_id " +
                 "join catastroestablecimiento.cm_comerciante " +
                "on catastroestablecimiento.cm_comerciante.comerciante_id = catastroestablecimiento.cm_documento_comerciante.comerciante_id " +
                "order by documento_comerciante_id asc";
            NpgsqlCommand conector = null;
            NpgsqlDataAdapter datos = null;
            DataTable tabla = null;
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
            string query = "select documento_comerciante_id, tipo_documento_comerciante_nombre, comerciante_nombres_representante_legal, documento_comerciante_nombre, documento_comerciante_fecha, documento_comerciante_detalle, documento_comerciante_observacion, documento_comerciante_estado " +
                "from catastroestablecimiento.cm_documento_comerciante " +
                "join catastroestablecimiento.cm_tipo_documento_comerciante " +
                "on catastroestablecimiento.cm_tipo_documento_comerciante.tipo_documento_comerciante_id = catastroestablecimiento.cm_documento_comerciante.tipo_documento_comerciante_id " +
                 "join catastroestablecimiento.cm_comerciante " +
                "on catastroestablecimiento.cm_comerciante.comerciante_id = catastroestablecimiento.cm_documento_comerciante.comerciante_id " +
                "where documento_comerciante_id = " + id + " " +
                "order by documento_comerciante_id asc";
            NpgsqlCommand conector = null;
            NpgsqlDataAdapter datos = null;
            DataTable tabla = null;
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

        public DataTable Documento_Comerciante()
        {
            NpgsqlConnection con = null;
            string query = "select documento_comerciante_id, documento_comerciante_nombre from catastroestablecimiento.cm_documento_comerciante order by documento_comerciante_id asc";
            NpgsqlCommand conector = null;
            NpgsqlDataAdapter datos = null;
            DataTable tabla = null;
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


        public void Insertar(int tipo, int comerciante, string nombre, DateTime fecha, string detalle, string observacion, int estado)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query =
                "Insert into catastroestablecimiento.cm_documento_comerciante (tipo_documento_comerciante_id, comerciante_id, documento_comerciante_nombre, documento_comerciante_fecha, documento_comerciante_detalle, documento_comerciante_observacion, documento_comerciante_estado) " +
                "values (" + tipo + "," + comerciante + ",'" + nombre + "','" + fecha + "','" + detalle + "','" + observacion + "'," + estado + ")";
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

        public void Editar(int tipo, int comerciante, string nombre, DateTime fecha, string detalle, string observacion, int estado, int id)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query = "update catastroestablecimiento.cm_documento_comerciante set " +
                "tipo_documento_comerciante_id = " + tipo + ", " +
                "comerciante_id = " + comerciante + ", " +
                "documento_comerciante_nombre = '" + nombre + "', " +
                "documento_comerciante_fecha = '" + fecha + "', " +
                "documento_comerciante_detalle = '" + detalle + "', " +
                "documento_comerciante_observacion = '" + observacion + "', " +
                "documento_comerciante_estado = " + estado +
                " where documento_comerciante_id = " + id + "";
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
                string query = "delete from catastroestablecimiento.cm_documento_comerciante where documento_comerciante_id = " + id + "";
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
