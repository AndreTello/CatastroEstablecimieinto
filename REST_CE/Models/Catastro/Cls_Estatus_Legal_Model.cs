namespace REST_CE.Models.Catastro
{
    public class Cls_Estatus_Legal_Model
    {
        /* 0 */
        public int estatus_legal_id { get; set; }
        /* 1 */
        public int puesto_id { get; set; }
        /* 2 */
        public int giro_negocio_id { get; set; }
        /* 3 */
        public DateTime estatus_legal_fecha_ocupacion { get; set; }
        /* 4 */
        public string estatus_legal_historial { get; set; }
        /* 5 */
        public int estatus_legal_estado_adjudicado { get; set; }
        /* 6 */
        public int estatus_legal_numero_puesto_adjudicado { get; set; }
        /* 7 */
        public string estatus_legal_condicion_uso { get; set; }
        /* 8 */
        public Byte estatus_legal_carta_adjudicacion { get; set; }
        /* 9 */
        public DateTime estatus_fecha_notificacion { get; set; }
        /* 10 */
        public Byte estatus_legal_acta_resolucion_notificacion { get; set; }
        /* 11 */
        public DateTime estatus_legal_fecha_resolucion_notificacion { get; set; }

        /* 12 */
        public string estatus_legal_convenio_nombre { get; set; }
        /* 13 */
        public int estatus_legal_convenio_numero { get; set; }
        /* 14 */
        public DateTime estatus_legal_convenio_fecha { get; set; }
        /* 15 */
        public string estatus_legal_condicion { get; set; }
        /* 16 */
        public int estatus_legal_cambio_giro { get; set; }
        /* 17 */
        public string estatus_legal_numero_oficio_cambio_giro { get; set; }
        /* 18 */
        public DateTime estatus_legal_fecha_cambio_giro { get; set; }
        /* 19 */
        public string estatus_legal_sanciones { get; set; }
        /* 20 */
        public string estatus_legal_numero_resolucion_sancion { get; set; }
        /* 21 */
        public DateTime estatus_legal_fecha_resolucion_sancion { get; set; }
        


    }
}
