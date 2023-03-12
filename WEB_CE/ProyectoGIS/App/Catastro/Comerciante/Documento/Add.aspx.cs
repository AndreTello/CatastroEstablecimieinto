using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;
namespace ProyectoGIS.App.Catastro.Comerciante.Documento
{
    public partial class Add : System.Web.UI.Page
    {
        Cls_Documento_Comerciante_BLL objdll = new Cls_Documento_Comerciante_BLL();
        Cls_Comerciante_BLL objdll2 = new Cls_Comerciante_BLL();
        Cls_Tipo_Documento_Comerciante_BLL objdll3 = new Cls_Tipo_Documento_Comerciante_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                COMERCIANTE_ID.DataSource = objdll2.Consultar_Comerciante();
                COMERCIANTE_ID.DataTextField = "comerciante_nombres_representante_legal";
                COMERCIANTE_ID.DataValueField = "COMERCIANTE_ID";
                COMERCIANTE_ID.DataBind();
                COMERCIANTE_ID.Items.Insert(0, new ListItem("-- Seleccione un Comerciante --", ""));

                TIPO_DOCUMENTO.DataSource = objdll3.Consultar_Tipo_Documento_Comerciante();
                TIPO_DOCUMENTO.DataTextField = "TIPO_DOCUMENTO_COMERCIANTE_NOMBRE";
                TIPO_DOCUMENTO.DataValueField = "TIPO_DOCUMENTO_COMERCIANTE_ID";
                TIPO_DOCUMENTO.DataBind();
                TIPO_DOCUMENTO.Items.Insert(0, new ListItem("-- Seleccione un Tipo de Documento --", ""));

                if (Request.QueryString["id"] != null)
                {
                    string id = Request.QueryString["id"];
                    DataTable dt = objdll.Consultar_IdDocumento_Comerciante(id);
                    if (dt != null)
                    {
                        DOCUMENTO_ESTADO.SelectedValue = dt.Rows[0]["DOCUMENTO_COMERCIANTE_ESTADO"].ToString();
                        DOCUMENTO_NOMBRE.Text = dt.Rows[0]["DOCUMENTO_COMERCIANTE_NOMBRE"].ToString().Trim();
                        DOCUMENTO_OBSERVACION.Text = dt.Rows[0]["DOCUMENTO_COMERCIANTE_OBSERVACION"].ToString().Trim();
                        DOCUMENTO_FECHA.SelectedDate = Convert.ToDateTime(dt.Rows[0]["DOCUMENTO_COMERCIANTE_FECHA"].ToString());
                        DOCUMENTO_DETALLE.Text = dt.Rows[0]["DOCUMENTO_COMERCIANTE_DETALLE"].ToString().Trim();
                        btnGuardar.Text = "Actualizar";
                    }
                    else
                    {
                        btnGuardar.Text = "Guardar";
                    }
                }
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (DOCUMENTO_DETALLE.Text == string.Empty || string.IsNullOrEmpty(DOCUMENTO_ESTADO.SelectedValue) || DOCUMENTO_FECHA.SelectedDate == null ||
                DOCUMENTO_OBSERVACION.Text == string.Empty || DOCUMENTO_NOMBRE.Text == string.Empty || string.IsNullOrEmpty(COMERCIANTE_ID.SelectedValue) || string.IsNullOrEmpty(TIPO_DOCUMENTO.SelectedValue))
            {
                Response.Write("<script>alert('Debe llenar todos los campos')</script>");
                return;
            }
            if (Request.QueryString["id"] != null)
            {
                string id = Request.QueryString["id"];
                objdll.Editar_Documento_Comerciante(Convert.ToInt32(TIPO_DOCUMENTO.SelectedValue), Convert.ToInt32(COMERCIANTE_ID.SelectedValue), DOCUMENTO_NOMBRE.Text, DOCUMENTO_FECHA.SelectedDate.ToString("MM/dd/yyyy"), DOCUMENTO_DETALLE.Text, DOCUMENTO_OBSERVACION.Text, DOCUMENTO_ESTADO.SelectedValue, id);
                Response.Redirect("./Ficha");
            }
            else
            {
                objdll.Insertar_Documento_Comerciante(Convert.ToInt32(TIPO_DOCUMENTO.SelectedValue), Convert.ToInt32(COMERCIANTE_ID.SelectedValue), DOCUMENTO_NOMBRE.Text, DOCUMENTO_FECHA.SelectedDate.ToString("MM/dd/yyyy"), DOCUMENTO_DETALLE.Text, DOCUMENTO_OBSERVACION.Text, DOCUMENTO_ESTADO.SelectedValue);
                Response.Redirect("./Ficha");
            }
        }
    }
}