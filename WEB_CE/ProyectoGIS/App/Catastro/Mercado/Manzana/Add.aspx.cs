using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;  
namespace ProyectoGIS.App.Catastro.Manzana
{
    public partial class Add : System.Web.UI.Page
    {
        Cls_Manzana_BLL objdll = new Cls_Manzana_BLL();
        Cls_Parroquia_BLL obj_par = new Cls_Parroquia_BLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            PARROQUIA_ID.Items.Insert(0, new ListItem("-- Seleccione una parroquia --", ""));
            if (!IsPostBack)
            {
                PARROQUIA_ID.DataSource = obj_par.Consultar_Parroquia();
                PARROQUIA_ID.DataTextField = "PARROQUIA_NOMBRE";
                PARROQUIA_ID.DataValueField = "PARROQUIA_ID";
                PARROQUIA_ID.DataBind();
            }
            MANZANA_ESTADO.Items.Insert(0, new ListItem("-- Seleccione un Estado --", ""));
            MANZANA_ESTADO.Items.Insert(1, new ListItem("Activo", "1"));
            MANZANA_ESTADO.Items.Insert(2, new ListItem("Inactivo", "0"));
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if(PARROQUIA_ID.SelectedValue == "" || PARROQUIA_ID.SelectedValue =="-1" || MANZANA_CODIGO.Text == String.Empty|| MANZANA_NOMBRE.Text == String.Empty || MANZANA_ESTADO.SelectedValue == "" || MANZANA_ESTADO.SelectedValue =="-1")
            {
                Response.Write("<script>alert('Debe llenar todos los campos')</script>");
                return;
            }
           
            objdll.Insertar_Manzana(Convert.ToInt32(PARROQUIA_ID.SelectedValue), MANZANA_CODIGO.Text, MANZANA_NOMBRE.Text, MANZANA_OBSERVACION.Text, MANZANA_ESTADO.SelectedValue);
            Response.Redirect("./Ficha");
        }

    }
}