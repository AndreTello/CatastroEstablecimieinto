using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using ENT_CE;

namespace DAL_CE_Postgresql.Catastro
{
    public class Cls_Giro_Negocio_DAL
    {
        Cls_Conexion_Postgresql_DAL conexion = new Cls_Conexion_Postgresql_DAL();

        

        public DataTable Consultar()
        {
            NpgsqlConnection con = null;
            string query = "select giro_negocio_id, tipo_producto_nombre, giro_negocio_nombre, giro_negocio_subgiro, giro_negocio_abastecimiento, giro_negocio_observacion, giro_negocio_estado " +
                "from catastroestablecimiento.cm_giro_negocio " +
                "join catastroestablecimiento.cm_tipo_producto " +
                "on catastroestablecimiento.cm_tipo_producto.tipo_producto_id = catastroestablecimiento.cm_giro_negocio.tipo_producto_id " +
                "order by giro_negocio_id asc";
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
            string query = "select giro_negocio_id, tipo_producto_nombre, giro_negocio_nombre, giro_negocio_subgiro, giro_negocio_abastecimiento, giro_negocio_observacion, giro_negocio_estado " +
                "from catastroestablecimiento.cm_giro_negocio " +
                "join catastroestablecimiento.cm_tipo_producto " +
                "on catastroestablecimiento.cm_tipo_producto.tipo_producto_id = catastroestablecimiento.cm_giro_negocio.tipo_producto_id " +
                "where giro_negocio_id = " + id + " " +
                "order by giro_negocio_id asc";
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

        public DataTable Giro_Negocio()
        {
            NpgsqlConnection con = null;
            string query = "select giro_negocio_id, giro_negocio_nombre from catastroestablecimiento.cm_giro_negocio order by giro_negocio_id asc";
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


        public void Insertar(int producto, string nombre, string subgiro, string abastecimiento, string observacion, int estado)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query =
                "Insert into catastroestablecimiento.cm_giro_negocio (tipo_producto_id, giro_negocio_nombre, giro_negocio_subgiro, giro_negocio_abastecimiento, giro_negocio_observacion, giro_negocio_estado) " +
                "values (" + producto + ",'" + nombre + "','" + subgiro + "','" + abastecimiento + "','" + observacion + "'," + estado + ")";
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

        public void Editar(int producto, string nombre, string subgiro, string abastecimiento, string observacion, int estado, int id)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query = "update catastroestablecimiento.cm_giro_negocio set " +
                "tipo_producto_id = " + producto + ", " +
                "giro_negocio_nombre = '" + nombre + "', " +
                "giro_negocio_subgiro = '" + subgiro + "', " +
                "giro_negocio_abastecimiento = '" + abastecimiento + "', " +
                "giro_negocio_observacion = '" + observacion + "', " +
                "giro_negocio_estado = " + estado +
                " where giro_negocio_id = " + id + "";
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
                string query = "delete from catastroestablecimiento.cm_giro_negocio where giro_negocio_id = " + id + "";
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
