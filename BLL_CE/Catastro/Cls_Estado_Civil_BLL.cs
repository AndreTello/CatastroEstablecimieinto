using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Estado_Civil_BLL
    {
        Cls_Estado_Civil_DAL objdll = new Cls_Estado_Civil_DAL();

        public DataTable Consultar_Estado_Civil()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Consultar();
            return tabla;
        }

        public DataTable Consultar_IdEstado_Civil(string id)
        {
            DataTable tabla = new DataTable();
            tabla = objdll.ConsultarID(Convert.ToInt32(id));
            return tabla;
        }

        public DataTable Listar_Estado_Civil()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.EstadoCivil();
            return tabla;
        }

        public void Insertar_Estado_Civil(string nombre, string detalle, string estado)
        {
            objdll.Insertar(nombre, detalle, Convert.ToInt32(estado));
        }

        public void Editar_Estado_Civil(string nombre, string detalle, string estado, string id)
        {
            objdll.Editar(nombre, detalle, Convert.ToInt32(estado), Convert.ToInt32(id));
        }

        public void Eliminar_Estado_Civil(string id)
        {
            objdll.Eliminar(Convert.ToInt32(id));
        }

    }
}
