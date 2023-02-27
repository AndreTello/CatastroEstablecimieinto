using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Administracion_Zonal_BLL
    {
        Cls_Administracion_Zonal_DAL objdll = new Cls_Administracion_Zonal_DAL();

        public DataTable Consultar_Administracion_Zonal()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Consultar();
            return tabla;
        }
        public DataTable Consultar_IdAdministracion_Zonal(string id)
        {
            DataTable tabla = new DataTable();
            tabla = objdll.ConsultarId(Convert.ToInt32(id));
            return tabla;
        }

        public DataTable Listar_Administracion_Zonal()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Administracion_Zonal();
            return tabla;
        }

        public void Insertar_Administracion_Zonal(string nombre, string detalle, string telefono, string celular, string mail, string pagina_web, string representante, string estado)
        {
            objdll.Insertar(nombre, detalle, telefono, celular, mail, pagina_web, representante, Convert.ToInt32(estado));
        }

        public void Editar_Administracion_Zonal(string nombre, string detalle, string telefono, string celular, string mail, string pagina_web, string representante, string estado, string id)
        {
            objdll.Editar(nombre, detalle, telefono, celular, mail, pagina_web, representante, Convert.ToInt32(estado), Convert.ToInt32(id));
        }

        public void Eliminar_Administracion_Zonal(string id)
        {
            objdll.Eliminar(Convert.ToInt32(id));
        }

    }
}
