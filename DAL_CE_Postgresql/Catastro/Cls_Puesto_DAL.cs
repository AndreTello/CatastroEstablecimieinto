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
    public class Cls_Puesto_DAL
    {
        Cls_Conexion_Postgresql_DAL conexion = new Cls_Conexion_Postgresql_DAL();

        public DataTable Consultar()
        {
            NpgsqlConnection con = null;
            string query = "select puesto_id, piso_nombre, tipo_area_nombre, comerciante_nombres_representante_legal, ayudante_nombres, reemplazo_nombres, documento_puesto_nombre, puesto_predio, puesto_clave_catastral, puesto_estado_conservacion, puesto_acabados, puesto_paredes, puesto_remodelacion, puesto_estado " +
                "from catastroestablecimiento.cm_puesto " +
                "join catastroestablecimiento.cm_piso " +
                "on catastroestablecimiento.cm_piso.piso_id = catastroestablecimiento.cm_puesto.piso_id " +
                "join catastroestablecimiento.cm_tipo_area " +
                "on catastroestablecimiento.cm_tipo_area.tipo_area_id = catastroestablecimiento.cm_puesto.tipo_area_id " +
                "join catastroestablecimiento.cm_comerciante " +
                "on catastroestablecimiento.cm_comerciante.comerciante_id = catastroestablecimiento.cm_puesto.comerciante_id " +
                "join catastroestablecimiento.cm_ayudante " +
                "on catastroestablecimiento.cm_ayudante.ayudante_id = catastroestablecimiento.cm_puesto.ayudante_id " +
                "join catastroestablecimiento.cm_reemplazo " +
                "on catastroestablecimiento.cm_reemplazo.reemplazo_id = catastroestablecimiento.cm_puesto.reemplazo_id " +
                "join catastroestablecimiento.cm_documento_puesto " +
                "on catastroestablecimiento.cm_documento_puesto.documento_puesto_id = catastroestablecimiento.cm_puesto.documento_puesto_id " +
                "order by puesto_id asc";
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
            string query = "select puesto_id, piso_nombre, tipo_area_nombre, comerciante_nombres_representante_legal, ayudante_nombres, reemplazo_nombres, documento_puesto_nombre, puesto_predio, puesto_clave_catastral, puesto_estado_conservacion, puesto_acabados, puesto_paredes, puesto_remodelacion, puesto_estado " +
                "from catastroestablecimiento.cm_puesto " +
                "join catastroestablecimiento.cm_piso " +
                "on catastroestablecimiento.cm_piso.piso_id = catastroestablecimiento.cm_puesto.piso_id " +
                "join catastroestablecimiento.cm_tipo_area " +
                "on catastroestablecimiento.cm_tipo_area.tipo_area_id = catastroestablecimiento.cm_puesto.tipo_area_id " +
                "join catastroestablecimiento.cm_comerciante " +
                "on catastroestablecimiento.cm_comerciante.comerciante_id = catastroestablecimiento.cm_puesto.comerciante_id " +
                "join catastroestablecimiento.cm_ayudante " +
                "on catastroestablecimiento.cm_ayudante.ayudante_id = catastroestablecimiento.cm_puesto.ayudante_id " +
                "join catastroestablecimiento.cm_reemplazo " +
                "on catastroestablecimiento.cm_reemplazo.reemplazo_id = catastroestablecimiento.cm_puesto.reemplazo_id " +
                "join catastroestablecimiento.cm_documento_puesto " +
                "on catastroestablecimiento.cm_documento_puesto.documento_puesto_id = catastroestablecimiento.cm_puesto.documento_puesto_id " +
                "where puesto_id = " + id + " " +
                "order by puesto_id asc";
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

        public DataTable Puesto()
        {
            NpgsqlConnection con = null;
            string query = "select puesto_id, puesto_clave_catastral from catastroestablecimiento.cm_puesto order by puesto_id asc";
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


        public void Insertar(int piso, int area, int comerciante, int ayudante, int reemplazo, int documento,  string predio, string clave_catastral, string estado_conservacion, string acabados, string paredes, string remodelacion, int estado)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query =
                "Insert into catastroestablecimiento.cm_puesto (piso_id, tipo_area_id, comerciante_id, ayudante_id, reemplazo_id, documento_puesto_id, puesto_predio, puesto_clave_catastral, puesto_estado_conservacion, puesto_acabados, puesto_paredes, puesto_remodelacion, puesto_estado) " +
                "values (" + piso + "," + area + "," + comerciante + "," + ayudante + "," + reemplazo + "," + documento + ",'" + predio + "','" + clave_catastral + "','" + estado_conservacion + "','" + acabados + "','" + paredes + "','" + remodelacion + "'," + estado + ")";
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

        public void Editar(int piso, int area, int comerciante, int ayudante, int reemplazo, int documento, string predio, string clave_catastral, string estado_conservacion, string acabados, string paredes, string remodelacion, int estado, int id)
        {
            NpgsqlConnection con = null;
            try
            {
                con = conexion.EstablecerConexion();
                string query =
                "update catastroestablecimiento.cm_puesto set " +
                "piso_id = " + piso + ", " +
                "tipo_area_id = " + area + ", " +
                "comerciante_id = " + comerciante + ", " +
                "ayudante_id = " + ayudante + ", " +
                "reemplazo_id = " + reemplazo + ", " +
                "documento_puesto_id = " + documento + ", " +
                "puesto_predio = '" + predio + "', " +
                "puesto_clave_catastral = '" + clave_catastral + "', " +
                "puesto_estado_conservacion = '" + estado_conservacion + "', " +
                "puesto_acabados = '" + acabados + "', " +
                "puesto_paredes = '" + paredes + "', " +
                "puesto_remodelacion = '" + remodelacion + "', " +
                "puesto_estado = " + estado + " " +
                "where puesto_id = " + id + " ";
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
                string query = "delete from catastroestablecimiento.cm_puesto where puesto_id = " + id + "";
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
