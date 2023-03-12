using BLL_CE.Administracion;
using System;
using System.Data;
namespace ProyectoGIS.App.Administracion.GestionRol
{
    public partial class Add : System.Web.UI.Page
    {
        Cls_Rol_BLL rol = new Cls_Rol_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                if (Request.QueryString["id"] != null)
                {
                    string id = Request.QueryString["id"];
                    DataTable dt = rol.Consultar_IdRol(id);
                    if (dt != null)
                    {
                        ROL_NOMBRE.Text = dt.Rows[0]["ROL_NOMBRE"].ToString().Trim();
                        ROL_DETALLE.Text = dt.Rows[0]["ROL_DETALLE"].ToString().Trim();
                        ROL_ESTADO.SelectedValue = dt.Rows[0]["ROL_ESTADO"].ToString();
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
            if (ROL_NOMBRE.Text == string.Empty || ROL_DETALLE.Text == string.Empty || ROL_ESTADO.SelectedValue == "")
            {
                Response.Write("<script>alert('Debe llenar todos los campos')</script>");

                return;
            }
            if (Request.QueryString["id"] != null)
            {
                string id = Request.QueryString["id"];
                rol.Editar_Rol(ROL_NOMBRE.Text, ROL_DETALLE.Text, ROL_ESTADO.SelectedValue, id);
                Response.Redirect("./GestionRoles");
            }
            else
            {
                rol.Insertar_Rol(ROL_NOMBRE.Text, ROL_DETALLE.Text, ROL_ESTADO.SelectedValue);
                Response.Redirect("./GestionRoles");
            }
        }
    }
}