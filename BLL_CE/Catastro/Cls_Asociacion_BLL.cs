using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Asociacion_BLL
    {
        Cls_Asociacion_DAL objdll = new Cls_Asociacion_DAL();

        public DataTable Consultar_Asociacion()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Consultar();
            return tabla;
        }

        public DataTable Consultar_IdAsociacion(string id)
        {
            DataTable tabla = new DataTable();
            tabla = objdll.ConsultarID(Convert.ToInt32(id));
            return tabla;
        }

        public DataTable Listar_Asociacion()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Asociacion();
            return tabla;
        }

        public void Insertar_Asociacion(string codigo, string nombre, string telefono, string mail, string contacto, string observacion, string estado)
        {
            objdll.Insertar(codigo, nombre, telefono, mail, contacto, observacion, Convert.ToInt32(estado));
        }

        public void Editar_Asociacion(string codigo, string nombre, string telefono, string mail, string contacto, string observacion, string estado, string id)
        {
            objdll.Editar(codigo, nombre, telefono, mail, contacto, observacion, Convert.ToInt32(estado), Convert.ToInt32(id));
        }

        public void Eliminar_Asociacion(string id)
        {
            objdll.Eliminar(Convert.ToInt32(id));
        }

    }
}
