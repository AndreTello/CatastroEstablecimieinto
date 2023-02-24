using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DAL_CE_Postgresql.Catastro
{
    public class Cls_Tipo_Intervencion_Tecnica_DAL
    {
        private int TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_ID;
        private string TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_NOMBRE;
        private string TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_DETALLE;
        private int TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_ESTADO;

        public int TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_ID1 { get => TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_ID; set => TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_ID = value; }
        public string TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_NOMBRE1 { get => TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_NOMBRE; set => TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_NOMBRE = value; }
        public string TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_DETALLE1 { get => TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_DETALLE; set => TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_DETALLE = value; }
        public int TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_ESTADO1 { get => TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_ESTADO; set => TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_ESTADO = value; }

        public void Ingresar_Tipo_Intervencion_Tecnica()
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
        public void Consultar_Tipo_Intervencion_Tecnica()
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
        public void Modificar_Tipo_Intervencion_Tecnica()
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
        public void Eliminar_Tipo_Intervencion_Tecnica()
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
