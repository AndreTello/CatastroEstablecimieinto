using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DAL_CE_Postgresql.Catastro
{
    public class Cls_Tipo_Identificacion_DAL
    {
        private int TIPO_IDENTIFICACION_ID;
        private string TIPO_IDENTIFICACION_NOMBRE;
        private string TIPO_IDENTIFICACION_DETALLE;
        private int TIPO_IDENTIFICACION_ESTADO;

        public int TIPO_IDENTIFICACION_ID1 { get => TIPO_IDENTIFICACION_ID; set => TIPO_IDENTIFICACION_ID = value; }
        public string TIPO_IDENTIFICACION_NOMBRE1 { get => TIPO_IDENTIFICACION_NOMBRE; set => TIPO_IDENTIFICACION_NOMBRE = value; }
        public string TIPO_IDENTIFICACION_DETALLE1 { get => TIPO_IDENTIFICACION_DETALLE; set => TIPO_IDENTIFICACION_DETALLE = value; }
        public int TIPO_IDENTIFICACION_ESTADO1 { get => TIPO_IDENTIFICACION_ESTADO; set => TIPO_IDENTIFICACION_ESTADO = value; }

        public void Ingresar_Tipo_Identificacion()
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
        public void Consultar_Tipo_Identificacion()
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
        public void Modificar_Tipo_Identificacion()
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
        public void Eliminar_Tipo_Identificacion()
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
