using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;
namespace ProyectoGIS.App.Catastro.Comerciante.TipoIdentificacion
{
    public partial class Ficha : System.Web.UI.Page
    {
        Cls_Tipo_Identificacion_BLL objdll = new Cls_Tipo_Identificacion_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            BindData();
        }
        protected void BindData()
        {
            DataTable dt = objdll.Consultar_Tipo_Identificacion();
            MiTabla.DataSource = dt;
            MiTabla.DataBind();
        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            LinkButton btnEliminar = (LinkButton)(sender);
            string tipo_identificacion_id = btnEliminar.CommandArgument;
            objdll.Eliminar_Tipo_Identificacion(tipo_identificacion_id);
            DataBind();
            Response.AddHeader("REFRESH", "0;URL=./Ficha.aspx");

        }
    }
}