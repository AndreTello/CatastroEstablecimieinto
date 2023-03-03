using Npgsql;
using System;
using System.Data;

namespace DAL_CE_Postgresql.Catastro
{
    public class Cls_Tipo_Documento_Puesto_DAL
    {
        Cls_Conexion_Postgresql_DAL conexion = new Cls_Conexion_Postgresql_DAL();
        private int TIPO_DOCUMENTO_PUESTO_ID;
        private string TIPO_DOCUMENTO_PUESTO_NOMBRE;
        private int TIPO_DOCUMENTO_PUESTO_ESTADO;

        public int TIPO_DOCUMENTO_PUESTO_ID1 { get => TIPO_DOCUMENTO_PUESTO_ID; set => TIPO_DOCUMENTO_PUESTO_ID = value; }
        public string TIPO_DOCUMENTO_PUESTO_NOMBRE1 { get => TIPO_DOCUMENTO_PUESTO_NOMBRE; set => TIPO_DOCUMENTO_PUESTO_NOMBRE = value; }
        public int TIPO_DOCUMENTO_PUESTO_ESTADO1 { get => TIPO_DOCUMENTO_PUESTO_ESTADO; set => TIPO_DOCUMENTO_PUESTO_ESTADO = value; }

        public void Ingresar_Tipo_Documento_Puesto(string nombre, int estado)
        {
            try
            {
                NpgsqlConnection con = null;
                con = conexion.EstablecerConexion();
                string query = "insert into catastroestablecimiento.cm_tipo_documento_puesto(tipo_documento_puesto_nombre, tipo_documento_puesto_estado) " +
                    "values('" + nombre + "', " + estado + ")";
                NpgsqlCommand conector = new NpgsqlCommand(query, con);
                conector.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine("HA OCURRIDO UN ERROR:  " + ex.ToString());
            }
            finally
            {

            }
        }
        public DataTable Consultar_Tipo_Documento_Puesto()
        {

            NpgsqlConnection con = null;
            string query = "INSERT INTO catastroestablecimiento.cm_tipo_documento_puesto(tipo_documento_puesto_nombre, tipo_documento_puesto_estado) VALUES " +
                "order by tipo_documento_puesto_id asc";
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


        public void Modificar_Tipo_Documento_Puesto()
        {
            
        }
        public void Eliminar_Tipo_Documento_Puesto()
        {
            
        }


    }
}

