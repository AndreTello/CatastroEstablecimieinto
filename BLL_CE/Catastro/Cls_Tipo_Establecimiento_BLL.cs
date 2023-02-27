using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Tipo_Establecimiento_BLL
    {
        Cls_Tipo_Establecimiento_DAL objdll = new Cls_Tipo_Establecimiento_DAL();

        public DataTable Consultar_Tipo_Establecimiento()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Consultar();
            return tabla;
        }

        public DataTable Consultar_IdTipo_Establecimiento(string id)
        {
            DataTable tabla = new DataTable();
            tabla = objdll.ConsultarID(Convert.ToInt32(id));
            return tabla;
        }


        public DataTable Listar_Tipo_Establecimiento()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Tipo_Establecimiento();
            return tabla;
        }

        public void Insertar_Tipo_Establecimiento(string nombre, string detalle, string estado)
        {
            objdll.Insertar(nombre, detalle, Convert.ToInt32(estado));
        }

        public void Editar_Tipo_Establecimiento(string nombre, string detalle, string estado, string id)
        {
            objdll.Editar(nombre, detalle, Convert.ToInt32(estado), Convert.ToInt32(id));
        }

        public void Eliminar_Tipo_Establecimiento(string id)
        {
            objdll.Eliminar(Convert.ToInt32(id));
        }

    }
}
