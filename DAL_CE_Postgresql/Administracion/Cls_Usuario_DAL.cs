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
    public class Cls_Usuario_DAL
    {
        Cls_Conexion_Postgresql_DAL conexion = new Cls_Conexion_Postgresql_DAL();

        private int USUARIO_ID;
        private int ROL_ID;
        private string USUARIO_LOGIN;
        private string USUARIO_CLAVE;
        private string USUARIO_CEDULA;
        private string USUARIO_APELLIDOS;
        private string USUARIO_NOMBRES;
        private string USUARIO_MAIL;
        private string USUARIO_DIRECCION;
        private string USUARO_TELEFONO;
        private int USUARIO_ESTADO;

        public int USUARIO_ID1 { get => USUARIO_ID; set => USUARIO_ID = value; }
        public int ROL_ID1 { get => ROL_ID; set => ROL_ID = value; }
        public string USUARIO_LOGIN1 { get => USUARIO_LOGIN; set => USUARIO_LOGIN = value; }
        public string USUARIO_CLAVE1 { get => USUARIO_CLAVE; set => USUARIO_CLAVE = value; }
        public string USUARIO_CEDULA1 { get => USUARIO_CEDULA; set => USUARIO_CEDULA = value; }
        public string USUARIO_APELLIDOS1 { get => USUARIO_APELLIDOS; set => USUARIO_APELLIDOS = value; }
        public string USUARIO_NOMBRES1 { get => USUARIO_NOMBRES; set => USUARIO_NOMBRES = value; }
        public string USUARIO_MAIL1 { get => USUARIO_MAIL; set => USUARIO_MAIL = value; }
        public string USUARIO_DIRECCION1 { get => USUARIO_DIRECCION; set => USUARIO_DIRECCION = value; }
        public string USUARO_TELEFONO1 { get => USUARO_TELEFONO; set => USUARO_TELEFONO = value; }
        public int USUARIO_ESTADO1 { get => USUARIO_ESTADO; set => USUARIO_ESTADO = value; }

        public DataTable Consultar()
        {
            NpgsqlConnection con = null;
            string query = "select usuario_id, rol_nombre, usuario_login, usuario_clave, usuario_cedula, usuario_apellidos, usuario_nombres, usuario_mail, usuario_direccion, usuario_telefono, usuario_estado " +
                "from administracion.ad_usuario " +
                "join administracion.ad_rol " +
                "on administracion.ad_rol.rol_id = administracion.ad_usuario.rol_id " +
                "order by usuario_id asc";
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
            string query = "select usuario_id, rol_nombre, usuario_login, usuario_clave, usuario_cedula, usuario_apellidos, usuario_nombres, usuario_mail, usuario_direccion, usuario_telefono, usuario_estado " +
                "from administracion.ad_usuario " +
                "join administracion.ad_rol " +
                "on administracion.ad_rol.rol_id = administracion.ad_usuario.rol_id " +
                "where usuario_id = " + id + " " +
                "order by usuario_id asc";
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


        public void Insertar(int rol, string login, string clave, string cedula, string apellidos, string nombres, string email, string direccion, string telefono, int estado)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query =
                "Insert into administracion.ad_usuario (rol_id, usuario_login, usuario_clave, usuario_cedula, usuario_apellidos, usuario_nombres, usuario_mail, usuario_direccion, usuario_telefono, usuario_estado) " + 
                "values (" + rol + ",'" + login + "','" + clave + "','" + cedula + "','" + apellidos + "','" + nombres + "','" + email + "','" + direccion + "','" + telefono + "'," + estado + ")";
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

        public void Editar(int rol, string login, string clave, string cedula, string apellidos, string nombres, string email, string direccion, string telefono, int estado, int id)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query = "update administracion.ad_usuario set " +
                "rol_id = " + rol + ", " +
                "usuario_login = '" + login + "', " +
                "usuario_clave = '" + clave + "', " +
                "usuario_cedula = '" + cedula + "', " +
                "usuario_apellidos = '" + apellidos + "', " +
                "usuario_nombres = '" + nombres + "', " +
                "usuario_mail = '" + email + "', " +
                "usuario_direccion = '" + direccion + "', " +
                "usuario_telefono = '" + telefono + "', " +
                "usuario_estado = " + estado +
                " where usuario_id = " + id + "";
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
                string query = "delete from administracion.ad_usuario where usuario_id = " + id + "";
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
