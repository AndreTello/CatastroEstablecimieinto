using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Asociacion_BLL
    {
        Cls_Asociacion_DAL objdll = new Cls_Asociacion_DAL();

        public void Consultar()
        {
            objdll.Consultar_Asociacion();
        }

        public void Insertar()
        {
            objdll.Ingresar_Asociacion();
        }

        public void Editar()
        {
            objdll.Modificar_Asociacion();
        }

        public void Eliminar()
        {
            objdll.Eliminar_Asociacion();
        }

    }
}
