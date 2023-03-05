using DAL_CE_Postgresql.Administracion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Administracion
{
    public class Cls_Usuario_BLL
    {
        Cls_Usuario_DAL objdll = new Cls_Usuario_DAL();

        public DataTable Consultar_Usuario()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Consultar();
            return tabla;
        }

        public DataTable Consultar_IdUsuario(string id)
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

        public void Insertar_Usuario(int rol, string login, string clave, string cedula, string apellidos, string nombres, string email, string direccion, string telefono, string estado)
        {
            objdll.Insertar(rol, login, clave, cedula, apellidos, nombres, email, direccion, telefono, Convert.ToInt32(estado));
        }

        public void Editar_Usuario(int rol, string login, string clave, string cedula, string apellidos, string nombres, string email, string direccion, string telefono, string estado, string id)
        {
            objdll.Editar(rol, login, clave, cedula, apellidos, nombres, email, direccion, telefono, Convert.ToInt32(estado), Convert.ToInt32(id));
        }

        public void Eliminar_Usuario(string id)
        {
            objdll.Eliminar(Convert.ToInt32(id));
        }

    }
}
