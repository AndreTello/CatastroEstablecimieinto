using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DAL_CE_Postgresql.Catastro
{
    public class Cls_Administracion_Zonal_DAL
    {
        private int ADMINISTRACION_ZONAL_ID;
        private string ADMINISTRACION_ZONAL_NOMBRE;
        private string ADMINISTRACION_ZONAL_DETALLE;
        private string ADMINISTRACION_ZONAL_TELEFONO;
        private string ADMINISTRACION_ZONAL_CELULAR;
        private string ADMINISTRACION_ZONAL_MAIL;
        private string ADMINISTRACION_ZONAL_PAGINA_WEB;
        private string ADMINISTRACION_ZONAL_REPRESENTANTE;
        private int ADMINISTRACION_ZONAL_ESTADO;

        public int ADMINISTRACION_ZONAL_ID1 { get => ADMINISTRACION_ZONAL_ID; set => ADMINISTRACION_ZONAL_ID = value; }
        public string ADMINISTRACION_ZONAL_NOMBRE1 { get => ADMINISTRACION_ZONAL_NOMBRE; set => ADMINISTRACION_ZONAL_NOMBRE = value; }
        public string ADMINISTRACION_ZONAL_DETALLE1 { get => ADMINISTRACION_ZONAL_DETALLE; set => ADMINISTRACION_ZONAL_DETALLE = value; }
        public string ADMINISTRACION_ZONAL_TELEFONO1 { get => ADMINISTRACION_ZONAL_TELEFONO; set => ADMINISTRACION_ZONAL_TELEFONO = value; }
        public string ADMINISTRACION_ZONAL_CELULAR1 { get => ADMINISTRACION_ZONAL_CELULAR; set => ADMINISTRACION_ZONAL_CELULAR = value; }
        public string ADMINISTRACION_ZONAL_MAIL1 { get => ADMINISTRACION_ZONAL_MAIL; set => ADMINISTRACION_ZONAL_MAIL = value; }
        public string ADMINISTRACION_ZONAL_PAGINA_WEB1 { get => ADMINISTRACION_ZONAL_PAGINA_WEB; set => ADMINISTRACION_ZONAL_PAGINA_WEB = value; }
        public string ADMINISTRACION_ZONAL_REPRESENTANTE1 { get => ADMINISTRACION_ZONAL_REPRESENTANTE; set => ADMINISTRACION_ZONAL_REPRESENTANTE = value; }
        public int ADMINISTRACION_ZONAL_ESTADO1 { get => ADMINISTRACION_ZONAL_ESTADO; set => ADMINISTRACION_ZONAL_ESTADO = value; }

        public void Ingresar_Administracion_Zonal()
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
        public void Consultar_Administracion_Zonal()
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
        public void Modificar_Administracion_Zonal()
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
        public void Eliminar_Administracion_Zonal()
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
