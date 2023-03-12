namespace REST_CE.Models.Catastro
{
    public class Cls_Establecimiento_Model
    {
        /* 0 */
        public int establecimiento_id { get; set; }
        /* 1 */
        public int lote_id { get; set; }
        /* 2 */
        public int administracion_zonal_id { get; set; }
        /* 3 */
        public int tipo_establecimiento_id { get; set; }
        /* 4 */
        public int asociacion_id { get; set; }
        /* 5 */
        public int intervencion_tecnica_establecimiento_id { get; set; }
        /* 6 */
        public string establecimiento_predio { get; set; }
        /* 7 */
        public string establecimiento_clave_catastral { get; set; }
        /* 8 */
        public string establecimiento_nomenclatura_vial { get; set; }
        /* 9 */
        public string establecimiento_calle_principal { get; set; }
        /* 10 */
        public string establecimiento_calle_secundaria { get; set; }
        /* 11 */
        public string establecimiento_paqueadero { get; set; }

        /* 12 */
        public int establecimiento_numero_parqueadero { get; set; }
        /* 13 */
        public string establecimiento_dias_apertura { get; set; }
        /* 14 */
        public string establecimiento_horario_atencion { get; set; }
        /* 15 */
        public int establecimiento_estado { get; set; }
    }
}
