using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;
namespace ProyectoGIS.App.Catastro.Canton
{
    public partial class Add : System.Web.UI.Page
    {
        Cls_Provincia_BLL obj_pro = new Cls_Provincia_BLL();
        Cls_Canton_BLL objdll = new Cls_Canton_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PROVINCIA_ID.DataSource = obj_pro.Consultar_Provincia();
                PROVINCIA_ID.DataTextField = "PROVINCIA_NOMBRE";
                PROVINCIA_ID.DataValueField = "PROVINCIA_ID";
                PROVINCIA_ID.DataBind();
                PROVINCIA_ID.Items.Insert(0, new ListItem("-- Seleccione una provincia --", ""));

                if (Request.QueryString["id"] != null)
                {
                    string id = Request.QueryString["id"];
                    DataTable dt = objdll.Consultar_IdCanton(id);
                    if(dt != null)
                    {
                        CANTON_NOMBRE.Text = dt.Rows[0]["CANTON_NOMBRE"].ToString().Trim();
                        PROVINCIA_ID.SelectedValue = dt.Rows[0]["PROVINCIA_NOMBRE"].ToString();
                        CANTON_OBSERVACION.Text = dt.Rows[0]["CANTON_OBSERVACION"].ToString().Trim();
                        CANTON_CODIGO.Text = dt.Rows[0]["CANTON_CODIGO"].ToString().Trim();
                        CANTON_ESTADO.SelectedValue = dt.Rows[0]["CANTON_ESTADO"].ToString();
                        btnGuardar.Text = "Actualizar";

                    }
                }
            }
            


        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            
           
            if (PROVINCIA_ID.SelectedValue == "-1" || PROVINCIA_ID.SelectedValue == "" || string.IsNullOrEmpty(CANTON_CODIGO.Text) ||
                string.IsNullOrEmpty(CANTON_NOMBRE.Text) || CANTON_ESTADO.SelectedValue == "-1" || CANTON_ESTADO.SelectedValue == "")
            {
                Response.Write("<script>alert('Debe llenar todos los campos')</script>");
                return;
            }

            if (Request.QueryString["id"] != null)
            {
                objdll.Editar_Canton(Request.QueryString["id"],Convert.ToInt32(PROVINCIA_ID.SelectedValue), CANTON_CODIGO.Text, CANTON_NOMBRE.Text, CANTON_OBSERVACION.Text, CANTON_ESTADO.SelectedValue);
                Response.Redirect("./Ficha");
            }
            else
            {
                objdll.Insertar_Canton(Convert.ToInt32(PROVINCIA_ID.SelectedValue), CANTON_CODIGO.Text, CANTON_NOMBRE.Text, CANTON_OBSERVACION.Text, CANTON_ESTADO.SelectedValue);
                Response.Redirect("./Ficha");

            }
         
            
        }



    }
}