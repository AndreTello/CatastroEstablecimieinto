using BLL_CE.Catastro;
using System;
using System.Data;
namespace ProyectoGIS.App.Catastro.Puesto.TipoDocumento
{
    public partial class Add : System.Web.UI.Page
    {
        Cls_Tipo_Documento_Puesto_BLL objdll = new Cls_Tipo_Documento_Puesto_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id = Request.QueryString["id"];
                if (id != null)
                {
                    DataTable dt = objdll.Consultar_IdTipo_Documento_Puesto(id);
                    if (dt != null)
                    {
                        TIPO_DOCUMENTO_PUESTO_NOMBRE.Text = dt.Rows[0]["TIPO_DOCUMENTO_PUESTO_NOMBRE"].ToString().Trim();
                        TIPO_DOCUMENTO_PUESTO_ESTADO.Text = dt.Rows[0]["TIPO_DOCUMENTO_PUESTO_ESTADO"].ToString();
                        btnGuardar.Text = "Actualizar";
                    }
                }
            }
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (TIPO_DOCUMENTO_PUESTO_NOMBRE.Text == string.Empty || TIPO_DOCUMENTO_PUESTO_ESTADO.SelectedValue == "")
            {
                Response.Write("<script>alert('Debe llenar todos los campos')</script>");
                return;
            }
            if (Request.QueryString["id"] != null)
            {
                string id = Request.QueryString["id"];
                objdll.Editar_Tipo_Documento_Puesto(TIPO_DOCUMENTO_PUESTO_NOMBRE.Text, TIPO_DOCUMENTO_PUESTO_ESTADO.SelectedValue, id);
                Response.Redirect("./Ficha.aspx");
            }
            else
            {
                objdll.Insertar_Tipo_Documento_Puesto(TIPO_DOCUMENTO_PUESTO_NOMBRE.Text, TIPO_DOCUMENTO_PUESTO_ESTADO.SelectedValue);
                Response.Redirect("./Ficha.aspx");

            }

        }


    }
}