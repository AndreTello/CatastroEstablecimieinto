using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Reemplazo_BLL
    {
        Cls_Reemplazo_DAL objdll = new Cls_Reemplazo_DAL();

        public DataTable Consultar_Reemplazo()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Consultar();
            return tabla;
        }

        public DataTable Consultar_IdReemplazo(string id)
        {
            DataTable tabla = new DataTable();
            tabla = objdll.ConsultarID(Convert.ToInt32(id));
            return tabla;
        }

        public DataTable Listar_Reemplazo()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Reemplazo();
            return tabla;
        }

        public void Insertar_Reemplazo(string cedula, string apellidos, string nombres, string autorizacion, string numero, string fechainicio, string fechafin, string estado)
        {
            objdll.Insertar(cedula, apellidos, nombres, autorizacion, numero, Convert.ToDateTime(fechainicio), Convert.ToDateTime(fechafin), Convert.ToInt32(estado));
        }

        public void Editar_Reemplazo(string cedula, string apellidos, string nombres, string autorizacion, string numero, string fechainicio, string fechafin, string estado, string id)
        {
            objdll.Editar(cedula, apellidos, nombres, autorizacion, numero, Convert.ToDateTime(fechainicio), Convert.ToDateTime(fechafin), Convert.ToInt32(estado), Convert.ToInt32(id));
        }

        public void Eliminar_Reemplazo(string id)
        {
            objdll.Eliminar(Convert.ToInt32(id));
        }

    }
}
