using BLL_CE.Catastro;
using System;
using System.Web.UI.WebControls;
namespace ProyectoGIS.App.Catastro.GiroNegocio.GiroComercio
{
    public partial class Add : System.Web.UI.Page
    {
        Cls_Giro_Negocio_BLL objdll = new Cls_Giro_Negocio_BLL();
        Cls_Tipos_Producto_BLL objdll2 = new Cls_Tipos_Producto_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GIRO_NEGOCIO_ESTADO.Items.Insert(0, new ListItem("-- Seleccione un Estado --", ""));
                GIRO_NEGOCIO_ESTADO.Items.Insert(1, new ListItem("Activo", "1"));
                GIRO_NEGOCIO_ESTADO.Items.Insert(1, new ListItem("Inactivo", "0"));

                TIPO_PRODUCTO_ID.DataSource = objdll2.Consultar_Tipo_Producto();
                TIPO_PRODUCTO_ID.DataTextField = "TIPO_PRODUCTO_NOMBRE";
                TIPO_PRODUCTO_ID.DataValueField = "TIPO_PRODUCTO_ID";
                TIPO_PRODUCTO_ID.DataBind();
            }
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if(TIPO_PRODUCTO_ID.SelectedValue =="" || GIRO_NEGOCIO_NOMBRE.Text == string.Empty || GIRO_NEGOCIO_ABASTECIMIENTO.Text == string.Empty ||
                GIRO_NEGOCIO_OBSERVACION.Text ==string.Empty || GIRO_NEGOCIO_SUBGIROS.Text == string.Empty)
            {
                Response.Write("<script>alert('Debe llenar todos los campos')</script>");
                return;
            }
            objdll.Insertar_Giro_Negocio(Convert.ToInt32(TIPO_PRODUCTO_ID.SelectedValue) ,GIRO_NEGOCIO_NOMBRE.Text, GIRO_NEGOCIO_SUBGIROS.Text, GIRO_NEGOCIO_ABASTECIMIENTO.Text, GIRO_NEGOCIO_OBSERVACION.Text , GIRO_NEGOCIO_ESTADO.SelectedValue);
            Response.Redirect("./Ficha.aspx");
            
        }
    }
}