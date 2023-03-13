using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
namespace DAL_CE_Postgresql
{
    public class Cls_Conexion_Postgresql_DAL
    {
        NpgsqlConnection con = new NpgsqlConnection();

        static string servidor= "localhost";
        static string bd= "poscatastroestablecimiento";
        static string usuario= "postgres";
        static string password= "123456";
        static string puerto="5432";


        string CadenaConexion = "server=" + servidor + "; port=" + puerto + "; user id=" + usuario + "; password=" + password + "; database= " + bd + ";";

        public NpgsqlConnection EstablecerConexion()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.ConnectionString = CadenaConexion;
                    con.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("A OCURRIDO UN ERROR:  " + ex);
            }
            return con;
        }

        public NpgsqlConnection CerrarConexion()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.ConnectionString = CadenaConexion;
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("A OCURRIDO UN ERROR:  " + ex);
            }
            return con;
        }
    }
}
