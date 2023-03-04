using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Tipos_Producto_BLL
    {
        Cls_Tipos_Producto_DAL objdll = new Cls_Tipos_Producto_DAL();

        public DataTable Consultar_Tipo_Producto()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Consultar();
            return tabla;
        }

        public DataTable Consultar_IdTipo_Producto(string id)
        {
            DataTable tabla = new DataTable();
            tabla = objdll.ConsultarID(Convert.ToInt32(id));
            return tabla;
        }


        public DataTable Listar_Tipo_Producto()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Tipo_Producto();
            return tabla;
        }

        public void Insertar_Tipo_Producto(string nombre, string detalle, string observacion, string estado)
        {
            objdll.Insertar(nombre, detalle, observacion, Convert.ToInt32(estado));
        }

        public void Editar_Tipo_Producto(string nombre, string detalle, string observacion, string estado, string id)
        {
            objdll.Editar(nombre, detalle, observacion, Convert.ToInt32(estado), Convert.ToInt32(id));
        }

        public void Eliminar_Tipo_Producto(string id)
        {
            objdll.Eliminar(Convert.ToInt32(id));
        }
    }
}
