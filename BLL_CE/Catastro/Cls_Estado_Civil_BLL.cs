using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Estado_Civil_BLL
    {
        Cls_Estado_Civil_DAL objdll = new Cls_Estado_Civil_DAL();

        public void Consultar()
        {
            objdll.Consultar_Estado_Civil();
        }

        public void Insertar()
        {
            objdll.Ingresar_Estado_Civil();
        }

        public void Editar()
        {
            objdll.Modificar_Estado_Civil();
        }

        public void Eliminar()
        {
            objdll.Eliminar_Estado_Civil();
        }

    }
}
