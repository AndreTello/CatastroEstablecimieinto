using BLL_CE.Catastro;
using System;
using System.Web.UI.WebControls;
namespace ProyectoGIS.App.Catastro.Provincia
{
    public partial class Add : System.Web.UI.Page
    {
        Cls_Provincia_BLL objdll = new Cls_Provincia_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            PROVINCIA_ESTADO.Items.Insert(0, new ListItem("-- Seleccione una provincia --", ""));

            PROVINCIA_ESTADO.Items.Insert(1, new ListItem("Activo", "1"));
            PROVINCIA_ESTADO.Items.Insert(2, new ListItem("Inactivo", "0"));

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if(PROVINCIA_CODIGO.Text == "" || PROVINCIA_NOMBRE.Text == "" || PROVINCIA_ESTADO.SelectedValue == "" || PROVINCIA_ESTADO.SelectedValue == "-1")
            {
                return;
            }
            objdll.Insertar_Provincia(PROVINCIA_CODIGO.Text, PROVINCIA_NOMBRE.Text, PROVINCIA_OBSERVACION.Text, PROVINCIA_ESTADO.SelectedValue);

            Response.Redirect("./Ficha");

        }
    }
}