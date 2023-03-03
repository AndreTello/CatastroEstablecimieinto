using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;
namespace ProyectoGIS.App.Catastro.Intervencion
{
    public partial class Add : System.Web.UI.Page
    {
        Cls_Intervencion_Tecnica_Establecimiento_BLL objdll = new Cls_Intervencion_Tecnica_Establecimiento_BLL();
        Cls_Tipo_Intervencion_Tecnica_BLL objdll2 = new Cls_Tipo_Intervencion_Tecnica_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_ID.Items.Insert(0, new ListItem("-- Seleccione un Tipo de Intervención --", ""));
            if (!IsPostBack)
            {
                TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_ID.DataSource = objdll2.Listar_Tipo_Intervencion_Tecnica();
                TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_ID.DataTextField = "TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_NOMBRE";
                TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_ID.DataValueField = "TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_ID";
                TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_ID.DataBind();
            }
            INTERVENCION_TECNICA_ESTABLECIMIENTO_ESTADO.Items.Insert(0, new ListItem("-- Seleccione un Estado --", ""));
            INTERVENCION_TECNICA_ESTABLECIMIENTO_ESTADO.Items.Insert(1, new ListItem("Activo", "1"));
            INTERVENCION_TECNICA_ESTABLECIMIENTO_ESTADO.Items.Insert(2, new ListItem("Inactivo", "0"));
            
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_ID.SelectedValue == "" || TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_ID.SelectedValue == "-1" || 
                INTERVENCION_TECNICA_ESTABLECIMIENTO_ESTADO.SelectedValue =="" || INTERVENCION_TECNICA_ESTABLECIMIENTO_ESTADO.SelectedValue == "-1" || 
                INTERVENCION_TECNICA_ESTABLECIMIENTO_FECHA_INICIO.SelectedDate == null || INTERVENCION_TECNICA_ESTABLECIMIENTO_FECHA_FIN == null || 
                INTERVENCION_TECNICA_ESTABLECIMIENTO_NOMBRE.Text == String.Empty )
            {
                Response.Write("<script>alert('Debe llenar todos los campos')</script>");
                return;
            }
            objdll.Insertar_Intervencion_Tecnica_Establecimiento(Convert.ToInt32(TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_ID.SelectedValue), INTERVENCION_TECNICA_ESTABLECIMIENTO_NOMBRE.Text, INTERVENCION_TECNICA_ESTABLECIMIENTO_FECHA_INICIO.SelectedDate.ToString("dd/MM/yyyy"), INTERVENCION_TECNICA_ESTABLECIMIENTO_FECHA_FIN.SelectedDate.ToString("dd/MM/yyyy"),INTERVENCION_TECNICA_ESTABLECIMIENTO_ESTADO.SelectedValue);
            Response.Redirect("./Ficha");
        }
    }
}