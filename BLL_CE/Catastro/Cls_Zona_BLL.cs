using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Zona_BLL
    {
        Cls_Zona_DAL objdll = new Cls_Zona_DAL();

        public DataTable Consultar_Zona()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Consultar();
            return tabla;
        }

        public DataTable Consultar_IdZona(string id)
        {
            DataTable tabla = new DataTable();
            tabla = objdll.ConsultarID(Convert.ToInt32(id));
            return tabla;
        }


        public DataTable Listar_Zona()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Zona();
            return tabla;
        }

        public void Insertar_Zona(int canton, string codigo, string nombre, string observacion, string estado)
        {
            objdll.Insertar(canton, codigo, nombre, observacion, Convert.ToInt32(estado));
        }

        public void Editar_Zona(int canton, string codigo, string nombre, string observacion, string estado, string id)
        {
            objdll.Editar(canton, codigo, nombre, observacion, Convert.ToInt32(estado), Convert.ToInt32(id));
        }

        public void Eliminar_Zona(string id)
        {
            objdll.Eliminar(Convert.ToInt32(id));
        }
    }
}
