using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;
namespace ProyectoGIS.App.Catastro.Puesto.Documento
{
    public partial class Add : System.Web.UI.Page
    {
        Cls_Documento_Puesto_BLL objdll = new Cls_Documento_Puesto_BLL();
        Cls_Tipo_Documento_Puesto_BLL objdll2 = new Cls_Tipo_Documento_Puesto_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            DOCUMENTO_PUESTO_ESTADO.Items.Insert(0, new ListItem("-- Seleccione un Estado --", ""));
            DOCUMENTO_PUESTO_ESTADO.Items.Insert(1, new ListItem("Activo", "1"));
            DOCUMENTO_PUESTO_ESTADO.Items.Insert(2, new ListItem("Inactivo", "0"));
            if(!IsPostBack)
            {
                TIPO_DOCUMENTO_PUESTO_ID.Items.Insert(0, new ListItem("-- Seleccione un Tipo de Documento --", ""));    
                TIPO_DOCUMENTO_PUESTO_ID.DataSource = objdll2.Consultar_Tipo_Documento_Puesto();
                TIPO_DOCUMENTO_PUESTO_ID.DataTextField = "TIPO_DOCUMENTO_PUESTO_DESCRIPCION";
                TIPO_DOCUMENTO_PUESTO_ID.DataValueField = "TIPO_DOCUMENTO_PUESTO_ID";
                TIPO_DOCUMENTO_PUESTO_ID.DataBind();
            }
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if(TIPO_DOCUMENTO_PUESTO_ID.SelectedValue == "" || DOCUMENTO_PUESTO_NOMBRE.Text == string.Empty || DOCUMENTO_PUESTO_DETALLE.Text == string.Empty || DOCUMENTO_PUESTO_FECHA.SelectedDate ==null || DOCUMENTO_PUESTO_OBSERVACION.Text =="")
            {
                
                return;
            }
            objdll.Insertar_Documento_Puesto(Convert.ToInt32(TIPO_DOCUMENTO_PUESTO_ID.SelectedValue), DOCUMENTO_PUESTO_NOMBRE.Text , DOCUMENTO_PUESTO_FECHA.SelectedDate.ToString("MM/dd/yyyy") , DOCUMENTO_PUESTO_DETALLE.Text, DOCUMENTO_PUESTO_OBSERVACION.Text ,DOCUMENTO_PUESTO_ESTADO.SelectedValue);
            Response.Redirect("Ficha.aspx");
        }
    }
}