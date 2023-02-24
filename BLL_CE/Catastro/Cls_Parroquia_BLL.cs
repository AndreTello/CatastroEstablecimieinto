using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Parroquia_BLL
    {
        Cls_Parroquia_DAL objdll = new Cls_Parroquia_DAL();

        public void Consultar()
        {
            objdll.Consultar_Parroquia();
        }

        public void Insertar()
        {
            objdll.Ingresar_Parroquia();
        }

        public void Editar()
        {
            objdll.Modificar_Parroquia();
        }

        public void Eliminar()
        {
            objdll.Eliminar_Parroquia();
        }

    }
}
