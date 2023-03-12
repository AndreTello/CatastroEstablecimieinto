using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT_CE.Catastro
{
    public class Cls_Piso_ENT
    {
        private int PISO_ID;
        private int BLOQUE_ID;
        private string PISO_CODIGO;
        private string PISO_NOMBRE;
        private int PISO_ESTADO;
        private string PISO_OBSERVACION;

        public int PISO_ID1 { get => PISO_ID; set => PISO_ID = value; }
        public int BLOQUE_ID1 { get => BLOQUE_ID; set => BLOQUE_ID = value; }
        public string PISO_CODIGO1 { get => PISO_CODIGO; set => PISO_CODIGO = value; }
        public string PISO_NOMBRE1 { get => PISO_NOMBRE; set => PISO_NOMBRE = value; }
        public int PISO_ESTADO1 { get => PISO_ESTADO; set => PISO_ESTADO = value; }
        public string PISO_OBSERVACION1 { get => PISO_OBSERVACION; set => PISO_OBSERVACION = value; }
    }
}
