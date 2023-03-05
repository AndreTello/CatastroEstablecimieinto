using System;
using System.Collections.Generic;
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
            TIPO_AREA_ESTADO.Items.Insert(0, new ListItem("-- Seleccione un Estado --", ""));
            TIPO_AREA_ESTADO.Items.Insert(1, new ListItem("Activo", "1"));
            TIPO_AREA_ESTADO.Items.Insert(2, new ListItem("Inactivo", "0"));

        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (TIPO_AREA_NOMBRE.Text == "" || TIPO_AREA_IDENTIFICACION.Text == "" || TIPO_AREA_ESTADO.SelectedValue == "")
            {
                Response.Write("<script>alert('Debe llenar todos los campos')</script>");
                return;
            }
            objdll.Insertar_Tipo_Area(TIPO_AREA_IDENTIFICACION.Text,TIPO_AREA_NOMBRE.Text,TIPO_AREA_OBSERVACION.Text , TIPO_AREA_ESTADO.SelectedValue);
            Response.Redirect("./Ficha.aspx");
        }
    }
}