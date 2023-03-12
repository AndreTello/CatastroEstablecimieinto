using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT_CE.Catastro
{
    public class Cls_Zona_ENT
    {
        private int ZONA_ID;
        private int CANTON_ID;
        private string ZONA_CODIGO;
        private string ZONA_NOMBRE;
        private int ZONA_ESTADO;
        private string ZONA_OBSERVACION;

        public int ZONA_ID1 { get => ZONA_ID; set => ZONA_ID = value; }
        public int CANTON_ID1 { get => CANTON_ID; set => CANTON_ID = value; }
        public string ZONA_CODIGO1 { get => ZONA_CODIGO; set => ZONA_CODIGO = value; }
        public string ZONA_NOMBRE1 { get => ZONA_NOMBRE; set => ZONA_NOMBRE = value; }
        public int ZONA_ESTADO1 { get => ZONA_ESTADO; set => ZONA_ESTADO = value; }
        public string ZONA_OBSERVACION1 { get => ZONA_OBSERVACION; set => ZONA_OBSERVACION = value; }
    }
}
