using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;
namespace ProyectoGIS.App.Catastro.TipoIntervencion
{
    public partial class Add : System.Web.UI.Page
    {
        Cls_Tipo_Intervencion_Tecnica_BLL objdll = new Cls_Tipo_Intervencion_Tecnica_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_ESTADO.Items.Insert(0, new ListItem("-- Seleccione un Estado --", ""));
            TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_ESTADO.Items.Insert(1, new ListItem("Activo", "1"));
            TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_ESTADO.Items.Insert(2, new ListItem("Inactivo", "0"));
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            objdll.Insertar_Tipo_Intervencion_Tecnica(TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_NOMBRE.Text, TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_DETALLE.Text, TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_ESTADO.SelectedValue);
            Response.AddHeader("REFRESH", "1;URL=./Ficha.aspx");
        }
    }
}