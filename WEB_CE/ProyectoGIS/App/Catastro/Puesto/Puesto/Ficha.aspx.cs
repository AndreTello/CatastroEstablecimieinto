using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;
namespace ProyectoGIS.App.Catastro.Puesto.Puesto
{
    public partial class Ficha : System.Web.UI.Page
    {
        Cls_Puesto_BLL objdll = new Cls_Puesto_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            BindData();
        }
        protected void BindData()
        {
            DataTable dt = objdll.Consultar_Puesto();
            MiTabla.DataSource = dt;
            MiTabla.DataBind();
        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            LinkButton btnEliminar = (LinkButton)(sender);
            string puesto_id = btnEliminar.CommandArgument;

            objdll.Eliminar_Puesto(puesto_id);
            DataBind();
        }
    }
}