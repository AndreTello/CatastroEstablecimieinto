using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;
namespace ProyectoGIS.App.Catastro.TipoEstablecimiento
{
    public partial class Add : System.Web.UI.Page
    {
        Cls_Tipo_Establecimiento_BLL objdll = new Cls_Tipo_Establecimiento_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    string id = Request.QueryString["id"];
                    DataTable dt = objdll.Consultar_IdTipo_Establecimiento(id);
                    TIPO_ESTABLECIMIENTO_NOMBRE.Text =dt.Rows[0]["TIPO_ESTABLECIMIENTO_NOMBRE"].ToString().Trim();
                    TIPO_ESTABLECIMIENTO_DETALLE.Text = dt.Rows[0]["TIPO_ESTABLECIMIENTO_DETALLE"].ToString().Trim();
                    TIPO_ESTABLECIMIENTO_ESTADO.SelectedValue = dt.Rows[0]["TIPO_ESTABLECIMIENTO_ESTADO"].ToString();
                    btnGuardar.Text = "Actualizar";
                }
            }
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if(TIPO_ESTABLECIMIENTO_NOMBRE.Text == String.Empty || TIPO_ESTABLECIMIENTO_DETALLE.Text == String.Empty || TIPO_ESTABLECIMIENTO_ESTADO.SelectedValue == "" || TIPO_ESTABLECIMIENTO_ESTADO.SelectedValue == "-1")
            {
                Response.Write("<script>alert('Debe llenar todos los campos')</script>");
                return;
            }
            if (Request.QueryString["id"] != null)
            {
                string id = Request.QueryString["id"];
                objdll.Editar_Tipo_Establecimiento(TIPO_ESTABLECIMIENTO_NOMBRE.Text, TIPO_ESTABLECIMIENTO_DETALLE.Text, TIPO_ESTABLECIMIENTO_ESTADO.SelectedValue,id);
                Response.Redirect("./Ficha.aspx");
            }
            else
            {
                objdll.Insertar_Tipo_Establecimiento(TIPO_ESTABLECIMIENTO_NOMBRE.Text, TIPO_ESTABLECIMIENTO_DETALLE.Text, TIPO_ESTABLECIMIENTO_ESTADO.SelectedValue);
                Response.Redirect("./Ficha.aspx");
            }
        }
    }
}