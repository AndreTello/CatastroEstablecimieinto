using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;
namespace ProyectoGIS.App.Catastro.Parroquia
{
    public partial class Ficha : System.Web.UI.Page
    {
        Cls_Parroquia_BLL objdll = new Cls_Parroquia_BLL();
        Cls_Zona_BLL obj_zon =  new Cls_Zona_BLL();
        protected void Page_Load(object sender, EventArgs e)
        { 
            BindData();
        }
        protected void BindData()
        {
            DataTable dt = objdll.Consultar_Parroquia();
            MiTabla.DataSource = dt;
            MiTabla.DataBind();
        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            LinkButton btnEliminar = (LinkButton)(sender);
            string parroquia_id = btnEliminar.CommandArgument;
            objdll.Eliminar_Parroquia(parroquia_id);
            DataBind();
            Response.AddHeader("REFRESH", "1;URL=./Ficha.aspx");
        }
    }
}