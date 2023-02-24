using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Giro_Negocio_BLL
    {
        Cls_Giro_Negocio_DAL objdll = new Cls_Giro_Negocio_DAL();

        public void Consultar()
        {
            objdll.Consultar_Giro_Negocio();
        }

        public void Insertar()
        {
            objdll.Ingresar_Giro_Negocio();
        }

        public void Editar()
        {
            objdll.Modificar_Giro_Negocio();
        }

        public void Eliminar()
        {
            objdll.Eliminar_Giro_Negocio();
        }

    }
}
