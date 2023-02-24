using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL_CE_Postgresql.Catastro
{
    public class Cls_Intervencion_Tecnica_Establecimiento_DAL
    {
        private int INTERVENCION_TECNICA_ESTABLECIMIENTO_ID;
        private int TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_ID;
		private string INTERVENCION_TECNICA_ESTABLECIMIENTO_NOMBRE;
        private string INTERVENCION_TECNICA_ESTABLECIMIENTO_FECHA_INICIO; //Declarados como string pero pueden ser de tipo date
        private string INTERVENCION_TECNICA_ESTABLECIMIENTO_FECHA_FIN;
        private int TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_ESTADO;

        public int INTERVENCION_TECNICA_ESTABLECIMIENTO_ID1 { get => INTERVENCION_TECNICA_ESTABLECIMIENTO_ID; set => INTERVENCION_TECNICA_ESTABLECIMIENTO_ID = value; }
        public int TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_ID1 { get => TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_ID; set => TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_ID = value; }
        public string INTERVENCION_TECNICA_ESTABLECIMIENTO_NOMBRE1 { get => INTERVENCION_TECNICA_ESTABLECIMIENTO_NOMBRE; set => INTERVENCION_TECNICA_ESTABLECIMIENTO_NOMBRE = value; }
        public string INTERVENCION_TECNICA_ESTABLECIMIENTO_FECHA_INICIO1 { get => INTERVENCION_TECNICA_ESTABLECIMIENTO_FECHA_INICIO; set => INTERVENCION_TECNICA_ESTABLECIMIENTO_FECHA_INICIO = value; }
        public string INTERVENCION_TECNICA_ESTABLECIMIENTO_FECHA_FIN1 { get => INTERVENCION_TECNICA_ESTABLECIMIENTO_FECHA_FIN; set => INTERVENCION_TECNICA_ESTABLECIMIENTO_FECHA_FIN = value; }
        public int TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_ESTADO1 { get => TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_ESTADO; set => TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_ESTADO = value; }

        public void Ingresar_Intervencion_Tecnica_Establecimiento()
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
        public void Consultar_Intervencion_Tecnica_Establecimiento()
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
        public void Modificar_Intervencion_Tecnica_Establecimiento()
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
        public void Eliminar_Intervencion_Tecnica_Establecimiento()
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
