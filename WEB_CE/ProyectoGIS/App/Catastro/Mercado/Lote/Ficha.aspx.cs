using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;
namespace ProyectoGIS.App.Catastro.Lote
{
    public partial class Ficha : System.Web.UI.Page
    {
        Cls_Lote_BLL objdll = new Cls_Lote_BLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            BindData();
        }
        protected void BindData()
        {
            DataTable dt = objdll.Consultar_Lote();
            MiTabla.DataSource = dt;
            MiTabla.DataBind();
        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            LinkButton btnEliminar = (LinkButton)(sender);
            string lote_id = btnEliminar.CommandArgument;
            objdll.Eliminar_Lote(lote_id);
            DataBind();
            Response.AddHeader("REFRESH", "1;URL=./Ficha.aspx");
        }
    }
}