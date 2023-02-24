using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DAL_CE_Postgresql.Catastro
{
    public class Cls_Estatus_Legal_DAL
    {
        private int ESTATUS_LEGAL_ID;
        private int PUESTO_ID;
        private int GIRO_NEGOCIO_ID;
        private DateTime ESTATUS_LEGAL_FECHA_OCUPACION;
        private string ESTATUS_LEGAL_HISTORIAL;
        private int ESTATUS_LEGAL_ESTADO_ADJUDICADO;
        private int ESTATUS_LEGAL_NUMERO_PUESTO_ADJUDICADO;
        private string ESTATUS_LEGAL_CONDICION_USO;
        private int ESTATUS_LEGAL_CARTA_ADJUDICACION;      //bytea
        private DateTime ESTATUS_FECHA_NOTIFICACION;
        private int ESTATUS_LEGAL_ACTA_RESOLUCION_NOTIFICACION;   //bytea
        private DateTime ESTATUS_LEGAL_FECHA_RESOLUCION_NOTIFICACION;
        private string ESTATUS_LEGAL_CONVENIO_NOMBRE;
        private int ESTATUS_LEGAL_CONVENIO_NUMERO;
		private DateTime ESTATUS_LEGAL_CONVENIO_FECHA;
        private string ESTATUS_LEGAL_CONDICION;
        private int ESTATUS_LEGAL_CAMBIO_GIRO;
        private string ESTATUS_LEGAL_NUMERO_OFICIO_CAMBIO_GIRO;
		private DateTime ESTATUS_LEGAL_FECHA_CAMBIO_GIRO;
        private string ESTATUS_LEGAL_SANCIONES;
		private string ESTATUS_LEGAL_NUMERO_RESOLUCION_SANCION;
		private DateTime ESTATUS_LEGAL_FECHA_RESOLUCION_SANCION;
        private int ESTATUS_LEGAL_ESTADO;

        public int ESTATUS_LEGAL_ID1 { get => ESTATUS_LEGAL_ID; set => ESTATUS_LEGAL_ID = value; }
        public int PUESTO_ID1 { get => PUESTO_ID; set => PUESTO_ID = value; }
        public int GIRO_NEGOCIO_ID1 { get => GIRO_NEGOCIO_ID; set => GIRO_NEGOCIO_ID = value; }
        public DateTime ESTATUS_LEGAL_FECHA_OCUPACION1 { get => ESTATUS_LEGAL_FECHA_OCUPACION; set => ESTATUS_LEGAL_FECHA_OCUPACION = value; }
        public string ESTATUS_LEGAL_HISTORIAL1 { get => ESTATUS_LEGAL_HISTORIAL; set => ESTATUS_LEGAL_HISTORIAL = value; }
        public int ESTATUS_LEGAL_ESTADO_ADJUDICADO1 { get => ESTATUS_LEGAL_ESTADO_ADJUDICADO; set => ESTATUS_LEGAL_ESTADO_ADJUDICADO = value; }
        public int ESTATUS_LEGAL_NUMERO_PUESTO_ADJUDICADO1 { get => ESTATUS_LEGAL_NUMERO_PUESTO_ADJUDICADO; set => ESTATUS_LEGAL_NUMERO_PUESTO_ADJUDICADO = value; }
        public string ESTATUS_LEGAL_CONDICION_USO1 { get => ESTATUS_LEGAL_CONDICION_USO; set => ESTATUS_LEGAL_CONDICION_USO = value; }
        public int ESTATUS_LEGAL_CARTA_ADJUDICACION1 { get => ESTATUS_LEGAL_CARTA_ADJUDICACION; set => ESTATUS_LEGAL_CARTA_ADJUDICACION = value; }
        public DateTime ESTATUS_FECHA_NOTIFICACION1 { get => ESTATUS_FECHA_NOTIFICACION; set => ESTATUS_FECHA_NOTIFICACION = value; }
        public int ESTATUS_LEGAL_ACTA_RESOLUCION_NOTIFICACION1 { get => ESTATUS_LEGAL_ACTA_RESOLUCION_NOTIFICACION; set => ESTATUS_LEGAL_ACTA_RESOLUCION_NOTIFICACION = value; }
        public DateTime ESTATUS_LEGAL_FECHA_RESOLUCION_NOTIFICACION1 { get => ESTATUS_LEGAL_FECHA_RESOLUCION_NOTIFICACION; set => ESTATUS_LEGAL_FECHA_RESOLUCION_NOTIFICACION = value; }
        public string ESTATUS_LEGAL_CONVENIO_NOMBRE1 { get => ESTATUS_LEGAL_CONVENIO_NOMBRE; set => ESTATUS_LEGAL_CONVENIO_NOMBRE = value; }
        public int ESTATUS_LEGAL_CONVENIO_NUMERO1 { get => ESTATUS_LEGAL_CONVENIO_NUMERO; set => ESTATUS_LEGAL_CONVENIO_NUMERO = value; }
        public DateTime ESTATUS_LEGAL_CONVENIO_FECHA1 { get => ESTATUS_LEGAL_CONVENIO_FECHA; set => ESTATUS_LEGAL_CONVENIO_FECHA = value; }
        public string ESTATUS_LEGAL_CONDICION1 { get => ESTATUS_LEGAL_CONDICION; set => ESTATUS_LEGAL_CONDICION = value; }
        public int ESTATUS_LEGAL_CAMBIO_GIRO1 { get => ESTATUS_LEGAL_CAMBIO_GIRO; set => ESTATUS_LEGAL_CAMBIO_GIRO = value; }
        public string ESTATUS_LEGAL_NUMERO_OFICIO_CAMBIO_GIRO1 { get => ESTATUS_LEGAL_NUMERO_OFICIO_CAMBIO_GIRO; set => ESTATUS_LEGAL_NUMERO_OFICIO_CAMBIO_GIRO = value; }
        public DateTime ESTATUS_LEGAL_FECHA_CAMBIO_GIRO1 { get => ESTATUS_LEGAL_FECHA_CAMBIO_GIRO; set => ESTATUS_LEGAL_FECHA_CAMBIO_GIRO = value; }
        public string ESTATUS_LEGAL_SANCIONES1 { get => ESTATUS_LEGAL_SANCIONES; set => ESTATUS_LEGAL_SANCIONES = value; }
        public string ESTATUS_LEGAL_NUMERO_RESOLUCION_SANCION1 { get => ESTATUS_LEGAL_NUMERO_RESOLUCION_SANCION; set => ESTATUS_LEGAL_NUMERO_RESOLUCION_SANCION = value; }
        public DateTime ESTATUS_LEGAL_FECHA_RESOLUCION_SANCION1 { get => ESTATUS_LEGAL_FECHA_RESOLUCION_SANCION; set => ESTATUS_LEGAL_FECHA_RESOLUCION_SANCION = value; }
        public int ESTATUS_LEGAL_ESTADO1 { get => ESTATUS_LEGAL_ESTADO; set => ESTATUS_LEGAL_ESTADO = value; }

        public void Ingresar_Estatus_Legal()
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
        public void Consultar_Estatus_Legal()
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
        public void Modificar_Estatus_Legal()
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
        public void Eliminar_Estatus_Legal()
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
