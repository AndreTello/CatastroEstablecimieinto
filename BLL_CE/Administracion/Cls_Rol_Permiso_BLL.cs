using DAL_CE_Postgresql.Administracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL_CE.Administracion
{
    public class Cls_Rol_Permiso_BLL
    {
        Cls_Rol_Permiso_DAL objdll = new Cls_Rol_Permiso_DAL();

        public void Consultar()
        {
            objdll.Consultar_Rol_Permiso();
        }

        public void Insertar()
        {
            objdll.Ingresar_Rol_Permiso();
        }

        public void Editar()
        {
            objdll.Modificar_Rol_Permiso();
        }

        public void Eliminar()
        {
            objdll.Eliminar_Rol_Permiso();
        }

    }
}
