using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;
namespace ProyectoGIS.App.Catastro.Zona
{
    public partial class Add : System.Web.UI.Page
    {
        Cls_Zona_BLL objdll = new Cls_Zona_BLL();
        Cls_Canton_BLL obj_can = new Cls_Canton_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CANTON_ID.DataSource = obj_can.Consultar_Canton();
                CANTON_ID.DataTextField = "CANTON_NOMBRE";
                CANTON_ID.DataValueField = "CANTON_ID";
                CANTON_ID.DataBind();
                CANTON_ID.Items.Insert(0, new ListItem("-- Seleccione un canton --", ""));
                if (Request.QueryString["id"] != null)
                {
                    string id = Request.QueryString["id"];
                    DataTable dt = objdll.Consultar_IdZona(id);
                    if (dt != null)
                    {
                        ZONA_NOMBRE.Text = dt.Rows[0]["ZONA_NOMBRE"].ToString().Trim();
                        ZONA_CODIGO.Text = dt.Rows[0]["ZONA_CODIGO"].ToString().Trim();
                        ZONA_OBSERVACION.Text = dt.Rows[0]["ZONA_OBSERVACION"].ToString().Trim();
                        ZONA_ESTADO.SelectedValue = dt.Rows[0]["ZONA_ESTADO"].ToString();
                        CANTON_ID.SelectedValue = dt.Rows[0]["CANTON_NOMBRE"].ToString();
                        btnGuardar.Text = "Actualizar";
                    }
                }
            }

        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ZONA_CODIGO.Text == "" || ZONA_NOMBRE.Text == "" || ZONA_ESTADO.SelectedValue == "" || ZONA_ESTADO.SelectedValue == "-1" || CANTON_ID.SelectedValue =="" || CANTON_ID.SelectedValue == "-1")
            {
                Response.Write("<script>alert('Debe llenar todos los campos')</script>");
                return;
            }
            if (Request.QueryString["id"] !=null)
            {
                objdll.Editar_Zona(Convert.ToInt32(CANTON_ID.SelectedValue), ZONA_CODIGO.Text, ZONA_NOMBRE.Text, ZONA_OBSERVACION.Text, ZONA_ESTADO.SelectedValue, Request.QueryString["id"]);
                Response.Redirect("./Ficha");
            }
            objdll.Insertar_Zona(Convert.ToInt32(CANTON_ID.SelectedValue), ZONA_CODIGO.Text, ZONA_NOMBRE.Text, ZONA_OBSERVACION.Text, ZONA_ESTADO.SelectedValue);
            Response.Redirect("./Ficha");
        }
    }

}