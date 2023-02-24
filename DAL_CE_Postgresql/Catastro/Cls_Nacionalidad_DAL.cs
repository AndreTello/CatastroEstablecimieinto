using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DAL_CE_Postgresql.Catastro
{
    public class Cls_Nacionalidad_DAL
    {
        private int NACIONALIDAD_ID;
        private string NACIONALIDAD_CODIGO;
        private string NACIONALIDAD_NOMBRE;
        private string NACIONALIDAD_DETALLE;
        private int NACIONALIDAD_ESTADO;

        public int NACIONALIDAD_ID1 { get => NACIONALIDAD_ID; set => NACIONALIDAD_ID = value; }
        public string NACIONALIDAD_CODIGO1 { get => NACIONALIDAD_CODIGO; set => NACIONALIDAD_CODIGO = value; }
        public string NACIONALIDAD_NOMBRE1 { get => NACIONALIDAD_NOMBRE; set => NACIONALIDAD_NOMBRE = value; }
        public string NACIONALIDAD_DETALLE1 { get => NACIONALIDAD_DETALLE; set => NACIONALIDAD_DETALLE = value; }
        public int NACIONALIDAD_ESTADO1 { get => NACIONALIDAD_ESTADO; set => NACIONALIDAD_ESTADO = value; }

        public void Ingresar_Nacionalidad()
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
        public void Consultar_Nacionalidad()
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
        public void Modificar_Nacionalidad()
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
        public void Eliminar_Nacionalidad()
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
