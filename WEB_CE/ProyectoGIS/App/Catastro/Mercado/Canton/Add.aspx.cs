using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;
namespace ProyectoGIS.App.Catastro.Canton
{
    public partial class Add : System.Web.UI.Page
    {
        Cls_Provincia_BLL obj_pro = new Cls_Provincia_BLL();
        Cls_Canton_BLL objdll = new Cls_Canton_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            PROVINCIA_ID.Items.Insert(0, new ListItem("-- Seleccione una provincia --", ""));
            if (!IsPostBack)
            {
                PROVINCIA_ID.DataSource = obj_pro.Consultar_Provincia();
                PROVINCIA_ID.DataTextField = "PROVINCIA_NOMBRE";
                PROVINCIA_ID.DataValueField = "PROVINCIA_ID";
                PROVINCIA_ID.DataBind();
            }
            CANTON_ESTADO.Items.Insert(0, new ListItem("-- Seleccione un Estado --", ""));
            CANTON_ESTADO.Items.Insert(1, new ListItem("Activo", "1"));
            CANTON_ESTADO.Items.Insert(2, new ListItem("Inactivo", "0"));


        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            
           
            if (PROVINCIA_ID.SelectedValue == "-1" || PROVINCIA_ID.SelectedValue == "")
            {
                
                return;
            }

            // Validación del campo CANTON_CODIGO
            if (string.IsNullOrEmpty(CANTON_CODIGO.Text))
            {
                
                return;
            }

            // Validación del campo CANTON_NOMBRE
            if (string.IsNullOrEmpty(CANTON_NOMBRE.Text))
            {
               
                return;
            }

            // Validación del campo CANTON_ESTADO
            if (CANTON_ESTADO.SelectedValue == "-1" || CANTON_ESTADO.SelectedValue =="")
            {
               
                return;
            }
            objdll.Insertar_Canton(Convert.ToInt32(PROVINCIA_ID.SelectedValue), CANTON_CODIGO.Text, CANTON_NOMBRE.Text, CANTON_OBSERVACION.Text, CANTON_ESTADO.SelectedValue);
            Response.Redirect("./Ficha");
            
        }



    }
}