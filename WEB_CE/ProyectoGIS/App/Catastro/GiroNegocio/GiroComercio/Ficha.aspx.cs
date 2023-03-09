using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;
namespace ProyectoGIS.App.Catastro.GiroNegocio.GiroComercio
{
    public partial class Ficha : System.Web.UI.Page
    {
        Cls_Giro_Negocio_BLL objdll = new Cls_Giro_Negocio_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            BindData();
        }
        protected void BindData()
        {
            DataTable dt = objdll.Consultar_Giro_Negocio();
            MiTabla.DataSource = dt;
            MiTabla.DataBind();
        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            LinkButton btnEliminar = (LinkButton)(sender);
            string giro_negocio_id = btnEliminar.CommandArgument;
            objdll.Eliminar_Giro_Negocio(giro_negocio_id);
            DataBind();
        }
    }
}