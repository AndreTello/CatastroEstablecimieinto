using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Tipo_Documento_Comerciante_BLL
    {
        Cls_Tipo_Documento_Comerciante_DAL objdll = new Cls_Tipo_Documento_Comerciante_DAL();

        public DataTable Consultar_Tipo_Documento_Comerciante()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Consultar();
            return tabla;
        }

        public DataTable Consultar_IdTipo_Documento_Comerciante(string id)
        {
            DataTable tabla = new DataTable();
            tabla = objdll.ConsultarID(Convert.ToInt32(id));
            return tabla;
        }

        public DataTable Listar_Tipo_Documento_Comerciante()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Tipo_Documento_Comerciante();
            return tabla;
        }

        public void Insertar_Tipo_Documento_Comerciante(string nombre, string estado)
        {
            objdll.Insertar( nombre, Convert.ToInt32(estado));
        }

        public void Editar_Tipo_Documento_Comerciante(string nombre, string estado, string id)
        {
            objdll.Editar(nombre, Convert.ToInt32(estado), Convert.ToInt32(id));
        }

        public void Eliminar_Tipo_Documento_Comerciante(string id)
        {
            objdll.Eliminar(Convert.ToInt32(id));
        }

    }
}
