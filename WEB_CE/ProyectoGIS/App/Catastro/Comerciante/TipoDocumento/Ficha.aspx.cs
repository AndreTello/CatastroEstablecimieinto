using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;
namespace ProyectoGIS.App.Catastro.Comerciante.TipoDocumento
{
    public partial class Ficha : System.Web.UI.Page
    {
        Cls_Tipo_Documento_Comerciante_BLL objddl = new Cls_Tipo_Documento_Comerciante_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            BindData();
        }
        protected void BindData()
        {
            DataTable dt = objddl.Consultar_Tipo_Documento_Comerciante();
            MiTabla.DataSource = dt;
            MiTabla.DataBind();
        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            LinkButton btnEliminar = (LinkButton)(sender);
            string tipo_documento_comerciante_id = btnEliminar.CommandArgument;
            objddl.Eliminar_Tipo_Documento_Comerciante(tipo_documento_comerciante_id);
            DataBind();
            Response.Redirect("./Ficha.aspx");
        }
    }
}