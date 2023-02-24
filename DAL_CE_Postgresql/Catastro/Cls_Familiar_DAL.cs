using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL_CE_Postgresql.Catastro
{
    public class Cls_Familiar_DAL
    {
        private int FAMILIAR_ID;
        private int TIPO_FAMILIAR_ID;
		private int COMERCIANTE_ID;
        private string FAMILIAR_CEDULA;
        private string FAMILIAR_APELLIDOS;
        private string FAMILIAR_NOMBRES;
        private decimal FAMILIAR_APORTE_ECONOMICO;
		private decimal FAMILIAR_PROMEDIO_INGRESO;
		private string FAMILIAR_MENOR_EDAD;
        private string FAMILIAR_ESCOLARIDAD;
        private int FAMILIAR_ESTADO;

        public int FAMILIAR_ID1 { get => FAMILIAR_ID; set => FAMILIAR_ID = value; }
        public int TIPO_FAMILIAR_ID1 { get => TIPO_FAMILIAR_ID; set => TIPO_FAMILIAR_ID = value; }
        public int COMERCIANTE_ID1 { get => COMERCIANTE_ID; set => COMERCIANTE_ID = value; }
        public string FAMILIAR_CEDULA1 { get => FAMILIAR_CEDULA; set => FAMILIAR_CEDULA = value; }
        public string FAMILIAR_APELLIDOS1 { get => FAMILIAR_APELLIDOS; set => FAMILIAR_APELLIDOS = value; }
        public string FAMILIAR_NOMBRES1 { get => FAMILIAR_NOMBRES; set => FAMILIAR_NOMBRES = value; }
        public decimal FAMILIAR_APORTE_ECONOMICO1 { get => FAMILIAR_APORTE_ECONOMICO; set => FAMILIAR_APORTE_ECONOMICO = value; }
        public decimal FAMILIAR_PROMEDIO_INGRESO1 { get => FAMILIAR_PROMEDIO_INGRESO; set => FAMILIAR_PROMEDIO_INGRESO = value; }
        public string FAMILIAR_MENOR_EDAD1 { get => FAMILIAR_MENOR_EDAD; set => FAMILIAR_MENOR_EDAD = value; }
        public string FAMILIAR_ESCOLARIDAD1 { get => FAMILIAR_ESCOLARIDAD; set => FAMILIAR_ESCOLARIDAD = value; }
        public int FAMILIAR_ESTADO1 { get => FAMILIAR_ESTADO; set => FAMILIAR_ESTADO = value; }

        public void Ingresar_Familiar()
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
        public void Consultar_Familiar()
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
        public void Modificar_Familiar()
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
        public void Eliminar_Familiar()
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
