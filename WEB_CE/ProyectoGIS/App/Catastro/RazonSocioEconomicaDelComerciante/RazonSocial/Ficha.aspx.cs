using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;
namespace ProyectoGIS.App.Catastro.RazonSocioEconomicaDelComerciante.RazonSocial
{
    public partial class Ficha : System.Web.UI.Page
    {
        Cls_Identificacion_Socio_Economica_BLL objdll = new Cls_Identificacion_Socio_Economica_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            BindData();
        }
        protected void BindData()
        {
            DataTable dt = objdll.Consultar_Identificacion_Socio_Economica();
            MiTabla.DataSource = dt;
            MiTabla.DataBind();
        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            LinkButton btnEliminar = (LinkButton)(sender);
            string identificacion_socio_economica_id = btnEliminar.CommandArgument;
            objdll.Eliminar_Identificacion_Socio_Economica(identificacion_socio_economica_id);
            DataBind();
            Response.AddHeader("REFRESH", "0;URL=./Ficha.aspx");
        }
    }
}