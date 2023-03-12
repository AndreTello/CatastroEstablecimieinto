using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;
namespace ProyectoGIS.App.Catastro.AdministracionZonal
{
    public partial class Add : System.Web.UI.Page
    {
        Cls_Administracion_Zonal_BLL objdll = new Cls_Administracion_Zonal_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {


                if (Request.QueryString["id"] != null)
                {
                    string id = Request.QueryString["id"];
                    DataTable dt = objdll.Consultar_IdAdministracion_Zonal(id);
                    if (dt != null)
                    {
                        ADMINISTRACION_ZONAL_CELULAR.Text = dt.Rows[0]["ADMINISTRACION_ZONAL_CELULAR"].ToString().Trim();
                        ADMINISTRACION_ZONAL_DETALLE.Text = dt.Rows[0]["ADMINISTRACION_ZONAL_DETALLE"].ToString().Trim();
                        ADMINISTRACION_ZONAL_MAIL.Text = dt.Rows[0]["ADMINISTRACION_ZONAL_MAIL"].ToString().Trim();
                        ADMINISTRACION_ZONAL_NOMBRE.Text = dt.Rows[0]["ADMINISTRACION_ZONAL_NOMBRE"].ToString().Trim();
                        ADMINISTRACION_ZONAL_PAGINA_WEB.Text = dt.Rows[0]["ADMINISTRACION_ZONAL_PAGINA_WEB"].ToString().Trim();
                        ADMINISTRACION_ZONAL_REPRESENTANTE.Text = dt.Rows[0]["ADMINISTRACION_ZONAL_REPRESENTANTE"].ToString().Trim();
                        ADMINISTRACION_ZONAL_TELEFONO.Text = dt.Rows[0]["ADMINISTRACION_ZONAL_TELEFONO"].ToString().Trim();
                        ADMINISTRACION_ZONAL_ESTADO.SelectedValue = dt.Rows[0]["ADMINISTRACION_ZONAL_ESTADO"].ToString().Trim();
                        btnGuardar.Text = "Actualizar";
                    }
                }
            }
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if(ADMINISTRACION_ZONAL_NOMBRE.Text == String.Empty || ADMINISTRACION_ZONAL_DETALLE.Text == String.Empty || 
                ADMINISTRACION_ZONAL_TELEFONO.Text == String.Empty || ADMINISTRACION_ZONAL_CELULAR.Text == String.Empty || 
                ADMINISTRACION_ZONAL_MAIL.Text == String.Empty || ADMINISTRACION_ZONAL_PAGINA_WEB.Text == String.Empty || 
                ADMINISTRACION_ZONAL_REPRESENTANTE.Text == String.Empty || ADMINISTRACION_ZONAL_ESTADO.SelectedValue == "" || 
                ADMINISTRACION_ZONAL_ESTADO.SelectedValue == "-1")
            {
                Response.Write("<script>alert('Debe llenar todos los campos')</script>");
                return;
            }
            if (Request.QueryString["id"] != null)
            {
                string id = Request.QueryString["id"];
                objdll.Editar_Administracion_Zonal(ADMINISTRACION_ZONAL_NOMBRE.Text, ADMINISTRACION_ZONAL_DETALLE.Text, ADMINISTRACION_ZONAL_TELEFONO.Text, ADMINISTRACION_ZONAL_CELULAR.Text, ADMINISTRACION_ZONAL_MAIL.Text, ADMINISTRACION_ZONAL_PAGINA_WEB.Text, ADMINISTRACION_ZONAL_REPRESENTANTE.Text, ADMINISTRACION_ZONAL_ESTADO.SelectedValue,id);
                Response.Redirect("./Ficha");

            }
            else
            {
                objdll.Insertar_Administracion_Zonal(ADMINISTRACION_ZONAL_NOMBRE.Text, ADMINISTRACION_ZONAL_DETALLE.Text, ADMINISTRACION_ZONAL_TELEFONO.Text, ADMINISTRACION_ZONAL_CELULAR.Text, ADMINISTRACION_ZONAL_MAIL.Text, ADMINISTRACION_ZONAL_PAGINA_WEB.Text, ADMINISTRACION_ZONAL_REPRESENTANTE.Text, ADMINISTRACION_ZONAL_ESTADO.SelectedValue);
                Response.Redirect("./Ficha");
            }
        }
    }
}