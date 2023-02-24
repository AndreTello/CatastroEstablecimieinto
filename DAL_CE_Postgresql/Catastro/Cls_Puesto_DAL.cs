using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DAL_CE_Postgresql.Catastro
{
    public class Cls_Puesto_DAL
    {
        private int PUESTO_ID;
        private int PISO_ID;
        private int TIPO_AREA_ID;
        private int COMERCIANTE_ID;
        private int AYUDANTE_ID;
        private int REEMPLAZO_ID;
        private int DOCUMENTO_PUESTO_ID;
        private string PUESTO_PREDIO;
        private string PUESTO_CLAVE_CATASTRAL;
        private decimal PUESTO_AREA;
        private decimal PUESTO_FRENTE;
        private decimal PUESTO_FONDO;
        private string PUESTO_ESTADO_CONSERVACION;
		private string PUESTO_ACABADOS;
        private string PUESTO_PAREDES;
		private string PUESTO_REMODELACION;
        private int PUESTO_ESTADO;

        public int PUESTO_ID1 { get => PUESTO_ID; set => PUESTO_ID = value; }
        public int PISO_ID1 { get => PISO_ID; set => PISO_ID = value; }
        public int TIPO_AREA_ID1 { get => TIPO_AREA_ID; set => TIPO_AREA_ID = value; }
        public int COMERCIANTE_ID1 { get => COMERCIANTE_ID; set => COMERCIANTE_ID = value; }
        public int AYUDANTE_ID1 { get => AYUDANTE_ID; set => AYUDANTE_ID = value; }
        public int REEMPLAZO_ID1 { get => REEMPLAZO_ID; set => REEMPLAZO_ID = value; }
        public int DOCUMENTO_PUESTO_ID1 { get => DOCUMENTO_PUESTO_ID; set => DOCUMENTO_PUESTO_ID = value; }
        public string PUESTO_PREDIO1 { get => PUESTO_PREDIO; set => PUESTO_PREDIO = value; }
        public string PUESTO_CLAVE_CATASTRAL1 { get => PUESTO_CLAVE_CATASTRAL; set => PUESTO_CLAVE_CATASTRAL = value; }
        public decimal PUESTO_AREA1 { get => PUESTO_AREA; set => PUESTO_AREA = value; }
        public decimal PUESTO_FRENTE1 { get => PUESTO_FRENTE; set => PUESTO_FRENTE = value; }
        public decimal PUESTO_FONDO1 { get => PUESTO_FONDO; set => PUESTO_FONDO = value; }
        public string PUESTO_ESTADO_CONSERVACION1 { get => PUESTO_ESTADO_CONSERVACION; set => PUESTO_ESTADO_CONSERVACION = value; }
        public string PUESTO_ACABADOS1 { get => PUESTO_ACABADOS; set => PUESTO_ACABADOS = value; }
        public string PUESTO_PAREDES1 { get => PUESTO_PAREDES; set => PUESTO_PAREDES = value; }
        public string PUESTO_REMODELACION1 { get => PUESTO_REMODELACION; set => PUESTO_REMODELACION = value; }
        public int PUESTO_ESTADO1 { get => PUESTO_ESTADO; set => PUESTO_ESTADO = value; }

        public void Ingresar_Puesto()
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
        public void Consultar_Puesto()
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
        public void Modificar_Puesto()
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
        public void Eliminar_Puesto()
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
