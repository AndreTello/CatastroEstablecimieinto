using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DAL_CE_Postgresql.Catastro
{
    public class Cls_Tipo_Area_DAL
    {
        private int TIPO_AREA_ID; 
        private string TIPO_AREA_IDENTIFICACION;
        private string TIPO_AREA_NOMBRE;
        private string TIPO_AREA_OBSERVACION;
        private int TIPO_AREA_ESTADO;

        public int TIPO_AREA_ID1 { get => TIPO_AREA_ID; set => TIPO_AREA_ID = value; }
        public string TIPO_AREA_IDENTIFICACION1 { get => TIPO_AREA_IDENTIFICACION; set => TIPO_AREA_IDENTIFICACION = value; }
        public string TIPO_AREA_NOMBRE1 { get => TIPO_AREA_NOMBRE; set => TIPO_AREA_NOMBRE = value; }
        public string TIPO_AREA_OBSERVACION1 { get => TIPO_AREA_OBSERVACION; set => TIPO_AREA_OBSERVACION = value; }
        public int TIPO_AREA_ESTADO1 { get => TIPO_AREA_ESTADO; set => TIPO_AREA_ESTADO = value; }

        public void Ingresar_Tipo_Area()
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
        public void Consultar_Tipo_Area()
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
        public void Modificar_Tipo_Area()
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
        public void Eliminar_Tipo_Area()
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
