using BLL_CE.Catastro;
using System;
using System.Web.UI.WebControls;
namespace ProyectoGIS.App.Catastro.RazonSocioEconomicaDelComerciante.RazonSocial
{
    public partial class Add : System.Web.UI.Page
    {
        Cls_Identificacion_Socio_Economica_BLL objdll = new Cls_Identificacion_Socio_Economica_BLL();
        Cls_Etnia_BLL objdll2 = new Cls_Etnia_BLL();
        Cls_Nivel_Educacion_BLL objdll3 = new Cls_Nivel_Educacion_BLL();
        Cls_Nacionalidad_BLL objdll4 = new Cls_Nacionalidad_BLL();
        Cls_Discapacidad_BLL objdll5 = new Cls_Discapacidad_BLL();
        Cls_Estado_Civil_BLL objdll6 = new Cls_Estado_Civil_BLL();
        Cls_Genero_BLL objdll7 = new Cls_Genero_BLL();
        Cls_Comerciante_BLL objd8 = new Cls_Comerciante_BLL();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                COMERCIANTE_ID.DataSource = objd8.Consultar_Comerciante();
                COMERCIANTE_ID.DataTextField = "comerciante_nombres_representante_legal";
                COMERCIANTE_ID.DataValueField = "COMERCIANTE_ID";
                COMERCIANTE_ID.DataBind();

                ETNIA_ID.DataSource = objdll2.Consultar_Etnia();
                ETNIA_ID.DataTextField = "ETNIA_NOMBRE";
                ETNIA_ID.DataValueField = "ETNIA_ID";
                ETNIA_ID.DataBind();

                NIVEL_EDUCACION_ID.DataSource = objdll3.Consultar_Nivel_Educacion();
                NIVEL_EDUCACION_ID.DataTextField = "NIVEL_EDUCACION_NOMBRE";
                NIVEL_EDUCACION_ID.DataValueField = "NIVEL_EDUCACION_ID";
                NIVEL_EDUCACION_ID.DataBind();

                NACIONALIDAD_ID.DataSource = objdll4.Consultar_Nacionalidad();
                NACIONALIDAD_ID.DataTextField = "NACIONALIDAD_NOMBRE";
                NACIONALIDAD_ID.DataValueField = "NACIONALIDAD_ID";
                NACIONALIDAD_ID.DataBind();

                DISCAPACIDAD_ID.DataSource = objdll5.Consultar_Discapacidad();
                DISCAPACIDAD_ID.DataTextField = "DISCAPACIDAD_NOMBRE";
                DISCAPACIDAD_ID.DataValueField = "DISCAPACIDAD_ID";
                DISCAPACIDAD_ID.DataBind();

                ESTADO_CIVIL_ID.DataSource = objdll6.Consultar_Estado_Civil();
                ESTADO_CIVIL_ID.DataTextField = "ESTADO_CIVIL_NOMBRE";
                ESTADO_CIVIL_ID.DataValueField = "ESTADO_CIVIL_ID";
                ESTADO_CIVIL_ID.DataBind();

                GENERO_ID.DataSource = objdll7.Consultar_Genero();
                GENERO_ID.DataTextField = "GENERO_NOMBRE";
                GENERO_ID.DataValueField = "GENERO_ID";
                GENERO_ID.DataBind();

            }

            IDENTIFICACION_SOCIO_ECONOMICA_ESTADO.Items.Insert(0, new ListItem("-- Seleccione un Estado --", ""));
            IDENTIFICACION_SOCIO_ECONOMICA_ESTADO.Items.Insert(1, new ListItem("Activo", "1"));
            IDENTIFICACION_SOCIO_ECONOMICA_ESTADO.Items.Insert(2, new ListItem("Inactivo", "0"));
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (COMERCIANTE_ID.SelectedValue == "" || COMERCIANTE_ID.SelectedValue == "-1" || ETNIA_ID.SelectedValue == "" || ETNIA_ID.SelectedValue == "-1" ||
                NIVEL_EDUCACION_ID.SelectedValue == "" || NIVEL_EDUCACION_ID.SelectedValue == "-1" || DISCAPACIDAD_ID.SelectedValue == "" || DISCAPACIDAD_ID.SelectedValue == "-1" ||
                ESTADO_CIVIL_ID.SelectedValue == "" || ESTADO_CIVIL_ID.SelectedValue == "-1" || GENERO_ID.SelectedValue == "" || GENERO_ID.SelectedValue == "-1" ||
                IDENTIFICACION_SOCIO_ECONOMICA_JEFE_FAMILIA.Text == string.Empty || IDENTIFICACION_SOCIO_ECONOMICA_NUMERO_DEPENDIENTES.Text == string.Empty ||
                IDENTIFICACION_SOCIO_ECONOMICA_PARENTESCO.Text == string.Empty || IDENTIFICACION_SOCIO_ECONOMICA_DEPENDIENTES.Text == string.Empty)
            {
                Response.Write("<script>alert('Debe seleccionar un comerciante')</script>");
            }

            objdll.Insertar_Identificacion_Socio_Economica(Convert.ToInt32(COMERCIANTE_ID.SelectedValue), Convert.ToInt32(ETNIA_ID.SelectedValue), Convert.ToInt32(GENERO_ID.SelectedValue), Convert.ToInt32(ESTADO_CIVIL_ID.SelectedValue), Convert.ToInt32(NACIONALIDAD_ID.SelectedValue), Convert.ToInt32(NIVEL_EDUCACION_ID.SelectedValue), Convert.ToInt32(DISCAPACIDAD_ID.SelectedValue), IDENTIFICACION_SOCIO_ECONOMICA_JEFE_FAMILIA.Text, IDENTIFICACION_SOCIO_ECONOMICA_DEPENDIENTES.Text, IDENTIFICACION_SOCIO_ECONOMICA_NUMERO_DEPENDIENTES.Text, IDENTIFICACION_SOCIO_ECONOMICA_PARENTESCO.Text, IDENTIFICACION_SOCIO_ECONOMICA_ESTADO.SelectedValue);
            Response.Redirect("./Ficha.aspx");

        }
    }
}