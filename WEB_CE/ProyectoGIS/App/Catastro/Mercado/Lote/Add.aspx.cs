using BLL_CE.Catastro;
using System;
using System.Data;
using System.Web.UI.WebControls;
namespace ProyectoGIS.App.Catastro.Lote
{
    public partial class Add : System.Web.UI.Page
    {
        Cls_Lote_BLL objdll = new Cls_Lote_BLL();
        Cls_Manzana_BLL obj_manzana = new Cls_Manzana_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MANZANA_ID.DataSource = obj_manzana.Listar_Manzana();
                MANZANA_ID.DataTextField = "MANZANA_NOMBRE";
                MANZANA_ID.DataValueField = "MANZANA_ID";
                MANZANA_ID.DataBind();
                MANZANA_ID.Items.Insert(0, new ListItem("-- Seleccione una manzana --", ""));
                if (Request.QueryString["id"] != null)
                {
                    string id = Request.QueryString["id"];
                    DataTable dt = objdll.Consultar_IdLote(id);
                    if (dt != null)
                    {
                        LOTE_NOMBRE.Text = dt.Rows[0]["LOTE_NOMBRE"].ToString().Trim();
                        LOTE_OBSERVACION.Text = dt.Rows[0]["LOTE_OBSERVACION"].ToString().Trim();
                        LOTE_CODIGO.Text = dt.Rows[0]["LOTE_CODIGO"].ToString().Trim();
                        LOTE_ESTADO.SelectedValue = dt.Rows[0]["LOTE_ESTADO"].ToString();
                        MANZANA_ID.SelectedValue = dt.Rows[0]["MANZANA_ID"].ToString();
                        btnGuardar.Text = "Actualizar";
                    }
                }
            }
            
        }
        
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MANZANA_ID.SelectedValue == "" || MANZANA_ID.SelectedValue == "-1" || LOTE_CODIGO.Text == String.Empty || LOTE_NOMBRE.Text == String.Empty || LOTE_ESTADO.SelectedValue == "" || LOTE_ESTADO.SelectedValue == "-1")
            {
                Response.Write("<script>alert('Debe llenar todos los campos')</script>");
                return;
            }
            if (Request.QueryString["id"] != null)
            {
                string id = Request.QueryString["id"];
                objdll.Editar_Lote(id, Convert.ToInt32(MANZANA_ID.SelectedValue), LOTE_CODIGO.Text, LOTE_NOMBRE.Text, LOTE_OBSERVACION.Text, LOTE_ESTADO.SelectedValue);
                Response.Redirect("./Ficha");
            }
            else
            {
                objdll.Insertar_Lote(Convert.ToInt32(MANZANA_ID.SelectedValue), LOTE_CODIGO.Text, LOTE_NOMBRE.Text, LOTE_OBSERVACION.Text, LOTE_ESTADO.SelectedValue);
                Response.Redirect("./Ficha");
            }
            

        }

    }
}