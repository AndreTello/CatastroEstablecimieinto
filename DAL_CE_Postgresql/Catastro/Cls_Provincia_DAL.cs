using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL_CE_Postgresql.Catastro
{
    public class Cls_Provincia_DAL
    {

        private int PROVINCIA_ID;
        private string PROVINCIA_CODIGO;
        private string PROVINCIA_NOMBRE;
        private int PROVINCIA_ESTADO;
        private string PROVINCIA_OBSERVACION;

        public int PROVINCIA_ID1 { get => PROVINCIA_ID; set => PROVINCIA_ID = value; }
        public string PROVINCIA_CODIGO1 { get => PROVINCIA_CODIGO; set => PROVINCIA_CODIGO = value; }
        public string PROVINCIA_NOMBRE1 { get => PROVINCIA_NOMBRE; set => PROVINCIA_NOMBRE = value; }
        public int PROVINCIA_ESTADO1 { get => PROVINCIA_ESTADO; set => PROVINCIA_ESTADO = value; }
        public string PROVINCIA_OBSERVACION1 { get => PROVINCIA_OBSERVACION; set => PROVINCIA_OBSERVACION = value; }

        public void Ingresar_Provincia()
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
        public void Consultar_Provincia()
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
        public void Modificar_Provincia()
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
        public void Eliminar_Provincia()
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
