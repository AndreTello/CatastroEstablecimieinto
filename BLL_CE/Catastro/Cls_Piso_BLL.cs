using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Piso_BLL
    {
        Cls_Piso_DAL objdll = new Cls_Piso_DAL();

        public DataTable Consultar_Piso()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Consultar();
            return tabla;
        }

        public DataTable Consultar_IdPiso(string id)
        {
            DataTable tabla = new DataTable();
            tabla = objdll.ConsultarID(Convert.ToInt32(id));
            return tabla;
        }

        public DataTable Listar_Piso()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Piso();
            return tabla;
        }

        public void Insertar_Piso(int bloque, string codigo, string nombre, string observacion, string estado)
        {
            objdll.Insertar(bloque, codigo, nombre, observacion, Convert.ToInt32(estado));
        }

        public void Editar_Piso(int bloque, string codigo, string nombre, string observacion, string estado, string id)
        {
            objdll.Editar(bloque, codigo, nombre, observacion, Convert.ToInt32(estado), Convert.ToInt32(id));
        }

        public void Eliminar_Piso(string id)
        {
            objdll.Eliminar(Convert.ToInt32(id));
        }

    }
}
