using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENT_CE;

namespace DAL_CE_Postgresql.Catastro
{
    public class Cls_Establecimiento_DAL
    {

        Cls_Conexion_Postgresql_DAL conexion = new Cls_Conexion_Postgresql_DAL();
                
        public DataTable Consultar()
        {
            NpgsqlConnection con = null;
            string query = "select establecimiento_id, lote_nombre, administracion_zonal_nombre, tipo_establecimiento_nombre, asociacion_nombre, intervencion_tecnica_establecimiento_nombre, establecimiento_predio, establecimiento_clave_catastral, establecimiento_nomenclatura_vial, establecimiento_calle_principal, establecimiento_calle_secundaria, establecimiento_paqueadero, establecimiento_numero_parqueadero, establecimiento_dias_apertura, establecimiento_horario_atencion, establecimiento_estado " +
                "from catastroestablecimiento.cm_establecimiento " +
                "join catastroestablecimiento.cm_lote " +
                "on catastroestablecimiento.cm_lote.lote_id = catastroestablecimiento.cm_establecimiento.lote_id " +
                "join catastroestablecimiento.cm_administracion_zonal " +
                "on catastroestablecimiento.cm_administracion_zonal.administracion_zonal_id = catastroestablecimiento.cm_establecimiento.administracion_zonal_id " +
                "join catastroestablecimiento.cm_tipo_establecimiento " +
                "on catastroestablecimiento.cm_tipo_establecimiento.tipo_establecimiento_id = catastroestablecimiento.cm_establecimiento.tipo_establecimiento_id " +
                "join catastroestablecimiento.cm_asociacion " +
                "on catastroestablecimiento.cm_asociacion.asociacion_id = catastroestablecimiento.cm_establecimiento.asociacion_id " +
                "join catastroestablecimiento.cm_intervencion_tecnica_establecimiento " +
                "on catastroestablecimiento.cm_intervencion_tecnica_establecimiento.intervencion_tecnica_establecimiento_id = catastroestablecimiento.cm_establecimiento.intervencion_tecnica_establecimiento_id " +
                "order by establecimiento_id asc";
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
            string query = "select establecimiento_id, lote_nombre, administracion_zonal_nombre, tipo_establecimiento_nombre, asociacion_nombre, intervencion_tecnica_establecimiento_nombre, establecimiento_predio, establecimiento_clave_catastral, establecimiento_nomenclatura_vial, establecimiento_calle_principal, establecimiento_calle_secundaria, establecimiento_paqueadero, establecimiento_numero_parqueadero, establecimiento_dias_apertura, establecimiento_horario_atencion, establecimiento_estado " +
                "from catastroestablecimiento.cm_establecimiento" +
                "join catastroestablecimiento.cm_lote " +
                "on catastroestablecimiento.cm_lote.lote_id = catastroestablecimiento.cm_establecimiento.lote_id " +
                "join catastroestablecimiento.cm_administracion_zonal " +
                "on catastroestablecimiento.cm_administracion_zonal.administracion_zonal_id = catastroestablecimiento.cm_establecimiento.administracion_zonal_id " +
                "join catastroestablecimiento.cm_tipo_establecimiento " +
                "on catastroestablecimiento.cm_tipo_establecimiento.tipo_establecimiento_id = catastroestablecimiento.cm_establecimiento.tipo_establecimiento_id " +
                "join catastroestablecimiento.cm_asociacion " +
                "on catastroestablecimiento.cm_asociacion.asociacion_id = catastroestablecimiento.cm_establecimiento.asociacion_id " +
                "join catastroestablecimiento.cm_intervencion_tecnica_establecimiento " +
                "on catastroestablecimiento.cm_intervencion_tecnica_establecimiento.intervencion_tecnica_establecimiento_id = catastroestablecimiento.cm_establecimiento.intervencion_tecnica_establecimiento_id where establecimiento_id = " + id + " order by establecimiento_id asc";
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

        public DataTable Establecimiento()
        {
            NpgsqlConnection con = null;
            string query = "select establecimiento_id, establecimiento_clave_catastral from catastroestablecimiento.cm_establecimiento order by establecimiento_id asc";
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


        public void Insertar(int lote, int admnistracion, int tipo, int asociacion, int intervencion, string predio, string clave_catastral, string nomenclatura_vial, string calle_principal, string calle_secundaria, string paqueadero, int numero_parqueadero, string dias_apertura, string horario_atencion, int estado)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query =
                "Insert into catastroestablecimiento.cm_establecimiento (lote_id, administracion_zonal_id, tipo_establecimiento_id, asociacion_id, intervencion_tecnica_establecimiento_id, establecimiento_predio, establecimiento_clave_catastral, establecimiento_nomenclatura_vial, establecimiento_calle_principal, establecimiento_calle_secundaria, establecimiento_paqueadero, establecimiento_numero_parqueadero, establecimiento_dias_apertura, establecimiento_horario_atencion, establecimiento_estado) " +
                "values (" + lote + "," + admnistracion + "," + tipo + "," + asociacion + "," + intervencion + ",'" + predio + "','" + clave_catastral + "','" + nomenclatura_vial + "','" + calle_principal + "','" + calle_secundaria + "','" + paqueadero + "'," + numero_parqueadero + ",'" + dias_apertura + "','" + horario_atencion + "'," + estado + ")";
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

        public void Editar(int lote, int admnistracion, int tipo, int asociacion, int intervencion, string predio, string clave_catastral, string nomenclatura_vial, string calle_principal, string calle_secundaria, string paqueadero, int numero_parqueadero, string dias_apertura, string horario_atencion, int estado, int id)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query =
                "update catastroestablecimiento.cm_establecimiento set " +
                "lote_id = " + lote + ", " +
                "administracion_zonal_id = " + admnistracion + ", " +
                "tipo_establecimiento_id = " + tipo + ", " +
                "asociacion_id = " + asociacion + ", " +
                "intervencion_tecnica_establecimiento_id = " + intervencion + ", " +
                "establecimiento_predio = '" + predio + "', " +
                "establecimiento_clave_catastral = '" + clave_catastral + "', " +
                "establecimiento_nomenclatura_vial = '" + nomenclatura_vial + "', " +
                "establecimiento_calle_principal = '" + calle_principal + "', " +
                "establecimiento_calle_secundaria = '" + calle_secundaria + "', " +
                "establecimiento_paqueadero = '" + paqueadero + "', " +
                "establecimiento_numero_parqueadero = " + numero_parqueadero + ", " +
                "establecimiento_dias_apertura = '" + dias_apertura + "', " +
                "establecimiento_horario_atencion = '" + horario_atencion + "', " +
                "establecimiento_estado = " + estado + " " +
                "where establecimiento_id = " + id + "";
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
                string query = "delete from catastroestablecimiento.cm_establecimiento where establecimiento_id = " + id + "";
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
