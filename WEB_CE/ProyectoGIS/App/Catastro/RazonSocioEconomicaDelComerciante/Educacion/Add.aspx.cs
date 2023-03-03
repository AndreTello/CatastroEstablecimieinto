using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;
namespace ProyectoGIS.App.Catastro.RazonSocioEconomicaDelComerciante.Educacion
{
    public partial class Add : System.Web.UI.Page
    {
        Cls_Nivel_Educacion_BLL objdll = new Cls_Nivel_Educacion_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            NIVEL_EDUCACION_ESTADO.Items.Insert(0, new ListItem("-- Seleccione un Tipo de Ocupante --", ""));
            NIVEL_EDUCACION_ESTADO.Items.Insert(1, new ListItem("Activo", "1"));
            NIVEL_EDUCACION_ESTADO.Items.Insert(2, new ListItem("Inactivo", "0"));
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if(NIVEL_EDUCACION_NOMBRE.Text == "" || NIVEL_EDUCACION_DETALLE.Text == "" || NIVEL_EDUCACION_ESTADO.SelectedValue == "" || NIVEL_EDUCACION_ESTADO.SelectedValue =="-1")
            objdll.Insertar_Nivel_Educacion(NIVEL_EDUCACION_NOMBRE.Text, NIVEL_EDUCACION_DETALLE.Text, NIVEL_EDUCACION_ESTADO.SelectedValue);
            Response.Redirect("./Ficha.aspx");
        }
    }
}