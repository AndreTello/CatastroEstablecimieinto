using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Documento_Puesto_BLL
    {
        Cls_Documento_Puesto_DAL objdll = new Cls_Documento_Puesto_DAL();

        public void Consultar()
        {
            objdll.Consultar_Documento_Puesto();
        }

        public void Insertar()
        {
            objdll.Ingresar_Documento_Puesto();
        }

        public void Editar()
        {
            objdll.Modificar_Documento_Puesto();
        }

        public void Eliminar()
        {
            objdll.Eliminar_Documento_Puesto();
        }

    }
}
