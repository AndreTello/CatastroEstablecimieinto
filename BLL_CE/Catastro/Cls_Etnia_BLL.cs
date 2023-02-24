using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Etnia_BLL
    {
        Cls_Etnia_DAL objdll = new Cls_Etnia_DAL();

        public void Consultar()
        {
            objdll.Consultar_Etnia();
        }

        public void Insertar()
        {
            objdll.Ingresar_Etnia();
        }

        public void Editar()
        {
            objdll.Modificar_Etnia();
        }

        public void Eliminar()
        {
            objdll.Eliminar_Etnia();
        }

    }
}
