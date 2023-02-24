using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DAL_CE_Postgresql.Administracion
{
    public class Cls_Rol_Permiso_DAL
    {
        private int ROL_PERMISO_ID;
        private int ROL_ID;
        private int PERMISO_ID;
        private int ROL_PERMISO_ESTADO;

        public int ROL_PERMISO_ID1 { get => ROL_PERMISO_ID; set => ROL_PERMISO_ID = value; }
        public int ROL_ID1 { get => ROL_ID; set => ROL_ID = value; }
        public int PERMISO_ID1 { get => PERMISO_ID; set => PERMISO_ID = value; }
        public int ROL_PERMISO_ESTADO1 { get => ROL_PERMISO_ESTADO; set => ROL_PERMISO_ESTADO = value; }

        public void Ingresar_Rol_Permiso()
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
        public void Consultar_Rol_Permiso()
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
        public void Modificar_Rol_Permiso()
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
        public void Eliminar_Rol_Permiso()
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
