using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Administracion;
namespace ProyectoGIS.App.Administracion.GestionRol
{
    public partial class Add : System.Web.UI.Page
    {
        Cls_Rol_BLL rol = new Cls_Rol_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ROL_NOMBRE.Text == string.Empty || ROL_DETALLE.Text == string.Empty || ROL_ESTADO.SelectedValue == "")
            {
                Response.Write("<script>alert('Debe llenar todos los campos')</script>");

                return;
            }
            rol.Insertar_Rol(ROL_NOMBRE.Text, ROL_DETALLE.Text, ROL_ESTADO.SelectedValue);
            Response.Redirect("./GestionRol");
        }
    }
}