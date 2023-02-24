using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoGIS
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario_login"] != null)
            {
                rol.Text = Session["usuario_login"] +" | " + Session["rol"].ToString();
                
            }
            else
            {
                Response.Redirect("/");   
            }
            if (Session["rol"].ToString() == "ADMIN")
            {
                adminLink.Visible= true;
                modLink.Visible= true;
            }
            if (Session["rol"].ToString() == "MOD")
            {
                modLink.Visible = true;
            }

        }
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("/");
        }

        protected void Unnamed_Load(object sender, EventArgs e)
        {

        }
    }
}