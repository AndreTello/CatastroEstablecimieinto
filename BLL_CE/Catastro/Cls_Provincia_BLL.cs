using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Provincia_BLL
    {
        Cls_Provincia_DAL objdll = new Cls_Provincia_DAL();

        public void Consultar()
        {
            objdll.Consultar_Provincia();
        }

        public void Insertar()
        {
            objdll.Ingresar_Provincia();
        }

        public void Editar()
        {
            objdll.Modificar_Provincia();
        }

        public void Eliminar()
        {
            objdll.Eliminar_Provincia();
        }

    }
}
