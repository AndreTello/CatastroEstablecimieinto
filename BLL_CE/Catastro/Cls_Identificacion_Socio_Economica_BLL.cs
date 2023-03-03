using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Identificacion_Socio_Economica_BLL
    {
        Cls_Identificacion_Socio_Economica_DAL objdll = new Cls_Identificacion_Socio_Economica_DAL();

        public DataTable Consultar_Identificacion_Socio_Economica()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Consultar();
            return tabla;
        }

        public DataTable Consultar_IdIdentificacion_Socio_Economica(string id)
        {
            DataTable tabla = new DataTable();
            tabla = objdll.ConsultarID(Convert.ToInt32(id));
            return tabla;
        }

        public DataTable Listar_Identificacion_Socio_Economica()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Identificacion_Socio_Economica();
            return tabla;
        }

        public void Insertar_Identificacion_Socio_Economica(int comerciante, int etnia, int genero, int estado_civil, int nacionalidad, int nivel_educación, int discapacidad, string jefe_familia, string dependientes, string n_dependientes, string parentezco, string estado)
        {
            objdll.Insertar(comerciante, etnia, genero, estado_civil, nacionalidad, nivel_educación, discapacidad, jefe_familia, dependientes, Convert.ToInt32(n_dependientes), parentezco, Convert.ToInt32(estado));
        }

        public void Editar_Identificacion_Socio_Economica(int comerciante, int etnia, int genero, int estado_civil, int nacionalidad, int nivel_educación, int discapacidad, string jefe_familia, string dependientes, string n_dependientes, string parentezco, string estado, string id)
        {
            objdll.Editar(comerciante, etnia, genero, estado_civil, nacionalidad, nivel_educación, discapacidad, jefe_familia, dependientes, Convert.ToInt32(n_dependientes), parentezco, Convert.ToInt32(estado), Convert.ToInt32(id));
        }

        public void Eliminar_Identificacion_Socio_Economica(string id)
        {
            objdll.Eliminar(Convert.ToInt32(id));
        }

    }
}
