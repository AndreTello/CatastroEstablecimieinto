using BLL_CE.Administracion;
using System;
using BCrypt.Net;
using System.Data;
using System.Web.UI.WebControls;

namespace ProyectoGIS.App.Administracion.GestionUsuario
{
    public partial class Add : System.Web.UI.Page
    {
        Cls_Usuario_BLL user = new Cls_Usuario_BLL();
        Cls_Rol_BLL rol = new Cls_Rol_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ROL_ID.DataSource = rol.Listar_Rol();
                ROL_ID.DataTextField = "ROL_NOMBRE";
                ROL_ID.DataValueField = "ROL_ID";
                ROL_ID.DataBind();
                ROL_ID.Items.Insert(0, new ListItem("-- Seleccione un Rol --", ""));

                if (Request.QueryString["id"] != null)
                {
                    string userId = Request.QueryString["id"];

                    // Obtener los datos del usuario correspondiente al ID
                    // y cargarlos en los controles de formulario
                    DataTable usuario = user.Consultar_IdUsuario(userId);
                     DataRow[] usert = usuario.Select($"USUARIO_ID = '{userId}'");
                    if (usert.Length == 1)
                    {
                        DataRow usr = usert[0];
                        USUARIO_LOGIN.Text = usr.Field<string>("USUARIO_LOGIN").Trim();
                        USUARIO_CLAVE.Text = usr.Field<string>("USUARIO_CLAVE").Trim();
                        USUARIO_CEDULA.Text = usr.Field<string>("USUARIO_CEDULA").Trim();
                        USUARIO_APELLIDOS.Text = usr.Field<string>("USUARIO_APELLIDOS").Trim();
                        USUARIO_NOMBRES.Text = usr.Field<string>("USUARIO_NOMBRES").Trim();
                        USUARIO_MAIL.Text = usr.Field<string>("USUARIO_MAIL").Trim();
                        USUARIO_DIRECCION.Text = usr.Field<string>("USUARIO_DIRECCION").Trim();
                        USUARIO_TELEFONO.Text = usr.Field<string>("USUARIO_TELEFONO").Trim();
                        USUARIO_ESTADO.SelectedValue = ""+usr.Field<int>("USUARIO_ESTADO");
                        ROL_ID.SelectedValue = ""+usr.Field<int>("ROL_ID");

                        // Cambiar el texto del botón "Guardar" a "Actualizar"
                        btnGuardar.Text = "Actualizar";
                    }
                }
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (USUARIO_APELLIDOS.Text == string.Empty || USUARIO_CEDULA.Text == string.Empty || USUARIO_CLAVE.Text == string.Empty || USUARIO_DIRECCION.Text == string.Empty || USUARIO_LOGIN.Text == string.Empty || USUARIO_MAIL.Text == string.Empty || USUARIO_NOMBRES.Text == string.Empty || USUARIO_TELEFONO.Text == string.Empty || ROL_ID.SelectedValue == "" || USUARIO_ESTADO.SelectedValue == "")
            {
                Response.Write("<script>alert('Debe llenar todos los campos')</script>");

                return;
            }
            if (Request.QueryString["id"] != null)
            {
                string userId = Request.QueryString["id"];
                user.Editar_Usuario(userId,Convert.ToInt32(ROL_ID.SelectedValue), USUARIO_LOGIN.Text, BCrypt.Net.BCrypt.HashPassword(USUARIO_CLAVE.Text), USUARIO_CEDULA.Text, USUARIO_APELLIDOS.Text, USUARIO_NOMBRES.Text, USUARIO_MAIL.Text, USUARIO_DIRECCION.Text, USUARIO_TELEFONO.Text, USUARIO_ESTADO.SelectedValue);
                Response.Redirect("./GestionUsuario");
            }
            else
            {
                // Insertar el usuario
                //user.Insertar_Usuario(Convert.ToInt32(ROL_ID.SelectedValue), USUARIO_LOGIN.Text, USUARIO_CLAVE.Text, USUARIO_CEDULA.Text, USUARIO_APELLIDOS.Text, USUARIO_NOMBRES.Text, USUARIO_MAIL.Text, USUARIO_DIRECCION.Text, USUARIO_TELEFONO.Text, USUARIO_ESTADO.SelectedValue
                user.Insertar_Usuario(Convert.ToInt32(ROL_ID.SelectedValue), USUARIO_LOGIN.Text, BCrypt.Net.BCrypt.HashPassword(USUARIO_CLAVE.Text), USUARIO_CEDULA.Text, USUARIO_APELLIDOS.Text, USUARIO_NOMBRES.Text, USUARIO_MAIL.Text, USUARIO_DIRECCION.Text, USUARIO_TELEFONO.Text, USUARIO_ESTADO.SelectedValue );
                Response.Redirect("./GestionUsuario");
            }
        }
    }
}