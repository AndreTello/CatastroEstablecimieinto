using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoGIS.App
{
    public partial class GestionUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["rol"] != null)
            {
                if (Session["rol"].ToString() != "ADMIN")
                {
                    Response.Redirect("/App/Home");
                }
                
            }
            else
            {
                Response.Redirect("/");
            }
        }
    }
}