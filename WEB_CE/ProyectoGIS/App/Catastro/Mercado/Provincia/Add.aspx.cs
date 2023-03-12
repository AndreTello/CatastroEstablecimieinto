using BLL_CE.Catastro;
using System;
using System.Data;
using System.Web.UI.WebControls;
namespace ProyectoGIS.App.Catastro.Provincia
{
    public partial class Add : System.Web.UI.Page
    {
        Cls_Provincia_BLL objdll = new Cls_Provincia_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    string id = Request.QueryString["id"];
                    DataTable dt = objdll.Consultar_IdProvincia(id);
                    if(dt != null)
                    {
                        PROVINCIA_NOMBRE.Text = dt.Rows[0]["PROVINCIA_NOMBRE"].ToString();
                        PROVINCIA_CODIGO.Text = dt.Rows[0]["PROVINCIA_CODIGO"].ToString();
                        PROVINCIA_OBSERVACION.Text = dt.Rows[0]["PROVINCIA_OBSERVACION"].ToString();
                        PROVINCIA_ESTADO.SelectedValue = dt.Rows[0]["PROVINCIA_ESTADO"].ToString();
                        btnGuardar.Text = "Actualizar";
                    }
                }
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if(PROVINCIA_CODIGO.Text == "" || PROVINCIA_NOMBRE.Text == "" || PROVINCIA_ESTADO.SelectedValue == "" || PROVINCIA_ESTADO.SelectedValue == "-1")
            {
                Response.Write("<script>alert('Debe llenar todos los campos')</script>");
                return;
            }
            if(Request.QueryString["id"] != null)
            {
                string id = Request.QueryString["id"];
                objdll.Editar_Provincia(PROVINCIA_CODIGO.Text, PROVINCIA_NOMBRE.Text, PROVINCIA_OBSERVACION.Text, PROVINCIA_ESTADO.SelectedValue,id);
                Response.Redirect("./Ficha");

            }
            objdll.Insertar_Provincia(PROVINCIA_CODIGO.Text, PROVINCIA_NOMBRE.Text, PROVINCIA_OBSERVACION.Text, PROVINCIA_ESTADO.SelectedValue);

            Response.Redirect("./Ficha");

        }
    }
}