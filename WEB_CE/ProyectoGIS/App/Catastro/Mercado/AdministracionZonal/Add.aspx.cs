using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;
namespace ProyectoGIS.App.Catastro.AdministracionZonal
{
    public partial class Add : System.Web.UI.Page
    {
        Cls_Administracion_Zonal_BLL objdll = new Cls_Administracion_Zonal_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            ADMINISTRACION_ZONAL_ESTADO.Items.Insert(0, new ListItem("-- Seleccione un Tipo de Intervención --", ""));
            ADMINISTRACION_ZONAL_ESTADO.Items.Insert(1, new ListItem("Activo", "1"));
            ADMINISTRACION_ZONAL_ESTADO.Items.Insert(2, new ListItem("Inactivo", "0"));

        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
           
            objdll.Insertar_Administracion_Zonal(ADMINISTRACION_ZONAL_NOMBRE.Text, ADMINISTRACION_ZONAL_DETALLE.Text, ADMINISTRACION_ZONAL_TELEFONO.Text, ADMINISTRACION_ZONAL_CELULAR.Text, ADMINISTRACION_ZONAL_MAIL.Text, ADMINISTRACION_ZONAL_PAGINA_WEB.Text, ADMINISTRACION_ZONAL_REPRESENTANTE.Text, ADMINISTRACION_ZONAL_ESTADO.SelectedValue);
            Response.AddHeader("REFRESH", "1;URL=./Ficha.aspx");
        }
    }
}