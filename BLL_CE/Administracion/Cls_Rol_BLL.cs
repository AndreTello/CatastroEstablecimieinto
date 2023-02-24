using DAL_CE_Postgresql.Administracion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Administracion
{
    public class Cls_Rol_BLL
    {
        Cls_Rol_DAL objdll = new Cls_Rol_DAL();

        public void Consultar()
        {
            objdll.Consultar_Rol();
        }

        public void Insertar()
        {
            objdll.Ingresar_Rol();
        }

        public void Editar()
        {
            objdll.Modificar_Rol();
        }

        public void Eliminar()
        {
            objdll.Eliminar_Rol();
        }
    }
}
