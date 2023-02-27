using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_CE;
using BLL_CE.Catastro;

namespace ProyectoGIS.App.Catastro.Provincia
{
    public partial class Ficha : System.Web.UI.Page
    {
        //Instanciar BLL_CE
        Cls_Provincia_BLL objdll = new Cls_Provincia_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            BindData();
        }
        protected void MiTabla_RowEditing(object sender, GridViewEditEventArgs e)
        {
            MiTabla.EditIndex = e.NewEditIndex;
            BindData();
        }
        protected void MiTabla_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            MiTabla.EditIndex = -1;
            BindData();
        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            LinkButton btnEliminar = (LinkButton)(sender);
            string provincia_id = btnEliminar.CommandArgument;

            // Lógica para eliminar la provincia con el provincia_id especificado
            // ...
            objdll.Eliminar_Provincia(provincia_id);
            Response.AddHeader("REFRESH", "1;URL=./Ficha.aspx");
        }
        protected void BindData()
        {
            DataTable dt = objdll.Consultar_Provincia();
            MiTabla.DataSource = dt;
            MiTabla.DataBind();
        }
        protected void MiTabla_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string id = ((TextBox)MiTabla.Rows[e.RowIndex].FindControl("txtId")).Text;
            string codigo = ((TextBox)MiTabla.Rows[e.RowIndex].FindControl("txtCodigo")).Text;
            string nombre = ((TextBox)MiTabla.Rows[e.RowIndex].FindControl("txtNombre")).Text;
            string estado = ((TextBox)MiTabla.Rows[e.RowIndex].FindControl("txtEstado")).Text;
            string observacion = ((TextBox)MiTabla.Rows[e.RowIndex].FindControl("txtObservacion")).Text;


            // Llamar al método que actualiza los datos en la base de datos
            objdll.Editar_Provincia(codigo, nombre, observacion, estado, id);

            MiTabla.EditIndex = -1;

            // Volver a enlazar los datos
            BindData();
        }
    }
}