using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Parroquia_BLL
    {
        Cls_Parroquia_DAL objdll = new Cls_Parroquia_DAL();

        public DataTable Consultar_Parroquia()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Consultar();
            return tabla;
        }

        public DataTable Consultar_IdParroquia(string id)
        {
            DataTable tabla = new DataTable();
            tabla = objdll.ConsultarID(Convert.ToInt32(id));
            return tabla;
        }


        public DataTable Listar_Parroquia()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Parroquia();
            return tabla;
        }

        public void Insertar_Parroquia(int zona, string codigo, string nombre, string observacion, string estado)
        {
            objdll.Insertar(zona, codigo, nombre, observacion, Convert.ToInt32(estado));
        }

        public void Editar_Parroquia(int zona, string codigo, string nombre, string observacion, string estado, string id)
        {
            objdll.Editar(zona, codigo, nombre, observacion, Convert.ToInt32(estado), Convert.ToInt32(id));
        }

        public void Eliminar_Parroquia(string id)
        {
            objdll.Eliminar(Convert.ToInt32(id));
        }

    }
}
