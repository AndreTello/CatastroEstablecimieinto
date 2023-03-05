using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;
namespace ProyectoGIS.App.Catastro.Puesto.Bloque
{
    public partial class Add : System.Web.UI.Page
    {
        Cls_Bloque_BLL objdll = new Cls_Bloque_BLL();
        Cls_Establecimiento_BLL objdll2 = new Cls_Establecimiento_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            BLOQUE_ESTADO.Items.Insert(0, new ListItem("-- Seleccione un Estado --", ""));
            BLOQUE_ESTADO.Items.Insert(1, new ListItem("Activo", "1"));
            BLOQUE_ESTADO.Items.Insert(2, new ListItem("Inactivo", "0"));
            if (!IsPostBack)
            {
                DataTable dt = objdll2.Consultar_Establecimiento();
                ESTABLECIMIENTO_ID.DataSource = dt;
                ESTABLECIMIENTO_ID.DataTextField = "establecimiento_clave_catastral";
                ESTABLECIMIENTO_ID.DataValueField = "ESTABLECIMIENTO_ID";
                ESTABLECIMIENTO_ID.DataBind();
            }
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if(BLOQUE_NOMBRE.Text == "" || BLOQUE_ESTADO.SelectedValue == "" || ESTABLECIMIENTO_ID.SelectedValue == "")
            {
                Response.Write("<script>alert('Debe llenar todos los campos')</script>");
                return;
            }
            objdll.Insertar_Bloque(Convert.ToInt32(ESTABLECIMIENTO_ID.SelectedValue), BLOQUE_CODIGO.Text,BLOQUE_NOMBRE.Text, BLOQUE_OBSERVACION.Text , BLOQUE_ESTADO.SelectedValue);
            Response.Redirect("./Ficha.aspx");
        }
    }
}