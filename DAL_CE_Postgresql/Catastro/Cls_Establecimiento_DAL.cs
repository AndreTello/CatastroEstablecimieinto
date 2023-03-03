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
    public class Cls_Establecimiento_DAL
    {

        Cls_Conexion_Postgresql_DAL conexion = new Cls_Conexion_Postgresql_DAL();

        private int ESTABLECIMIENTO_ID;
        private int LOTE_ID;
		private int ADMINISTRACION_ZONAL_ID;
        private int TIPO_ESTABLECIMIENTO_ID;
		private int ASOCIACION_ID;
        private int INTERVENCION_TECNICA_ESTABLECIMIENTO_ID;
		private string ESTABLECIMIENTO_PREDIO;
        private string ESTABLECIMIENTO_CLAVE_CATASTRAL;
        private string ESTABLECIMIENTO_NOMENCLATURA_VIAL;
		private string ESTABLECIMIENTO_CALLE_PRINCIPAL;
        private string ESTABLECIMIENTO_CALLE_SECUNDARIA;
        private string ESTABLECIMIENTO_PAQUEADERO;
        private int ESTABLECIMIENTO_NUMERO_PARQUEADERO;
		private string ESTABLECIMIENTO_DIAS_APERTURA;
        private string ESTABLECIMIENTO_HORARIO_ATENCION;
        private int ESTABLECIMIENTO_ESTADO;

        public int ESTABLECIMIENTO_ID1 { get => ESTABLECIMIENTO_ID; set => ESTABLECIMIENTO_ID = value; }
        public int LOTE_ID1 { get => LOTE_ID; set => LOTE_ID = value; }
        public int ADMINISTRACION_ZONAL_ID1 { get => ADMINISTRACION_ZONAL_ID; set => ADMINISTRACION_ZONAL_ID = value; }
        public int TIPO_ESTABLECIMIENTO_ID1 { get => TIPO_ESTABLECIMIENTO_ID; set => TIPO_ESTABLECIMIENTO_ID = value; }
        public int ASOCIACION_ID1 { get => ASOCIACION_ID; set => ASOCIACION_ID = value; }
        public int INTERVENCION_TECNICA_ESTABLECIMIENTO_ID1 { get => INTERVENCION_TECNICA_ESTABLECIMIENTO_ID; set => INTERVENCION_TECNICA_ESTABLECIMIENTO_ID = value; }
        public string ESTABLECIMIENTO_PREDIO1 { get => ESTABLECIMIENTO_PREDIO; set => ESTABLECIMIENTO_PREDIO = value; }
        public string ESTABLECIMIENTO_CLAVE_CATASTRAL1 { get => ESTABLECIMIENTO_CLAVE_CATASTRAL; set => ESTABLECIMIENTO_CLAVE_CATASTRAL = value; }
        public string ESTABLECIMIENTO_NOMENCLATURA_VIAL1 { get => ESTABLECIMIENTO_NOMENCLATURA_VIAL; set => ESTABLECIMIENTO_NOMENCLATURA_VIAL = value; }
        public string ESTABLECIMIENTO_CALLE_PRINCIPAL1 { get => ESTABLECIMIENTO_CALLE_PRINCIPAL; set => ESTABLECIMIENTO_CALLE_PRINCIPAL = value; }
        public string ESTABLECIMIENTO_CALLE_SECUNDARIA1 { get => ESTABLECIMIENTO_CALLE_SECUNDARIA; set => ESTABLECIMIENTO_CALLE_SECUNDARIA = value; }
        public string ESTABLECIMIENTO_PAQUEADERO1 { get => ESTABLECIMIENTO_PAQUEADERO; set => ESTABLECIMIENTO_PAQUEADERO = value; }
        public int ESTABLECIMIENTO_NUMERO_PARQUEADERO1 { get => ESTABLECIMIENTO_NUMERO_PARQUEADERO; set => ESTABLECIMIENTO_NUMERO_PARQUEADERO = value; }
        public string ESTABLECIMIENTO_DIAS_APERTURA1 { get => ESTABLECIMIENTO_DIAS_APERTURA; set => ESTABLECIMIENTO_DIAS_APERTURA = value; }
        public string ESTABLECIMIENTO_HORARIO_ATENCION1 { get => ESTABLECIMIENTO_HORARIO_ATENCION; set => ESTABLECIMIENTO_HORARIO_ATENCION = value; }
        public int ESTABLECIMIENTO_ESTADO1 { get => ESTABLECIMIENTO_ESTADO; set => ESTABLECIMIENTO_ESTADO = value; }

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
