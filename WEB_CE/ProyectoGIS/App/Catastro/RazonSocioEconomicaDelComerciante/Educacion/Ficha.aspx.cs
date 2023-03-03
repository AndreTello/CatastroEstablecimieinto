using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;
namespace ProyectoGIS.App.Catastro.RazonSocioEconomicaDelComerciante.Educacion
{
    public partial class Ficha : System.Web.UI.Page
    {
        Cls_Nivel_Educacion_BLL objdll = new Cls_Nivel_Educacion_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            BindData();

        }
        protected void BindData()
        {
            DataTable dt = objdll.Consultar_Nivel_Educacion();
            MiTabla.DataSource = dt;
            MiTabla.DataBind();
        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            LinkButton btnEliminar = (LinkButton)(sender);
            string nivel_educacion_id = btnEliminar.CommandArgument;
            objdll.Eliminar_Nivel_Educacion(nivel_educacion_id);
            DataBind();
            Response.AddHeader("REFRESH", "0;URL=./Ficha.aspx");
        }
    }
}