using Npgsql.Internal.TypeHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL_CE_Postgresql.Catastro
{
    public class Cls_Ayudante_DAL 
    {
        private int AYUDANTE_ID;
        private string AYUDANTE_CEDULA;
        private string AYUDANTE_APELLIDOS;
        private string AYUDANTE_NOMBRES;
        private string AYUDANTE_PARENTEZCO;
        private string AYUDANTE_AUTORIZACION;
        private string AYUDANTE_NUMERO_OFICIO;
        private byte [] AYUDANTE_OFICIO_ARCHIVO; //Tipo de dato faltante BYTEA use int por mientras
		private DateTime AYUDANTE_FECHA_OFICIO;
        private int AYUDANTE_ESTADO;

        public int AYUDANTE_ID1 { get => AYUDANTE_ID; set => AYUDANTE_ID = value; }
        public string AYUDANTE_CEDULA1 { get => AYUDANTE_CEDULA; set => AYUDANTE_CEDULA = value; }
        public string AYUDANTE_APELLIDOS1 { get => AYUDANTE_APELLIDOS; set => AYUDANTE_APELLIDOS = value; }
        public string AYUDANTE_NOMBRES1 { get => AYUDANTE_NOMBRES; set => AYUDANTE_NOMBRES = value; }
        public string AYUDANTE_PARENTEZCO1 { get => AYUDANTE_PARENTEZCO; set => AYUDANTE_PARENTEZCO = value; }
        public string AYUDANTE_AUTORIZACION1 { get => AYUDANTE_AUTORIZACION; set => AYUDANTE_AUTORIZACION = value; }
        public string AYUDANTE_NUMERO_OFICIO1 { get => AYUDANTE_NUMERO_OFICIO; set => AYUDANTE_NUMERO_OFICIO = value; }
        public byte[] AYUDANTE_OFICIO_ARCHIVO1 { get => AYUDANTE_OFICIO_ARCHIVO; set => AYUDANTE_OFICIO_ARCHIVO = value; }
        public DateTime AYUDANTE_FECHA_OFICIO1 { get => AYUDANTE_FECHA_OFICIO; set => AYUDANTE_FECHA_OFICIO = value; }
        public int AYUDANTE_ESTADO1 { get => AYUDANTE_ESTADO; set => AYUDANTE_ESTADO = value; }
        

        public void Ingresar_Ayudante()
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
        public void Consultar_Ayudante()
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
        public void Modificar_Ayudante()
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
        public void Eliminar_Ayudante()
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
