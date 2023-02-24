using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL_CE_Postgresql.Catastro
{
    public class Cls_Asociacion_DAL
    {
        private int ASOCIACION_ID;
        private string ASOCIACION_CODIGO;
        private string ASOCIACION_NOMBRE;
        private string ASOCIACION_TELEFONO;
        private string ASOCIACION_MAIL;
        private string ASOCIACION_CONTACTO;
        private int ASOCIACION_ESTADO;
        private string ASOCIACION_OBSERVACION;

        public int ASOCIACION_ID1 { get => ASOCIACION_ID; set => ASOCIACION_ID = value; }
        public string ASOCIACION_CODIGO1 { get => ASOCIACION_CODIGO; set => ASOCIACION_CODIGO = value; }
        public string ASOCIACION_NOMBRE1 { get => ASOCIACION_NOMBRE; set => ASOCIACION_NOMBRE = value; }
        public string ASOCIACION_TELEFONO1 { get => ASOCIACION_TELEFONO; set => ASOCIACION_TELEFONO = value; }
        public string ASOCIACION_MAIL1 { get => ASOCIACION_MAIL; set => ASOCIACION_MAIL = value; }
        public string ASOCIACION_CONTACTO1 { get => ASOCIACION_CONTACTO; set => ASOCIACION_CONTACTO = value; }
        public int ASOCIACION_ESTADO1 { get => ASOCIACION_ESTADO; set => ASOCIACION_ESTADO = value; }
        public string ASOCIACION_OBSERVACION1 { get => ASOCIACION_OBSERVACION; set => ASOCIACION_OBSERVACION = value; }

        public void Ingresar_Asociacion()
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
        public void Consultar_Asociacion()
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
        public void Modificar_Asociacion()
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
        public void Eliminar_Asociacion()
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
