using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;
namespace ProyectoGIS.App.Catastro.Establecimiento
{
    public partial class Add : System.Web.UI.Page
    {
        Cls_Establecimiento_BLL objdll = new Cls_Establecimiento_BLL();
        Cls_Asociacion_BLL obj_aso = new Cls_Asociacion_BLL();
        Cls_Lote_BLL obj_lot = new Cls_Lote_BLL();
        Cls_Intervencion_Tecnica_Establecimiento_BLL obj_int = new Cls_Intervencion_Tecnica_Establecimiento_BLL();
        Cls_Administracion_Zonal_BLL obj_adm = new Cls_Administracion_Zonal_BLL();
        Cls_Tipo_Establecimiento_BLL obj_tip = new Cls_Tipo_Establecimiento_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            ESTABLECIMIENTO_ESTADO.Items.Insert(0, new ListItem("--Seleccione un Estado--", ""));
            ESTABLECIMIENTO_ESTADO.Items.Insert(1, new ListItem("Activo", "1"));
            ESTABLECIMIENTO_ESTADO.Items.Insert(2, new ListItem("Inactivo", "0"));
            if (!IsPostBack)
            {
                ASOCIACION_ID.DataSource = obj_aso.Consultar_Asociacion();
                ASOCIACION_ID.DataTextField = "ASOCIACION_NOMBRE";
                ASOCIACION_ID.DataValueField = "ASOCIACION_ID";
                ASOCIACION_ID.DataBind();

                LOTE_ID.DataSource = obj_lot.Consultar_Lote();
                LOTE_ID.DataTextField = "LOTE_NOMBRE";
                LOTE_ID.DataValueField = "LOTE_ID";
                LOTE_ID.DataBind();

                INTERVENCION_TECNICA_ESTABLECIMIENTO_ID.DataSource = obj_int.Consultar_Intervencion_Tecnica_Establecimiento();
                INTERVENCION_TECNICA_ESTABLECIMIENTO_ID.DataTextField = "INTERVENCION_TECNICA_ESTABLECIMIENTO_NOMBRE";
                INTERVENCION_TECNICA_ESTABLECIMIENTO_ID.DataValueField = "INTERVENCION_TECNICA_ESTABLECIMIENTO_ID";
                INTERVENCION_TECNICA_ESTABLECIMIENTO_ID.DataBind();

                ADMINISTRACION_ZONAL_ID.DataSource = obj_adm.Consultar_Administracion_Zonal();
                ADMINISTRACION_ZONAL_ID.DataTextField = "ADMINISTRACION_ZONAL_NOMBRE";
                ADMINISTRACION_ZONAL_ID.DataValueField = "ADMINISTRACION_ZONAL_ID";
                ADMINISTRACION_ZONAL_ID.DataBind();

                TIPO_ESTABLECIMIENTO_ID.DataSource = obj_tip.Consultar_Tipo_Establecimiento();
                TIPO_ESTABLECIMIENTO_ID.DataTextField = "TIPO_ESTABLECIMIENTO_NOMBRE";
                TIPO_ESTABLECIMIENTO_ID.DataValueField = "TIPO_ESTABLECIMIENTO_ID";
                TIPO_ESTABLECIMIENTO_ID.DataBind();
            }

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if(ESTABLECIMIENTO_PREDIO.Text == "" || ESTABLECIMIENTO_CLAVE_CATASTRAL.Text == "" || ESTABLECIMIENTO_NOMENCLATURA_VIAL.Text == "" || 
                ESTABLECIMIENTO_CALLE_PRINCIPAL.Text == "" || ESTABLECIMIENTO_CALLE_SECUNDARIA.Text == "" || ESTABLECIMIENTO_PARQUEADERO.Text == "" || 
                ESTABLECIMIENTO_NUMERO_PARQUEADERO.Text == "" || ESTABLECIMIENTO_DIAS_APERTURA.Text == "" || ESTABLECIMIENTO_HORARIO_ATENCION.Text == "" || 
                ESTABLECIMIENTO_ESTADO.SelectedValue == "" || TIPO_ESTABLECIMIENTO_ID.SelectedValue =="" || TIPO_ESTABLECIMIENTO_ID.SelectedValue =="-1" ||
                ASOCIACION_ID.SelectedValue == "" || ADMINISTRACION_ZONAL_ID.SelectedValue == "" || INTERVENCION_TECNICA_ESTABLECIMIENTO_ID.SelectedValue == "" ||
                LOTE_ID.SelectedValue == "")
            {
                Response.Write("<script>alert('Debe llenar todos los campos')</script>");
            }
            
            objdll.Insertar_Establecimiento(Convert.ToInt32(LOTE_ID.SelectedValue), Convert.ToInt32(ADMINISTRACION_ZONAL_ID.SelectedValue), Convert.ToInt32(TIPO_ESTABLECIMIENTO_ID.SelectedValue), Convert.ToInt32(ASOCIACION_ID.SelectedValue), Convert.ToInt32(INTERVENCION_TECNICA_ESTABLECIMIENTO_ID.SelectedValue), ESTABLECIMIENTO_PREDIO.Text, ESTABLECIMIENTO_CLAVE_CATASTRAL.Text, ESTABLECIMIENTO_NOMENCLATURA_VIAL.Text, ESTABLECIMIENTO_CALLE_PRINCIPAL.Text, ESTABLECIMIENTO_CALLE_SECUNDARIA.Text, ESTABLECIMIENTO_PARQUEADERO.Text, ESTABLECIMIENTO_NUMERO_PARQUEADERO.Text, ESTABLECIMIENTO_DIAS_APERTURA.Text, ESTABLECIMIENTO_HORARIO_ATENCION.Text, ESTABLECIMIENTO_ESTADO.SelectedValue);
            Response.Redirect("./Ficha.aspx");
        }
    }
}