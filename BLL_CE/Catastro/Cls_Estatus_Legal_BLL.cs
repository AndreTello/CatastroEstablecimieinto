using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Estatus_Legal_BLL
    {
        Cls_Estatus_Legal_DAL objdll = new Cls_Estatus_Legal_DAL();

        public DataTable Consultar_Estatus_Legal()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Consultar();
            return tabla;
        }

        public DataTable Consultar_IdEstatus_Legal(string id)
        {
            DataTable tabla = new DataTable();
            tabla = objdll.ConsultarID(Convert.ToInt32(id));
            return tabla;
        }


        public DataTable Listar_Estatus_Legal()
        {
            DataTable tabla = new DataTable();
            tabla = objdll.Estatus_Legal();
            return tabla;
        }

        public void Insertar_Estatus_Legal(int puesto, int negocio, string fechao, string historial, string estadoa, string numeropa, string condicionu, string notificacion, string fecharn, string conveniono, string convenion, string conveniof, string condicion, string cambiog, string numerocg, string fechacg, string sanciones, string numerors, string fechars, string estado)
        {
            objdll.Insertar(puesto, negocio, fechao, historial, Convert.ToInt32(estadoa), Convert.ToInt32(numeropa), condicionu, notificacion, fecharn, conveniono, Convert.ToInt32(convenion), conveniof, condicion, Convert.ToInt32(cambiog), numerocg, fechacg, sanciones, numerors, fechars, Convert.ToInt32(estado)); 
        }

        public void Editar_Estatus_Legal(int puesto, int negocio, string fechao, string historial, string estadoa, string numeropa, string condicionu, string notificacion, string fecharn, string conveniono, string convenion, string conveniof, string condicion, string cambiog, string numerocg, string fechacg, string sanciones, string numerors, string fechars, string estado, string id)
        {
            objdll.Editar(puesto, negocio, fechao, historial, Convert.ToInt32(estadoa), Convert.ToInt32(numeropa), condicionu, notificacion, fecharn, conveniono, Convert.ToInt32(convenion), conveniof, condicion, Convert.ToInt32(cambiog), numerocg, fechacg, sanciones, numerors, fechars, Convert.ToInt32(estado), Convert.ToInt32(id));
        }
        public void Eliminar_Estatus_Legal(string id)
        {
            objdll.Eliminar(Convert.ToInt32(id));
        }

    }
}
