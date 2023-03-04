using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Familiar_BLL
    {
        Cls_Familiar_DAL objdll = new Cls_Familiar_DAL();

        public DataTable Consultar_Familiar()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Consultar();
            return tabla;
        }

        public DataTable Consultar_IdFamiliar(string id)
        {
            DataTable tabla = new DataTable();
            tabla = objdll.ConsultarID(Convert.ToInt32(id));
            return tabla;
        }

        public DataTable Listar_Familiar()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Familiar();
            return tabla;
        }

        public void Insertar_Familiar(int tipo, int comerciante, string cedula, string apellidos, string nombres, string menor, string escolaridad, string estado)
        {
            objdll.Insertar(tipo, comerciante, cedula, apellidos, nombres, menor, escolaridad, Convert.ToInt32(estado));
        }

        public void Editar_Familiar(int tipo, int comerciante, string cedula, string apellidos, string nombres, string menor, string escolaridad, string estado, string id)
        {
            objdll.Editar(tipo, comerciante, cedula, apellidos, nombres, menor, escolaridad, Convert.ToInt32(estado), Convert.ToInt32(id));
        }

        public void Eliminar_Familiar(string id)
        {
            objdll.Eliminar(Convert.ToInt32(id));
        }

    }
}
