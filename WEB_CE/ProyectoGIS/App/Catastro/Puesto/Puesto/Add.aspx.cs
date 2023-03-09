using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;
namespace ProyectoGIS.App.Catastro.Puesto.Puesto
{
    public partial class Add : System.Web.UI.Page
    {
        Cls_Puesto_BLL objdll = new Cls_Puesto_BLL();
        Cls_Ayudante_BLL objdll2 = new Cls_Ayudante_BLL();
        Cls_Reemplazo_BLL objdll3 = new Cls_Reemplazo_BLL();
        Cls_Documento_Puesto_BLL objdll4 = new Cls_Documento_Puesto_BLL();
        Cls_Piso_BLL objdll5 = new Cls_Piso_BLL(); 
        Cls_Tipo_Area_BLL objdll6 = new Cls_Tipo_Area_BLL();
        Cls_Comerciante_BLL objdll7 = new Cls_Comerciante_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PUESTO_ESTADO.Items.Insert(0, new ListItem("-- Seleccione un Estado --", ""));
                PUESTO_ESTADO.Items.Insert(1, new ListItem("Activo", "1"));
                PUESTO_ESTADO.Items.Insert(2, new ListItem("Inactivo", "0"));

                PISO_ID.DataSource = objdll5.Consultar_Piso();
                PISO_ID.DataTextField = "PISO_NOMBRE";
                PISO_ID.DataValueField = "PISO_ID";
                PISO_ID.DataBind();

                TIPO_AREA_ID.DataSource = objdll6.Consultar_Tipo_Area();
                TIPO_AREA_ID.DataTextField = "tipo_area_nombre";
                TIPO_AREA_ID.DataValueField = "tipo_area_id";
                TIPO_AREA_ID.DataBind();

                AYUDANTE_ID.DataSource = objdll2.Consultar_Ayudante();
                AYUDANTE_ID.DataTextField = "AYUDANTE_NOMBRES";
                AYUDANTE_ID.DataValueField = "AYUDANTE_ID";
                AYUDANTE_ID.DataBind();

                DOCUMENTO_PUESTO_ID.DataSource = objdll4.Consultar_Documento_Puesto();
                DOCUMENTO_PUESTO_ID.DataTextField = "DOCUMENTO_PUESTO_NOMBRE";
                DOCUMENTO_PUESTO_ID.DataValueField = "DOCUMENTO_PUESTO_ID";
                DOCUMENTO_PUESTO_ID.DataBind();

                REEMPLAZO_ID.DataSource = objdll3.Consultar_Reemplazo();
                REEMPLAZO_ID.DataTextField = "REEMPLAZO_NOMBRES";
                REEMPLAZO_ID.DataValueField = "REEMPLAZO_ID";
                REEMPLAZO_ID.DataBind();

                COMERCIANTE_ID.DataSource = objdll7.Consultar_Comerciante();
                COMERCIANTE_ID.DataTextField = "comerciante_nombres_representante_legal";
                COMERCIANTE_ID.DataValueField = "COMERCIANTE_ID";
                COMERCIANTE_ID.DataBind();

            }

        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if(PISO_ID.SelectedValue =="" || TIPO_AREA_ID.SelectedValue =="" || AYUDANTE_ID.SelectedValue =="" || DOCUMENTO_PUESTO_ID.SelectedValue=="" ||
                REEMPLAZO_ID.SelectedValue =="" || COMERCIANTE_ID.SelectedValue =="")
            {
                Response.Write("<script>alert('Debe llenar todos los campos')</script>");
                return;
            }
            
            objdll.Insertar_Puesto(Convert.ToInt32(PISO_ID.SelectedValue), Convert.ToInt32(TIPO_AREA_ID.SelectedValue), Convert.ToInt32(COMERCIANTE_ID.SelectedValue), Convert.ToInt32(AYUDANTE_ID.SelectedValue), Convert.ToInt32(REEMPLAZO_ID.SelectedValue), Convert.ToInt32(DOCUMENTO_PUESTO_ID.SelectedValue), PUESTO_PREDIO.Text, PUESTO_CLAVE_CATASTRAL.Text, PUESTO_ESTADO_CONSERVACION.Text, PUESTO_ACABADOS.Text, PUESTO_PAREDES.Text, PUESTO_REMODELACION.Text , PUESTO_ESTADO.SelectedValue );
            Response.Redirect("./Ficha.aspx");
        }
    }
}