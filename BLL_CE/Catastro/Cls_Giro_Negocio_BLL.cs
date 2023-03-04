using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Giro_Negocio_BLL
    {
        Cls_Giro_Negocio_DAL objdll = new Cls_Giro_Negocio_DAL();

        public DataTable Consultar_Giro_Negocio()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Consultar();
            return tabla;
        }

        public DataTable Consultar_IdGiro_Negocio(string id)
        {
            DataTable tabla = new DataTable();
            tabla = objdll.ConsultarID(Convert.ToInt32(id));
            return tabla;
        }

        public DataTable Listar_Giro_Negocio()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Giro_Negocio();
            return tabla;
        }

        public void Insertar_Giro_Negocio(int producto, string nombre, string subgiro, string abastecimiento, string observacion, string estado)
        {
            objdll.Insertar(producto, nombre, subgiro, abastecimiento, observacion, Convert.ToInt32(estado));
        }

        public void Editar_Giro_Negocio(int producto, string nombre, string subgiro, string abastecimiento, string observacion, string estado, string id)
        {
            objdll.Editar(producto, nombre, subgiro, abastecimiento, observacion, Convert.ToInt32(estado), Convert.ToInt32(id));
        }

        public void Eliminar_Giro_Negocio(string id)
        {
            objdll.Eliminar(Convert.ToInt32(id));
        }

    }
}
