using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE.Catastro;
namespace ProyectoGIS.App.Catastro.Comerciante.TipoDocumento
{
    public partial class Add : System.Web.UI.Page
    {
        Cls_Tipo_Documento_Comerciante_BLL objdll = new Cls_Tipo_Documento_Comerciante_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                if (Request.QueryString["id"] != null)
                {
                    string id = Request.QueryString["id"];
                    DataTable dt = objdll.Consultar_IdTipo_Documento_Comerciante(id);
                    TIPO_DOCUMENTO_COMERCIANTE_NOMBRE.Text = dt.Rows[0]["TIPO_DOCUMENTO_COMERCIANTE_NOMBRE"].ToString().Trim();
                    TIPO_DOCUMENTO_COMERCIANTE_ESTADO.SelectedValue = dt.Rows[0]["TIPO_DOCUMENTO_COMERCIANTE_ESTADO"].ToString();
                    btnGuardar.Text = "Actualizar";
                }
                else
                {
                    btnGuardar.Text = "Guardar";
                }
            }
            
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if(TIPO_DOCUMENTO_COMERCIANTE_NOMBRE.Text == "" || string.IsNullOrEmpty(TIPO_DOCUMENTO_COMERCIANTE_ESTADO.SelectedValue))
            {
                Response.Write("<script>alert('Debe llenar todos los campos')</script>");
                return;
            }
            if (Request.QueryString["id"] != null)
            { 
                string id = Request.QueryString["id"];
                objdll.Editar_Tipo_Documento_Comerciante(TIPO_DOCUMENTO_COMERCIANTE_NOMBRE.Text, TIPO_DOCUMENTO_COMERCIANTE_ESTADO.SelectedValue, id);
                Response.Redirect("./Ficha");
                 
            }
            else
            {
                objdll.Insertar_Tipo_Documento_Comerciante(TIPO_DOCUMENTO_COMERCIANTE_NOMBRE.Text,  TIPO_DOCUMENTO_COMERCIANTE_ESTADO.SelectedValue);
                Response.Redirect("./Ficha");
            }
        }
    }
}