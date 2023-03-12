using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;  
namespace ProyectoGIS.App.Catastro.Manzana
{
    public partial class Add : System.Web.UI.Page
    {
        Cls_Manzana_BLL objdll = new Cls_Manzana_BLL();
        Cls_Parroquia_BLL obj_par = new Cls_Parroquia_BLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PARROQUIA_ID.DataSource = obj_par.Consultar_Parroquia();
                PARROQUIA_ID.DataTextField = "PARROQUIA_NOMBRE";
                PARROQUIA_ID.DataValueField = "PARROQUIA_ID";
                PARROQUIA_ID.DataBind();
                PARROQUIA_ID.Items.Insert(0, new ListItem("-- Seleccione una parroquia --", ""));

                if (Request.QueryString["id"] != null)
                {
                    string id = Request.QueryString["id"];
                    DataTable dt = objdll.Consultar_IdManzana(id);
                    if (dt != null)
                    {
                        MANZANA_NOMBRE.Text = dt.Rows[0]["MANZANA_NOMBRE"].ToString().Trim();
                        MANZANA_OBSERVACION.Text = dt.Rows[0]["MANZANA_OBSERVACION"].ToString().Trim();
                        MANZANA_CODIGO.Text = dt.Rows[0]["MANZANA_CODIGO"].ToString().Trim();
                        MANZANA_ESTADO.SelectedValue = dt.Rows[0]["MANZANA_ESTADO"].ToString();
                        PARROQUIA_ID.SelectedValue = dt.Rows[0]["PARROQUIA_NOMBRE"].ToString();
                        btnGuardar.Text = "Actualizar";
                    }
                }
            }
            
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if(PARROQUIA_ID.SelectedValue == "" || PARROQUIA_ID.SelectedValue =="-1" || MANZANA_CODIGO.Text == String.Empty|| MANZANA_NOMBRE.Text == String.Empty || MANZANA_ESTADO.SelectedValue == "" || MANZANA_ESTADO.SelectedValue =="-1")
            {
                Response.Write("<script>alert('Debe llenar todos los campos')</script>");
                return;
            }
            if (Request.QueryString["id"] != null)
            {
                string id = Request.QueryString["id"];
                objdll.Editar_Manzana(Convert.ToInt32(PARROQUIA_ID.SelectedValue), MANZANA_CODIGO.Text, MANZANA_NOMBRE.Text, MANZANA_OBSERVACION.Text, MANZANA_ESTADO.SelectedValue, id);
                Response.Redirect("./Ficha");
            }
            else
            {
                objdll.Insertar_Manzana(Convert.ToInt32(PARROQUIA_ID.SelectedValue), MANZANA_CODIGO.Text, MANZANA_NOMBRE.Text, MANZANA_OBSERVACION.Text, MANZANA_ESTADO.SelectedValue);
                Response.Redirect("./Ficha");
            }
        }

    }
}