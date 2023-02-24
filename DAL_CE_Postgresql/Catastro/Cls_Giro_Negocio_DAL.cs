using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DAL_CE_Postgresql.Catastro
{
    public class Cls_Giro_Negocio_DAL
    {
        private int GIRO_NEGOCIO_ID;
        private int TIPO_PRODUCTO_ID;
		private string GIRO_NEGOCIO_NOMBRE;
        private string GIRO_NEGOCIO_SUBGIRO;
        private string GIRO_NEGOCIO_ABASTECIMIENTO;
        private string GIRO_NEGOCIO_OBSERVACION;
		private int GIRO_NEGOCIO_ESTADO;

        public int GIRO_NEGOCIO_ID1 { get => GIRO_NEGOCIO_ID; set => GIRO_NEGOCIO_ID = value; }
        public int TIPO_PRODUCTO_ID1 { get => TIPO_PRODUCTO_ID; set => TIPO_PRODUCTO_ID = value; }
        public string GIRO_NEGOCIO_NOMBRE1 { get => GIRO_NEGOCIO_NOMBRE; set => GIRO_NEGOCIO_NOMBRE = value; }
        public string GIRO_NEGOCIO_SUBGIRO1 { get => GIRO_NEGOCIO_SUBGIRO; set => GIRO_NEGOCIO_SUBGIRO = value; }
        public string GIRO_NEGOCIO_ABASTECIMIENTO1 { get => GIRO_NEGOCIO_ABASTECIMIENTO; set => GIRO_NEGOCIO_ABASTECIMIENTO = value; }
        public string GIRO_NEGOCIO_OBSERVACION1 { get => GIRO_NEGOCIO_OBSERVACION; set => GIRO_NEGOCIO_OBSERVACION = value; }
        public int GIRO_NEGOCIO_ESTADO1 { get => GIRO_NEGOCIO_ESTADO; set => GIRO_NEGOCIO_ESTADO = value; }

        public void Ingresar_Giro_Negocio()
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
        public void Consultar_Giro_Negocio()
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
        public void Modificar_Giro_Negocio()
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
        public void Eliminar_Giro_Negocio()
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
