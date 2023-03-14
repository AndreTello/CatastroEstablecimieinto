using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;
namespace ProyectoGIS.App.Catastro.Asociacion
{
    public partial class Add : System.Web.UI.Page
    {
        Cls_Asociacion_BLL objdll = new Cls_Asociacion_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    string id = Request.QueryString["id"];
                    DataTable dt = objdll.Consultar_IdAsociacion(id);
                    if (dt != null)
                    {
                        ASOCIACION_CODIGO.Text = dt.Rows[0]["ASOCIACION_CODIGO"].ToString();
                        ASOCIACION_NOMBRE.Text = dt.Rows[0]["ASOCIACION_NOMBRE"].ToString();
                        ASOCIACION_TELEFONO.Text = dt.Rows[0]["ASOCIACION_TELEFONO"].ToString();
                        ASOCIACION_MAIL.Text = dt.Rows[0]["ASOCIACION_MAIL"].ToString();
                        ASOCIACION_CONTACTO.Text = dt.Rows[0]["ASOCIACION_CONTACTO"].ToString();
                        ASOCIACION_OBSERVACION.Text = dt.Rows[0]["ASOCIACION_OBSERVACION"].ToString();
                        ASOCIACION_ESTADO.SelectedValue = dt.Rows[0]["ASOCIACION_ESTADO"].ToString();
                        btnGuardar.Text = "Actualizar";
                    }
                }
            }
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if(ASOCIACION_CODIGO.Text == String.Empty || ASOCIACION_NOMBRE.Text == String.Empty || ASOCIACION_TELEFONO.Text == String.Empty || 
                ASOCIACION_MAIL.Text == String.Empty || ASOCIACION_CONTACTO.Text == String.Empty  || 
                ASOCIACION_ESTADO.SelectedValue == "" || ASOCIACION_ESTADO.SelectedValue == "-1")
            {
                Response.Write("<script>alert('Debe llenar todos los campos')</script>");
                return;
            }
            if (Request.QueryString["id"] != null)
            {
                objdll.Editar_Asociacion(Request.QueryString["id"], ASOCIACION_CODIGO.Text, ASOCIACION_NOMBRE.Text, ASOCIACION_TELEFONO.Text, ASOCIACION_MAIL.Text, ASOCIACION_CONTACTO.Text, ASOCIACION_OBSERVACION.Text, ASOCIACION_ESTADO.SelectedValue);
                Response.Redirect("./Ficha");

            }
            else
            {
                objdll.Insertar_Asociacion(ASOCIACION_CODIGO.Text, ASOCIACION_NOMBRE.Text, ASOCIACION_TELEFONO.Text, ASOCIACION_MAIL.Text, ASOCIACION_CONTACTO.Text, ASOCIACION_OBSERVACION.Text, ASOCIACION_ESTADO.SelectedValue );
                Response.Redirect("./Ficha");
            }
        }
    }
}