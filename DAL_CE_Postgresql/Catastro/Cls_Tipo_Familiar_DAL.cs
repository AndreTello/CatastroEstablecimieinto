using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DAL_CE_Postgresql.Catastro
{
    public class Cls_Tipo_Familiar_DAL
    {
        private int TIPO_FAMILIAR_ID;
        private string TIPO_FAMILIAR_NOMBRE;
        private string TIPO_FAMILIAR_DETALLE;
        private int TIPO_FAMILAR_ESTADO;

        public int TIPO_FAMILIAR_ID1 { get => TIPO_FAMILIAR_ID; set => TIPO_FAMILIAR_ID = value; }
        public string TIPO_FAMILIAR_NOMBRE1 { get => TIPO_FAMILIAR_NOMBRE; set => TIPO_FAMILIAR_NOMBRE = value; }
        public string TIPO_FAMILIAR_DETALLE1 { get => TIPO_FAMILIAR_DETALLE; set => TIPO_FAMILIAR_DETALLE = value; }
        public int TIPO_FAMILAR_ESTADO1 { get => TIPO_FAMILAR_ESTADO; set => TIPO_FAMILAR_ESTADO = value; }

        public void Ingresar_Tipo_Familiar()
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
        public void Consultar_Tipo_Familiar()
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
        public void Modificar_Tipo_Familiar()
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
        public void Eliminar_Tipo_Familiar()
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
