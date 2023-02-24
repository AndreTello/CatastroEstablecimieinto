using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Familiar_BLL
    {
        Cls_Familiar_DAL objdll = new Cls_Familiar_DAL();

        public void Consultar()
        {
            objdll.Consultar_Familiar();
        }

        public void Insertar()
        {
            objdll.Ingresar_Familiar();
        }

        public void Editar()
        {
            objdll.Modificar_Familiar();
        }

        public void Eliminar()
        {
            objdll.Eliminar_Familiar();
        }

    }
}
