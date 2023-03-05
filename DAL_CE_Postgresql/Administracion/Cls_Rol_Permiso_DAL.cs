using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DAL_CE_Postgresql.Administracion
{
    public class Cls_Rol_Permiso_DAL
    {   
        Cls_Conexion_Postgresql_DAL conexion = new Cls_Conexion_Postgresql_DAL();

        private int ROL_PERMISO_ID;
        private int ROL_ID;
        private int PERMISO_ID;
        private int ROL_PERMISO_ESTADO;

        public int ROL_PERMISO_ID1 { get => ROL_PERMISO_ID; set => ROL_PERMISO_ID = value; }
        public int ROL_ID1 { get => ROL_ID; set => ROL_ID = value; }
        public int PERMISO_ID1 { get => PERMISO_ID; set => PERMISO_ID = value; }
        public int ROL_PERMISO_ESTADO1 { get => ROL_PERMISO_ESTADO; set => ROL_PERMISO_ESTADO = value; }

        public DataTable Consultar()
        {
            NpgsqlConnection con = null;
            string query = "select rol_permiso_id, rol_nombre, permiso_nombre, rol_permiso_estado " +
                "from administracion.ad_rol_permiso " +
                "join administracion.ad_rol " +
                "on administracion.ad_rol.rol_id = administracion.ad_rol_permiso.rol_id " +
                "join administracion.ad_permiso " +
                "on administracion.ad_permiso.permiso_id = administracion.ad_rol_permiso.permiso_id " +
                "order by rol_permiso_id asc";
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
            string query = "select rol_permiso_id, rol_nombre, permiso_nombre, rol_permiso_estado " +
                "from administracion.ad_rol_permiso " +
                "join administracion.ad_rol " +
                "on administracion.ad_rol.rol_id = administracion.ad_rol_permiso.rol_id " +
                "join administracion.ad_permiso " +
                "on administracion.ad_permiso.permiso_id = administracion.ad_rol_permiso.permiso_id " +
                "where rol_permiso_id = " + id + " " +
                "order by rol_permiso_id asc";
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

        /*public DataTable Rol_Permiso()
        {
            NpgsqlConnection con = null;
            string query = "select familiar_id, familiar_nombres administracion.ad_rol_permiso order by familiar_id asc";
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
        }*/


        public void Insertar(int rol, int permiso, int estado)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query =
                "Insert into administracion.ad_rol_permiso (rol_id, permiso_id, rol_permiso_estado) " +
                "values (" + rol + "," + permiso + "," + estado + ")";
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

        public void Editar(int rol, int permiso, int estado, int id)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query = "update administracion.ad_rol_permiso set " +
                "rol_id = " + rol + ", " +
                "permiso_id = " + permiso + ", " +
                "rol_permiso_estado = " + estado +
                " where rol_permiso_id = " + id + "";
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
                string query = "delete from administracion.ad_rol_permiso where rol_permiso_id = " + id + "";
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
