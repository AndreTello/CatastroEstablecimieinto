using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL_CE_Postgresql.Catastro
{
    public class Cls_Tipos_Producto_DAL
    {
        Cls_Conexion_Postgresql_DAL conexion = new Cls_Conexion_Postgresql_DAL();
        
        private int TIPO_PRODUCTO_ID;
        private string TIPO_PRODUCTO_NOMBRE;
        private string TIPO_PRODUCTO_DETALLE;
        private string TIPO_PRODUCTO_OBSERVACION;
        private int TIPO_PRODUCTO_ESTADO;

        public int TIPO_PRODUCTO_ID1 { get => TIPO_PRODUCTO_ID; set => TIPO_PRODUCTO_ID = value; }
        public string TIPO_PRODUCTO_NOMBRE1 { get => TIPO_PRODUCTO_NOMBRE; set => TIPO_PRODUCTO_NOMBRE = value; }
        public string TIPO_PRODUCTO_DETALLE1 { get => TIPO_PRODUCTO_DETALLE; set => TIPO_PRODUCTO_DETALLE = value; }
        public string TIPO_PRODUCTO_OBSERVACION1 { get => TIPO_PRODUCTO_OBSERVACION; set => TIPO_PRODUCTO_OBSERVACION = value; }
        public int TIPO_PRODUCTO_ESTADO1 { get => TIPO_PRODUCTO_ESTADO; set => TIPO_PRODUCTO_ESTADO = value; }

        public DataTable Consultar()
        {
            NpgsqlConnection con = null;
            string query = "select tipo_producto_id, tipo_producto_nombre, tipo_producto_detalle, tipo_producto_observacion, tipo_producto_estado " +
                "from catastroestablecimiento.cm_tipo_producto " +
                "order by tipo_producto_id asc;";
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
            string query = "select tipo_producto_id, tipo_producto_nombre, tipo_producto_detalle, tipo_producto_observacion, tipo_producto_estado " +
                "from catastroestablecimiento.cm_tipo_producto " +
                "where tipo_producto_id = " + id + " " +
                "order by tipo_producto_id asc;";
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

        public DataTable Tipo_Producto()
        {
            NpgsqlConnection con = null;
            string query = "select tipo_producto_id, tipo_producto_nombre from catastroestablecimiento.cm_tipo_producto order by tipo_producto_id asc";
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


        public void Insertar(string nombre, string detalle, string observacion, int estado)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query =
                "Insert into catastroestablecimiento.cm_tipo_producto (tipo_producto_nombre, tipo_producto_detalle, tipo_producto_observacion, tipo_producto_estado) " +
                "values ('" + nombre + "','" + detalle + "','" + observacion + "'," + estado + ")";
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

        public void Editar(string nombre, string detalle, string observacion, int estado, int id)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query =
                "update catastroestablecimiento.cm_tipo_producto set " +
                "tipo_producto_nombre = '" + nombre + "', " +
                "tipo_producto_detalle = '" + detalle + "', " +
                "tipo_producto_observacion = '" + observacion + "', " +
                "tipo_producto_estado = " + estado + " " +
                "where tipo_producto_id = " + id + "";
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
                string query = "delete from catastroestablecimiento.cm_tipo_producto where tipo_producto_id = " + id + "";
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
