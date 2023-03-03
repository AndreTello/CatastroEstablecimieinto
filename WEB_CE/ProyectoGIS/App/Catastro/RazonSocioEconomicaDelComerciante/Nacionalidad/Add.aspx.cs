using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;
namespace ProyectoGIS.App.Catastro.RazonSocioEconomicaDelComerciante.Nacionalidad
{
    public partial class Add : System.Web.UI.Page
    {
        Cls_Nacionalidad_BLL objdll = new Cls_Nacionalidad_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            NACIONALIDAD_ESTADO.Items.Insert(0, new ListItem("-- Seleccione un Estado --", ""));
            NACIONALIDAD_ESTADO.Items.Insert(1, new ListItem("Activo", "1"));
            NACIONALIDAD_ESTADO.Items.Insert(2, new ListItem("Inactivo", "0"));
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if(NACIONALIDAD_CODIGO.Text == "" || NACIONALIDAD_NOMBRE.Text == "" || NACIONALIDAD_DETALLE.Text == "" || NACIONALIDAD_ESTADO.SelectedValue == "" || NACIONALIDAD_ESTADO.SelectedValue == "-- Seleccione un Estado --")
            {
                Response.Write("<script>alert('Debe llenar todos los campos');</script>");
                return;
            }
            objdll.Insertar_Nacionalidad(NACIONALIDAD_CODIGO.Text, NACIONALIDAD_NOMBRE.Text, NACIONALIDAD_DETALLE.Text, NACIONALIDAD_ESTADO.SelectedValue);
            Response.Redirect("./Ficha.aspx");
        }
    }
}