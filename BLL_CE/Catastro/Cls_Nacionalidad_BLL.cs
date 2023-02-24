using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Nacionalidad_BLL
    {
        Cls_Nacionalidad_DAL objdll = new Cls_Nacionalidad_DAL();

        public void Consultar()
        {
            objdll.Consultar_Nacionalidad();
        }

        public void Insertar()
        {
            objdll.Ingresar_Nacionalidad();
        }

        public void Editar()
        {
            objdll.Modificar_Nacionalidad();
        }

        public void Eliminar()
        {
            objdll.Eliminar_Nacionalidad();
        }

    }
}
