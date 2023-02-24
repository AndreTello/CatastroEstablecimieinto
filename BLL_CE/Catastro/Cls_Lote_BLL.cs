using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Lote_BLL
    {
        Cls_Lote_DAL objdll = new Cls_Lote_DAL();

        public void Consultar()
        {
            objdll.Consultar_Lote();
        }

        public void Insertar()
        {
            objdll.Ingresar_Lote();
        }

        public void Editar()
        {
            objdll.Modificar_Lote();
        }

        public void Eliminar()
        {
            objdll.Eliminar_Lote();
        }

    }
}
