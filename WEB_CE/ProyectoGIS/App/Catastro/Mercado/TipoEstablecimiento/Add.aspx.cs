using System;
using System.Collections.Generic;
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
            TIPO_ESTABLECIMIENTO_ESTADO.Items.Insert(0, new ListItem("-- Seleccione un Estado --", ""));
            TIPO_ESTABLECIMIENTO_ESTADO.Items.Insert(1, new ListItem("Activo", "1"));
            TIPO_ESTABLECIMIENTO_ESTADO.Items.Insert(2, new ListItem("Inactivo", "0"));

        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if(TIPO_ESTABLECIMIENTO_NOMBRE.Text == String.Empty || TIPO_ESTABLECIMIENTO_DETALLE.Text == String.Empty || TIPO_ESTABLECIMIENTO_ESTADO.SelectedValue == "" || TIPO_ESTABLECIMIENTO_ESTADO.SelectedValue == "-1")
            {
                Response.Write("<script>alert('Debe llenar todos los campos')</script>");
                return;
            }
            objdll.Insertar_Tipo_Establecimiento(TIPO_ESTABLECIMIENTO_NOMBRE.Text, TIPO_ESTABLECIMIENTO_DETALLE.Text, TIPO_ESTABLECIMIENTO_ESTADO.SelectedValue);
            Response.Redirect("./Ficha.aspx");
        }
    }
}