using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DAL_CE_Postgresql.Catastro
{
    public class Cls_Estatus_Legal_DAL
    {
        Cls_Conexion_Postgresql_DAL conexion = new Cls_Conexion_Postgresql_DAL();

        private int ESTATUS_LEGAL_ID;
        private int PUESTO_ID;
        private int GIRO_NEGOCIO_ID;
        private string ESTATUS_LEGAL_FECHA_OCUPACION;
        private string ESTATUS_LEGAL_HISTORIAL;
        private int ESTATUS_LEGAL_ESTADO_ADJUDICADO;
        private int ESTATUS_LEGAL_NUMERO_PUESTO_ADJUDICADO;
        private string ESTATUS_LEGAL_CONDICION_USO;
       // private int ESTATUS_LEGAL_CARTA_ADJUDICACION;      //bytea
        private string ESTATUS_LEGAL_NOTIFICACION;
       // private int ESTATUS_LEGAL_ACTA_RESOLUCION_NOTIFICACION;   //bytea
        private string ESTATUS_LEGAL_FECHA_RESOLUCION_NOTIFICACION;
        private string ESTATUS_LEGAL_CONVENIO_NOMBRE;
        private int ESTATUS_LEGAL_CONVENIO_NUMERO;
		private string ESTATUS_LEGAL_CONVENIO_FECHA;
        private string ESTATUS_LEGAL_CONDICION;
        private int ESTATUS_LEGAL_CAMBIO_GIRO;
        private string ESTATUS_LEGAL_NUMERO_OFICIO_CAMBIO_GIRO;
		private string ESTATUS_LEGAL_FECHA_CAMBIO_GIRO;
        private string ESTATUS_LEGAL_SANCIONES;
		private string ESTATUS_LEGAL_NUMERO_RESOLUCION_SANCION;
		private string ESTATUS_LEGAL_FECHA_RESOLUCION_SANCION;
        private int ESTATUS_LEGAL_ESTADO;

        public int ESTATUS_LEGAL_ID1 { get => ESTATUS_LEGAL_ID; set => ESTATUS_LEGAL_ID = value; }
        public int PUESTO_ID1 { get => PUESTO_ID; set => PUESTO_ID = value; }
        public int GIRO_NEGOCIO_ID1 { get => GIRO_NEGOCIO_ID; set => GIRO_NEGOCIO_ID = value; }
        public string ESTATUS_LEGAL_FECHA_OCUPACION1 { get => ESTATUS_LEGAL_FECHA_OCUPACION; set => ESTATUS_LEGAL_FECHA_OCUPACION = value; }
        public string ESTATUS_LEGAL_HISTORIAL1 { get => ESTATUS_LEGAL_HISTORIAL; set => ESTATUS_LEGAL_HISTORIAL = value; }
        public int ESTATUS_LEGAL_ESTADO_ADJUDICADO1 { get => ESTATUS_LEGAL_ESTADO_ADJUDICADO; set => ESTATUS_LEGAL_ESTADO_ADJUDICADO = value; }
        public int ESTATUS_LEGAL_NUMERO_PUESTO_ADJUDICADO1 { get => ESTATUS_LEGAL_NUMERO_PUESTO_ADJUDICADO; set => ESTATUS_LEGAL_NUMERO_PUESTO_ADJUDICADO = value; }
        public string ESTATUS_LEGAL_CONDICION_USO1 { get => ESTATUS_LEGAL_CONDICION_USO; set => ESTATUS_LEGAL_CONDICION_USO = value; }
        public string ESTATUS_LEGAL_NOTIFICACION1 { get => ESTATUS_LEGAL_NOTIFICACION; set => ESTATUS_LEGAL_NOTIFICACION = value; }
        public string ESTATUS_LEGAL_FECHA_RESOLUCION_NOTIFICACION1 { get => ESTATUS_LEGAL_FECHA_RESOLUCION_NOTIFICACION; set => ESTATUS_LEGAL_FECHA_RESOLUCION_NOTIFICACION = value; }
        public string ESTATUS_LEGAL_CONVENIO_NOMBRE1 { get => ESTATUS_LEGAL_CONVENIO_NOMBRE; set => ESTATUS_LEGAL_CONVENIO_NOMBRE = value; }
        public int ESTATUS_LEGAL_CONVENIO_NUMERO1 { get => ESTATUS_LEGAL_CONVENIO_NUMERO; set => ESTATUS_LEGAL_CONVENIO_NUMERO = value; }
        public string ESTATUS_LEGAL_CONVENIO_FECHA1 { get => ESTATUS_LEGAL_CONVENIO_FECHA; set => ESTATUS_LEGAL_CONVENIO_FECHA = value; }
        public string ESTATUS_LEGAL_CONDICION1 { get => ESTATUS_LEGAL_CONDICION; set => ESTATUS_LEGAL_CONDICION = value; }
        public int ESTATUS_LEGAL_CAMBIO_GIRO1 { get => ESTATUS_LEGAL_CAMBIO_GIRO; set => ESTATUS_LEGAL_CAMBIO_GIRO = value; }
        public string ESTATUS_LEGAL_NUMERO_OFICIO_CAMBIO_GIRO1 { get => ESTATUS_LEGAL_NUMERO_OFICIO_CAMBIO_GIRO; set => ESTATUS_LEGAL_NUMERO_OFICIO_CAMBIO_GIRO = value; }
        public string ESTATUS_LEGAL_FECHA_CAMBIO_GIRO1 { get => ESTATUS_LEGAL_FECHA_CAMBIO_GIRO; set => ESTATUS_LEGAL_FECHA_CAMBIO_GIRO = value; }
        public string ESTATUS_LEGAL_SANCIONES1 { get => ESTATUS_LEGAL_SANCIONES; set => ESTATUS_LEGAL_SANCIONES = value; }
        public string ESTATUS_LEGAL_NUMERO_RESOLUCION_SANCION1 { get => ESTATUS_LEGAL_NUMERO_RESOLUCION_SANCION; set => ESTATUS_LEGAL_NUMERO_RESOLUCION_SANCION = value; }
        public string ESTATUS_LEGAL_FECHA_RESOLUCION_SANCION1 { get => ESTATUS_LEGAL_FECHA_RESOLUCION_SANCION; set => ESTATUS_LEGAL_FECHA_RESOLUCION_SANCION = value; }
        public int ESTATUS_LEGAL_ESTADO1 { get => ESTATUS_LEGAL_ESTADO; set => ESTATUS_LEGAL_ESTADO = value; }

        public DataTable Consultar()
        {
            NpgsqlConnection con = null;
            string query = "select estatus_legal_id, puesto_clave_catastral, giro_negocio_nombre, estatus_legal_fecha_ocupacion, estatus_legal_historial, estatus_legal_estado_adjudicado, estatus_legal_numero_puesto_adjudicado, estatus_legal_condicion_uso, estatus_fecha_notificacion, estatus_legal_fecha_resolucion_notificacion, estatus_legal_convenio_nombre, estatus_legal_convenio_numero, estatus_legal_convenio_fecha, estatus_legal_condicion, estatus_legal_cambio_giro, estatus_legal_numero_oficio_cambio_giro, estatus_legal_fecha_cambio_giro, estatus_legal_sanciones, estatus_legal_numero_resolucion_sancion, estatus_legal_fecha_resolucion_sancion, estatus_legal_estado " +
                "from catastroestablecimiento.cm_estatus_legal " +
                "join catastroestablecimiento.cm_puesto " +
                "on catastroestablecimiento.cm_puesto.puesto_id = catastroestablecimiento.cm_estatus_legal.puesto_id " +
                "join catastroestablecimiento.cm_giro_negocio " +
                "on catastroestablecimiento.cm_giro_negocio.giro_negocio_id = catastroestablecimiento.cm_estatus_legal.giro_negocio_id " +               
                "order by estatus_legal_id asc";
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
            string query = "select estatus_legal_id, puesto_clave_catastral, giro_negocio_nombre, estatus_legal_fecha_ocupacion, estatus_legal_historial, estatus_legal_estado_adjudicado, estatus_legal_numero_puesto_adjudicado, estatus_legal_condicion_uso, estatus_legal_notificacion, estatus_legal_fecha_resolucion_notificacion, estatus_legal_convenio_nombre, estatus_legal_convenio_numero, estatus_legal_convenio_fecha, estatus_legal_condicion, estatus_legal_cambio_giro, estatus_legal_numero_oficio_cambio_giro, estatus_legal_fecha_cambio_giro, estatus_legal_sanciones, estatus_legal_numero_resolucion_sancion, estatus_legal_fecha_resolucion_sancion, estatus_legal_estado " +
                "from catastroestablecimiento.cm_estatus_legal " +
                "join catastroestablecimiento.cm_puesto " +
                "on catastroestablecimiento.cm_puesto.puesto_id = catastroestablecimiento.cm_estatus_legal.puesto_id " +
                "join catastroestablecimiento.cm_giro_negocio " +
                "on catastroestablecimiento.cm_giro_negocio.giro_negocio_id = catastroestablecimiento.cm_estatus_legal.giro_negocio_id " +
                "where estatus_legal_id = " + id + " " +
                "order by estatus_legal_id asc";
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

        public DataTable Estatus_Legal()
        {
            NpgsqlConnection con = null;
            string query = "select estatus_legal_id, estatus_legal_estado_adjudicado from catastroestablecimiento.cm_estatus_legal order by estatus_legal_id asc";
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


        public void Insertar(int puesto, int negocio, string fechao, string historial, int estadoa, int numeropa, string condicionu, string notificacion, string fecharn, string conveniono, int convenion, string conveniof, string condicion, int cambiog, string numerocg, string fechacg, string sanciones, string numerors, string fechars, int estado)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query =
                "Insert into catastroestablecimiento.cm_estatus_legal (puesto_id, giro_negocio_id, estatus_legal_fecha_ocupacion, estatus_legal_historial, estatus_legal_estado_adjudicado, estatus_legal_numero_puesto_adjudicado, estatus_legal_condicion_uso, estatus_legal_notificacion, estatus_legal_fecha_resolucion_notificacion, estatus_legal_convenio_nombre, estatus_legal_convenio_numero, estatus_legal_convenio_fecha, estatus_legal_condicion, estatus_legal_cambio_giro, estatus_legal_numero_oficio_cambio_giro, estatus_legal_fecha_cambio_giro, estatus_legal_sanciones, estatus_legal_numero_resolucion_sancion, estatus_legal_fecha_resolucion_sancion, estatus_legal_estado) " +
                "values (" + puesto + "," + negocio + ",'" + fechao + "','" + historial + "'," + estadoa + "," + numeropa + ",'" + condicionu + "','" + notificacion + "','" + fecharn + "','" + conveniono + "','" + convenion + "','" + conveniof + "','" + condicion + "'," + cambiog + ",'" + numerocg + "','" + fechacg + "','" + sanciones + "','" + numerors + "','" + fechars + "'," + estado + ")";
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

        public void Editar(int puesto, int negocio, string fechao, string historial, int estadoa, int numeropa, string condicionu, string notificacion, string fecharn, string conveniono, int convenion, string conveniof, string condicion, int cambiog, string numerocg, string fechacg, string sanciones, string numerors, string fechars, int estado, int id)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query =
                "update catastroestablecimiento.cm_estatus_legal set " +
                "puesto_id = " + puesto + ", " +
                "giro_negocio_id = " + negocio + ", " +
                "estatus_legal_fecha_ocupacion = '" + fechao + "', " +
                "estatus_legal_historial = '" + historial + "', " +
                "estatus_legal_estado_adjudicado = " + estadoa + ", " +
                "estatus_legal_numero_puesto_adjudicado = " + numeropa + ", " +
                "estatus_legal_condicion_uso = '" + condicionu + "', " +
                "estatus_legal_notificacion = '" + notificacion + "', " +
                "estatus_legal_fecha_resolucion_notificacion = '" + fecharn + "', " +
                "estatus_legal_convenio_nombre = '" + conveniono + "', " +
                "estatus_legal_convenio_numero = " + convenion + ", " +
                "estatus_legal_convenio_fecha = '" + conveniof + "', " +
                "estatus_legal_condicion = '" + condicion + "', " +
                "estatus_legal_cambio_giro = " + cambiog + ", " +
                "estatus_legal_numero_oficio_cambio_giro = '" + numerocg + "', " +
                "estatus_legal_fecha_cambio_giro = '" + fechacg + "', " +
                "estatus_legal_sanciones = '" + sanciones + "', " +
                "estatus_legal_numero_resolucion_sancion = '" + numerors + "', " +
                "estatus_legal_fecha_resolucion_sancion = '" + fechars + "', " +
                "estatus_legal_estado = " + estado + " " +
                "where estatus_legal_id = " + id + " ";
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
                string query = "delete from catastroestablecimiento.cm_estatus_legal where estatus_legal_id = " + id + "";
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
