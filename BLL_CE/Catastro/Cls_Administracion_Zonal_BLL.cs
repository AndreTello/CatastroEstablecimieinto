using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Administracion_Zonal_BLL
    {
        Cls_Administracion_Zonal_DAL objdll = new Cls_Administracion_Zonal_DAL();

        public void Consultar()
        {
            objdll.Consultar_Administracion_Zonal();
        }

        public void Insertar()
        {
            objdll.Ingresar_Administracion_Zonal();
        }

        public void Editar()
        {
            objdll.Modificar_Administracion_Zonal();
        }

        public void Eliminar()
        {
            objdll.Eliminar_Administracion_Zonal();
        }

    }
}
