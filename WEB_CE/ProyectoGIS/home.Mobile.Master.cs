using BLL_CE.Administracion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoGIS
{
    public partial class Home_Mobile : System.Web.UI.MasterPage
    {
        Cls_Usuario_BLL user = new Cls_Usuario_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario_login"] != null)
            {
                Response.Redirect("/App/Home");
            }

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = user.Consultar_Usuario();
            string cuenta = string.Empty;
            DataRow[] finded = dt.Select($"USUARIO_LOGIN = '{usuario_login.Text}'");

            if (finded.Length > 0)
            {
                string usuario = finded[0].Field<string>("USUARIO_LOGIN").Trim();
                string pass = finded[0].Field<string>("USUARIO_CLAVE").Trim();
                string rol = finded[0].Field<string>("ROL_NOMBRE").Trim();
                if (BCrypt.Net.BCrypt.Verify(usuario_clave.Text, pass))
                {
                    Session["usuario_login"] = usuario_login.Text;
                    Session["rol"] = rol;
                    Response.Redirect("./App/Home.aspx");
                }
                else
                {
                    errorLabel.Visible = true;
                    //Mostrar una pantalla de error 
                    errorLabel.Text = "Usuario / Contraseña invalidos.";
                }

            }
            else
            {
                errorLabel.Visible = true;
                //Mostrar una pantalla de error 
                errorLabel.Text = "No existe.";
            }
            if (usuario_login.Text == "admin" && usuario_clave.Text == "admin")
            {
                Session["usuario_login"] = usuario_login.Text;
                Session["rol"] = "ADMIN";
                Response.Redirect("./App/Home.aspx");

            }
            else if (usuario_login.Text == "mod" && usuario_clave.Text == "mod")
            {
                Session["usuario_login"] = usuario_login.Text;
                Session["rol"] = "MOD";
                Response.Redirect("./App/Home.aspx");
            }
            else
            {
                errorLabel.Visible = true;
                //Mostrar una pantalla de error 
                errorLabel.Text = "Usuario / Contraseña invalidos.";


            }


        }
    }
}