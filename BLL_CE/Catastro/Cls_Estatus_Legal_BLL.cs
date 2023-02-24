using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Estatus_Legal_BLL
    {
        Cls_Estatus_Legal_DAL objdll = new Cls_Estatus_Legal_DAL();

        public void Consultar()
        {
            objdll.Consultar_Estatus_Legal();
        }

        public void Insertar()
        {
            objdll.Ingresar_Estatus_Legal();
        }

        public void Editar()
        {
            objdll.Modificar_Estatus_Legal();
        }

        public void Eliminar()
        {
            objdll.Eliminar_Estatus_Legal();
        }

    }
}
