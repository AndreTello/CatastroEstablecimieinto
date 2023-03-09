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
        static string servidor= "ec2-52-3-200-138.compute-1.amazonaws.com";
        static string bd= "d51g849jft7tso";
        static string usuario= "fauvwdpbsuibow";
        static string password= "36c503ebe96a44aba6607171d55682e10faca3afc1bc4c67159ace56b2df63a6";
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
