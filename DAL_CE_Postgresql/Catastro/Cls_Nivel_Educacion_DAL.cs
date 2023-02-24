using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DAL_CE_Postgresql.Catastro
{
    public class Cls_Nivel_Educacion_DAL
    {
        private int NIVEL_EDUCACION_ID;
        private string NIVEL_EDUCACION_NOMBRE;
        private string NIVEL_EDUCACION_DETALLE;
		private int NIVEL_EDUCACION_ESTADO;

        public int NIVEL_EDUCACION_ID1 { get => NIVEL_EDUCACION_ID; set => NIVEL_EDUCACION_ID = value; }
        public string NIVEL_EDUCACION_NOMBRE1 { get => NIVEL_EDUCACION_NOMBRE; set => NIVEL_EDUCACION_NOMBRE = value; }
        public string NIVEL_EDUCACION_DETALLE1 { get => NIVEL_EDUCACION_DETALLE; set => NIVEL_EDUCACION_DETALLE = value; }
        public int NIVEL_EDUCACION_ESTADO1 { get => NIVEL_EDUCACION_ESTADO; set => NIVEL_EDUCACION_ESTADO = value; }

        public void Ingresar_Nivel_Educacion()
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
        public void Consultar_Nivel_Educacion()
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
        public void Modificar_Nivel_Educacion()
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
        public void Eliminar_Nivel_Educacion()
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
