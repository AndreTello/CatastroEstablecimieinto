using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DAL_CE_Postgresql.Catastro
{
    public class Cls_Estado_Civil_DAL
    {
        private int ESTADO_CIVIL_ID;
        private string ESTADO_CIVIL_NOMBRE;
        private string ESTADO_CIVIL_DETALLE;
        private int ESTADO_CIVIL_ESTADO;

        public int ESTADO_CIVIL_ID1 { get => ESTADO_CIVIL_ID; set => ESTADO_CIVIL_ID = value; }
        public string ESTADO_CIVIL_NOMBRE1 { get => ESTADO_CIVIL_NOMBRE; set => ESTADO_CIVIL_NOMBRE = value; }
        public string ESTADO_CIVIL_DETALLE1 { get => ESTADO_CIVIL_DETALLE; set => ESTADO_CIVIL_DETALLE = value; }
        public int ESTADO_CIVIL_ESTADO1 { get => ESTADO_CIVIL_ESTADO; set => ESTADO_CIVIL_ESTADO = value; }

        public void Ingresar_Estado_Civil()
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
        public void Consultar_Estado_Civil()
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
        public void Modificar_Estado_Civil()
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
        public void Eliminar_Estado_Civil()
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
