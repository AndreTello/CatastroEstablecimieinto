using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;
namespace ProyectoGIS.App.Catastro.Parroquia
{
    public partial class Add : System.Web.UI.Page
    {
        Cls_Parroquia_BLL objdll = new Cls_Parroquia_BLL();
        Cls_Zona_BLL obj_zon = new Cls_Zona_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            ZONA_ID.Items.Insert(0, new ListItem("-- Seleccione una zona --", ""));
            if (!IsPostBack)
            {
                ZONA_ID.DataSource = obj_zon.Consultar_Zona();
                ZONA_ID.DataTextField = "ZONA_NOMBRE";
                ZONA_ID.DataValueField = "ZONA_ID";
                ZONA_ID.DataBind();
            }
            PARROQUIA_ESTADO.Items.Insert(0, new ListItem("-- Seleccione un Estado --", ""));
            PARROQUIA_ESTADO.Items.Insert(1, new ListItem("Activo", "1"));
            PARROQUIA_ESTADO.Items.Insert(2, new ListItem("Inactivo", "0"));

        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (PARROQUIA_CODIGO.Text == "" || PARROQUIA_NOMBRE.Text == "" || PARROQUIA_ESTADO.SelectedValue == "" || PARROQUIA_ESTADO.SelectedValue == "-1" || ZONA_ID.SelectedValue == "" || ZONA_ID.SelectedValue == "-1")
            {
                return;
            }
            objdll.Insertar_Parroquia(Convert.ToInt32(ZONA_ID.SelectedValue), PARROQUIA_CODIGO.Text, PARROQUIA_NOMBRE.Text, PARROQUIA_OBSERVACION.Text, PARROQUIA_ESTADO.SelectedValue);
            Response.Redirect("./Ficha");
        }
    }
}