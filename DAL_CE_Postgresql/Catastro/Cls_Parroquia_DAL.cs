using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL_CE_Postgresql.Catastro
{
    public class Cls_Parroquia_DAL
    {
        private int PARROQUIA_ID;
        private int ZONA_ID;
		private string PARROQUIA_CODIGO;
        private string PARROQUIA_NOMBRE;
        private int PARROQUIA_ESTADO;
		private string PARROQUIA_OBSERVACION;

        public int PARROQUIA_ID1 { get => PARROQUIA_ID; set => PARROQUIA_ID = value; }
        public int ZONA_ID1 { get => ZONA_ID; set => ZONA_ID = value; }
        public string PARROQUIA_CODIGO1 { get => PARROQUIA_CODIGO; set => PARROQUIA_CODIGO = value; }
        public string PARROQUIA_NOMBRE1 { get => PARROQUIA_NOMBRE; set => PARROQUIA_NOMBRE = value; }
        public int PARROQUIA_ESTADO1 { get => PARROQUIA_ESTADO; set => PARROQUIA_ESTADO = value; }
        public string PARROQUIA_OBSERVACION1 { get => PARROQUIA_OBSERVACION; set => PARROQUIA_OBSERVACION = value; }

        public void Ingresar_Parroquia()
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
        public void Consultar_Parroquia()
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
        public void Modificar_Parroquia()
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
        public void Eliminar_Parroquia()
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
