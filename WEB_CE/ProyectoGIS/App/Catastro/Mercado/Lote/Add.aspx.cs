using BLL_CE.Catastro;
using System;
using System.Web.UI.WebControls;
namespace ProyectoGIS.App.Catastro.Lote
{
    public partial class Add : System.Web.UI.Page
    {
        Cls_Lote_BLL objdll = new Cls_Lote_BLL();
        Cls_Manzana_BLL obj_manzana = new Cls_Manzana_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            MANZANA_ID.Items.Insert(0, new ListItem("-- Seleccione una manzana --", ""));
            if (!IsPostBack)
            {
                MANZANA_ID.DataSource = obj_manzana.Consultar_Manzana();
                MANZANA_ID.DataTextField = "MANZANA_NOMBRE";
                MANZANA_ID.DataValueField = "MANZANA_ID";
                MANZANA_ID.DataBind();
            }
            LOTE_ESTADO.Items.Insert(0, new ListItem("-- Seleccione un Estado --", ""));
            LOTE_ESTADO.Items.Insert(1, new ListItem("Activo", "1"));
            LOTE_ESTADO.Items.Insert(1, new ListItem("Inactivo", "0"));
        }
        
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MANZANA_ID.SelectedValue == "" || MANZANA_ID.SelectedValue == "-1" || LOTE_CODIGO.Text == String.Empty || LOTE_NOMBRE.Text == String.Empty || LOTE_ESTADO.SelectedValue == "" || LOTE_ESTADO.SelectedValue == "-1")
            {
                Response.Write("<script>alert('Debe llenar todos los campos')</script>");
                return;
            }
            objdll.Insertar_Lote(Convert.ToInt32(MANZANA_ID.SelectedValue), LOTE_CODIGO.Text, LOTE_NOMBRE.Text, LOTE_OBSERVACION.Text, LOTE_ESTADO.SelectedValue);
            Response.Redirect("./Ficha");

        }

    }
}