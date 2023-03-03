using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Bloque_BLL
    {
        Cls_Bloque_DAL objdll = new Cls_Bloque_DAL();

        public DataTable Consultar_Bloque()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Consultar();
            return tabla;
        }

        public DataTable Consultar_IdBloque(string id)
        {
            DataTable tabla = new DataTable();
            tabla = objdll.ConsultarID(Convert.ToInt32(id));
            return tabla;
        }

        public DataTable Listar_Bloque()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Bloque();
            return tabla;
        }

        public void Insertar_Bloque(int establecimiento, string codigo, string nombre, string observacion, string estado)
        {
            objdll.Insertar(establecimiento, codigo, nombre, observacion, Convert.ToInt32(estado));
        }

        public void Editar_Bloque(int establecimiento, string codigo, string nombre, string observacion, string estado, string id)
        {
            objdll.Editar(establecimiento, codigo, nombre, observacion, Convert.ToInt32(estado), Convert.ToInt32(id));
        }

        public void Eliminar_Bloque(string id)
        {
            objdll.Eliminar(Convert.ToInt32(id));
        }

    }
}
