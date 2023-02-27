using System;
using System.Collections.Generic;
using System.Data;
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
        static string servidor= "ec2-54-160-109-68.compute-1.amazonaws.com";
        static string bd= "d11m763ckv12i2";
        static string usuario= "hxldeyhnvsoncq";
        static string password= "e2a615c96a473f6d11017e38a1ce910fa72f03862bdbd85b1e53f9688cf8ac13";
        static string puerto="5432";

        string CadenaConexion = "server=" + servidor + "; port=" + puerto + "; user id=" + usuario + "; password=" + password + "; database= " + bd +";";
        
        public NpgsqlConnection EstablecerConexion()
        {
            try
            {
                con.ConnectionString = CadenaConexion;
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("A OCURRIDO UN ERROR:  " + ex);
            }
            return con;
        }

        /*public DataTable Consultar()
        {
            string query = "select * from cm_tipo_producto";
            NpgsqlCommand conector = new NpgsqlCommand(query, con);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            con.Close();
            return tabla;
        }*/

    }
}
