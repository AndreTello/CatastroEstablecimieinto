using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Nivel_Educacion_BLL
    {
        Cls_Nivel_Educacion_DAL objdll = new Cls_Nivel_Educacion_DAL();

        public void Consultar()
        {
            objdll.Consultar_Nivel_Educacion();
        }

        public void Insertar()
        {
            objdll.Ingresar_Nivel_Educacion();
        }

        public void Editar()
        {
            objdll.Modificar_Nivel_Educacion();
        }

        public void Eliminar()
        {
            objdll.Eliminar_Nivel_Educacion();
        }

    }
}
