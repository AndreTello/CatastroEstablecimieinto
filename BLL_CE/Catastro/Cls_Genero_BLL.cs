using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Genero_BLL
    {
        Cls_Genero_DAL objdll = new Cls_Genero_DAL();

        public void Consultar()
        {
            objdll.Consultar_Genero();
        }

        public void Insertar()
        {
            objdll.Ingresar_Genero();
        }

        public void Editar()
        {
            objdll.Modificar_Genero();
        }

        public void Eliminar()
        {
            objdll.Eliminar_Genero();
        }

    }
}
