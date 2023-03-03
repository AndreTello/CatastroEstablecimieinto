using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;
namespace ProyectoGIS.App.Catastro.Comerciante.TipoOcupante
{
    public partial class Add : System.Web.UI.Page
    {
        Cls_Tipo_Ocupante_BLL objdll = new Cls_Tipo_Ocupante_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            TIPO_OCUPANTE_ESTADO.Items.Insert(0, new ListItem("-- Seleccione un Estado --", ""));
            TIPO_OCUPANTE_ESTADO.Items.Insert(1, new ListItem("Activo", "1"));
            TIPO_OCUPANTE_ESTADO.Items.Insert(2, new ListItem("Inactivo", "0"));
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validación del campo TIPO_OCUPANTE_ESTADO
            if (TIPO_OCUPANTE_ESTADO.SelectedValue == "-1" || TIPO_OCUPANTE_ESTADO.SelectedValue == "" || TIPO_OCUPANTE_NOMBRE.Text == string.Empty ||
                               TIPO_OCUPANTE_DETALLE.Text == string.Empty)
            {
                return;
            }
            objdll.Insertar_Tipo_Ocupante(TIPO_OCUPANTE_NOMBRE.Text, TIPO_OCUPANTE_DETALLE.Text, TIPO_OCUPANTE_ESTADO.SelectedValue);
            Response.Redirect("./Ficha");
        }
    }
}