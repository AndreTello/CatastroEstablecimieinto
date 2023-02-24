using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL_CE_Postgresql.Catastro
{
    public class Cls_Manzana_DAL
    {
        private int MANZANA_ID;
        private int PARROQUIA_ID;
		private string MANZANA_CODIGO;
        private string MANZANA_NOMBRE;
        private int MANZANA_ESTADO;
		private string MANZANA_OBSERVACION;

        public int MANZANA_ID1 { get => MANZANA_ID; set => MANZANA_ID = value; }
        public int PARROQUIA_ID1 { get => PARROQUIA_ID; set => PARROQUIA_ID = value; }
        public string MANZANA_CODIGO1 { get => MANZANA_CODIGO; set => MANZANA_CODIGO = value; }
        public string MANZANA_NOMBRE1 { get => MANZANA_NOMBRE; set => MANZANA_NOMBRE = value; }
        public int MANZANA_ESTADO1 { get => MANZANA_ESTADO; set => MANZANA_ESTADO = value; }
        public string MANZANA_OBSERVACION1 { get => MANZANA_OBSERVACION; set => MANZANA_OBSERVACION = value; }

        public void Ingresar_Manzana()
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
        public void Consultar_Manzana()
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
        public void Modificar_Manzana()
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
        public void Eliminar_Manzana()
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
