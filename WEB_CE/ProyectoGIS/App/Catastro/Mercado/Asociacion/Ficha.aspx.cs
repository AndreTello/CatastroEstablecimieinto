using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;
namespace ProyectoGIS.App.Catastro.Asociacion
{
    public partial class Ficha : System.Web.UI.Page
    {
        Cls_Asociacion_BLL  objdll = new Cls_Asociacion_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            BindData();
        }
        protected void BindData()
        {
            MiTabla.DataSource = objdll.Consultar_Asociacion();
            MiTabla.DataBind();
        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            LinkButton btnEliminar = (LinkButton)(sender);
            string administracion_zonal_id = btnEliminar.CommandArgument;

            objdll.Eliminar_Asociacion(administracion_zonal_id);
            DataBind();
        }
    }
}