
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data.SQLite;
using DAL_CE_Postgresql.Catastro;

namespace BLL_CE.Catastro
{
    public class Cls_Ayudante_BLL
    {
        Cls_Ayudante_DAL objdll = new Cls_Ayudante_DAL();

        public void Consultar()
        {
            objdll.Consultar_Ayudante();
        }

        public void Insertar()
        {
            objdll.Ingresar_Ayudante();
        }

        public void Editar()
        {
            objdll.Modificar_Ayudante();
        }

        public void Eliminar()
        {
            objdll.Eliminar_Ayudante();
        }

        
    }
}
