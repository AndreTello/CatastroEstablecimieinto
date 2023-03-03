using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;
namespace ProyectoGIS.App.Catastro.RazonSocioEconomicaDelComerciante.Discapacidad
{
    public partial class Ficha : System.Web.UI.Page
    {
        Cls_Discapacidad_BLL objdll = new Cls_Discapacidad_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            BindData();
        }
        protected void BindData()
        {
            DataTable dt = objdll.Consultar_Discapacidad();
            MiTabla.DataSource = dt;
            MiTabla.DataBind();
        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            LinkButton btnEliminar = (LinkButton)(sender);
            string discapacidad_id = btnEliminar.CommandArgument;
            objdll.Eliminar_Discapacidad(discapacidad_id);
            DataBind();
            Response.AddHeader("REFRESH", "0;URL=./Ficha.aspx");
        }
    }
}