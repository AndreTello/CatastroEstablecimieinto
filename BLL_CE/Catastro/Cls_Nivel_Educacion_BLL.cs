using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Nivel_Educacion_BLL
    {
        Cls_Nivel_Educacion_DAL objdll = new Cls_Nivel_Educacion_DAL();

        public DataTable Consultar_Nivel_Educacion()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Consultar();
            return tabla;
        }

        public DataTable Consultar_IdNivel_Educacion(string id)
        {
            DataTable tabla = new DataTable();
            tabla = objdll.ConsultarID(Convert.ToInt32(id));
            return tabla;
        }

        public DataTable Listar_Nivel_Educacion()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Nivel_Educacion();
            return tabla;
        }

        public void Insertar_Nivel_Educacion(string nombre, string detalle, string estado)
        {
            objdll.Insertar(nombre, detalle, Convert.ToInt32(estado));
        }

        public void Editar_Nivel_Educacion(string  nombre, string detalle, string estado, string id)
        {
            objdll.Editar(nombre, detalle, Convert.ToInt32(estado), Convert.ToInt32(id));
        }

        public void Eliminar_Nivel_Educacion(string id)
        {
            objdll.Eliminar(Convert.ToInt32(id));
        }
    }
}
