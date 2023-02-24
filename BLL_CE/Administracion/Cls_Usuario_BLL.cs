using DAL_CE_Postgresql.Administracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Administracion
{
    public class Cls_Usuario_BLL
    {
        Cls_Usuario_DAL objdll = new Cls_Usuario_DAL();

        public void Consultar()
        {
            objdll.Consultar_Usuario();
        }

        public void Insertar()
        {
            objdll.Ingresar_Usuario();
        }

        public void Editar()
        {
            objdll.Modificar_Usuario();
        }

        public void Eliminar()
        {
            objdll.Eliminar_Usuario();
        }

    }
}
