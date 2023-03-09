using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;
namespace ProyectoGIS.App.Catastro.EstatusLegal.EstatusLegal
{
    public partial class Ficha : System.Web.UI.Page
    {
        Cls_Estatus_Legal_BLL objdll = new Cls_Estatus_Legal_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            BindData();
        }
        protected void BindData()
        {
            DataTable dt = objdll.Consultar_Estatus_Legal();
            MiTabla.DataSource = dt;
            MiTabla.DataBind();
        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            LinkButton btnEliminar = (LinkButton)(sender);
            string estatus_legal_id = btnEliminar.CommandArgument;
            objdll.Eliminar_Estatus_Legal(estatus_legal_id);
            DataBind();
        }
    }
}