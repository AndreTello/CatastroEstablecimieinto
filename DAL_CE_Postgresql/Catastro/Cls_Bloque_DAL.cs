using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL_CE_Postgresql.Catastro
{
    public class Cls_Bloque_DAL
    {
        private int BLOQUE_ID;
        private int ESTABLECIMIENTO_ID;
		private string BLOQUE_CODIGO;
        private string BLOQUE_NOMBRE;
        private int BLOQUE_ESTADO;
		private string BLOQUE_OBSERVACION;

        public int BLOQUE_ID1 { get => BLOQUE_ID; set => BLOQUE_ID = value; }
        public int ESTABLECIMIENTO_ID1 { get => ESTABLECIMIENTO_ID; set => ESTABLECIMIENTO_ID = value; }
        public string BLOQUE_CODIGO1 { get => BLOQUE_CODIGO; set => BLOQUE_CODIGO = value; }
        public string BLOQUE_NOMBRE1 { get => BLOQUE_NOMBRE; set => BLOQUE_NOMBRE = value; }
        public int BLOQUE_ESTADO1 { get => BLOQUE_ESTADO; set => BLOQUE_ESTADO = value; }
        public string BLOQUE_OBSERVACION1 { get => BLOQUE_OBSERVACION; set => BLOQUE_OBSERVACION = value; }

        public void Ingresar_Bloque()
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
        public void Consultar_Bloque()
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
        public void Modificar_Bloque()
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
        public void Eliminar_Bloque()
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
