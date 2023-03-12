using BLL_CE.Catastro;
using System;
using System.Data;

namespace ProyectoGIS.App.Catastro.Comerciante.TipoIdentificacion
{
    public partial class Add : System.Web.UI.Page
    {
        Cls_Tipo_Identificacion_BLL objdll = new Cls_Tipo_Identificacion_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    string id = Request.QueryString["id"];
                    DataTable dt = objdll.Consultar_IdTipo_Identificacion(id);
                    if (dt != null)
                    {
                        TIPO_IDENTIFICACION_NOMBRE.Text = dt.Rows[0]["TIPO_IDENTIFICACION_NOMBRE"].ToString().Trim();
                        TIPO_IDENTIFICACION_DETALLE.Text = dt.Rows[0]["TIPO_IDENTIFICACION_DETALLE"].ToString();
                        TIPO_IDENTIFICACION_ESTADO.SelectedValue = dt.Rows[0]["TIPO_IDENTIFICACION_ESTADO"].ToString();
                        btnGuardar.Text = "Actualizar";
                    }
                }
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {


            // Validación del campo TIPO_IDENTIFICACION_ESTADO
            if (TIPO_IDENTIFICACION_ESTADO.SelectedValue == "-1" || TIPO_IDENTIFICACION_ESTADO.SelectedValue == "" || TIPO_IDENTIFICACION_NOMBRE.Text == string.Empty ||
                TIPO_IDENTIFICACION_DETALLE.Text == string.Empty)
            {
                Response.Write("<script>alert('Debe llenar todos los campos')</script>");

                return;
            }
            if (Request.QueryString["id"] != null)
            {
                string id = Request.QueryString["id"];

                objdll.Editar_Tipo_Identificacion(TIPO_IDENTIFICACION_NOMBRE.Text, TIPO_IDENTIFICACION_DETALLE.Text, TIPO_IDENTIFICACION_ESTADO.SelectedValue,id);
                Response.Redirect("./Ficha");
            }
            else
            {
                objdll.Insertar_Tipo_Identificacion(TIPO_IDENTIFICACION_NOMBRE.Text, TIPO_IDENTIFICACION_DETALLE.Text, TIPO_IDENTIFICACION_ESTADO.SelectedValue);
                Response.Redirect("./Ficha");
            }
        }

    }

}