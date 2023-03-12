using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;
using Org.BouncyCastle.Bcpg.OpenPgp;

namespace ProyectoGIS.App.Catastro.Comerciante.TipoFamiliar
{
    public partial class Add : System.Web.UI.Page
    {
        Cls_Tipo_Familiar_BLL objdll = new Cls_Tipo_Familiar_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    string id = Request.QueryString["id"];
                    DataTable dt = objdll.Consultar_IdTipo_Familiar(id);
                    if (dt != null)
                    {
                        TIPO_FAMILIAR_NOMBRE.Text = dt.Rows[0]["tipo_familiar_nombre"].ToString().Trim();
                        TIPO_FAMILIAR_DETALLE.Text = dt.Rows[0]["tipo_familiar_detalle"].ToString().Trim();
                        TIPO_FAMILIAR_ESTADO.SelectedValue = dt.Rows[0]["tipo_familar_estado"].ToString();
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
            if (TIPO_FAMILIAR_NOMBRE.Text == string.Empty || TIPO_FAMILIAR_DETALLE.Text == string.Empty || string.IsNullOrEmpty(TIPO_FAMILIAR_ESTADO.SelectedValue))
            {
                Response.Write("<script>alert('Debe llenar todos los campos')</script>");
                return;
            }
            if (Request.QueryString["id"] != null)
            {
                string id = Request.QueryString["id"];
                objdll.Editar_Tipo_Familiar(TIPO_FAMILIAR_NOMBRE.Text, TIPO_FAMILIAR_DETALLE.Text, TIPO_FAMILIAR_ESTADO.SelectedValue, id);
                Response.Redirect("./Ficha");
            }
            else
            {
                objdll.Insertar_Tipo_Familiar(TIPO_FAMILIAR_NOMBRE.Text, TIPO_FAMILIAR_DETALLE.Text, TIPO_FAMILIAR_ESTADO.SelectedValue);
                Response.Redirect("./Ficha");
            }
        }
    }
}