using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Discapacidad_BLL
    {
        Cls_Discapacidad_DAL objdll = new Cls_Discapacidad_DAL();

        public void Consultar()
        {
            objdll.Consultar_Discapacidad();
        }

        public void Insertar()
        {
            objdll.Ingresar_Discapacidad();
        }

        public void Editar()
        {
            objdll.Modificar_Discapacidad();
        }

        public void Eliminar()
        {
            objdll.Eliminar_Discapacidad();
        }

    }
}
