using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;
namespace ProyectoGIS.App.Catastro.RazonSocioEconomicaDelComerciante.Etnia
{
    public partial class Add : System.Web.UI.Page
    {
        Cls_Etnia_BLL objdll = new Cls_Etnia_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            ETNIA_ESTADO.Items.Insert(0, new ListItem("-- Seleccione un Estado --", ""));
            ETNIA_ESTADO.Items.Insert(1, new ListItem("Activo", "1"));
            ETNIA_ESTADO.Items.Insert(2, new ListItem("Inactivo", "0"));
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if(ETNIA_NOMBRE.Text == "" || ETNIA_DETALLE.Text == "" || ETNIA_ESTADO.SelectedValue == "" || ETNIA_ESTADO.SelectedValue == "-1")
            {
                Response.Write("<script>alert('Debe llenar todos los campos')</script>");
                return;
            }   
            objdll.Insertar_Etnia(ETNIA_NOMBRE.Text, ETNIA_DETALLE.Text, ETNIA_ESTADO.SelectedValue);
            Response.Redirect("./Ficha.aspx");
        }
    }
}