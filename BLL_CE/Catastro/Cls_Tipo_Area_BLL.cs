using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Tipo_Area_BLL
    {
        Cls_Tipo_Area_DAL objdll = new Cls_Tipo_Area_DAL();

        public DataTable Consultar_Tipo_Area()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Consultar();
            return tabla;
        }

        public DataTable Consultar_IdTipo_Area(string id)
        {
            DataTable tabla = new DataTable();
            tabla = objdll.ConsultarID(Convert.ToInt32(id));
            return tabla;
        }

        public DataTable Listar_Tipo_Area()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Tipo_Area();
            return tabla;
        }

        public void Insertar_Tipo_Area(string identificacion, string nombre, string observaciones, string estado)
        {
            objdll.Insertar(identificacion, nombre, observaciones, Convert.ToInt32(estado));
        }

        public void Editar_Tipo_Area(string identificacion, string nombre, string observaciones, string estado, string id)
        {
            objdll.Editar(identificacion, nombre, observaciones, Convert.ToInt32(estado), Convert.ToInt32(id));
        }

        public void Eliminar_Tipo_Area(string id)
        {
            objdll.Eliminar(Convert.ToInt32(id));
        }

    }
}
