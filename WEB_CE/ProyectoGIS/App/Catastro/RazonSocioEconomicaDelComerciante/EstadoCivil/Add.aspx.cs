using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;
namespace ProyectoGIS.App.Catastro.RazonSocioEconomicaDelComerciante.EstadoCivil
{
    public partial class Add : System.Web.UI.Page
    {
        Cls_Estado_Civil_BLL objdll = new Cls_Estado_Civil_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            ESTADO_CIVIL_ESTADO.Items.Insert(0, new ListItem("-- Seleccione un Estado --", ""));
            ESTADO_CIVIL_ESTADO.Items.Insert(1, new ListItem("Activo", "1"));
            ESTADO_CIVIL_ESTADO.Items.Insert(2, new ListItem("Inactivo", "0"));

        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if(ESTADO_CIVIL_NOMBRE.Text == "" || ESTADO_CIVIL_DETALLE.Text == "" || ESTADO_CIVIL_ESTADO.SelectedValue == "" || ESTADO_CIVIL_ESTADO.SelectedValue =="-1")
            {
                Response.Write("<script>alert('Debe llenar todos los campos')</script>");
                return;
            }
            objdll.Insertar_Estado_Civil(ESTADO_CIVIL_NOMBRE.Text ,ESTADO_CIVIL_DETALLE.Text, ESTADO_CIVIL_ESTADO.SelectedValue);
            Response.Redirect("./Ficha.aspx");
        }
    }
}