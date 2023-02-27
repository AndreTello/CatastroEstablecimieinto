using DAL_CE_SQLLite.Catastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data.SQLite;


namespace BLL_CE.Catastro
{
    public class Cls_Ayudante_BLL
    {
        /*Cls_Ayudante_DAL objdll = new Cls_Ayudante_DAL();

        public void Consultar()
        {
            objdll.Consultar_Ayudante();
        }

        public void Insertar()
        {
            objdll.Ingresar_Ayudante();
        }

        public void Editar()
        {
            objdll.Modificar_Ayudante();
        }

        public void Eliminar()
        {
            objdll.Eliminar_Ayudante();
        }*/

        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static Cls_Ayudante_BLL _instancia = null;

        public Cls_Ayudante_BLL()
        {

        }

        public static Cls_Ayudante_BLL Instancia
        {
            get
            {
                if(_instancia == null)
                {
                    _instancia = new Cls_Ayudante_BLL();
                }
                return _instancia;

            }
        }

        public bool Insertar (Cls_Ayudante_DAL obj)
        {
            bool res = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "insert into AYUDANTE (AYUDANTE_CEDULA, AYUDANTE_APELLIDOS, AYUDANTE_NOMBRES, AYUDANTE_PARENTEZCO, AYUDANTE_AUTORIZACION, AYUDANTE_NUMERO_OFICIO, AYUDANTE_FECHA_OFICIO, AYUDANTE_ESTADO)" +
                    "values (@ayudante_cedula, @ayudante_apellidos, @ayudante_nombres, @ayudante_parentezco, @ayudante_autorizacion, @ayudante_numero_oficio, @ayudante_fecha_oficio, @ayudante_estado)";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@ayudante_cedula", obj.AYUDANTE_CEDULA1));
                cmd.Parameters.Add(new SQLiteParameter("@ayudante_apellidos", obj.AYUDANTE_APELLIDOS1));
                cmd.Parameters.Add(new SQLiteParameter("@ayudante_nombres", obj.AYUDANTE_NOMBRES1));
                cmd.Parameters.Add(new SQLiteParameter("@ayudante_parentezco", obj.AYUDANTE_PARENTEZCO1));
                cmd.Parameters.Add(new SQLiteParameter("@ayudante_autorizacion", obj.AYUDANTE_AUTORIZACION1));
                cmd.Parameters.Add(new SQLiteParameter("@ayudante_numero_oficio", obj.AYUDANTE_NUMERO_OFICIO1));
                //cmd.Parameters.Add(new SQLiteParameter("@ayudante_oficio_archivo", obj.AYUDANTE_OFICIO_ARCHIVO1));
                cmd.Parameters.Add(new SQLiteParameter("@ayudante_fecha_oficio", obj.AYUDANTE_FECHA_OFICIO1));
                cmd.Parameters.Add(new SQLiteParameter("@ayudante_estado", obj.AYUDANTE_ESTADO1));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery()< 1)
                {
                    res = false;
                }
            }
            return res;
        }

        public List<Cls_Ayudante_DAL> Listar()
        {
            List<Cls_Ayudante_DAL> olista = new List<Cls_Ayudante_DAL>();

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "select AYUDANTE_ID, AYUDANTE_CEDULA, AYUDANTE_APELLIDOS, AYUDANTE_NOMBRES, AYUDANTE_PARENTEZCO, AYUDANTE_AUTORIZACION, AYUDANTE_NUMERO_OFICIO, AYUDANTE_FECHA_OFICIO, AYUDANTE_ESTADO from AYUDANTE";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        olista.Add(new Cls_Ayudante_DAL()
                        {
                            AYUDANTE_ID1 = int.Parse(dr["AYUDANTE_ID"].ToString()),
                            AYUDANTE_CEDULA1 = dr["AYUDANTE_CEDULA"].ToString(),
                            AYUDANTE_APELLIDOS1 = dr["AYUDANTE_APELLIDOS"].ToString(),
                            AYUDANTE_NOMBRES1 = dr["AYUDANTE_NOMBRES"].ToString(),
                            AYUDANTE_PARENTEZCO1 = dr["AYUDANTE_PARENTEZCO"].ToString(),
                            AYUDANTE_AUTORIZACION1 = dr["AYUDANTE_AUTORIZACION"].ToString(),
                            AYUDANTE_NUMERO_OFICIO1 = dr["AYUDANTE_NUMERO_OFICIO"].ToString(),
                            // AYUDANTE_OFICIO_ARCHIVO1 = ["AYUDANTE_OFICIO_ARCHIVO"].ToString(),
                            AYUDANTE_FECHA_OFICIO1 = DateTime.Parse(dr["AYUDANTE_FECHA_OFICIO"].ToString()),
                            AYUDANTE_ESTADO1 = int.Parse(dr["AYUDANTE_ESTADO"].ToString())
                        });
                    }
                }
            }
            return olista;
        }

        public bool Actualizar(Cls_Ayudante_DAL obj)
        {
            bool res = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "Update AYUDANTE set AYUDANTE_CEDULA = @ayudante_cedula, AYUDANTE_APELLIDOS = @ayudante_apellidos, AYUDANTE_NOMBRES = @ayudante_nombres, AYUDANTE_PARENTEZCO = @ayudante_parentezco, " +
                    "AYUDANTE_AUTORIZACION = @ayudante_autorizacion, AYUDANTE_NUMERO_OFICIO = @ayudante_numero_oficio, AYUDANTE_FECHA_OFICIO = @ayudante_fecha_oficio, AYUDANTE_ESTADO = @ayudante_estado" +
                    "where AYUDANTE_ID = @ayudante_id";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@ayudante_id", obj.AYUDANTE_ID1));
                cmd.Parameters.Add(new SQLiteParameter("@ayudante_cedula", obj.AYUDANTE_CEDULA1));
                cmd.Parameters.Add(new SQLiteParameter("@ayudante_apellidos", obj.AYUDANTE_APELLIDOS1));
                cmd.Parameters.Add(new SQLiteParameter("@ayudante_nombres", obj.AYUDANTE_NOMBRES1));
                cmd.Parameters.Add(new SQLiteParameter("@ayudante_parentezco", obj.AYUDANTE_PARENTEZCO1));
                cmd.Parameters.Add(new SQLiteParameter("@ayudante_autorizacion", obj.AYUDANTE_AUTORIZACION1));
                cmd.Parameters.Add(new SQLiteParameter("@ayudante_numero_oficio", obj.AYUDANTE_NUMERO_OFICIO1));
                //cmd.Parameters.Add(new SQLiteParameter("@ayudante_oficio_archivo", obj.AYUDANTE_OFICIO_ARCHIVO1));
                cmd.Parameters.Add(new SQLiteParameter("@ayudante_fecha_oficio", obj.AYUDANTE_FECHA_OFICIO1));
                cmd.Parameters.Add(new SQLiteParameter("@ayudante_estado", obj.AYUDANTE_ESTADO1));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    res = false;
                }
            }
            return res;
        }
    }
}
