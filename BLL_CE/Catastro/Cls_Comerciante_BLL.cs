using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Comerciante_BLL
    {
        Cls_Comerciante_DAL objdll = new Cls_Comerciante_DAL();

        public DataTable Consultar_Comerciante()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Consultar();
            return tabla;
        }

        public DataTable Consultar_IdComerciante (string id)
        {
            DataTable tabla = new DataTable();
            tabla = objdll.ConsultarID(Convert.ToInt32(id));
            return tabla;
        }


        public DataTable Listar_Comerciante()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Comerciante();
            return tabla;
        }

        public void Insertar_Comerciante(int identificacion, int ocupante, string cedula, string apellidos, string nombres, string fecha_n, string edad, string lugar, string telefono, string celular, string direccion, string ciudad, string provincia, string email, string estado)
        {
            objdll.Insertar(identificacion, ocupante, cedula, apellidos, nombres, fecha_n, Convert.ToInt32(edad), lugar, telefono, celular, direccion, ciudad, provincia, email, Convert.ToInt32(estado));
        }

        public void Editar_Comerciante(int identificacion, int ocupante, string cedula, string apellidos, string nombres, string fecha_n, string edad, string lugar, string telefono, string celular, string direccion, string ciudad, string provincia, string email, string estado, string id)
        {
            objdll.Editar(identificacion, ocupante, cedula, apellidos, nombres, fecha_n, Convert.ToInt32(edad), lugar, telefono, celular, direccion, ciudad, provincia, email, Convert.ToInt32(estado), Convert.ToInt32(id));
        }

        public void Eliminar_Comerciante(string id)
        {
            objdll.Eliminar(Convert.ToInt32(id));
        }

    }
}
