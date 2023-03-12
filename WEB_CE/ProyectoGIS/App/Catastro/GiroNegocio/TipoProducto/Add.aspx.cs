using System;
using System.Collections.Generic;
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
                TIPO_PRODUCTO_ESTADO.Items.Insert(0, new ListItem("-- Seleccione un Estado --", ""));
                TIPO_PRODUCTO_ESTADO.Items.Insert(1, new ListItem("Activo", "1"));
                TIPO_PRODUCTO_ESTADO.Items.Insert(2, new ListItem("Inactivo", "0"));

            }
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if(TIPO_PRODUCTO_ESTADO.SelectedValue =="" || TIPO_PRODUCTO_NOMBRE.Text == string.Empty || TIPO_PRODUCTO_DETALLE.Text == string.Empty ||
                TIPO_PRODUCTO_OBSERVACION.Text == string.Empty)
            {
                Response.Write("<script>alert('Debe llenar todos los campos')</script>");
                return;
            }
            objdll.Insertar_Tipo_Producto(TIPO_PRODUCTO_NOMBRE.Text, TIPO_PRODUCTO_DETALLE.Text, TIPO_PRODUCTO_OBSERVACION.Text, TIPO_PRODUCTO_ESTADO.SelectedValue);
            Response.Redirect("./Ficha");
        }
    }
}