using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Lote_BLL
    {
        Cls_Lote_DAL objdll = new Cls_Lote_DAL();

        public DataTable Consultar_Lote()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Consultar();
            return tabla;
        }

        public DataTable Consultar_IdLote(string id)
        {
            DataTable tabla = new DataTable();
            tabla = objdll.ConsultarID(Convert.ToInt32(id));
            return tabla;
        }


        public DataTable Listar_Lote()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Lote();
            return tabla;
        }

        public void Insertar_Lote(int manzana, string codigo, string nombre, string observacion, string estado)
        {
            objdll.Insertar(manzana, codigo, nombre, observacion, Convert.ToInt32(estado));
        }

        public void Editar_Lote(int manzana, string codigo, string nombre, string observacion, string estado, string id)
        {
            objdll.Editar(manzana, codigo, nombre, observacion, Convert.ToInt32(estado), Convert.ToInt32(id));
        }

        public void Eliminar_Lote(string id)
        {
            objdll.Eliminar(Convert.ToInt32(id));
        }

    }
}
