using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Reemplazo_BLL
    {
        Cls_Reemplazo_DAL objdll = new Cls_Reemplazo_DAL();

        public void Consultar()
        {
            objdll.Consultar_Reemplazo();
        }

        public void Insertar()
        {
            objdll.Ingresar_Reemplazo();
        }

        public void Editar()
        {
            objdll.Modificar_Reemplazo();
        }

        public void Eliminar()
        {
            objdll.Eliminar_Reemplazo();
        }

    }
}
