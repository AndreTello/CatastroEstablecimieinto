using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Etnia_BLL
    {
        Cls_Etnia_DAL objdll = new Cls_Etnia_DAL();

        public DataTable Consultar_Etnia()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Consultar();
            return tabla;
        }

        public DataTable Consultar_IdEtnia(string id)
        {
            DataTable tabla = new DataTable();
            tabla = objdll.ConsultarID(Convert.ToInt32(id));
            return tabla;
        }

        public DataTable Listar_Etnia()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Etnia();
            return tabla;
        }

        public void Insertar_Etnia(string nombre, string detalle, string estado)
        {
            objdll.Insertar(nombre, detalle, Convert.ToInt32(estado));
        }

        public void Editar_Etnia(string nombre, string detalle, string estado, string id)
        {
            objdll.Editar(nombre, detalle, Convert.ToInt32(estado), Convert.ToInt32(id));
        }

        public void Eliminar_Etnia(string id)
        {
            objdll.Eliminar(Convert.ToInt32(id));
        }

    }
}
