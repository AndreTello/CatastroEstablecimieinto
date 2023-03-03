using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;
namespace ProyectoGIS.App.Catastro.Comerciante.TipoIdentificacion
{
    public partial class Add : System.Web.UI.Page
    {
        Cls_Tipo_Identificacion_BLL objdll = new Cls_Tipo_Identificacion_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            TIPO_IDENTIFICACION_ESTADO.Items.Insert(0, new ListItem("-- Seleccione un Estado --", ""));
            TIPO_IDENTIFICACION_ESTADO.Items.Insert(1, new ListItem("Activo", "1"));
            TIPO_IDENTIFICACION_ESTADO.Items.Insert(2, new ListItem("Inactivo", "0"));

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            

            // Validación del campo TIPO_IDENTIFICACION_ESTADO
            if (TIPO_IDENTIFICACION_ESTADO.SelectedValue == "-1" || TIPO_IDENTIFICACION_ESTADO.SelectedValue =="" || TIPO_IDENTIFICACION_NOMBRE.Text == string.Empty ||
                TIPO_IDENTIFICACION_DETALLE.Text == string.Empty )
            {
                return;
            }
            objdll.Insertar_Tipo_Identificacion(TIPO_IDENTIFICACION_NOMBRE.Text, TIPO_IDENTIFICACION_DETALLE.Text , TIPO_IDENTIFICACION_ESTADO.SelectedValue);
            Response.Redirect("./Ficha");
        }

    }

}