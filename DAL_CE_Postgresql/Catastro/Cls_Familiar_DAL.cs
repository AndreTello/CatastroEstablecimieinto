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
    public class Cls_Familiar_DAL
    {
        Cls_Conexion_Postgresql_DAL conexion = new Cls_Conexion_Postgresql_DAL();

        private int FAMILIAR_ID;
        private int TIPO_FAMILIAR_ID;
		private int COMERCIANTE_ID;
        private string FAMILIAR_CEDULA;
        private string FAMILIAR_APELLIDOS;
        private string FAMILIAR_NOMBRES;
        //private decimal FAMILIAR_APORTE_ECONOMICO;
		//private decimal FAMILIAR_PROMEDIO_INGRESO;
		private string FAMILIAR_MENOR_EDAD;
        private string FAMILIAR_ESCOLARIDAD;
        private int FAMILIAR_ESTADO;

        public int FAMILIAR_ID1 { get => FAMILIAR_ID; set => FAMILIAR_ID = value; }
        public int TIPO_FAMILIAR_ID1 { get => TIPO_FAMILIAR_ID; set => TIPO_FAMILIAR_ID = value; }
        public int COMERCIANTE_ID1 { get => COMERCIANTE_ID; set => COMERCIANTE_ID = value; }
        public string FAMILIAR_CEDULA1 { get => FAMILIAR_CEDULA; set => FAMILIAR_CEDULA = value; }
        public string FAMILIAR_APELLIDOS1 { get => FAMILIAR_APELLIDOS; set => FAMILIAR_APELLIDOS = value; }
        public string FAMILIAR_NOMBRES1 { get => FAMILIAR_NOMBRES; set => FAMILIAR_NOMBRES = value; }
        //public decimal FAMILIAR_APORTE_ECONOMICO1 { get => FAMILIAR_APORTE_ECONOMICO; set => FAMILIAR_APORTE_ECONOMICO = value; }
        //public decimal FAMILIAR_PROMEDIO_INGRESO1 { get => FAMILIAR_PROMEDIO_INGRESO; set => FAMILIAR_PROMEDIO_INGRESO = value; }
        public string FAMILIAR_MENOR_EDAD1 { get => FAMILIAR_MENOR_EDAD; set => FAMILIAR_MENOR_EDAD = value; }
        public string FAMILIAR_ESCOLARIDAD1 { get => FAMILIAR_ESCOLARIDAD; set => FAMILIAR_ESCOLARIDAD = value; }
        public int FAMILIAR_ESTADO1 { get => FAMILIAR_ESTADO; set => FAMILIAR_ESTADO = value; }

        public DataTable Consultar()
        {
            NpgsqlConnection con = null;
            string query = "select familiar_id, tipo_familiar_nombre, comerciante_nombres_representante_legal, familiar_cedula, familiar_apellidos, familiar_nombres, familiar_menor_edad, familiar_escolaridad, familiar_estado " +
                "from catastroestablecimiento.cm_familiar " +
                "join catastroestablecimiento.cm_tipo_familiar " +
                "on catastroestablecimiento.cm_tipo_familiar.tipo_familiar_id = catastroestablecimiento.cm_familiar.tipo_familiar_id " +
                "join catastroestablecimiento.cm_comerciante " +
                "on catastroestablecimiento.cm_comerciante.comerciante_id = catastroestablecimiento.cm_familiar.comerciante_id " +
                "order by familiar_id asc";
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
            string query = "select familiar_id, tipo_familiar_nombre, comerciante_nombres_representante_legal, familiar_cedula, familiar_apellidos, familiar_nombres, familiar_menor_edad, familiar_escolaridad, familiar_estado " +
                "from catastroestablecimiento.cm_familiar " +
                "join catastroestablecimiento.cm_tipo_familiar " +
                "on catastroestablecimiento.cm_tipo_familiar.tipo_familiar_id = catastroestablecimiento.cm_familiar.tipo_familiar_id " +
                "join catastroestablecimiento.cm_comerciante " +
                "on catastroestablecimiento.cm_comerciante.comerciante_id = catastroestablecimiento.cm_familiar.comerciante_id " +
                "where familiar_id = " + id + " " +
                "order by familiar_id asc";
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

        public DataTable Familiar()
        {
            NpgsqlConnection con = null;
            string query = "select familiar_id, familiar_nombres catastroestablecimiento.cm_familiar order by familiar_id asc";
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


        public void Insertar(int tipo, int comerciante, string cedula, string apellidos, string nombres, string menor, string escolaridad, int estado)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query =
                "Insert into catastroestablecimiento.cm_familiar (tipo_familiar_id, comerciante_id, familiar_cedula, familiar_apellidos, familiar_nombres, familiar_menor_edad, familiar_escolaridad, familiar_estado) " +
                "values (" + tipo + "," + comerciante + ",'" + cedula + "','" + apellidos + "','" + nombres + "','" + menor + "','" + escolaridad + "'," + estado + ")";
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

        public void Editar(int tipo, int comerciante, string cedula, string apellidos, string nombres, string menor, string escolaridad, int estado, int id)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query = "update catastroestablecimiento.cm_familiar set " +
                "tipo_familiar_id = " + tipo + ", " +
                "comerciante_id = " + comerciante + ", " +
                "familiar_cedula = '" + cedula + "', " +
                "familiar_apellidos = '" + apellidos + "', " +
                "familiar_nombres = '" + nombres + "', " +
                "familiar_menor_edad = '" + menor + "', " +
                "familiar_escolaridad = '" + escolaridad + "', " +
                "familiar_estado = " + estado +
                " where familiar_id = " + id + "";
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
                string query = "delete from catastroestablecimiento.cm_familiar where familiar_id = " + id + "";
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
