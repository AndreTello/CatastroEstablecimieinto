using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;
namespace ProyectoGIS.App.Catastro.Puesto.Ayudante
{
    public partial class Add : System.Web.UI.Page
    {
        Cls_Ayudante_BLL objdll = new Cls_Ayudante_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            AYUDANTE_ESTADO.Items.Insert(0, new ListItem("-- Seleccione un Estado --", ""));
            AYUDANTE_ESTADO.Items.Insert(1, new ListItem("Activo", "1"));
            AYUDANTE_ESTADO.Items.Insert(2, new ListItem("Inactivo", "0"));
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if(AYUDANTE_CEDULA.Text == "" || AYUDANTE_APELLIDOS.Text == "" || AYUDANTE_NOMBRES.Text == "" || AYUDANTE_PARENTEZCO.Text == "" || AYUDANTE_AUTORIZACION.Text == "" || AYUDANTE_NUMERO_OFICIO.Text == "" || AYUDANTE_FECHA_OFICIO.SelectedDate.ToString("MM/dd/yyyy") == "" || AYUDANTE_ESTADO.SelectedValue == "")
            {
                Response.Write("<script>alert('Debe llenar todos los campos')</script>");
                return;
            }
            objdll.Insertar_Ayudante(AYUDANTE_CEDULA.Text, AYUDANTE_APELLIDOS.Text, AYUDANTE_NOMBRES.Text, AYUDANTE_PARENTEZCO.Text,AYUDANTE_AUTORIZACION.Text, AYUDANTE_NUMERO_OFICIO.Text, AYUDANTE_FECHA_OFICIO.SelectedDate.Date.ToString("MM/dd/yyyy"), AYUDANTE_ESTADO.SelectedValue);
            Response.Redirect("./Ficha.aspx");
        }
    }
}