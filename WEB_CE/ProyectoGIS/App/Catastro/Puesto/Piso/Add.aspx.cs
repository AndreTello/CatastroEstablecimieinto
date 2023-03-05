using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;
namespace ProyectoGIS.App.Catastro.Puesto.Piso
{
    public partial class Add : System.Web.UI.Page
    {
        Cls_Piso_BLL objdll = new Cls_Piso_BLL();
        Cls_Bloque_BLL objdll2 = new Cls_Bloque_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            PISO_ESTADO.Items.Insert(0, new ListItem("-- Seleccione un Estado --", ""));
            PISO_ESTADO.Items.Insert(1, new ListItem("Activo", "1"));
            PISO_ESTADO.Items.Insert(2, new ListItem("Inactivo", "0"));
            if(!IsPostBack)
            {
                BLOQUE_ID.DataSource = objdll2.Listar_Bloque();
                BLOQUE_ID.DataTextField = "BLOQUE_NOMBRE";
                BLOQUE_ID.DataValueField = "BLOQUE_ID";
                BLOQUE_ID.DataBind();
            }
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if(PISO_NOMBRE.Text == "" || PISO_ESTADO.SelectedValue == "" || PISO_CODIGO.Text == string.Empty || BLOQUE_ID.SelectedValue =="")
            {
                Response.Write("<script>alert('Debe llenar todos los campos')</script>");
                return;
            }
            objdll.Insertar_Piso(Convert.ToInt32(BLOQUE_ID.SelectedValue), PISO_CODIGO.Text,PISO_NOMBRE.Text, PISO_OBSERVACION.Text ,PISO_ESTADO.SelectedValue);
            Response.Redirect("./Ficha.aspx");
        }
    }
}