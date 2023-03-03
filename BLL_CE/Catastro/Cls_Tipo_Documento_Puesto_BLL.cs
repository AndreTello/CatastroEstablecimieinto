using DAL_CE_Postgresql.Catastro;
using System;
using System.Data;

namespace BLL_CE.Catastro
{
    public class Cls_Tipo_Documento_Puesto_BLL
    {
        Cls_Tipo_Documento_Puesto_DAL objdll = new Cls_Tipo_Documento_Puesto_DAL();

        public DataTable Consultar()
        {
            DataTable dt = new DataTable();
            dt = objdll.Consultar_Tipo_Documento_Puesto();
            return dt;
        }

        public void Insertar(string nombre, string estado)
        {
            objdll.Ingresar_Tipo_Documento_Puesto(nombre, Convert.ToInt32(estado));
        }

        public void Editar()
        {
            objdll.Modificar_Tipo_Documento_Puesto();
        }

        public void Eliminar()
        {
            objdll.Eliminar_Tipo_Documento_Puesto();
        }

    }
}
