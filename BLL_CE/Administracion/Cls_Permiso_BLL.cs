using DAL_CE_Postgresql.Administracion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Administracion
{
    public class Cls_Permiso_BLL
    {
        Cls_Permiso_DAL objdll = new Cls_Permiso_DAL();

        public DataTable Consultar_Permiso()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Consultar();
            return tabla;
        }

        public DataTable Consultar_IdPermiso(string id)
        {
            DataTable tabla = new DataTable();
            tabla = objdll.ConsultarID(Convert.ToInt32(id));
            return tabla;
        }

        public DataTable Listar_Permiso()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Permiso();
            return tabla;
        }

        public void Insertar_Permiso(string nombre, string detalle, string estado)
        {
            objdll.Insertar(nombre, detalle, Convert.ToInt32(estado));
        }

        public void Editar_Permiso(string id, string nombre, string detalle, string estado)
        {
            objdll.Editar(Convert.ToInt32(id), nombre, detalle, Convert.ToInt32(estado));
        }

        public void Eliminar_Permiso(string id)
        {
            objdll.Eliminar(Convert.ToInt32(id));
        }

    }
}
