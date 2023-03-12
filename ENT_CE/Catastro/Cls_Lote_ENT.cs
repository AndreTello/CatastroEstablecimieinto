using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT_CE.Catastro
{
    public class Cls_Lote_ENT
    {
        private int LOTE_ID;
        private int MANZANA_ID;
        private string LOTE_CODIGO;
        private string LOTE_NOMBRE;
        private int LOTE_ESTADO;
        private string LOTE_OBSERVACION;

        public int LOTE_ID1 { get => LOTE_ID; set => LOTE_ID = value; }
        public int MANZANA_ID1 { get => MANZANA_ID; set => MANZANA_ID = value; }
        public string LOTE_CODIGO1 { get => LOTE_CODIGO; set => LOTE_CODIGO = value; }
        public string LOTE_NOMBRE1 { get => LOTE_NOMBRE; set => LOTE_NOMBRE = value; }
        public int LOTE_ESTADO1 { get => LOTE_ESTADO; set => LOTE_ESTADO = value; }
        public string LOTE_OBSERVACION1 { get => LOTE_OBSERVACION; set => LOTE_OBSERVACION = value; }
    }
}
