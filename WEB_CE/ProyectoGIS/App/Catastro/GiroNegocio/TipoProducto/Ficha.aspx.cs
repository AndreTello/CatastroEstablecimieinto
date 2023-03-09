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
    public partial class Ficha : System.Web.UI.Page
    {
        Cls_Tipos_Producto_BLL objdll = new Cls_Tipos_Producto_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            BindData();
        }
        protected void BindData()
        {
            DataTable dt = objdll.Consultar_Tipo_Producto();
            MiTabla.DataSource = dt;
            MiTabla.DataBind();
        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            LinkButton btnEliminar = (LinkButton)(sender);
            string tipo_producto_id = btnEliminar.CommandArgument;
            objdll.Eliminar_Tipo_Producto(tipo_producto_id);
            DataBind();
        }
    }
}