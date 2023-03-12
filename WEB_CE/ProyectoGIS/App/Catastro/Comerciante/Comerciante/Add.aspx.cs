using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;
namespace ProyectoGIS.App.Catastro.Comerciante.Comerciante
{
    public partial class Add : System.Web.UI.Page
    {
        Cls_Comerciante_BLL objdll = new Cls_Comerciante_BLL();
        Cls_Tipo_Ocupante_BLL obj_ocu = new Cls_Tipo_Ocupante_BLL();
        Cls_Tipo_Identificacion_BLL obj_iden = new Cls_Tipo_Identificacion_BLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TIPO_OCUPANTE_ID.Items.Insert(0, new ListItem("-- Seleccione un Tipo de Ocupante --", ""));
                TIPO_OCUPANTE_ID.DataSource = obj_ocu.Consultar_Tipo_Ocupante();
                TIPO_OCUPANTE_ID.DataTextField = "TIPO_OCUPANTE_NOMBRE";
                TIPO_OCUPANTE_ID.DataValueField = "TIPO_OCUPANTE_ID";
                TIPO_OCUPANTE_ID.DataBind();

                TIPO_IDENTIFICACION_ID.Items.Insert(0, new ListItem("-- Seleccione un Tipo de Identificación --", ""));
                TIPO_IDENTIFICACION_ID.DataSource = obj_iden.Consultar_Tipo_Identificacion();
                TIPO_IDENTIFICACION_ID.DataTextField = "TIPO_IDENTIFICACION_NOMBRE";
                TIPO_IDENTIFICACION_ID.DataValueField = "TIPO_IDENTIFICACION_ID";
                TIPO_IDENTIFICACION_ID.DataBind();
            }

            COMERCIANTE_ESTADO.Items.Insert(0, new ListItem("-- Seleccione un Estado --", ""));
            COMERCIANTE_ESTADO.Items.Insert(1, new ListItem("Activo", "1"));
            COMERCIANTE_ESTADO.Items.Insert(2, new ListItem("Inactivo", "0"));
        }
        
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validación del campo TIPO_OCUPANTE_ID
            if (TIPO_OCUPANTE_ID.SelectedValue == "-1" || TIPO_OCUPANTE_ID.SelectedValue == "" || TIPO_IDENTIFICACION_ID.SelectedValue == "-1" || TIPO_IDENTIFICACION_ID.SelectedValue == "" ||
                COMERCIANTE_CEDULA_RUC.Text == string.Empty || COMERCIANTE_APELLIDOS_RAZON_SOCIAL.Text == string.Empty || COMERCIANTE_NOMBRES_REPRESENTANTE_LEGAL.Text == string.Empty ||
                COMERCIANTE_FECHA_NACIMIENTO.Text == string.Empty || COMERCIANTE_EDAD.Text == string.Empty || COMERCIANTE_LUGAR_ORIGEN.Text == string.Empty ||
                COMERCIANTE_TELEFONO_CONVENCIONAL.Text == string.Empty || COMERCIANTE_TELEFONO_CELULAR.Text == string.Empty || COMERCIANTE_DIRECCION_DOMICILIO.Text == string.Empty ||
                COMERCIANTE_CIUDAD.Text == string.Empty || COMERCIANTE_PROVINCIA.Text == string.Empty || COMERCIANTE_MAIL.Text == string.Empty)
            {
                return;
            }
           
            
            objdll.Insertar_Comerciante(Convert.ToInt32(TIPO_IDENTIFICACION_ID.SelectedValue), Convert.ToInt32(TIPO_OCUPANTE_ID.SelectedValue), COMERCIANTE_CEDULA_RUC.Text, COMERCIANTE_APELLIDOS_RAZON_SOCIAL.Text, COMERCIANTE_NOMBRES_REPRESENTANTE_LEGAL.Text, COMERCIANTE_FECHA_NACIMIENTO.Text, COMERCIANTE_EDAD.Text, COMERCIANTE_LUGAR_ORIGEN.Text, COMERCIANTE_TELEFONO_CONVENCIONAL.Text, COMERCIANTE_TELEFONO_CELULAR.Text, COMERCIANTE_DIRECCION_DOMICILIO.Text, COMERCIANTE_CIUDAD.Text, COMERCIANTE_PROVINCIA.Text, COMERCIANTE_MAIL.Text, COMERCIANTE_ESTADO.SelectedValue) ;
            Response.Redirect("./Ficha");
        }
    }
}