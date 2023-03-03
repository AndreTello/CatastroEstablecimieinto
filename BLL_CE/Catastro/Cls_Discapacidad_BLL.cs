using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Discapacidad_BLL
    {
        Cls_Discapacidad_DAL objdll = new Cls_Discapacidad_DAL();

        public DataTable Consultar_Discapacidad()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Consultar();
            return tabla;
        }

        public DataTable Consultar_IdDiscapacidad(string id)
        {
            DataTable tabla = new DataTable();
            tabla = objdll.ConsultarID(Convert.ToInt32(id));
            return tabla;
        }

        public DataTable Listar_Discapacidad()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Discapacidad();
            return tabla;
        }

        public void Insertar_Discapacidad(string carnet, string nombre, string estado)
        {            
            objdll.Insertar(carnet, nombre, Convert.ToInt32(estado));
        }

        public void Editar_Discapacidad(string carnet, string nombre, string estado, string id)
        {
            objdll.Editar(carnet, nombre, Convert.ToInt32(estado), Convert.ToInt32(id));
        }

        public void Eliminar_Discapacidad(string id)
        {
            objdll.Eliminar(Convert.ToInt32(id));
        }

    }
}
