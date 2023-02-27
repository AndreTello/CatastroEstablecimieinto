using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Intervencion_Tecnica_Establecimiento_BLL
    {
        Cls_Intervencion_Tecnica_Establecimiento_DAL objdll = new Cls_Intervencion_Tecnica_Establecimiento_DAL();

        public DataTable Consultar_Intervencion_Tecnica_Establecimiento()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Consultar();
            return tabla;
        }

        public DataTable Consultar_IdIntervencion_Tecnica_Establecimiento(string id)
        {
            DataTable tabla = new DataTable();
            tabla = objdll.ConsultarID(Convert.ToInt32(id));
            return tabla;
        }


        public DataTable Listar_Intervencion_Tecnica_Establecimiento()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Intervencion_Tecnica();
            return tabla;
        }

        public void Insertar_Intervencion_Tecnica_Establecimiento(int tipo, string nombre, string fecha_inicio, string fecha_fin, string estado)
        {
            objdll.Insertar(tipo, nombre, fecha_inicio, fecha_fin, Convert.ToInt32(estado));
        }

        public void Editar_Intervencion_Tecnica_Establecimiento(int tipo, string nombre, string fecha_inicio, string fecha_fin, string estado, string id)
        {
            objdll.Editar(tipo, nombre, fecha_inicio, fecha_fin, Convert.ToInt32(estado), Convert.ToInt32(id));
        }

        public void Eliminar_Intervencion_Tecnica_Establecimiento(string id)
        {
            objdll.Eliminar(Convert.ToInt32(id));
        }
    }
}
