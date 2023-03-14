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
    public class Cls_Establecimiento_DAL
    {

        Cls_Conexion_Postgresql_DAL conexion = new Cls_Conexion_Postgresql_DAL();

        NpgsqlCommand comando = new NpgsqlCommand();

        public DataTable Consultar()
        {
            DataTable tabla = new DataTable();
            NpgsqlConnection con = null;
            NpgsqlDataAdapter datos = null;
            try
            {
                con = conexion.EstablecerConexion();
                datos = new NpgsqlDataAdapter("SELECT * FROM catastroestablecimiento.consultar_establecimiento()", con);
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

        public DataTable ConsultarID(int e_id)
        {
            DataTable tabla = new DataTable();
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                NpgsqlCommand comando = new NpgsqlCommand("SELECT * FROM catastroestablecimiento.consultar_establecimientoid(@e_id)", con);
                comando.Parameters.AddWithValue("@e_id", e_id);
                NpgsqlDataAdapter datos = new NpgsqlDataAdapter(comando);
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

        public DataTable Establecimiento()
        {
            DataTable tabla = new DataTable();
            NpgsqlConnection con = null;
            NpgsqlDataAdapter datos = null;
            try
            {
                con = conexion.EstablecerConexion();
                datos = new NpgsqlDataAdapter("SELECT * FROM catastroestablecimiento.establecimiento()", con);
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


        public void Insertar(int lote, int admnistracion, int tipo, int asociacion, int intervencion, string predio, string clave_catastral, string nomenclatura_vial, string calle_principal, string calle_secundaria, string paqueadero, int numero_parqueadero, string dias_apertura, string horario_atencion, int estado)
        {
            NpgsqlConnection con = null;
            try
            {
                comando.Connection = conexion.EstablecerConexion();
                comando.CommandText = "catastroestablecimiento.insertar_establecimiento";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("l_id", lote);
                comando.Parameters.AddWithValue("az_id", admnistracion);
                comando.Parameters.AddWithValue("te_id", tipo);
                comando.Parameters.AddWithValue("a_id", asociacion);
                comando.Parameters.AddWithValue("ite_id", intervencion);
                comando.Parameters.AddWithValue("e_predio", predio);
                comando.Parameters.AddWithValue("e_clave_catastral", clave_catastral);
                comando.Parameters.AddWithValue("e_nomenclatura_vial", nomenclatura_vial);
                comando.Parameters.AddWithValue("e_calle_principal", calle_principal);
                comando.Parameters.AddWithValue("e_calle_secundaria", calle_secundaria);
                comando.Parameters.AddWithValue("e_paqueadero", paqueadero);
                comando.Parameters.AddWithValue("e_numero_parqueadero", numero_parqueadero);
                comando.Parameters.AddWithValue("e_dias_apertura", dias_apertura);
                comando.Parameters.AddWithValue("e_horario_atencion", horario_atencion);
                comando.Parameters.AddWithValue("e_estado", estado);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
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

        public void Editar(int id, int lote, int admnistracion, int tipo, int asociacion, int intervencion, string predio, string clave_catastral, string nomenclatura_vial, string calle_principal, string calle_secundaria, string paqueadero, int numero_parqueadero, string dias_apertura, string horario_atencion, int estado)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                NpgsqlCommand comando = new NpgsqlCommand("catastroestablecimiento.editar_establecimiento", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("e_id", id);
                comando.Parameters.AddWithValue("l_id", lote);
                comando.Parameters.AddWithValue("az_id", admnistracion);
                comando.Parameters.AddWithValue("te_id", tipo);
                comando.Parameters.AddWithValue("a_id", asociacion);
                comando.Parameters.AddWithValue("ite_id", intervencion);
                comando.Parameters.AddWithValue("e_predio", predio);
                comando.Parameters.AddWithValue("e_clave_catastral", clave_catastral);
                comando.Parameters.AddWithValue("e_nomenclatura_vial", nomenclatura_vial);
                comando.Parameters.AddWithValue("e_calle_principal", calle_principal);
                comando.Parameters.AddWithValue("e_calle_secundaria", calle_secundaria);
                comando.Parameters.AddWithValue("e_paqueadero", paqueadero);
                comando.Parameters.AddWithValue("e_numero_parqueadero", numero_parqueadero);
                comando.Parameters.AddWithValue("e_dias_apertura", dias_apertura);
                comando.Parameters.AddWithValue("e_horario_atencion", horario_atencion);
                comando.Parameters.AddWithValue("e_estado", estado);
                comando.ExecuteNonQuery();
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
                NpgsqlCommand comando = new NpgsqlCommand("catastroestablecimiento.eliminar_establecimiento", con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("e_id", id);
                comando.ExecuteNonQuery();
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
