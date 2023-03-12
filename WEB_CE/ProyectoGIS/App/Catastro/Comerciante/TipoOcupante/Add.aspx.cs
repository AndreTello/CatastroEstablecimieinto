using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;
namespace ProyectoGIS.App.Catastro.Comerciante.TipoOcupante
{
    public partial class Add : System.Web.UI.Page
    {
        Cls_Tipo_Ocupante_BLL objdll = new Cls_Tipo_Ocupante_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id =Request.QueryString["id"];
                if(id != null)
                {
                    DataTable dt = objdll.Consultar_IdTipo_Ocupante(id);
                    if(dt != null)
                    {
                        TIPO_OCUPANTE_NOMBRE.Text = dt.Rows[0]["TIPO_OCUPANTE_NOMBRE"].ToString().Trim();
                        TIPO_OCUPANTE_DETALLE.Text = dt.Rows[0]["TIPO_OCUPANTE_DETALLE"].ToString().Trim();
                        TIPO_OCUPANTE_ESTADO.Text = dt.Rows[0]["TIPO_OCUPANTE_ESTADO"].ToString();
                        btnGuardar.Text = "Actualizar";
                    }
                }
            }

        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validación del campo TIPO_OCUPANTE_ESTADO
            if (TIPO_OCUPANTE_ESTADO.SelectedValue == "-1" || TIPO_OCUPANTE_ESTADO.SelectedValue == "" || TIPO_OCUPANTE_NOMBRE.Text == string.Empty ||
                               TIPO_OCUPANTE_DETALLE.Text == string.Empty)
            {
                Response.Write("<script>alert('Debe llenar todos los campos')</script>");
                return;
            }
            if (Request.QueryString["id"] != null)
            {
                string id = Request.QueryString["id"];
                objdll.Editar_Tipo_Ocupante(TIPO_OCUPANTE_NOMBRE.Text, TIPO_OCUPANTE_DETALLE.Text, TIPO_OCUPANTE_ESTADO.SelectedValue, id);
                Response.Redirect("./Ficha");
            }
            else
            {
                objdll.Insertar_Tipo_Ocupante(TIPO_OCUPANTE_NOMBRE.Text, TIPO_OCUPANTE_DETALLE.Text, TIPO_OCUPANTE_ESTADO.SelectedValue);
                Response.Redirect("./Ficha");

            }

        }
    }
}