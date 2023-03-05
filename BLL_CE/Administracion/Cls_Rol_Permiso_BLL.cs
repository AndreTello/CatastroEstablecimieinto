using DAL_CE_Postgresql.Administracion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL_CE.Administracion
{
    public class Cls_Rol_Permiso_BLL
    {
        Cls_Rol_Permiso_DAL objdll = new Cls_Rol_Permiso_DAL();

        public DataTable Consultar_Rol_Permiso()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Consultar();
            return tabla;
        }

        public DataTable Consultar_IdRol_Permiso(string id)
        {
            DataTable tabla = new DataTable();
            tabla = objdll.ConsultarID(Convert.ToInt32(id));
            return tabla;
        }

        /*public DataTable Listar_Familiar()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Familiar();
            return tabla;
        }*/

        public void Insertar_Rol_Permiso(int rol, int permiso, string estado)
        {
            objdll.Insertar(rol, permiso, Convert.ToInt32(estado));
        }

        public void Editar_Rol_Permiso(int rol, int permiso, string estado, string id)
        {
            objdll.Editar(rol, permiso, Convert.ToInt32(estado), Convert.ToInt32(id));
        }

        public void Eliminar_Rol_Permiso(string id)
        {
            objdll.Eliminar(Convert.ToInt32(id));
        }

    }
}
