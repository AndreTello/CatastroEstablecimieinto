using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT_CE;

namespace DAL_CE_Postgresql.Catastro
{
    public class Cls_Provincia_DAL
    {
        Cls_Conexion_Postgresql_DAL conexion = new Cls_Conexion_Postgresql_DAL();

        NpgsqlCommand comando = new NpgsqlCommand();

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
                comando.Connection = conexion.EstablecerConexion();
                comando.CommandText = "CATASTROESTABLECIMIENTO.insertar_provincia";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("p_codigo", codigo);
                comando.Parameters.AddWithValue("p_nombre", nombre);
                comando.Parameters.AddWithValue("p_observacion", observacion);
                comando.Parameters.AddWithValue("p_estado", estado);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception ex)
            {
                // manejar excepciones
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
