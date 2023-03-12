namespace REST_CE.Models.Catastro
{
    public class Cls_Identificacion_Socio_Economica_Model
    {

        /* 0 */
        public int identificacion_socio_economica_id { get; set; }
        /* 1 */
        public int comerciante_id { get; set; }
        /* 2 */
        public int etnia_id { get; set; }
        /* 3 */
        public int genero_id { get; set; }
        /* 4 */
        public int estado_civil_id { get; set; }
        /* 5 */
        public int nacionalidad_id { get; set; }
        /* 6 */
        public int nivel_educacion_id { get; set; }
        /* 7 */
        public string puesto_predio { get; set; }
        /* 8 */
        public int discapacidad_id { get; set; }

        /* 9 */
        public string identificacion_socio_economica_jefe_familia { get; set; }

        /* 10 */
        public string identificacion_socio_economica_dependientes { get; set; }
        /* 11 */
        public int identificacion_socio_economica_numero_dependientes { get; set; }

        /* 12 */
        public string identificacion_socio_economica_parentesco { get; set; }
        /* 13 */
        public int identificacion_socio_economica_estado { get; set; }
    }
}
