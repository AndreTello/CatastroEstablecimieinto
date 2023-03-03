using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL_CE_Postgresql.Catastro
{
    public class Cls_Provincia_DAL
    {
        Cls_Conexion_Postgresql_DAL conexion = new Cls_Conexion_Postgresql_DAL();

        private int PROVINCIA_ID;
        private string PROVINCIA_CODIGO;
        private string PROVINCIA_NOMBRE;
        private int PROVINCIA_ESTADO;
        private string PROVINCIA_OBSERVACION;

        public int PROVINCIA_ID1 { get => PROVINCIA_ID; set => PROVINCIA_ID = value; }
        public string PROVINCIA_CODIGO1 { get => PROVINCIA_CODIGO; set => PROVINCIA_CODIGO = value; }
        public string PROVINCIA_NOMBRE1 { get => PROVINCIA_NOMBRE; set => PROVINCIA_NOMBRE = value; }
        public int PROVINCIA_ESTADO1 { get => PROVINCIA_ESTADO; set => PROVINCIA_ESTADO = value; }
        public string PROVINCIA_OBSERVACION1 { get => PROVINCIA_OBSERVACION; set => PROVINCIA_OBSERVACION = value; }

        public DataTable Consultar()
        {
            NpgsqlConnection con = null;
            string query = "select * from catastroestablecimiento.cm_provincia order by provincia_id asc;";
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
            catch (Exception ex )
            {
            }
            finally
            {
                if(con != null)
                {
                    con.Close();
                }
            }
            return tabla;
        }

        public DataTable ConsultarID(int id)
        {
            NpgsqlConnection con = null;
            string query = "select * from catastroestablecimiento.cm_provincia where provincia_id = " + id + " order by provincia_id asc;";
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

        public DataTable Provincia()
        {
            NpgsqlConnection con = null;
            string query = "select provincia_id, provincia_nombre from catastroestablecimiento.cm_provincia order by provincia_id asc;";
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

        public void Insertar(string codigo, string nombre, string observacion, int estado)
        {
            NpgsqlConnection con = null; 
            try
            {
                con = conexion.EstablecerConexion();
                string query =
                "Insert into catastroestablecimiento.cm_provincia (provincia_codigo, provincia_nombre, provincia_observacion, provincia_estado) " +
                "values ('" + codigo + "','" + nombre + "','" + observacion + "'," + estado + ")";
                NpgsqlCommand insert = new NpgsqlCommand(query, con);
                insert.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }  
        }

        public void Editar(string codigo, string nombre, string observacion, int estado, int id)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query = "update catastroestablecimiento.cm_provincia set provincia_codigo = '" + codigo + "', " +
                "provincia_nombre = '" + nombre + "', provincia_observacion = '" + observacion + "', provincia_estado = " + estado +
                " where provincia_id = " + id + "";
                NpgsqlCommand update = new NpgsqlCommand(query, con);
                update.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
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
                string query = "delete from catastroestablecimiento.cm_provincia where provincia_id = " + id + "";
                NpgsqlCommand delete = new NpgsqlCommand(query, con);
                delete.ExecuteNonQuery(); 
            }
            catch (Exception ex)
            {
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
