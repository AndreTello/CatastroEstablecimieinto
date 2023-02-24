using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DAL_CE_Postgresql.Administracion
{
    public class Cls_Rol_DAL
    {
        private int ROL_ID;
        private string ROL_NOMBRE;
        private string ROL_DETALLE;
        private int ROL_ESTADO;

        public int ROL_ID1 { get => ROL_ID; set => ROL_ID = value; }
        public string ROL_NOMBRE1 { get => ROL_NOMBRE; set => ROL_NOMBRE = value; }
        public string ROL_DETALLE1 { get => ROL_DETALLE; set => ROL_DETALLE = value; }
        public int ROL_ESTADO1 { get => ROL_ESTADO; set => ROL_ESTADO = value; }

        public void Ingresar_Rol()
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
        public void Consultar_Rol()
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
        public void Modificar_Rol()
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
        public void Eliminar_Rol()
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
