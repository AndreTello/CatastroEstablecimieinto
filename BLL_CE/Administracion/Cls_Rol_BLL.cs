using DAL_CE_Postgresql.Administracion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Administracion
{
    public class Cls_Rol_BLL
    {
        Cls_Rol_DAL objdll = new Cls_Rol_DAL();

        public DataTable Consultar_Rol()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Consultar();
            return tabla;
        }

        public DataTable Consultar_IdRol(string id)
        {
            DataTable tabla = new DataTable();
            tabla = objdll.ConsultarID(Convert.ToInt32(id));
            return tabla;
        }

        public DataTable Listar_Rol()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Rol();
            return tabla;
        }

        public void Insertar_Rol(string nombre, string detalle, string estado)
        {
            objdll.Insertar(nombre, detalle, Convert.ToInt32(estado));
        }

        public void Editar_Rol(string id, string nombre, string detalle, string estado)
        {
            objdll.Editar(Convert.ToInt32(id), nombre, detalle, Convert.ToInt32(estado));
        }

        public void Eliminar_Rol(string id)
        {
            objdll.Eliminar(Convert.ToInt32(id));
        }
    }
}
