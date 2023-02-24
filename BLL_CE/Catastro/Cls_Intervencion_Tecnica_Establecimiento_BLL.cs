using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Intervencion_Tecnica_Establecimiento_BLL
    {   
        Cls_Intervencion_Tecnica_Establecimiento_DAL objdll = new Cls_Intervencion_Tecnica_Establecimiento_DAL();

        public void Consultar()
        {
            objdll.Consultar_Intervencion_Tecnica_Establecimiento();
        }

        public void Insertar()
        {
            objdll.Ingresar_Intervencion_Tecnica_Establecimiento();
        }

        public void Editar()
        {
            objdll.Modificar_Intervencion_Tecnica_Establecimiento();
        }

        public void Eliminar()
        {
            objdll.Eliminar_Intervencion_Tecnica_Establecimiento();
        }

    }
}
