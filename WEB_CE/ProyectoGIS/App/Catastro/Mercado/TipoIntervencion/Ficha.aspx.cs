using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;
namespace ProyectoGIS.App.Catastro.TipoIntervencion
{
    public partial class Ficha : System.Web.UI.Page
    {
        Cls_Tipo_Intervencion_Tecnica_BLL objdll = new Cls_Tipo_Intervencion_Tecnica_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            BindData();
        }
        protected void BindData() {             
            DataTable dt = objdll.Consultar_Tipo_Intervencion_Tecnica();
            MiTabla.DataSource = dt;
            MiTabla.DataBind();
        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            LinkButton btnEliminar = (LinkButton)(sender);
            string tipo_intervencion_tecnica_id = btnEliminar.CommandArgument;
            objdll.Eliminar_Tipo_Intervencion_Tecnica(tipo_intervencion_tecnica_id);
            DataBind();
            Response.AddHeader("REFRESH", "1;URL=./Ficha.aspx");
        }

    }
}