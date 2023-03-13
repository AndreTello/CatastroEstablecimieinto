using BLL_CE.Administracion;
using System;
using System.Data;

namespace ProyectoGIS.App.Administracion.GestiolPermiso
{
    public partial class Add : System.Web.UI.Page
    {
        Cls_Permiso_BLL permiso = new Cls_Permiso_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    DataTable dt = permiso.Consultar_IdPermiso(Request.QueryString["id"]);
                    if (dt != null)
                    {
                        PERMISO_NOMBRE.Text = dt.Rows[0]["PERMISO_NOMBRE"].ToString().Trim();
                        PERMISO_DETALLE.Text = dt.Rows[0]["PERMISO_DETALLE"].ToString().Trim();
                        PERMISO_ESTADO.SelectedValue = dt.Rows[0]["PERMISO_ESTADO"].ToString();
                        btnGuardar.Text = "Actualizar";
                    }
                    else
                    {
                        btnGuardar.Text = "Guardar";
                    }
                }
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (PERMISO_NOMBRE.Text == string.Empty || PERMISO_DETALLE.Text == string.Empty || PERMISO_ESTADO.SelectedValue == "")
            {
                Response.Write("<script>alert('Debe llenar todos los campos')</script>");

                return;

            }
            if (Request.QueryString["id"] != null)
            {
                permiso.Editar_Permiso(Request.QueryString["id"], PERMISO_NOMBRE.Text, PERMISO_DETALLE.Text, PERMISO_ESTADO.SelectedValue);
                Response.Redirect("./GestionPermiso");
            }
            else
            { 
                permiso.Insertar_Permiso(PERMISO_NOMBRE.Text, PERMISO_DETALLE.Text, PERMISO_ESTADO.SelectedValue);
                Response.Redirect("./GestionPermiso");
            }
        }
    }
}