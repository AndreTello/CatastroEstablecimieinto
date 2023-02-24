using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL_CE_Postgresql.Catastro
{
    public class Cls_Reemplazo_DAL
    {
        private int REEMPLAZO_ID;
        private string REEMPLAZO_CEDULA;
        private string REEMPLAZO_APELLIDOS;
        private string REEMPLAZO_NOMBRES;
        private string REEMPLAZO_AUTORIZACION;
        private string REEMPLAZO_NUMERO_OFICIO;
        private byte[] REEMPLAZO_OFICIO_ARCHIVO;
		private DateTime REEMPLAZO_FECHA_INICIO;
        private DateTime REEMPLAZO_FECHA_FIN;
        private int REEMPLAZO_ESTADO;

        public int REEMPLAZO_ID1 { get => REEMPLAZO_ID; set => REEMPLAZO_ID = value; }
        public string REEMPLAZO_CEDULA1 { get => REEMPLAZO_CEDULA; set => REEMPLAZO_CEDULA = value; }
        public string REEMPLAZO_APELLIDOS1 { get => REEMPLAZO_APELLIDOS; set => REEMPLAZO_APELLIDOS = value; }
        public string REEMPLAZO_NOMBRES1 { get => REEMPLAZO_NOMBRES; set => REEMPLAZO_NOMBRES = value; }
        public string REEMPLAZO_AUTORIZACION1 { get => REEMPLAZO_AUTORIZACION; set => REEMPLAZO_AUTORIZACION = value; }
        public string REEMPLAZO_NUMERO_OFICIO1 { get => REEMPLAZO_NUMERO_OFICIO; set => REEMPLAZO_NUMERO_OFICIO = value; }
        public byte[] REEMPLAZO_OFICIO_ARCHIVO1 { get => REEMPLAZO_OFICIO_ARCHIVO; set => REEMPLAZO_OFICIO_ARCHIVO = value; }
        public DateTime REEMPLAZO_FECHA_INICIO1 { get => REEMPLAZO_FECHA_INICIO; set => REEMPLAZO_FECHA_INICIO = value; }
        public DateTime REEMPLAZO_FECHA_FIN1 { get => REEMPLAZO_FECHA_FIN; set => REEMPLAZO_FECHA_FIN = value; }
        public int REEMPLAZO_ESTADO1 { get => REEMPLAZO_ESTADO; set => REEMPLAZO_ESTADO = value; }

        public void Ingresar_Reemplazo()
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
        public void Consultar_Reemplazo()
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
        public void Modificar_Reemplazo()
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
        public void Eliminar_Reemplazo()
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
