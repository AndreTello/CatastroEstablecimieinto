using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Documento_Puesto_BLL
    {
        Cls_Documento_Puesto_DAL objdll = new Cls_Documento_Puesto_DAL();

        public DataTable Consultar_Documento_Puesto()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Consultar();
            return tabla;
        }

        public DataTable Consultar_IdDocumento_Puesto(string id)
        {
            DataTable tabla = new DataTable();
            tabla = objdll.ConsultarID(Convert.ToInt32(id));
            return tabla;
        }


        public DataTable Listar_Documento_Puesto()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Documento_Puesto();
            return tabla;
        }

        public void Insertar_Documento_Puesto(int tipo, string nombre, string fecha, string detalle, string observacion, string estado)
        {
            objdll.Insertar(tipo, nombre, fecha, detalle, observacion, Convert.ToInt32(estado));
        }

        public void Editar_Documento_Puesto(int tipo, string nombre, string fecha, string detalle, string observacion, string estado, string id)
        {
            objdll.Editar(tipo, nombre, fecha, detalle, observacion, Convert.ToInt32(estado), Convert.ToInt32(id));
        }

        public void Eliminar_Documento_Puesto(string id)
        {
            objdll.Eliminar(Convert.ToInt32(id));
        }

    }
}
