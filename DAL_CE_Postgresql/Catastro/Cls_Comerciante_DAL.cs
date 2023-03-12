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
    public class Cls_Comerciante_DAL
    {

        Cls_Conexion_Postgresql_DAL conexion = new Cls_Conexion_Postgresql_DAL();

        public DataTable Consultar()
        {
            NpgsqlConnection con = null;
            string query = "select comerciante_id, tipo_identificacion_nombre, tipo_ocupante_nombre, comerciante_cedula_ruc, comerciante_apellidos_razon_social, comerciante_nombres_representante_legal, comerciante_fecha_nacimiento, comerciante_edad, comerciante_lugar_origen, comerciante_telefono_convencional, comerciante_telefono_celular, comerciante_direccion_domicilio, comerciante_ciudad, comerciante_provincia, comerciante_mail, comerciante_estado " +
                "from catastroestablecimiento.cm_comerciante " +
                "join catastroestablecimiento.cm_tipo_identificacion " +
                "on catastroestablecimiento.cm_tipo_identificacion.tipo_identificacion_id = catastroestablecimiento.cm_comerciante.tipo_identificacion_id " +
                "join catastroestablecimiento.cm_tipo_ocupante " +
                "on catastroestablecimiento.cm_tipo_ocupante.tipo_ocupante_id = catastroestablecimiento.cm_comerciante.tipo_ocupante_id " +
                "order by comerciante_id asc";
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
            string query = "select comerciante_id, tipo_identificacion_nombre, tipo_ocupante_nombre, comerciante_cedula_ruc, comerciante_apellidos_razon_social, comerciante_nombres_representante_legal, comerciante_fecha_nacimiento, comerciante_edad, comerciante_lugar_origen, comerciante_telefono_convencional, comerciante_telefono_celular, comerciante_direccion_domicilio, comerciante_ciudad, comerciante_provincia, comerciante_mail, comerciante_estado " +
                "from catastroestablecimiento.cm_comerciante " +
                "join catastroestablecimiento.cm_tipo_identificacion " +
                "on catastroestablecimiento.cm_tipo_identificacion.tipo_identificacion_id = catastroestablecimiento.cm_comerciante.tipo_identificacion_id " +
                "join catastroestablecimiento.cm_tipo_ocupante " +
                "on catastroestablecimiento.cm_tipo_ocupante.tipo_ocupante_id = catastroestablecimiento.cm_comerciante.tipo_ocupante_id where comerciante_id = " + id + " order by comerciante_id asc";
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

        public DataTable Comerciante()
        {
            NpgsqlConnection con = null;
            string query = "select comerciante_id, comerciante_nombres_representante_legal from catastroestablecimiento.cm_comerciante order by comerciante_id asc";
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


        public void Insertar(int identificacion, int ocupante, string cedula, string apellidos, string nombres, string fecha_n, int edad, string lugar, string telefono, string celular, string direccion, string ciudad, string provincia, string email, int estado)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query =
                "Insert into catastroestablecimiento.cm_comerciante (tipo_identificacion_id, tipo_ocupante_id, comerciante_cedula_ruc, comerciante_apellidos_razon_social, comerciante_nombres_representante_legal, comerciante_fecha_nacimiento, comerciante_edad, comerciante_lugar_origen, comerciante_telefono_convencional, comerciante_telefono_celular, comerciante_direccion_domicilio, comerciante_ciudad, comerciante_provincia, comerciante_mail, comerciante_estado) " +
                "values (" + identificacion + "," + ocupante + ",'" + cedula + "','" + apellidos + "','" + nombres + "','" + fecha_n + "'," + edad + ",'" + lugar + "','" + telefono + "','" + celular + "','" + direccion + "','" + ciudad + "','" + provincia + "','" + email + "'," + estado + ")";
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

        public void Editar(int identificacion, int ocupante, string cedula, string apellidos, string nombres, string fecha_n, int edad, string lugar, string telefono, string celular, string direccion, string ciudad, string provincia, string email, int estado, int id)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query =
                "update catastroestablecimiento.cm_comerciante set " +
                "tipo_identificacion_id = " + identificacion + ", " +
                "tipo_ocupante_id = " + ocupante + ", " +
                "comerciante_cedula_ruc = '" + cedula + "', " +
                "comerciante_apellidos_razon_social = '" + apellidos + "', " +
                "comerciante_nombres_representante_legal = '" + nombres + "', " +
                "comerciante_fecha_nacimiento = '" + fecha_n + "', " +
                "comerciante_edad = " + edad + ", " +
                "comerciante_lugar_origen = '" + lugar + "', " +
                "comerciante_telefono_convencional = '" + telefono + "', " +
                "comerciante_telefono_celular = '" + celular + "', " +
                "comerciante_direccion_domicilio = '" + direccion + "', " +
                "comerciante_ciudad = '" + ciudad + "', " +
                "comerciante_provincia = '" + provincia + "', " +
                "comerciante_mail = '" + email + "', " +
                "comerciante_estado = " + estado + " " +
                "where comerciante_id = " + id + "";
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
                string query = "delete from catastroestablecimiento.cm_comerciante where comerciante_id = " + id + "";
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
