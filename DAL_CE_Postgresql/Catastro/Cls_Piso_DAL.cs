using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL_CE_Postgresql.Catastro
{
    public class Cls_Piso_DAL
    {
        private int PISO_ID;
        private int BLOQUE_ID;
		private string PISO_CODIGO;
        private string PISO_NOMBRE;
        private int PISO_ESTADO;
		private string PISO_OBSERVACION;

        public int PISO_ID1 { get => PISO_ID; set => PISO_ID = value; }
        public int BLOQUE_ID1 { get => BLOQUE_ID; set => BLOQUE_ID = value; }
        public string PISO_CODIGO1 { get => PISO_CODIGO; set => PISO_CODIGO = value; }
        public string PISO_NOMBRE1 { get => PISO_NOMBRE; set => PISO_NOMBRE = value; }
        public int PISO_ESTADO1 { get => PISO_ESTADO; set => PISO_ESTADO = value; }

        public void Ingresar_Piso()
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
        public void Consultar_Piso()
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
        public void Modificar_Piso()
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
        public void Eliminar_Piso()
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
