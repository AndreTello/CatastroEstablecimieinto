using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DAL_CE_Postgresql.Catastro
{
    public class Cls_Administracion_Zonal_DAL
    {
        Cls_Conexion_Postgresql_DAL conexion = new Cls_Conexion_Postgresql_DAL();

        private int ADMINISTRACION_ZONAL_ID;
        private string ADMINISTRACION_ZONAL_NOMBRE;
        private string ADMINISTRACION_ZONAL_DETALLE;
        private string ADMINISTRACION_ZONAL_TELEFONO;
        private string ADMINISTRACION_ZONAL_CELULAR;
        private string ADMINISTRACION_ZONAL_MAIL;
        private string ADMINISTRACION_ZONAL_PAGINA_WEB;
        private string ADMINISTRACION_ZONAL_REPRESENTANTE;
        private int ADMINISTRACION_ZONAL_ESTADO;

        public int ADMINISTRACION_ZONAL_ID1 { get => ADMINISTRACION_ZONAL_ID; set => ADMINISTRACION_ZONAL_ID = value; }
        public string ADMINISTRACION_ZONAL_NOMBRE1 { get => ADMINISTRACION_ZONAL_NOMBRE; set => ADMINISTRACION_ZONAL_NOMBRE = value; }
        public string ADMINISTRACION_ZONAL_DETALLE1 { get => ADMINISTRACION_ZONAL_DETALLE; set => ADMINISTRACION_ZONAL_DETALLE = value; }
        public string ADMINISTRACION_ZONAL_TELEFONO1 { get => ADMINISTRACION_ZONAL_TELEFONO; set => ADMINISTRACION_ZONAL_TELEFONO = value; }
        public string ADMINISTRACION_ZONAL_CELULAR1 { get => ADMINISTRACION_ZONAL_CELULAR; set => ADMINISTRACION_ZONAL_CELULAR = value; }
        public string ADMINISTRACION_ZONAL_MAIL1 { get => ADMINISTRACION_ZONAL_MAIL; set => ADMINISTRACION_ZONAL_MAIL = value; }
        public string ADMINISTRACION_ZONAL_PAGINA_WEB1 { get => ADMINISTRACION_ZONAL_PAGINA_WEB; set => ADMINISTRACION_ZONAL_PAGINA_WEB = value; }
        public string ADMINISTRACION_ZONAL_REPRESENTANTE1 { get => ADMINISTRACION_ZONAL_REPRESENTANTE; set => ADMINISTRACION_ZONAL_REPRESENTANTE = value; }
        public int ADMINISTRACION_ZONAL_ESTADO1 { get => ADMINISTRACION_ZONAL_ESTADO; set => ADMINISTRACION_ZONAL_ESTADO = value; }

        public DataTable Consultar()
        {
            NpgsqlConnection con = null;
            string query = "select administracion_zonal_id, administracion_zonal_nombre, administracion_zonal_detalle, administracion_zonal_telefono, administracion_zonal_celular, administracion_zonal_mail, administracion_zonal_pagina_web, administracion_zonal_representante, administracion_zonal_estado " +
                "from catastroestablecimiento.cm_administracion_zonal " +
                "order by administracion_zonal_id asc;";
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


        public DataTable ConsultarId(int id)
        {
            NpgsqlConnection con = null;
            string query = "select administracion_zonal_id, administracion_zonal_nombre, administracion_zonal_detalle, administracion_zonal_telefono, administracion_zonal_celular, administracion_zonal_mail, administracion_zonal_pagina_web, administracion_zonal_representante, administracion_zonal_estado " +
                "from catastroestablecimiento.cm_administracion_zonal where administracion_zonal_id = " + id + " order by administracion_zonal_id asc;";
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

        public DataTable Administracion_Zonal()
        {
            NpgsqlConnection con = null;
            string query = "select administracion_zonal_id, administracion_zonal_nombre from catastroestablecimiento.cm_administracion_zonal order by administracion_zonal_id asc";
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


        public void Insertar(string nombre, string detalle, string telefono, string celular, string mail, string pagina_web, string representante, int estado)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query =
                "Insert into catastroestablecimiento.cm_administracion_zonal (administracion_zonal_nombre, administracion_zonal_detalle, administracion_zonal_telefono, administracion_zonal_celular, administracion_zonal_mail, administracion_zonal_pagina_web, administracion_zonal_representante, administracion_zonal_estado) " +
                "values ('" + nombre + "','" + detalle + "','" + telefono + "','" + celular + "','" + mail + "','" + pagina_web + "','" + representante + "'," + estado + ")";
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

        public void Editar(string nombre, string detalle, string telefono, string celular, string mail, string pagina_web, string representante, int estado, int id)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query =
                "update catastroestablecimiento.cm_administracion_zonal set administracion_zonal_nombre = '" + nombre + "', administracion_zonal_detalle = '"+ detalle + "', " +
                "administracion_zonal_telefono = '"+telefono+ "', administracion_zonal_celular = '"+celular+ "', administracion_zonal_mail = '"+mail+ "', " +
                "administracion_zonal_pagina_web = '"+pagina_web+ "', administracion_zonal_representante = '"+representante+ "', administracion_zonal_estado = "+estado+" " +
                "where administracion_zonal_id = " + id + "";
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
                string query = "delete from catastroestablecimiento.cm_administracion_zonal where administracion_zonal_id = " + id + "";
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
