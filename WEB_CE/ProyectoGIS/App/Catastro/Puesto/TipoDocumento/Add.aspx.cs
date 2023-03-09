using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;
namespace ProyectoGIS.App.Catastro.Puesto.TipoDocumento
{
    public partial class Add : System.Web.UI.Page
    {
        Cls_Tipo_Documento_Puesto_BLL objdll = new Cls_Tipo_Documento_Puesto_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            TIPO_DOCUMENTO_PUESTO_ESTADO.Items.Insert(0, new ListItem("-- Seleccione un Estado --", ""));
            TIPO_DOCUMENTO_PUESTO_ESTADO.Items.Insert(1, new ListItem("Activo", "1"));
            TIPO_DOCUMENTO_PUESTO_ESTADO.Items.Insert(2, new ListItem("Inactivo", "0"));
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if(TIPO_DOCUMENTO_PUESTO_NOMBRE.Text == string.Empty || TIPO_DOCUMENTO_PUESTO_ESTADO.SelectedValue == "")
            {
                return;
            }
            objdll.Insertar_Tipo_Documento_Puesto(TIPO_DOCUMENTO_PUESTO_NOMBRE.Text, TIPO_DOCUMENTO_PUESTO_ESTADO.SelectedValue);
            Response.Redirect("./Ficha.aspx");
        }
       

    }
}