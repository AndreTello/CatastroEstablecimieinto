using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;
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
            try
            {

                objdll.Insertar_Provincia(PROVINCIA_CODIGO.Text, PROVINCIA_NOMBRE.Text, PROVINCIA_OBSERVACION.Text, PROVINCIA_ESTADO.SelectedValue);
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Los datos se han guardado correctamente');", true);
                Response.AddHeader("REFRESH", "1;URL=./Ficha.aspx");

            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Los datos no se han guardado correctamente');", true);

            }

        }
    }
}