using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL_CE_Postgresql.Administracion
{
    public class Cls_Permiso_DAL
    {
        private int PERMISO_ID;
        private string PERMISO_NOMBRE;
        private string PERMISO_DETALLE;
        private int PERMISO_ESTADO;

        public int PERMISO_ID1 { get => PERMISO_ID; set => PERMISO_ID = value; }
        public string PERMISO_NOMBRE1 { get => PERMISO_NOMBRE; set => PERMISO_NOMBRE = value; }
        public string PERMISO_DETALLE1 { get => PERMISO_DETALLE; set => PERMISO_DETALLE = value; }
        public int PERMISO_ESTADO1 { get => PERMISO_ESTADO; set => PERMISO_ESTADO = value; }

        public void Ingresar_Permiso() 
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
        public void Consultar_Permiso()
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
        public void Modificar_Permiso()
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
        public void Eliminar_Permiso()
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
