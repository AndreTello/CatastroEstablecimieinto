using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Establecimiento_BLL
    {
        Cls_Establecimiento_DAL objdll = new Cls_Establecimiento_DAL();

        public DataTable Consultar_Establecimiento()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Consultar();
            return tabla;
        }

        public DataTable Consultar_IdEstablecimiento(string id)
        {
            DataTable tabla = new DataTable();
            tabla = objdll.ConsultarID(Convert.ToInt32(id));
            return tabla;
        }


        public DataTable Listar_Establecimiento()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Establecimiento();
            return tabla;
        }

        public void Insertar_Establecimiento(int lote, int admnistracion, int tipo, int asociacion, int intervencion, string predio, string clave_catastral, string nomenclatura_vial, string calle_principal, string calle_secundaria, string paqueadero, string numero_parqueadero, string dias_apertura, string horario_atencion, string estado)
        {
            objdll.Insertar(lote, admnistracion, tipo, asociacion, intervencion, predio, clave_catastral, nomenclatura_vial, calle_principal, calle_secundaria, paqueadero, Convert.ToInt32(numero_parqueadero), dias_apertura, horario_atencion, Convert.ToInt32(estado));
        }

        public void Editar_Establecimiento(int lote, int admnistracion, int tipo, int asociacion, int intervencion, string predio, string clave_catastral, string nomenclatura_vial, string calle_principal, string calle_secundaria, string paqueadero, string numero_parqueadero, string dias_apertura, string horario_atencion, string estado, string id)
        {
            objdll.Editar(lote, admnistracion, tipo, asociacion, intervencion, predio, clave_catastral, nomenclatura_vial, calle_principal, calle_secundaria, paqueadero, Convert.ToInt32(numero_parqueadero), dias_apertura, horario_atencion, Convert.ToInt32(estado), Convert.ToInt32(id));
        }

        public void Eliminar_Establecimiento(string id)
        {
            objdll.Eliminar(Convert.ToInt32(id));
        }

    }
}
