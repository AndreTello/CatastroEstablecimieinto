using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;
namespace ProyectoGIS.App.Catastro.RazonSocioEconomicaDelComerciante.Discapacidad
{
    public partial class Add : System.Web.UI.Page
    {
        Cls_Discapacidad_BLL objdll = new Cls_Discapacidad_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            DISCAPACIDAD_ESTADO.Items.Insert(0, new ListItem("-- Seleccione un Estado --", ""));
            DISCAPACIDAD_ESTADO.Items.Insert(1, new ListItem("Activo", "1"));
            DISCAPACIDAD_ESTADO.Items.Insert(2, new ListItem("Inactivo", "0"));
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if(DISCAPACIDAD_CARNET.Text == "" || DISCAPACIDAD_NOMBRE.Text == "" || DISCAPACIDAD_ESTADO.SelectedValue == "" || DISCAPACIDAD_ESTADO.SelectedValue == "-1")
            {
                Response.Write("<script>alert('Por favor, llene todos los campos.');</script>");
                return;
            }
            objdll.Insertar_Discapacidad(DISCAPACIDAD_CARNET.Text, DISCAPACIDAD_NOMBRE.Text, DISCAPACIDAD_ESTADO.SelectedValue);
            Response.Redirect("./Ficha.aspx");
        }
    }
}