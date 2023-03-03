using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;
namespace ProyectoGIS.App.Catastro.RazonSocioEconomicaDelComerciante.Nacionalidad
{
    public partial class Ficha : System.Web.UI.Page
    {
        Cls_Nacionalidad_BLL objdll = new Cls_Nacionalidad_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            BindData();
        }
        protected void BindData()
        {
            DataTable dt = objdll.Consultar_Nacionalidad();
            MiTabla.DataSource = dt;
            MiTabla.DataBind();
        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            LinkButton btnEliminar = (LinkButton)(sender);
            string nacionalidad_id = btnEliminar.CommandArgument;
            objdll.Eliminar_Nacionalidad(nacionalidad_id);
            DataBind();
            Response.AddHeader("REFRESH", "0;URL=./Ficha.aspx");
        }

    }
}