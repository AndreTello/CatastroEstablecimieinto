using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Tipos_Producto_BLL
    {
        Cls_Tipos_Producto_DAL objdll = new Cls_Tipos_Producto_DAL();

        public void Consultar()
        {
            objdll.Consultar_Tipos_Producto();
        }

        public void Insertar()
        {
            objdll.Ingresar_Tipos_Producto();
        }

        public void Editar()
        {
            objdll.Modificar_Tipos_Producto();
        }

        public void Eliminar()
        {
            objdll.Eliminar_Tipos_Producto();
        }

    }
}
