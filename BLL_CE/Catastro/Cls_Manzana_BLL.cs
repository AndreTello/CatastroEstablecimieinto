using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Manzana_BLL
    {
        Cls_Manzana_DAL objdll = new Cls_Manzana_DAL();

        public void Consultar()
        {
            objdll.Consultar_Manzana();
        }

        public void Insertar()
        {
            objdll.Ingresar_Manzana();
        }

        public void Editar()
        {
            objdll.Modificar_Manzana();
        }

        public void Eliminar()
        {
            objdll.Eliminar_Manzana();
        }

    }
}
