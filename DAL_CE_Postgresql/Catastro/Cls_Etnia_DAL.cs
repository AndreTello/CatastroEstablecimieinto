using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DAL_CE_Postgresql.Catastro
{
    public class Cls_Etnia_DAL
    {
        private int ETNIA_ID;
        private string ETNIA_NOMBRE;
        private string ETNIA_DETALLE;
        private int ETNIA_ESTADO;

        public int ETNIA_ID1 { get => ETNIA_ID; set => ETNIA_ID = value; }
        public string ETNIA_NOMBRE1 { get => ETNIA_NOMBRE; set => ETNIA_NOMBRE = value; }
        public string ETNIA_DETALLE1 { get => ETNIA_DETALLE; set => ETNIA_DETALLE = value; }
        public int ETNIA_ESTADO1 { get => ETNIA_ESTADO; set => ETNIA_ESTADO = value; }

        public void Ingresar_Etnia()
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
        public void Consultar_Etnia()
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
        public void Modificar_Etnia()
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
        public void Eliminar_Etnia()
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
