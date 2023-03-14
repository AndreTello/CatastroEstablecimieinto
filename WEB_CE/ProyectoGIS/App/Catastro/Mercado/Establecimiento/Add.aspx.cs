using System;
using System.Collections.Generic;
using System.Data;
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
            
            if (!IsPostBack)
            {
                ASOCIACION_ID.DataSource = obj_aso.Listar_Asociacion();
                ASOCIACION_ID.DataTextField = "ASOCIACION_NOMBRE";
                ASOCIACION_ID.DataValueField = "ASOCIACION_ID";
                ASOCIACION_ID.DataBind();
                ASOCIACION_ID.Items.Insert(0, new ListItem("-- Seleccione una Asociacion --", ""));

                LOTE_ID.DataSource = obj_lot.Listar_Lote();
                LOTE_ID.DataTextField = "LOTE_NOMBRE";
                LOTE_ID.DataValueField = "LOTE_ID";
                LOTE_ID.DataBind();
                LOTE_ID.Items.Insert(0, new ListItem("-- Seleccione un Lote --", ""));

                INTERVENCION_TECNICA_ESTABLECIMIENTO_ID.DataSource = obj_int.Listar_Intervencion_Tecnica_Establecimiento();
                INTERVENCION_TECNICA_ESTABLECIMIENTO_ID.DataTextField = "INTERVENCION_TECNICA_ESTABLECIMIENTO_NOMBRE";
                INTERVENCION_TECNICA_ESTABLECIMIENTO_ID.DataValueField = "INTERVENCION_TECNICA_ESTABLECIMIENTO_ID";
                INTERVENCION_TECNICA_ESTABLECIMIENTO_ID.DataBind();
                INTERVENCION_TECNICA_ESTABLECIMIENTO_ID.Items.Insert(0, new ListItem("-- Seleccione una Intervencion Tecnica --", ""));

                ADMINISTRACION_ZONAL_ID.DataSource = obj_adm.Listar_Administracion_Zonal();
                ADMINISTRACION_ZONAL_ID.DataTextField = "ADMINISTRACION_ZONAL_NOMBRE";
                ADMINISTRACION_ZONAL_ID.DataValueField = "ADMINISTRACION_ZONAL_ID";
                ADMINISTRACION_ZONAL_ID.DataBind();
                ADMINISTRACION_ZONAL_ID.Items.Insert(0, new ListItem("-- Seleccione una Administracion Zonal --", ""));

                TIPO_ESTABLECIMIENTO_ID.DataSource = obj_tip.Listar_Tipo_Establecimiento();
                TIPO_ESTABLECIMIENTO_ID.DataTextField = "TIPO_ESTABLECIMIENTO_NOMBRE";
                TIPO_ESTABLECIMIENTO_ID.DataValueField = "TIPO_ESTABLECIMIENTO_ID";
                TIPO_ESTABLECIMIENTO_ID.DataBind();
                TIPO_ESTABLECIMIENTO_ID.Items.Insert(0, new ListItem("-- Seleccione un Tipo de Establecimiento --", ""));

                string id = Request.QueryString["id"];
                if (id != null)
                {
                    DataTable dt = objdll.Consultar_IdEstablecimiento(id);
                    if(dt != null)
                    {
                        ASOCIACION_ID.SelectedValue = dt.Rows[0]["ASOCIACION_id"].ToString();
                        LOTE_ID.SelectedValue = dt.Rows[0]["LOTE_id"].ToString();
                        INTERVENCION_TECNICA_ESTABLECIMIENTO_ID.SelectedValue = dt.Rows[0]["INTERVENCION_TECNICA_ESTABLECIMIENTO_id"].ToString();
                        ADMINISTRACION_ZONAL_ID.SelectedValue = dt.Rows[0]["ADMINISTRACION_ZONAL_id"].ToString();
                        TIPO_ESTABLECIMIENTO_ID.SelectedValue = dt.Rows[0]["TIPO_ESTABLECIMIENTO_id"].ToString();

                        ESTABLECIMIENTO_PREDIO.Text = dt.Rows[0]["ESTABLECIMIENTO_PREDIO"].ToString().Trim();
                        ESTABLECIMIENTO_CLAVE_CATASTRAL.Text = dt.Rows[0]["ESTABLECIMIENTO_CLAVE_CATASTRAL"].ToString().Trim();
                        ESTABLECIMIENTO_NOMENCLATURA_VIAL.Text = dt.Rows[0]["ESTABLECIMIENTO_NOMENCLATURA_VIAL"].ToString().Trim();
                        ESTABLECIMIENTO_CALLE_PRINCIPAL.Text = dt.Rows[0]["ESTABLECIMIENTO_CALLE_PRINCIPAL"].ToString().Trim();
                        ESTABLECIMIENTO_CALLE_SECUNDARIA.Text = dt.Rows[0]["ESTABLECIMIENTO_CALLE_SECUNDARIA"].ToString().Trim();
                        ESTABLECIMIENTO_PARQUEADERO.Text = dt.Rows[0]["ESTABLECIMIENTO_PARQUEADERO"].ToString().Trim();
                        ESTABLECIMIENTO_NUMERO_PARQUEADERO.Text = dt.Rows[0]["ESTABLECIMIENTO_NUMERO_PARQUEADERO"].ToString().Trim();
                        ESTABLECIMIENTO_DIAS_APERTURA.Text = dt.Rows[0]["ESTABLECIMIENTO_DIAS_APERTURA"].ToString().Trim();
                        ESTABLECIMIENTO_HORARIO_ATENCION.Text = dt.Rows[0]["ESTABLECIMIENTO_HORARIO_ATENCION"].ToString().Trim();
                        ESTABLECIMIENTO_ESTADO.SelectedValue = dt.Rows[0]["ESTABLECIMIENTO_ESTADO"].ToString();

                        btnGuardar.Text = "Actualizar";

                    }
                }
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
                return;
            }
            string id = Request.QueryString["id"];
            if (id != null)
            {
                objdll.Editar_Establecimiento(id,Convert.ToInt32(LOTE_ID.SelectedValue), Convert.ToInt32(ADMINISTRACION_ZONAL_ID.SelectedValue), Convert.ToInt32(TIPO_ESTABLECIMIENTO_ID.SelectedValue), Convert.ToInt32(ASOCIACION_ID.SelectedValue), Convert.ToInt32(INTERVENCION_TECNICA_ESTABLECIMIENTO_ID.SelectedValue), ESTABLECIMIENTO_PREDIO.Text, ESTABLECIMIENTO_CLAVE_CATASTRAL.Text, ESTABLECIMIENTO_NOMENCLATURA_VIAL.Text, ESTABLECIMIENTO_CALLE_PRINCIPAL.Text, ESTABLECIMIENTO_CALLE_SECUNDARIA.Text, ESTABLECIMIENTO_PARQUEADERO.Text, ESTABLECIMIENTO_NUMERO_PARQUEADERO.Text, ESTABLECIMIENTO_DIAS_APERTURA.Text, ESTABLECIMIENTO_HORARIO_ATENCION.Text, ESTABLECIMIENTO_ESTADO.SelectedValue);
                Response.Redirect("./Ficha.aspx");
            }
            else
            {
                objdll.Insertar_Establecimiento(Convert.ToInt32(LOTE_ID.SelectedValue), Convert.ToInt32(ADMINISTRACION_ZONAL_ID.SelectedValue), Convert.ToInt32(TIPO_ESTABLECIMIENTO_ID.SelectedValue), Convert.ToInt32(ASOCIACION_ID.SelectedValue), Convert.ToInt32(INTERVENCION_TECNICA_ESTABLECIMIENTO_ID.SelectedValue), ESTABLECIMIENTO_PREDIO.Text, ESTABLECIMIENTO_CLAVE_CATASTRAL.Text, ESTABLECIMIENTO_NOMENCLATURA_VIAL.Text, ESTABLECIMIENTO_CALLE_PRINCIPAL.Text, ESTABLECIMIENTO_CALLE_SECUNDARIA.Text, ESTABLECIMIENTO_PARQUEADERO.Text, ESTABLECIMIENTO_NUMERO_PARQUEADERO.Text, ESTABLECIMIENTO_DIAS_APERTURA.Text, ESTABLECIMIENTO_HORARIO_ATENCION.Text, ESTABLECIMIENTO_ESTADO.SelectedValue);
                Response.Redirect("./Ficha.aspx");
            }
        }
    }
}