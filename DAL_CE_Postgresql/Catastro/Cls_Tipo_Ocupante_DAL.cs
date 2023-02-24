using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL_CE_Postgresql.Catastro
{
    public class Cls_Tipo_Ocupante_DAL
    {
        private int TIPO_OCUPANTE_ID;
        private string TIPO_OCUPANTE_NOMBRE;
        private string TIPO_OCUPANTE_DETALLE;
		private int TIPO_OCUPANTE_ESTADO;

        public int TIPO_OCUPANTE_ID1 { get => TIPO_OCUPANTE_ID; set => TIPO_OCUPANTE_ID = value; }
        public string TIPO_OCUPANTE_NOMBRE1 { get => TIPO_OCUPANTE_NOMBRE; set => TIPO_OCUPANTE_NOMBRE = value; }
        public string TIPO_OCUPANTE_DETALLE1 { get => TIPO_OCUPANTE_DETALLE; set => TIPO_OCUPANTE_DETALLE = value; }
        public int TIPO_OCUPANTE_ESTADO1 { get => TIPO_OCUPANTE_ESTADO; set => TIPO_OCUPANTE_ESTADO = value; }

        public void Ingresar_Tipo_Ocupante()
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
        public void Consultar_Tipo_Ocupante()
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
        public void Modificar_Tipo_Ocupante()
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
        public void Eliminar_Tipo_Ocupante()
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
