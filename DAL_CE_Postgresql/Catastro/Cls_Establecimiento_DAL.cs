﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL_CE_Postgresql.Catastro
{
    public class Cls_Establecimiento_DAL
    {
        private int ESTABLECIMIENTO_ID;
        private int LOTE_ID;
		private int ADMINISTRACION_ZONAL_ID;
        private int TIPO_ESTABLECIMIENTO_ID;
		private int ASOCIACION_ID;
        private int INTERVENCION_TECNICA_ESTABLECIMIENTO_ID;
		private string ESTABLECIMIENTO_PREDIO;
        private string ESTABLECIMIENTO_CLAVE_CATASTRAL;
        private string ESTABLECIMIENTO_NOMENCLATURA_VIAL;
		private string ESTABLECIMIENTO_CALLE_PRINCIPAL;
        private string ESTABLECIMIENTO_CALLE_SECUNDARIA;
        private string ESTABLECIMIENTO_PAQUEADERO;
        private int ESTABLECIMIENTO_NUMERO_PARQUEADERO;
		private string ESTABLECIMIENTO_DIAS_APERTURA;
        private string ESTABLECIMIENTO_HORARIO_ATENCION;
        private int ESTABLECIMIENTO_ESTADO;

        public int ESTABLECIMIENTO_ID1 { get => ESTABLECIMIENTO_ID; set => ESTABLECIMIENTO_ID = value; }
        public int LOTE_ID1 { get => LOTE_ID; set => LOTE_ID = value; }
        public int ADMINISTRACION_ZONAL_ID1 { get => ADMINISTRACION_ZONAL_ID; set => ADMINISTRACION_ZONAL_ID = value; }
        public int TIPO_ESTABLECIMIENTO_ID1 { get => TIPO_ESTABLECIMIENTO_ID; set => TIPO_ESTABLECIMIENTO_ID = value; }
        public int ASOCIACION_ID1 { get => ASOCIACION_ID; set => ASOCIACION_ID = value; }
        public int INTERVENCION_TECNICA_ESTABLECIMIENTO_ID1 { get => INTERVENCION_TECNICA_ESTABLECIMIENTO_ID; set => INTERVENCION_TECNICA_ESTABLECIMIENTO_ID = value; }
        public string ESTABLECIMIENTO_PREDIO1 { get => ESTABLECIMIENTO_PREDIO; set => ESTABLECIMIENTO_PREDIO = value; }
        public string ESTABLECIMIENTO_CLAVE_CATASTRAL1 { get => ESTABLECIMIENTO_CLAVE_CATASTRAL; set => ESTABLECIMIENTO_CLAVE_CATASTRAL = value; }
        public string ESTABLECIMIENTO_NOMENCLATURA_VIAL1 { get => ESTABLECIMIENTO_NOMENCLATURA_VIAL; set => ESTABLECIMIENTO_NOMENCLATURA_VIAL = value; }
        public string ESTABLECIMIENTO_CALLE_PRINCIPAL1 { get => ESTABLECIMIENTO_CALLE_PRINCIPAL; set => ESTABLECIMIENTO_CALLE_PRINCIPAL = value; }
        public string ESTABLECIMIENTO_CALLE_SECUNDARIA1 { get => ESTABLECIMIENTO_CALLE_SECUNDARIA; set => ESTABLECIMIENTO_CALLE_SECUNDARIA = value; }
        public string ESTABLECIMIENTO_PAQUEADERO1 { get => ESTABLECIMIENTO_PAQUEADERO; set => ESTABLECIMIENTO_PAQUEADERO = value; }
        public int ESTABLECIMIENTO_NUMERO_PARQUEADERO1 { get => ESTABLECIMIENTO_NUMERO_PARQUEADERO; set => ESTABLECIMIENTO_NUMERO_PARQUEADERO = value; }
        public string ESTABLECIMIENTO_DIAS_APERTURA1 { get => ESTABLECIMIENTO_DIAS_APERTURA; set => ESTABLECIMIENTO_DIAS_APERTURA = value; }
        public string ESTABLECIMIENTO_HORARIO_ATENCION1 { get => ESTABLECIMIENTO_HORARIO_ATENCION; set => ESTABLECIMIENTO_HORARIO_ATENCION = value; }
        public int ESTABLECIMIENTO_ESTADO1 { get => ESTABLECIMIENTO_ESTADO; set => ESTABLECIMIENTO_ESTADO = value; }

        public void Ingresar_Establecimiento()
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
        public void Consultar_Establecimiento()
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
        public void Modificar_Establecimiento()
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
        public void Eliminar_Establecimiento()
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
