using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL_CE_Postgresql.Catastro
{
    public class Cls_Discapacidad_DAL
    {
        private int DISCAPACIDAD_ID;
        private string DISCAPACIDAD_CARNET;
        private string DISCAPACIDAD_NOMBRE;
        private decimal DISCAPACIDAD_PORCENTAJE;
        private int DISCAPACIDAD_ESTADO;

        public int DISCAPACIDAD_ID1 { get => DISCAPACIDAD_ID; set => DISCAPACIDAD_ID = value; }
        public string DISCAPACIDAD_CARNET1 { get => DISCAPACIDAD_CARNET; set => DISCAPACIDAD_CARNET = value; }
        public string DISCAPACIDAD_NOMBRE1 { get => DISCAPACIDAD_NOMBRE; set => DISCAPACIDAD_NOMBRE = value; }
        public decimal DISCAPACIDAD_PORCENTAJE1 { get => DISCAPACIDAD_PORCENTAJE; set => DISCAPACIDAD_PORCENTAJE = value; }
        public int DISCAPACIDAD_ESTADO1 { get => DISCAPACIDAD_ESTADO; set => DISCAPACIDAD_ESTADO = value; }

        public void Ingresar_Discapacidad()
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
        public void Consultar_Discapacidad()
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
        public void Modificar_Discapacidad()
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
        public void Eliminar_Discapacidad()
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
