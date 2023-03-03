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
    public class Cls_Identificacion_Socio_Economica_DAL
    {
        Cls_Conexion_Postgresql_DAL conexion = new Cls_Conexion_Postgresql_DAL();

        private int IDENTIFICACION_SOCIO_ECONOMICA_ID;
        private int COMERCIANTE_ID;
		private int ETNIA_ID;
        private int GENERO_ID;
		private int ESTADO_CIVIL_ID;
        private int NACIONALIDAD_ID;
		private int NIVEL_EDUCACION_ID;
        private int DISCAPACIDAD_ID;
		private string IDENTIFICACION_SOCIO_ECONOMICA_JEFE_FAMILIA;
        private string IDENTIFICACION_SOCIO_ECONOMICA_DEPENDIENTES;
        private int IDENTIFICACION_SOCIO_ECONOMICA_NUMERO_DEPENDIENTES;
		private string IDENTIFICACION_SOCIO_ECONOMICA_PARENTESCO;
        private int IDENTIFICACION_SOCIO_ECONOMICA_ESTADO;

        public int IDENTIFICACION_SOCIO_ECONOMICA_ID1 { get => IDENTIFICACION_SOCIO_ECONOMICA_ID; set => IDENTIFICACION_SOCIO_ECONOMICA_ID = value; }
        public int COMERCIANTE_ID1 { get => COMERCIANTE_ID; set => COMERCIANTE_ID = value; }
        public int ETNIA_ID1 { get => ETNIA_ID; set => ETNIA_ID = value; }
        public int GENERO_ID1 { get => GENERO_ID; set => GENERO_ID = value; }
        public int ESTADO_CIVIL_ID1 { get => ESTADO_CIVIL_ID; set => ESTADO_CIVIL_ID = value; }
        public int NACIONALIDAD_ID1 { get => NACIONALIDAD_ID; set => NACIONALIDAD_ID = value; }
        public int NIVEL_EDUCACION_ID1 { get => NIVEL_EDUCACION_ID; set => NIVEL_EDUCACION_ID = value; }
        public int DISCAPACIDAD_ID1 { get => DISCAPACIDAD_ID; set => DISCAPACIDAD_ID = value; }
        public string IDENTIFICACION_SOCIO_ECONOMICA_JEFE_FAMILIA1 { get => IDENTIFICACION_SOCIO_ECONOMICA_JEFE_FAMILIA; set => IDENTIFICACION_SOCIO_ECONOMICA_JEFE_FAMILIA = value; }
        public string IDENTIFICACION_SOCIO_ECONOMICA_DEPENDIENTES1 { get => IDENTIFICACION_SOCIO_ECONOMICA_DEPENDIENTES; set => IDENTIFICACION_SOCIO_ECONOMICA_DEPENDIENTES = value; }
        public int IDENTIFICACION_SOCIO_ECONOMICA_NUMERO_DEPENDIENTES1 { get => IDENTIFICACION_SOCIO_ECONOMICA_NUMERO_DEPENDIENTES; set => IDENTIFICACION_SOCIO_ECONOMICA_NUMERO_DEPENDIENTES = value; }
        public string IDENTIFICACION_SOCIO_ECONOMICA_PARENTESCO1 { get => IDENTIFICACION_SOCIO_ECONOMICA_PARENTESCO; set => IDENTIFICACION_SOCIO_ECONOMICA_PARENTESCO = value; }
        public int IDENTIFICACION_SOCIO_ECONOMICA_ESTADO1 { get => IDENTIFICACION_SOCIO_ECONOMICA_ESTADO; set => IDENTIFICACION_SOCIO_ECONOMICA_ESTADO = value; }

        public DataTable Consultar()
        {
            NpgsqlConnection con = null;
            string query = "select identificacion_socio_economica_id, comerciante_nombres_representante_legal, etnia_nombre, genero_nombre, estado_civil_nombre, nacionalidad_nombre, nivel_educacion_nombre, discapacidad_nombre, identificacion_socio_economica_jefe_familia, identificacion_socio_economica_dependientes, identificacion_socio_economica_numero_dependientes, identificacion_socio_economica_parentesco, identificacion_socio_economica_estado " +
                "from catastroestablecimiento.cm_identificacion_socio_economica " +
                "join catastroestablecimiento.cm_comerciante " +
                "on catastroestablecimiento.cm_comerciante.comerciante_id = catastroestablecimiento.cm_identificacion_socio_economica.comerciante_id " +
                "join catastroestablecimiento.cm_etnia " +
                "on catastroestablecimiento.cm_etnia.etnia_id = catastroestablecimiento.cm_identificacion_socio_economica.etnia_id " +
                "join catastroestablecimiento.cm_genero " +
                "on catastroestablecimiento.cm_genero.genero_id = catastroestablecimiento.cm_identificacion_socio_economica.genero_id " +
                "join catastroestablecimiento.cm_estado_civil " +
                "on catastroestablecimiento.cm_estado_civil.estado_civil_id = catastroestablecimiento.cm_identificacion_socio_economica.estado_civil_id " +
                "join catastroestablecimiento.cm_nacionalidad " +
                "on catastroestablecimiento.cm_nacionalidad.nacionalidad_id = catastroestablecimiento.cm_identificacion_socio_economica.nacionalidad_id " +
                "join catastroestablecimiento.cm_nivel_educacion " +
                "on catastroestablecimiento.cm_nivel_educacion.nivel_educacion_id = catastroestablecimiento.cm_identificacion_socio_economica.nivel_educacion_id " +
                "join catastroestablecimiento.cm_discapacidad " +
                "on catastroestablecimiento.cm_discapacidad.discapacidad_id = catastroestablecimiento.cm_identificacion_socio_economica.discapacidad_id " +
                "order by identificacion_socio_economica_id asc ";
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
            string query = "select identificacion_socio_economica_id, comerciante_nombres_representante_legal, etnia_nombre, genero_nombre, estado_civil_nombre, nacionalidad_nombre, nivel_educacion_nombre, discapacidad_nombre, identificacion_socio_economica_jefe_familia, identificacion_socio_economica_dependientes, identificacion_socio_economica_numero_dependientes, identificacion_socio_economica_parentesco, identificacion_socio_economica_estado " +
                "from catastroestablecimiento.cm_identificacion_socio_economica " +
                "join catastroestablecimiento.cm_comerciante " +
                "on catastroestablecimiento.cm_comerciante.comerciante_id = catastroestablecimiento.cm_identificacion_socio_economica.comerciante_id " +
                "join catastroestablecimiento.cm_etnia " +
                "on catastroestablecimiento.cm_etnia.etnia_id = catastroestablecimiento.cm_identificacion_socio_economica.etnia_id " +
                "join catastroestablecimiento.cm_genero " +
                "on catastroestablecimiento.cm_genero.genero_id = catastroestablecimiento.cm_identificacion_socio_economica.genero_id " +
                "join catastroestablecimiento.cm_estado_civil " +
                "on catastroestablecimiento.cm_estado_civil.estado_civil_id = catastroestablecimiento.cm_identificacion_socio_economica.estado_civil_id " +
                "join catastroestablecimiento.cm_nacionalidad " +
                "on catastroestablecimiento.cm_nacionalidad.nacionalidad_id = catastroestablecimiento.cm_identificacion_socio_economica.nacionalidad_id " +
                "join catastroestablecimiento.cm_nivel_educacion " +
                "on catastroestablecimiento.cm_nivel_educacion.nivel_educacion_id = catastroestablecimiento.cm_identificacion_socio_economica.nivel_educacion_id " +
                "join catastroestablecimiento.cm_discapacidad " +
                "on catastroestablecimiento.cm_discapacidad.discapacidad_id = catastroestablecimiento.cm_identificacion_socio_economica.discapacidad_id " +
                "where identificacion_socio_economica_id = " + id + " order by identificacion_socio_economica_id asc";
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

        public DataTable Identificacion_Socio_Economica()
        {
            NpgsqlConnection con = null;
            string query = "select identificacion_socio_economica_id, identificacion_socio_economica_jefe_familia from catastroestablecimiento.cm_identificacion_socio_economica order by identificacion_socio_economica_id asc";
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


        public void Insertar(int comerciante, int etnia, int genero, int estado_civil, int nacionalidad, int nivel_educación, int discapacidad, string jefe_familia, string dependientes, int n_dependientes, string parentezco, int estado)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query =
                "Insert into catastroestablecimiento.cm_identificacion_socio_economica (comerciante_id, etnia_id, genero_id, estado_civil_id, nacionalidad_id, nivel_educacion_id, discapacidad_id, identificacion_socio_economica_jefe_familia, identificacion_socio_economica_dependientes, identificacion_socio_economica_numero_dependientes, identificacion_socio_economica_parentesco, identificacion_socio_economica_estado) " +
                "values (" + comerciante + "," + etnia + "," + genero + "," + estado_civil + "," + nacionalidad + "," + nivel_educación + "," + discapacidad + ",'" + jefe_familia + "','" + dependientes + "'," + n_dependientes + ",'" + parentezco + "'," + estado + ")";
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

        public void Editar(int comerciante, int etnia, int genero, int estado_civil, int nacionalidad, int nivel_educación, int discapacidad, string jefe_familia, string dependientes, int n_dependientes, string parentezco, int estado, int id)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query =
                "update catastroestablecimiento.cm_identificacion_socio_economica set " +
                "comerciante_id = " + comerciante + ", " +
                "etnia_id = " + etnia + ", " +
                "genero_id = " + genero + ", " +
                "estado_civil_id = " + estado_civil + ", " +
                "nacionalidad_id = " + nacionalidad + ", " +
                "nivel_educacion_id = " + nivel_educación + ", " +
                "discapacidad_id = " + discapacidad + ", " +
                "identificacion_socio_economica_jefe_familia = '" + jefe_familia + "', " +
                "identificacion_socio_economica_dependientes = '" + dependientes + "', " +
                "identificacion_socio_economica_numero_dependientes = " + n_dependientes + ", " +
                "identificacion_socio_economica_parentesco = '" + parentezco + "', " +
                "identificacion_socio_economica_estado = " + estado + " " +
                "where identificacion_socio_economica_id = " + id + "";
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
                string query = "delete from catastroestablecimiento.cm_identificacion_socio_economica where identificacion_socio_economica_id = " + id + "";
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
