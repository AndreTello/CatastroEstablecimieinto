using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Canton_BLL
    {
        Cls_Canton_DAL objdll = new Cls_Canton_DAL();

        public DataTable Consultar_Canton()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Consultar();
            return tabla;
        }

        public DataTable Consultar_IdCanton(string id)
        {
            DataTable tabla = new DataTable();
            tabla = objdll.ConsultarID(Convert.ToInt32(id));
            return tabla;
        }

        public DataTable Listar_Canton()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Canton();
            return tabla;
        }

        public void Insertar_Canton(int provincia, string codigo, string nombre, string observacion, string estado)
        {
            objdll.Insertar(provincia, codigo, nombre, observacion, Convert.ToInt32(estado));
        }

        public void Editar_Canton(string id, int provincia, string codigo, string nombre, string observacion, string estado)
        {
            objdll.Editar(Convert.ToInt32(id), provincia, codigo, nombre, observacion, Convert.ToInt32(estado));
        }

        public void Eliminar_Canton(string id)
        {
            objdll.Eliminar(Convert.ToInt32(id));
        }

    }
}
