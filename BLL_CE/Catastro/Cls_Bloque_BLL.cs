using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Bloque_BLL
    {
        Cls_Bloque_DAL objdll = new Cls_Bloque_DAL();

        public void Consultar()
        {
            objdll.Consultar_Bloque();
        }

        public void Insertar()
        {
            objdll.Ingresar_Bloque();
        }

        public void Editar()
        {
            objdll.Modificar_Bloque();
        }

        public void Eliminar()
        {
            objdll.Eliminar_Bloque();
        }

    }
}
