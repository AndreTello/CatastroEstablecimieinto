using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Piso_BLL
    {
        Cls_Piso_DAL objdll = new Cls_Piso_DAL();

        public void Consultar()
        {
            objdll.Consultar_Piso();
        }

        public void Insertar()
        {
            objdll.Ingresar_Piso();
        }

        public void Editar()
        {
            objdll.Modificar_Piso();
        }

        public void Eliminar()
        {
            objdll.Eliminar_Piso();
        }

    }
}
