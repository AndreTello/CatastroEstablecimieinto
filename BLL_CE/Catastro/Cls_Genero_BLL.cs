using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Genero_BLL
    {
        Cls_Genero_DAL objdll = new Cls_Genero_DAL();

        public DataTable Consultar_Genero()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Consultar();
            return tabla;
        }

        public DataTable Consultar_IdGenero(string id)
        {
            DataTable tabla = new DataTable();
            tabla = objdll.ConsultarID(Convert.ToInt32(id));
            return tabla;
        }

        public DataTable Listar_Genero()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Genero();
            return tabla;
        }

        public void Insertar_Genero(string nombre, string detalle, string estado)
        {
            objdll.Insertar(nombre, detalle, Convert.ToInt32(estado));
        }

        public void Editar_Genero(string nombre, string detalle, string estado, string id)
        {
            objdll.Editar(nombre, detalle, Convert.ToInt32(estado), Convert.ToInt32(id));
        }

        public void Eliminar_Genero(string id)
        {
            objdll.Eliminar(Convert.ToInt32(id));
        }

    }
}
