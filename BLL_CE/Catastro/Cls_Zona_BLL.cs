using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Zona_BLL
    {
        Cls_Zona_DAL objdll = new Cls_Zona_DAL();

        public void Consultar()
        {
            objdll.Consultar_Zona();
        }

        public void Insertar()
        {
            objdll.Ingresar_Zona();
        }

        public void Editar()
        {
            objdll.Modificar_Zona();
        }

        public void Eliminar()
        {
            objdll.Eliminar_Zona();
        }

    }
}
