using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL_CE_Postgresql.Catastro
{
    public class Cls_Tipos_Producto_DAL
    {
        Cls_Conexion_Postgresql_DAL con = new Cls_Conexion_Postgresql_DAL();
        
        private int TIPO_PRODUCTO_ID;
        private string TIPO_PRODUCTO_NOMBRE;
        private string TIPO_PRODUCTO_DETALLE;
        private string TIPO_PRODUCTO_OBSERVACION;
        private int TIPO_PRODUCTO_ESTADO;

        public int TIPO_PRODUCTO_ID1 { get => TIPO_PRODUCTO_ID; set => TIPO_PRODUCTO_ID = value; }
        public string TIPO_PRODUCTO_NOMBRE1 { get => TIPO_PRODUCTO_NOMBRE; set => TIPO_PRODUCTO_NOMBRE = value; }
        public string TIPO_PRODUCTO_DETALLE1 { get => TIPO_PRODUCTO_DETALLE; set => TIPO_PRODUCTO_DETALLE = value; }
        public string TIPO_PRODUCTO_OBSERVACION1 { get => TIPO_PRODUCTO_OBSERVACION; set => TIPO_PRODUCTO_OBSERVACION = value; }
        public int TIPO_PRODUCTO_ESTADO1 { get => TIPO_PRODUCTO_ESTADO; set => TIPO_PRODUCTO_ESTADO = value; }

        public void Ingresar_Tipos_Producto()
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("A OCURRIDO UN ERROR:  " + ex);
            }
            finally
            {

            }
        }

        public void Consultar_Tipos_Producto()
        {
            try
            {
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("A OCURRIDO UN ERROR:  " + ex);
            }
            finally
            {

            }
        }

        public void Modificar_Tipos_Producto()
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("A OCURRIDO UN ERROR:  " + ex);
            }
            finally
            {

            }
        }
        public void Eliminar_Tipos_Producto()
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("A OCURRIDO UN ERROR:  " + ex);
            }
            finally
            {

            }
        }

    }
}
