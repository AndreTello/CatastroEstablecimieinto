using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;
namespace ProyectoGIS.App.Catastro.GiroNegocio.TipoProducto
{
    public partial class Add : System.Web.UI.Page
    {
        Cls_Tipos_Producto_BLL objdll = new Cls_Tipos_Producto_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id = Request.QueryString["id"];
                if (id != null)
                {
                    DataTable dt = objdll.Consultar_IdTipo_Producto(id);
                    if(dt != null)
                    {
                        TIPO_PRODUCTO_NOMBRE.Text = dt.Rows[0]["TIPO_PRODUCTO_NOMBRE"].ToString().Trim();
                        TIPO_PRODUCTO_DETALLE.Text = dt.Rows[0]["TIPO_PRODUCTO_DETALLE"].ToString().Trim();
                        TIPO_PRODUCTO_OBSERVACION.Text = dt.Rows[0]["TIPO_PRODUCTO_OBSERVACION"].ToString().Trim();
                        TIPO_PRODUCTO_ESTADO.Text = dt.Rows[0]["TIPO_PRODUCTO_ESTADO"].ToString().Trim();
                        btnGuardar.Text = "Actualizar";
                    }
                }
            }
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if(TIPO_PRODUCTO_ESTADO.SelectedValue =="" || TIPO_PRODUCTO_NOMBRE.Text == string.Empty || TIPO_PRODUCTO_DETALLE.Text == string.Empty )
            {
                Response.Write("<script>alert('Debe llenar todos los campos')</script>");
                return;
            }
            if (Request.QueryString["id"] != null)
            {
                objdll.Editar_Tipo_Producto(TIPO_PRODUCTO_NOMBRE.Text, TIPO_PRODUCTO_DETALLE.Text, TIPO_PRODUCTO_OBSERVACION.Text, TIPO_PRODUCTO_ESTADO.SelectedValue, Request.QueryString["id"]);
                Response.Redirect("./Ficha");
            }
            objdll.Insertar_Tipo_Producto(TIPO_PRODUCTO_NOMBRE.Text, TIPO_PRODUCTO_DETALLE.Text, TIPO_PRODUCTO_OBSERVACION.Text, TIPO_PRODUCTO_ESTADO.SelectedValue);
            Response.Redirect("./Ficha");
        }
    }
}