using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Administracion;
namespace ProyectoGIS.App.Administracion.GestionRolPermiso
{
    public partial class GestionRolPermiso : System.Web.UI.Page
    {
        Cls_Rol_Permiso_BLL rol = new Cls_Rol_Permiso_BLL();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            BindData();
        }
        protected void BindData()
        {
            DataTable dt = rol.Consultar_Rol_Permiso();
            MiTabla.DataSource = dt;
            MiTabla.DataBind();
        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            LinkButton btnEliminar = (LinkButton)(sender);
            string rol_id = btnEliminar.CommandArgument;
            rol.Eliminar_Rol_Permiso(rol_id);
            DataBind();
            Response.Redirect("./GestionRolPermiso");
        }
    }
}