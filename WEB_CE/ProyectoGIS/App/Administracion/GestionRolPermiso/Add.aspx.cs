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
    public partial class Add : System.Web.UI.Page
    {
        Cls_Rol_Permiso_BLL rolP = new Cls_Rol_Permiso_BLL();
        Cls_Rol_BLL rol = new Cls_Rol_BLL();
        Cls_Permiso_BLL permiso = new Cls_Permiso_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ROL_ID.DataSource = rol.Consultar_Rol();
                ROL_ID.DataTextField = "ROL_NOMBRE";
                ROL_ID.DataValueField = "ROL_ID";
                ROL_ID.DataBind();
                PERMISO_ID.DataSource = permiso.Consultar_Permiso();
                PERMISO_ID.DataTextField = "PERMISO_NOMBRE";
                PERMISO_ID.DataValueField = "PERMISO_ID";
                PERMISO_ID.DataBind();
                if (Request.QueryString["id"] != null)
                {
                    string id = Request.QueryString["id"];
                    DataTable dt = rolP.Consultar_IdRol_Permiso(id);
                    if(dt != null)
                    { 
                        PERMISO_ROL_ESTADO.SelectedValue = dt.Rows[0]["rol_permiso_estado"].ToString();
                        PERMISO_ID.SelectedValue = dt.Rows[0]["permiso_id"].ToString();
                        ROL_ID.SelectedValue = dt.Rows[0]["rol_permiso_estado"].ToString();
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
            if(PERMISO_ID.SelectedValue == "" || PERMISO_ROL_ESTADO.SelectedValue=="" || ROL_ID.SelectedValue=="")
            {
                Response.Write("<script>alert('Debe llenar todos los campos')</script>");
                return;
            }
            if (Request.QueryString["id"] != null)
            {
                string id = Request.QueryString["id"];
                rolP.Editar_Rol_Permiso(Convert.ToInt32(ROL_ID.SelectedValue), Convert.ToInt32(PERMISO_ID.SelectedValue), PERMISO_ROL_ESTADO.SelectedValue, id);
                Response.Redirect("./GestionRolPermiso");
            }
            else
            {
                rolP.Insertar_Rol_Permiso(Convert.ToInt32(ROL_ID.SelectedValue), Convert.ToInt32(PERMISO_ID.SelectedValue), PERMISO_ROL_ESTADO.SelectedValue);
                Response.Redirect("./GestionRolPermiso");
            }
        }
    }
}