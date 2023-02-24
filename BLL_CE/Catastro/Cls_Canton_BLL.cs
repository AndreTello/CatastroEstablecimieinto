using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Canton_BLL
    {
        Cls_Canton_DAL objdll = new Cls_Canton_DAL();

        public void Consultar()
        {
            objdll.Consultar_Canton();
        }

        public void Insertar()
        {
            objdll.Ingresar_Canton();
        }

        public void Editar()
        {
            objdll.Modificar_Canton();
        }

        public void Eliminar()
        {
            objdll.Eliminar_Canton();
        }

    }
}
