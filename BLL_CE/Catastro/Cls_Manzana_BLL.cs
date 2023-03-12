using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Manzana_BLL
    {
        Cls_Manzana_DAL objdll = new Cls_Manzana_DAL();

        public DataTable Consultar_Manzana()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Consultar();
            return tabla;
        }

        public DataTable Consultar_IdManzana(string id)
        {
            DataTable tabla = new DataTable();
            tabla = objdll.ConsultarID(Convert.ToInt32(id));
            return tabla;
        }


        public DataTable Listar_Manzana()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Manzana();
            return tabla;
        }

        public void Insertar_Manzana(int parroquia, string codigo, string nombre, string observacion, string estado)
        {
            objdll.Insertar(parroquia, codigo, nombre, observacion, Convert.ToInt32(estado));
        }

        public void Editar_Manzana(string id, int parroquia, string codigo, string nombre, string observacion, string estado)
        {
            objdll.Editar(Convert.ToInt32(id), parroquia, codigo, nombre, observacion, Convert.ToInt32(estado));
        }

        public void Eliminar_Manzana(string id)
        {
            objdll.Eliminar(Convert.ToInt32(id));
        }

    }
}
