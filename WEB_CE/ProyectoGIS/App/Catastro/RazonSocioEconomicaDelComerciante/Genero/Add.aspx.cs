using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;
namespace ProyectoGIS.App.Catastro.RazonSocioEconomicaDelComerciante.Genero
{
    public partial class Add : System.Web.UI.Page
    {
        Cls_Genero_BLL objdll = new Cls_Genero_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            GENERO_ESTADO.Items.Insert(0, new ListItem("-- Seleccione un Estado --", ""));
            GENERO_ESTADO.Items.Insert(1, new ListItem("Activo", "1"));
            GENERO_ESTADO.Items.Insert(2, new ListItem("Inactivo", "0"));
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if(GENERO_NOMBRE.Text == "" || GENERO_DETALLE.Text == "" || GENERO_ESTADO.SelectedValue == "" || GENERO_ESTADO.SelectedValue == "-1")
            {
                return;
            }
            objdll.Insertar_Genero(GENERO_NOMBRE.Text, GENERO_DETALLE.Text, GENERO_ESTADO.SelectedValue);
            Response.Redirect("./Ficha.aspx");
        }

    }
}