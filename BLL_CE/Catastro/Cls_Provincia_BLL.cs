using DAL_CE_Postgresql.Catastro;
using System;

using System.Data;


namespace BLL_CE.Catastro
{
    public class Cls_Provincia_BLL
    {
        Cls_Provincia_DAL objdll = new Cls_Provincia_DAL();

        public DataTable Consultar_Provincia()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Consultar();
            return tabla;
        }

        public DataTable Consultar_IdProvincia(string id)
        {
            DataTable tabla = new DataTable();
            tabla = objdll.ConsultarID(Convert.ToInt32(id));
            return tabla;
        }

        public DataTable Listar_Provincia()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Provincia();
            return tabla;
        }

        public void Insertar_Provincia(string codigo, string nombre, string observacion, string estado)
        {
            objdll.Insertar(codigo, nombre, observacion, Convert.ToInt32(estado));
        }

        public void Editar_Provincia(string codigo, string nombre, string observacion, string estado, string id)
        {
            objdll.Editar(codigo, nombre, observacion, Convert.ToInt32(estado), Convert.ToInt32(id));
        }

        public void Eliminar_Provincia(string id)
        {
            objdll.Eliminar(Convert.ToInt32(id));
        }

    }
}
