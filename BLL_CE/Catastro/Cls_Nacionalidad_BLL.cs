using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Nacionalidad_BLL
    {
        Cls_Nacionalidad_DAL objdll = new Cls_Nacionalidad_DAL();

        public DataTable Consultar_Nacionalidad()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Consultar();
            return tabla;
        }

        public DataTable Consultar_IdNacionalidad(string id)
        {
            DataTable tabla = new DataTable();
            tabla = objdll.ConsultarID(Convert.ToInt32(id));
            return tabla;
        }

        public DataTable Listar_Nacionalidad()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Nacionalidad();
            return tabla;
        }

        public void Insertar_Nacionalidad(string codigo, string nombre, string detalle, string estado)
        {
            objdll.Insertar(codigo, nombre, detalle, Convert.ToInt32(estado));
        }

        public void Editar_Nacionalidad(string codigo, string nombre, string detalle, string estado, string id)
        {
            objdll.Editar(codigo, nombre, detalle, Convert.ToInt32(estado), Convert.ToInt32(id));
        }

        public void Eliminar_Nacionalidad(string id)
        {
            objdll.Eliminar(Convert.ToInt32(id));
        }

    }
}
