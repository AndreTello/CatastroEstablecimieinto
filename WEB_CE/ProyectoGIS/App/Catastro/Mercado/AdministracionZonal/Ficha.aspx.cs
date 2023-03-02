using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;
namespace ProyectoGIS.App.Catastro
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Cls_Administracion_Zonal_BLL objdll = new Cls_Administracion_Zonal_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
             BindData();

        }
        protected void BindData()
        {
            DataTable dt = objdll.Consultar_Administracion_Zonal();
            MiTabla.DataSource = dt;
            MiTabla.DataBind();
        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            LinkButton btnEliminar = (LinkButton)(sender);
            string administracion_zonal_id = btnEliminar.CommandArgument;
            objdll.Eliminar_Administracion_Zonal(administracion_zonal_id);
            DataBind();
            Response.AddHeader("REFRESH", "1;URL=./Ficha.aspx");
        }
    }
}