using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;
namespace ProyectoGIS.App.Catastro.Parroquia
{
    public partial class Add : System.Web.UI.Page
    {
        Cls_Parroquia_BLL objdll = new Cls_Parroquia_BLL();
        Cls_Zona_BLL obj_zon = new Cls_Zona_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ZONA_ID.DataSource = obj_zon.Consultar_Zona();
                ZONA_ID.DataTextField = "ZONA_NOMBRE";
                ZONA_ID.DataValueField = "ZONA_ID";
                ZONA_ID.DataBind();
                ZONA_ID.Items.Insert(0, new ListItem("-- Seleccione una zona --", ""));

                if (Request.QueryString["id"] != null)
                { 
                    string id = Request.QueryString["id"];
                    DataTable dt = objdll.Consultar_IdParroquia(id);
                    if (dt != null)
                    {
                        PARROQUIA_CODIGO.Text = dt.Rows[0]["PARROQUIA_CODIGO"].ToString().Trim();
                        PARROQUIA_NOMBRE.Text = dt.Rows[0]["PARROQUIA_NOMBRE"].ToString().Trim();
                        PARROQUIA_OBSERVACION.Text = dt.Rows[0]["PARROQUIA_OBSERVACION"].ToString();
                        PARROQUIA_ESTADO.SelectedValue = dt.Rows[0]["PARROQUIA_ESTADO"].ToString();
                        ZONA_ID.SelectedValue = dt.Rows[0]["ZONA_NOMBRE"].ToString();
                        btnGuardar.Text = "Actualizar";
                    }
                }
            }
          
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (PARROQUIA_CODIGO.Text == "" || PARROQUIA_NOMBRE.Text == "" || PARROQUIA_ESTADO.SelectedValue == "" || PARROQUIA_ESTADO.SelectedValue == "-1" || ZONA_ID.SelectedValue == "" || ZONA_ID.SelectedValue == "-1")
            {
                Response.Write("<script>alert('Debe llenar todos los campos')</script>");
                return;
            }
            if (Request.QueryString["id"] != null)
            {
                string id = Request.QueryString["id"];
                objdll.Editar_Parroquia(id, Convert.ToInt32(ZONA_ID.SelectedValue), PARROQUIA_CODIGO.Text, PARROQUIA_NOMBRE.Text, PARROQUIA_OBSERVACION.Text, PARROQUIA_ESTADO.SelectedValue);
                Response.Redirect("./Ficha");
            }
            else
            {
                objdll.Insertar_Parroquia(Convert.ToInt32(ZONA_ID.SelectedValue), PARROQUIA_CODIGO.Text, PARROQUIA_NOMBRE.Text, PARROQUIA_OBSERVACION.Text, PARROQUIA_ESTADO.SelectedValue);
                Response.Redirect("./Ficha");
            }
        }
    }
}