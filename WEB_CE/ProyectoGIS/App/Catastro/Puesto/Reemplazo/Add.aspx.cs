using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;
namespace ProyectoGIS.App.Catastro.Puesto.Reemplazo
{
    public partial class Add : System.Web.UI.Page
    {
        Cls_Reemplazo_BLL objdll = new Cls_Reemplazo_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            REEMPLAZO_ESTADO.Items.Insert(0, new ListItem("-- Seleccione un Estado --", ""));
            REEMPLAZO_ESTADO.Items.Insert(1, new ListItem("Activo", "1"));
            REEMPLAZO_ESTADO.Items.Insert(2, new ListItem("Inactivo", "0"));
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if(REEMPLAZO_CEDULA.Text == "" || REEMPLAZO_APELLIDOS.Text == "" || REEMPLAZO_NOMBRES.Text == "" ||  REEMPLAZO_AUTORIZACION.Text == "" || REEMPLAZO_NUMERO_OFICIO.Text == "" || REEMPLAZO_FECHA_INICIO.SelectedDate.ToString("MM/dd/yyyy") == "" || REEMPLAZO_FECHA_FIN.SelectedDate.ToString("MM/dd/yyyy") == "" || REEMPLAZO_ESTADO.SelectedValue == "")
            {
                Response.Write("<script>alert('Debe llenar todos los campos')</script>");
                return;
            }
            objdll.Insertar_Reemplazo(REEMPLAZO_CEDULA.Text, REEMPLAZO_APELLIDOS.Text, REEMPLAZO_NOMBRES.Text, REEMPLAZO_AUTORIZACION.Text, REEMPLAZO_NUMERO_OFICIO.Text, REEMPLAZO_FECHA_INICIO.SelectedDate.Date.ToString("MM/dd/yyyy"), REEMPLAZO_FECHA_FIN.SelectedDate.Date.ToString("MM/dd/yyyy"), REEMPLAZO_ESTADO.SelectedValue);
            Response.Redirect("./Ficha.aspx");

        }
    }
}