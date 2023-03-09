using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Administracion;
namespace ProyectoGIS.App
{
    public partial class GestionUsuario : System.Web.UI.Page
    {
        Cls_Usuario_BLL objdll = new Cls_Usuario_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            BindData();
        }
        protected void BindData()
        {
            DataTable dt = objdll.Consultar_Usuario();
            MiTabla.DataSource = dt;
            MiTabla.DataBind();
        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            LinkButton btnEliminar = (LinkButton)(sender);
            string usuario_id = btnEliminar.CommandArgument;
            objdll.Eliminar_Usuario(usuario_id);
            DataBind();
        }
    }
}