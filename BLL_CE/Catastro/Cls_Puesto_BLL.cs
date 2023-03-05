using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Puesto_BLL
    {
        Cls_Puesto_DAL objdll = new Cls_Puesto_DAL();

        public DataTable Consultar_Puesto()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Consultar();
            return tabla;
        }

        public DataTable Consultar_IdPuesto(string id)
        {
            DataTable tabla = new DataTable();
            tabla = objdll.ConsultarID(Convert.ToInt32(id));
            return tabla;
        }


        public DataTable Listar_Puesto()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Puesto();
            return tabla;
        }

        public void Insertar_Puesto(int piso, int area, int comerciante, int ayudante, int reemplazo, int documento, string predio, string clave_catastral, string estado_conservacion, string acabados, string paredes, string remodelacion, string estado)
        {
            objdll.Insertar(piso, area, comerciante, ayudante, reemplazo, documento, predio, clave_catastral, estado_conservacion, acabados, paredes, remodelacion, Convert.ToInt32(estado));
        }

        public void Editar_Puesto(int piso, int area, int comerciante, int ayudante, int reemplazo, int documento, string predio, string clave_catastral, string estado_conservacion, string acabados, string paredes, string remodelacion, string estado, string id)
        {
            objdll.Editar(piso, area, comerciante, ayudante, reemplazo, documento, predio, clave_catastral, estado_conservacion, acabados, paredes, remodelacion, Convert.ToInt32(estado), Convert.ToInt32(id));
        }

        public void Eliminar_Puesto(string id)
        {
            objdll.Eliminar(Convert.ToInt32(id));
        }

    }
}
