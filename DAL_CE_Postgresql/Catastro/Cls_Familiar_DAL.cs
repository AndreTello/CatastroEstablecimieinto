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
    public class Cls_Familiar_DAL
    {
        Cls_Conexion_Postgresql_DAL conexion = new Cls_Conexion_Postgresql_DAL();

        public DataTable Consultar()
        {
            NpgsqlConnection con = null;
            string query = "select familiar_id, tipo_familiar_nombre, comerciante_nombres_representante_legal, familiar_cedula, familiar_apellidos, familiar_nombres, familiar_menor_edad, familiar_escolaridad, familiar_estado " +
                "from catastroestablecimiento.cm_familiar " +
                "join catastroestablecimiento.cm_tipo_familiar " +
                "on catastroestablecimiento.cm_tipo_familiar.tipo_familiar_id = catastroestablecimiento.cm_familiar.tipo_familiar_id " +
                "join catastroestablecimiento.cm_comerciante " +
                "on catastroestablecimiento.cm_comerciante.comerciante_id = catastroestablecimiento.cm_familiar.comerciante_id " +
                "order by familiar_id asc";
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
            string query = "select familiar_id, tipo_familiar_nombre, comerciante_nombres_representante_legal, familiar_cedula, familiar_apellidos, familiar_nombres, familiar_menor_edad, familiar_escolaridad, familiar_estado " +
                "from catastroestablecimiento.cm_familiar " +
                "join catastroestablecimiento.cm_tipo_familiar " +
                "on catastroestablecimiento.cm_tipo_familiar.tipo_familiar_id = catastroestablecimiento.cm_familiar.tipo_familiar_id " +
                "join catastroestablecimiento.cm_comerciante " +
                "on catastroestablecimiento.cm_comerciante.comerciante_id = catastroestablecimiento.cm_familiar.comerciante_id " +
                "where familiar_id = " + id + " " +
                "order by familiar_id asc";
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

        public DataTable Familiar()
        {
            NpgsqlConnection con = null;
            string query = "select familiar_id, familiar_nombres catastroestablecimiento.cm_familiar order by familiar_id asc";
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


        public void Insertar(int tipo, int comerciante, string cedula, string apellidos, string nombres, string menor, string escolaridad, int estado)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query =
                "Insert into catastroestablecimiento.cm_familiar (tipo_familiar_id, comerciante_id, familiar_cedula, familiar_apellidos, familiar_nombres, familiar_menor_edad, familiar_escolaridad, familiar_estado) " +
                "values (" + tipo + "," + comerciante + ",'" + cedula + "','" + apellidos + "','" + nombres + "','" + menor + "','" + escolaridad + "'," + estado + ")";
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

        public void Editar(int tipo, int comerciante, string cedula, string apellidos, string nombres, string menor, string escolaridad, int estado, int id)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query = "update catastroestablecimiento.cm_familiar set " +
                "tipo_familiar_id = " + tipo + ", " +
                "comerciante_id = " + comerciante + ", " +
                "familiar_cedula = '" + cedula + "', " +
                "familiar_apellidos = '" + apellidos + "', " +
                "familiar_nombres = '" + nombres + "', " +
                "familiar_menor_edad = '" + menor + "', " +
                "familiar_escolaridad = '" + escolaridad + "', " +
                "familiar_estado = " + estado +
                " where familiar_id = " + id + "";
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
                string query = "delete from catastroestablecimiento.cm_familiar where familiar_id = " + id + "";
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
