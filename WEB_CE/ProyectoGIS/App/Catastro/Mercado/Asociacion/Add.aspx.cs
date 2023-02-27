using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;
namespace ProyectoGIS.App.Catastro.Asociacion
{
    public partial class Add : System.Web.UI.Page
    {
        Cls_Asociacion_BLL objdll = new Cls_Asociacion_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            ASOCIACION_ESTADO.Items.Insert(0, new ListItem("--Seleccione un Tipo de Intervención--", ""));
            ASOCIACION_ESTADO.Items.Insert(1, new ListItem("Activo", "1"));
            ASOCIACION_ESTADO.Items.Insert(2, new ListItem("Inactivo", "0"));
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            objdll.Insertar_Asociacion(ASOCIACION_CODIGO.Text, ASOCIACION_NOMBRE.Text, ASOCIACION_TELEFONO.Text, ASOCIACION_MAIL.Text, ASOCIACION_CONTACTO.Text, ASOCIACION_OBSERVACION.Text, ASOCIACION_ESTADO.SelectedValue );
            Response.AddHeader("REFRESH", "1;URL=./Ficha.aspx");
        }
    }
}