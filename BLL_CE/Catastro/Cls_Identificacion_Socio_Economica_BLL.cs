using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Identificacion_Socio_Economica_BLL
    {
        Cls_Identificacion_Socio_Economica_DAL objdll = new Cls_Identificacion_Socio_Economica_DAL();

        public void Consultar()
        {
            objdll.Consultar_Identificacion_Socio_Economica();
        }

        public void Insertar()
        {
            objdll.Ingresar_Identificacion_Socio_Economica();
        }

        public void Editar()
        {
            objdll.Modificar_Identificacion_Socio_Economica();
        }

        public void Eliminar()
        {
            objdll.Eliminar_Identificacion_Socio_Economica();
        }

    }
}
