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
using ENT_CE;

namespace DAL_CE_Postgresql.Catastro
{
    public class Cls_Estatus_Legal_DAL
    {
        Cls_Conexion_Postgresql_DAL conexion = new Cls_Conexion_Postgresql_DAL();
        
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
