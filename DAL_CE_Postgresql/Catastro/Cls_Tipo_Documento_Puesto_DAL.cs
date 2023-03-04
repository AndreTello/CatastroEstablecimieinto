using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace DAL_CE_Postgresql.Catastro
{
    public class Cls_Tipo_Documento_Puesto_DAL
    {
        Cls_Conexion_Postgresql_DAL conexion = new Cls_Conexion_Postgresql_DAL();
        private int TIPO_DOCUMENTO_PUESTO_ID;
        private string TIPO_DOCUMENTO_PUESTO_NOMBRE;
        private int TIPO_DOCUMENTO_PUESTO_ESTADO;

        public int TIPO_DOCUMENTO_PUESTO_ID1 { get => TIPO_DOCUMENTO_PUESTO_ID; set => TIPO_DOCUMENTO_PUESTO_ID = value; }
        public string TIPO_DOCUMENTO_PUESTO_NOMBRE1 { get => TIPO_DOCUMENTO_PUESTO_NOMBRE; set => TIPO_DOCUMENTO_PUESTO_NOMBRE = value; }
        public int TIPO_DOCUMENTO_PUESTO_ESTADO1 { get => TIPO_DOCUMENTO_PUESTO_ESTADO; set => TIPO_DOCUMENTO_PUESTO_ESTADO = value; }

        public DataTable Consultar()
        {
            NpgsqlConnection con = null;
            string query = "select tipo_documento_puesto_id, tipo_documento_puesto_nombre, tipo_documento_puesto_estado " +
                "from catastroestablecimiento.cm_tipo_documento_puesto " +
                "order by tipo_documento_puesto_id asc;";
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
            string query = "select tipo_documento_puesto_id, tipo_documento_puesto_nombre, tipo_documento_puesto_estado " +
                "from catastroestablecimiento.cm_tipo_documento_puesto " +
                "where tipo_documento_puesto_id = " + id + " order by tipo_documento_puesto_id asc;";
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

        public DataTable Tipo_Documento_Puesto()
        {
            NpgsqlConnection con = null;
            string query = "select tipo_documento_puesto_id, tipo_documento_puesto_nombre from catastroestablecimiento.cm_tipo_documento_puesto order by tipo_documento_puesto_id asc;";
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

        public void Insertar(string nombre, int estado)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query =
                "Insert into catastroestablecimiento.cm_tipo_documento_puesto (tipo_documento_puesto_nombre, tipo_documento_puesto_estado) " +
                "values ('" + nombre + "'," + estado + ")";
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

        public void Editar(string nombre, int estado, int id)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query = "update catastroestablecimiento.cm_tipo_documento_puesto set " +
                "tipo_documento_puesto_nombre = '" + nombre + "', " +
                "tipo_documento_puesto_estado = " + estado +
                " where tipo_documento_puesto_id = " + id + "";
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
                string query = "delete from catastroestablecimiento.cm_tipo_documento_puesto where tipo_documento_puesto_id = " + id + "";
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

