using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DAL_CE_Postgresql.Catastro
{
    public class Cls_Genero_DAL
    {
        private int GENERO_ID;
        private string GENERO_NOMBRE;
        private string GENERO_DETALLE;
        private int GENERO_ESTADO;

        public int GENERO_ID1 { get => GENERO_ID; set => GENERO_ID = value; }
        public string GENERO_NOMBRE1 { get => GENERO_NOMBRE; set => GENERO_NOMBRE = value; }
        public string GENERO_DETALLE1 { get => GENERO_DETALLE; set => GENERO_DETALLE = value; }
        public int GENERO_ESTADO1 { get => GENERO_ESTADO; set => GENERO_ESTADO = value; }

        public void Ingresar_Genero()
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
        public void Consultar_Genero()
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
        public void Modificar_Genero()
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
        public void Eliminar_Genero()
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
