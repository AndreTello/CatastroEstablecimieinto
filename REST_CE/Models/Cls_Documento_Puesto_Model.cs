namespace REST_CE.Models
{
    public class Cls_Documento_Puesto_Model
    {
        private int DOCUMENTO_PUESTO_ID;
        private int TIPO_DOCUMENTO_PUESTO_ID;
        private int PUESTO_ID;
        private string DOCUMENTO_PUESTO_NOMBRE;
        private DateTime DOCUMENTO_PUESTO_FECHA;
        private string DOCUMENTO_PUESTO_DETALLE;
        private string DOCUMENTO_PUESTO_OBSERVACION;
        private int DOCUMENTO_PUESTO_ESTADO;

        public int DOCUMENTO_PUESTO_ID1 { get => DOCUMENTO_PUESTO_ID; set => DOCUMENTO_PUESTO_ID = value; }
        public int PUESTO_ID1 { get => PUESTO_ID; set => PUESTO_ID = value; }
        public int TIPO_DOCUMENTO_PUESTO_ID1 { get => TIPO_DOCUMENTO_PUESTO_ID; set => TIPO_DOCUMENTO_PUESTO_ID = value; }
        public string DOCUMENTO_PUESTO_NOMBRE1 { get => DOCUMENTO_PUESTO_NOMBRE; set => DOCUMENTO_PUESTO_NOMBRE = value; }
        public string DOCUMENTO_PUESTO_DETALLE1 { get => DOCUMENTO_PUESTO_DETALLE; set => DOCUMENTO_PUESTO_DETALLE = value; }
        public DateTime DOCUMENTO_PUESTO_FECHA1 { get => DOCUMENTO_PUESTO_FECHA; set => DOCUMENTO_PUESTO_FECHA = value; }
        public int DOCUMENTO_PUESTO_ESTADO1 { get => DOCUMENTO_PUESTO_ESTADO; set => DOCUMENTO_PUESTO_ESTADO = value; }
        public string DOCUMENTO_PUESTO_OBSERVACION1 { get => DOCUMENTO_PUESTO_OBSERVACION; set => DOCUMENTO_PUESTO_OBSERVACION = value; }
    }
}
