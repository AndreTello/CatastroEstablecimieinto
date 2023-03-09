using BLL_CE.Administracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoGIS.App.Administracion.GestiolPermiso
{
    public partial class Add : System.Web.UI.Page
    {
        Cls_Permiso_BLL permiso = new Cls_Permiso_BLL(); 
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if(PERMISO_NOMBRE.Text == string.Empty || PERMISO_DETALLE.Text == string.Empty || PERMISO_ESTADO.SelectedValue == "")
            {
                Response.Write("<script>alert('Debe llenar todos los campos')</script>");

                return;
            }
            permiso.Insertar_Permiso(PERMISO_NOMBRE.Text, PERMISO_DETALLE.Text, PERMISO_ESTADO.SelectedValue);
            Response.Redirect("./GestionPermiso");
        }
    }
}