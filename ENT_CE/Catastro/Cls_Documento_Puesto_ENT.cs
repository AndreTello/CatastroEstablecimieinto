using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT_CE.Catastro
{
    public class Cls_Documento_Puesto_ENT
    {
        private int DOCUMENTO_PUESTO_ID;
        private int TIPO_DOCUMENTO_PUESTO_ID;
        private string DOCUMENTO_PUESTO_NOMBRE;
        private string DOCUMENTO_PUESTO_FECHA;
        private byte [] DOCUMENTO_PUESTO_ARCHIVO;
        private string DOCUMENTO_PUESTO_DETALLE;
        private string DOCUMENTO_PUESTO_OBSERVACION;
        private int DOCUMENTO_PUESTO_ESTADO;

        public int DOCUMENTO_PUESTO_ID1 { get => DOCUMENTO_PUESTO_ID; set => DOCUMENTO_PUESTO_ID = value; }
        public int TIPO_DOCUMENTO_PUESTO_ID1 { get => TIPO_DOCUMENTO_PUESTO_ID; set => TIPO_DOCUMENTO_PUESTO_ID = value; }
        public string DOCUMENTO_PUESTO_NOMBRE1 { get => DOCUMENTO_PUESTO_NOMBRE; set => DOCUMENTO_PUESTO_NOMBRE = value; }
        public string DOCUMENTO_PUESTO_FECHA1 { get => DOCUMENTO_PUESTO_FECHA; set => DOCUMENTO_PUESTO_FECHA = value; }
        public byte [] DOCUMENTO_PUESTO_ARCHIVO1 { get => DOCUMENTO_PUESTO_ARCHIVO; set => DOCUMENTO_PUESTO_ARCHIVO = value; }
        public string DOCUMENTO_PUESTO_DETALLE1 { get => DOCUMENTO_PUESTO_DETALLE; set => DOCUMENTO_PUESTO_DETALLE = value; }
        public string DOCUMENTO_PUESTO_OBSERVACION1 { get => DOCUMENTO_PUESTO_OBSERVACION; set => DOCUMENTO_PUESTO_OBSERVACION = value; }
        public int DOCUMENTO_PUESTO_ESTADO1 { get => DOCUMENTO_PUESTO_ESTADO; set => DOCUMENTO_PUESTO_ESTADO = value; }
    }
}
