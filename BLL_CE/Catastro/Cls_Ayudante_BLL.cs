
using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Ayudante_BLL
    {
        Cls_Ayudante_DAL objdll = new Cls_Ayudante_DAL();

        public DataTable Consultar_Ayudante()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Consultar();
            return tabla;
        }

        public DataTable Consultar_IdAyudante(string id)
        {
            DataTable tabla = new DataTable();
            tabla = objdll.ConsultarID(Convert.ToInt32(id));
            return tabla;
        }

        public DataTable Listar_Ayudante()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Ayudante();
            return tabla;
        }

        public void Insertar_Ayudante(string cedula, string apellidos, string nombres, string parentezco, string autorizacion, string numero, string fecha, string estado)
        {
            objdll.Insertar(cedula, apellidos, nombres, parentezco, autorizacion, numero, Convert.ToDateTime(fecha), Convert.ToInt32(estado));
        }

        public void Editar_Ayudante(string cedula, string apellidos, string nombres, string parentezco, string autorizacion, string numero, string fecha, string estado, string id)
        {
            objdll.Editar(cedula, apellidos, nombres, parentezco, autorizacion, numero, Convert.ToDateTime(fecha), Convert.ToInt32(estado), Convert.ToInt32(id));
        }

        public void Eliminar_Ayudante(string id)
        {
            objdll.Eliminar(Convert.ToInt32(id));
        }
    } 

    

}
