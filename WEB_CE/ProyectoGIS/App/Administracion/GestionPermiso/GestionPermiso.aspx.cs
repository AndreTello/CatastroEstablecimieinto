using System;

using System.Data;

using System.Web.UI.WebControls;
using BLL_CE.Administracion;
namespace ProyectoGIS.App.Administracion.GestiolPermiso
{
    public partial class GestionPermiso : System.Web.UI.Page
    {
        Cls_Permiso_BLL objdll = new Cls_Permiso_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            BindData();
        }
        protected void BindData()
        {
            DataTable dt = objdll.Consultar_Permiso();
            MiTabla.DataSource = dt;
            MiTabla.DataBind();
        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            LinkButton btnEliminar = (LinkButton)(sender);
            string permiso_id = btnEliminar.CommandArgument;
            objdll.Eliminar_Permiso(permiso_id);
            DataBind();
        }
    }
}