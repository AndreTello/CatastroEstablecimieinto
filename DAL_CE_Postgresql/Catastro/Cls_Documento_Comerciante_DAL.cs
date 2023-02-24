using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DAL_CE_Postgresql.Catastro
{
    public class Cls_Documento_Comerciante_DAL
    {
        private int DOCUMENTO_COMERCIANTE_ID;
        private int TIPO_DOCUMENTO_COMERCIANTE_ID;
		private int COMERCIANTE_ID;
        private string DOCUMENTO_COMERCIANTE_NOMBRE;
        private DateTime DOCUMENTO_COMERCIANTE_FECHA;
        private byte[] DOCUMENTO_COMERCIANTE_ARCHIVO; //bytea
        private string DOCUMENTO_COMERCIANTE_DETALLE;
        private string DOCUMENTO_COMERCIANTE_OBSERVACION;
        private int DOCUMENTO_COMERCIANTE_ESTADO;

        public int DOCUMENTO_COMERCIANTE_ID1 { get => DOCUMENTO_COMERCIANTE_ID; set => DOCUMENTO_COMERCIANTE_ID = value; }
        public int TIPO_DOCUMENTO_COMERCIANTE_ID1 { get => TIPO_DOCUMENTO_COMERCIANTE_ID; set => TIPO_DOCUMENTO_COMERCIANTE_ID = value; }
        public int COMERCIANTE_ID1 { get => COMERCIANTE_ID; set => COMERCIANTE_ID = value; }
        public string DOCUMENTO_COMERCIANTE_NOMBRE1 { get => DOCUMENTO_COMERCIANTE_NOMBRE; set => DOCUMENTO_COMERCIANTE_NOMBRE = value; }
        public DateTime DOCUMENTO_COMERCIANTE_FECHA1 { get => DOCUMENTO_COMERCIANTE_FECHA; set => DOCUMENTO_COMERCIANTE_FECHA = value; }
        public byte[] DOCUMENTO_COMERCIANTE_ARCHIVO1 { get => DOCUMENTO_COMERCIANTE_ARCHIVO; set => DOCUMENTO_COMERCIANTE_ARCHIVO = value; }
        public string DOCUMENTO_COMERCIANTE_DETALLE1 { get => DOCUMENTO_COMERCIANTE_DETALLE; set => DOCUMENTO_COMERCIANTE_DETALLE = value; }
        public string DOCUMENTO_COMERCIANTE_OBSERVACION1 { get => DOCUMENTO_COMERCIANTE_OBSERVACION; set => DOCUMENTO_COMERCIANTE_OBSERVACION = value; }
        public int DOCUMENTO_COMERCIANTE_ESTADO1 { get => DOCUMENTO_COMERCIANTE_ESTADO; set => DOCUMENTO_COMERCIANTE_ESTADO = value; }

        public void Ingresar_Documento_Comerciante()
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
        public void Consultar_Documento_Comerciante()
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
        public void Modificar_Documento_Comerciante()
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
        public void Eliminar_Documento_Comerciante()
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
