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
    public class Cls_Piso_DAL
    {
        Cls_Conexion_Postgresql_DAL conexion = new Cls_Conexion_Postgresql_DAL();

        private int PISO_ID;
        private int BLOQUE_ID;
		private string PISO_CODIGO;
        private string PISO_NOMBRE;
        private int PISO_ESTADO;
		private string PISO_OBSERVACION;

        public int PISO_ID1 { get => PISO_ID; set => PISO_ID = value; }
        public int BLOQUE_ID1 { get => BLOQUE_ID; set => BLOQUE_ID = value; }
        public string PISO_CODIGO1 { get => PISO_CODIGO; set => PISO_CODIGO = value; }
        public string PISO_NOMBRE1 { get => PISO_NOMBRE; set => PISO_NOMBRE = value; }
        public int PISO_ESTADO1 { get => PISO_ESTADO; set => PISO_ESTADO = value; }
        public string PISO_OBSERVACION1 { get => PISO_OBSERVACION; set => PISO_OBSERVACION = value; }

        public DataTable Consultar()
        {
            NpgsqlConnection con = null;
            string query = "select piso_id, bloque_nombre, piso_codigo, piso_nombre, piso_observacion, piso_estado " +
                "from catastroestablecimiento.cm_piso " +
                "join catastroestablecimiento.cm_bloque " +
                "on catastroestablecimiento.cm_bloque.bloque_id = catastroestablecimiento.cm_piso.bloque_id " +
                "order by piso_id asc";
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
            string query = "select piso_id, bloque_nombre, piso_codigo, piso_nombre, piso_observacion, piso_estado " +
                "from catastroestablecimiento.cm_piso " +
                "join catastroestablecimiento.cm_bloque " +
                "on catastroestablecimiento.cm_bloque.bloque_id = catastroestablecimiento.cm_piso.bloque_id " +
                "where piso_id = " + id + " " +
                "order by piso_id asc";
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

        public DataTable Piso()
        {
            NpgsqlConnection con = null;
            string query = "select piso_id, piso_nombre from catastroestablecimiento.cm_piso order by piso_id asc";
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


        public void Insertar(int bloque, string codigo, string nombre, string observacion, int estado)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query =
                "Insert into catastroestablecimiento.cm_piso (bloque_id, piso_codigo, piso_nombre, piso_observacion, piso_estado) " +
                "values (" + bloque + ",'" + codigo + "','" + nombre + "','" + observacion + "'," + estado + ")";
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

        public void Editar(int bloque, string codigo, string nombre, string observacion, int estado, int id)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query = "update catastroestablecimiento.cm_piso set " +
                "bloque_id = " + bloque + ", " +
                "piso_codigo = '" + codigo + "', " +
                "piso_nombre = '" + nombre + "', " +
                "piso_observacion = '" + observacion + "', " +
                "piso_estado = " + estado +
                " where piso_id = " + id + "";
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
                string query = "delete from catastroestablecimiento.cm_piso where piso_id = " + id + "";
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
