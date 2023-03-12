using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;
namespace ProyectoGIS.App.Catastro.Puesto.TipoArea
{
    public partial class Add : System.Web.UI.Page
    {
        Cls_Tipo_Area_BLL objdll = new Cls_Tipo_Area_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    string id = Request.QueryString["id"];
                    DataTable dt = objdll.Consultar_IdTipo_Area(id);
                    if (dt != null)
                    {
                        TIPO_AREA_IDENTIFICACION.Text = dt.Rows[0]["TIPO_AREA_IDENTIFICACION"].ToString().Trim();
                        TIPO_AREA_NOMBRE.Text = dt.Rows[0]["TIPO_AREA_NOMBRE"].ToString().Trim();
                        TIPO_AREA_OBSERVACION.Text = dt.Rows[0]["TIPO_AREA_OBSERVACION"].ToString().Trim();
                        TIPO_AREA_ESTADO.SelectedValue = dt.Rows[0]["TIPO_AREA_ESTADO"].ToString().Trim();
                        btnGuardar.Text = "Actualizar";
                    }
                }
            }

        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (TIPO_AREA_NOMBRE.Text == "" || TIPO_AREA_IDENTIFICACION.Text == "" || TIPO_AREA_ESTADO.SelectedValue == "")
            {
                Response.Write("<script>alert('Debe llenar todos los campos')</script>");
                return;
            }
            if (Request.QueryString["id"] != null)
            {
                objdll.Editar_Tipo_Area(TIPO_AREA_IDENTIFICACION.Text, TIPO_AREA_NOMBRE.Text, TIPO_AREA_OBSERVACION.Text, TIPO_AREA_ESTADO.SelectedValue, Request.QueryString["id"]);
                Response.Redirect("./Ficha.aspx");
            }
            else
            {
                objdll.Insertar_Tipo_Area(TIPO_AREA_IDENTIFICACION.Text,TIPO_AREA_NOMBRE.Text,TIPO_AREA_OBSERVACION.Text , TIPO_AREA_ESTADO.SelectedValue);
                Response.Redirect("./Ficha.aspx");
            }
        }
    }
}