using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;
namespace ProyectoGIS.App.Catastro.TipoIntervencion
{
    public partial class Add : System.Web.UI.Page
    {
        Cls_Tipo_Intervencion_Tecnica_BLL objdll = new Cls_Tipo_Intervencion_Tecnica_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    string id = Request.QueryString["id"];
                    DataTable dt = objdll.Consultar_IdTipo_Intervencion_Tecnica(id);
                    if (dt != null)
                    {
                        TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_NOMBRE.Text = dt.Rows[0]["TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_NOMBRE"].ToString().Trim();
                        TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_DETALLE.Text = dt.Rows[0]["TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_DETALLE"].ToString().Trim();
                        TIPO_INTERVENCION_TECNICA_ESTADO.SelectedValue = dt.Rows[0]["TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_ESTADO"].ToString();
                        btnGuardar.Text = "Actualizar";
                    }
                }
            }
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_NOMBRE.Text == String.Empty || TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_DETALLE.Text == String.Empty || TIPO_INTERVENCION_TECNICA_ESTADO.SelectedValue == "" || TIPO_INTERVENCION_TECNICA_ESTADO.SelectedValue == "-1")
            {
                Response.Write("<script>alert('Debe llenar todos los campos')</script>");
                return;
            }
            if(Request.QueryString["id"] != null)
            {
                objdll.Editar_Tipo_Intervencion_Tecnica(TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_NOMBRE.Text, TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_DETALLE.Text, TIPO_INTERVENCION_TECNICA_ESTADO.SelectedValue, Request.QueryString["id"]);
                Response.Redirect("./Ficha");
            }
            objdll.Insertar_Tipo_Intervencion_Tecnica(TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_NOMBRE.Text, TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_DETALLE.Text, TIPO_INTERVENCION_TECNICA_ESTADO.SelectedValue);
            Response.Redirect("./Ficha");
        }
    }
}