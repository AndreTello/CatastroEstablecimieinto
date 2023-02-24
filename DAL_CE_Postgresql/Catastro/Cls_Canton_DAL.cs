using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL_CE_Postgresql.Catastro
{
    public class Cls_Canton_DAL
    {
        private int CANTON_ID;
        private int PROVINCIA_ID;
        private string CANTON_CODIGO;
        private string CANTON_NOMBRE;
        private int CANTON_ESTADO;
        private string CANTON_OBSERVACION;

        public int CANTON_ID1 { get => CANTON_ID; set => CANTON_ID = value; }
        public int PROVINCIA_ID1 { get => PROVINCIA_ID; set => PROVINCIA_ID = value; }
        public string CANTON_CODIGO1 { get => CANTON_CODIGO; set => CANTON_CODIGO = value; }
        public string CANTON_NOMBRE1 { get => CANTON_NOMBRE; set => CANTON_NOMBRE = value; }
        public int CANTON_ESTADO1 { get => CANTON_ESTADO; set => CANTON_ESTADO = value; }
        public string CANTON_OBSERVACION1 { get => CANTON_OBSERVACION; set => CANTON_OBSERVACION = value; }

        public void Ingresar_Canton()
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
        public void Consultar_Canton()
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
        public void Modificar_Canton()
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
        public void Eliminar_Canton()
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
