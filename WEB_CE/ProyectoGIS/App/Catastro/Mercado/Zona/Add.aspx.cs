using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;
namespace ProyectoGIS.App.Catastro.Zona
{
    public partial class Add : System.Web.UI.Page
    {
        Cls_Zona_BLL objdll = new Cls_Zona_BLL();
        Cls_Canton_BLL obj_can = new Cls_Canton_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            CANTON_ID.Items.Insert(0, new ListItem("-- Seleccione un canton --", ""));
            if (!IsPostBack)
            {
                CANTON_ID.DataSource = obj_can.Consultar_Canton();
                CANTON_ID.DataTextField = "CANTON_NOMBRE";
                CANTON_ID.DataValueField = "CANTON_ID";
                CANTON_ID.DataBind();
            }
            ZONA_ESTADO.Items.Insert(0, new ListItem("-- Seleccione un Estado --", ""));
            ZONA_ESTADO.Items.Insert(1, new ListItem("Activo", "1"));
            ZONA_ESTADO.Items.Insert(2, new ListItem("Inactivo", "0"));

        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ZONA_CODIGO.Text == "" || ZONA_NOMBRE.Text == "" || ZONA_ESTADO.SelectedValue == "" || ZONA_ESTADO.SelectedValue == "-1" || CANTON_ID.SelectedValue =="" || CANTON_ID.SelectedValue == "-1")
            { 
                return;
            }
            objdll.Insertar_Zona(Convert.ToInt32(CANTON_ID.SelectedValue), ZONA_CODIGO.Text, ZONA_NOMBRE.Text, ZONA_OBSERVACION.Text, ZONA_ESTADO.SelectedValue);
            Response.Redirect("./Ficha");
        }
    }

}