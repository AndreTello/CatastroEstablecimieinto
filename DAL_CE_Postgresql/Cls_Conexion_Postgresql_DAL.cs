﻿using System;
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
        static string servidor= "ec2-35-81-168-89.us-west-2.compute.amazonaws.com";
        static string bd= "poscatastroestablecimiento";
        static string usuario= "acdc";
        static string password= "Acdc$2023";
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
