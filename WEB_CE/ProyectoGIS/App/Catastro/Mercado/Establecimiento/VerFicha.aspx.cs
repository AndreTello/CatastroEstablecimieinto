using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using BLL_CE.Catastro;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using iTextSharp.tool.xml.html.table;
using System.Web.UI.HtmlControls;
using iTextSharp.tool.xml.html;
using System.Net;
using System.Drawing;
using Image = iTextSharp.text.Image;

namespace ProyectoGIS.App.Catastro.Mercado.Establecimiento
{
    public partial class VerFicha : System.Web.UI.Page
    {
        Cls_Establecimiento_BLL objdll_Est = new Cls_Establecimiento_BLL();
        Cls_Intervencion_Tecnica_Establecimiento_BLL objdll_int = new Cls_Intervencion_Tecnica_Establecimiento_BLL();
        Cls_Tipo_Establecimiento_BLL objdll_tipo = new Cls_Tipo_Establecimiento_BLL();
        Cls_Tipo_Identificacion_BLL objdll_ide = new Cls_Tipo_Identificacion_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {

            string id = Request.QueryString["id"];
            DataTable FichaMercado = objdll_Est.Consultar_Establecimiento();
            DataRow[] FichaMercadoFiltrada = FichaMercado.Select($"ESTABLECIMIENTO_ID = '{id}'");
            DataTable dt = objdll_int.Consultar_IdIntervencion_Tecnica_Establecimiento(id);
            DataTable dt2 = objdll_tipo.Consultar_IdTipo_Establecimiento(id);
            DataTable dt3 = 
            if(FichaMercadoFiltrada.Length == 1)
            {
                DataRow ficha = FichaMercadoFiltrada[0];

                //Primera columna
                E_PREDIO.Text = ficha.Field<string>("establecimiento_predio");
                E_CLAVE_C.Text = ficha.Field<string>("ESTABLECIMIENTO_CLAVE_CATASTRAL");
                E_NOMENCLATURA.Text = ficha.Field<string>("ESTABLECIMIENTO_NOMENCLATURA_VIAL");
                E_ADMINISTRACION_Z.Text = ficha.Field<string>("ADMINISTRACION_ZONAL_NOMBRE");
                E_PARROQUIA.Text = ficha.Field<string>("LOTE_NOMBRE");
                E_IDENTIFICACION.Text = dt2.Rows[0]["tipo_establecimiento_nombre"].ToString();

                E_NOMBRE_ASOCIACION.Text = ficha.Field<string>("ASOCIACION_NOMBRE");
                E_PARQUEADERO.Text = ficha.Field<string>("ESTABLECIMIENTO_PAQUEADERO");
                E_DIAS_APERTURA.Text = ficha.Field<string>("ESTABLECIMIENTO_DIAS_APERTURA");
                //E_REMODELACION.Text = ficha.Field<string>("INTERVENCION_TECNICA_ESTABLECIMIENTO_NOMBRE");

                //Segunda columna
                E_CALLE_P.Text = ficha.Field<string>("ESTABLECIMIENTO_CALLE_PRINCIPAL");
                E_N_PARQUEADERO.Text = ficha.Field<string>("ESTABLECIMIENTO_NUMERO_PARQUEADERO");
                E_HORA_AT.Text = ficha.Field<string>("ESTABLECIMIENTO_HORARIO_ATENCION");
                E_TIPO_I.Text = ficha.Field<string>("INTERVENCION_TECNICA_ESTABLECIMIENTO_NOMBRE");

                //Tercera columna
                E_CALLE_S.Text = ficha.Field<string>("ESTABLECIMIENTO_CALLE_SECUNDARIA");
                E_ANO_INTER.Text = dt.Rows[0]["intervencion_tecnica_establecimiento_fecha_inicio"].ToString();

            }
        }
        public void generarPDF()
        {

            // Crear una instancia del Document.
            Document doc = new Document();

            // Crear una instancia del PdfWriter y asociarlo con el Document.
            PdfWriter.GetInstance(doc, new FileStream("C:\\xd\\Code.pdf", FileMode.Create));

            // Abrir el Document.
            doc.Open();

            // Crear una instancia del WebClient y obtener el contenido de la página ASPX.
            WebClient wc = new WebClient();
            byte[] contenido = wc.DownloadData("E:\\Works\\SefaKS\\Git\\CatastroEstablecimieinto\\WEB_CE\\ProyectoGIS\\App\\Catastro\\Mercado\\Establecimiento\\VerFicha.aspx");

            // Crear una instancia del MemoryStream y cargar el contenido de la página ASPX.
            MemoryStream ms = new MemoryStream(contenido);

            // Crear una instancia del Image y cargar la imagen desde el MemoryStream.
            Image img = Image.GetInstance(ms);

            // Agregar la imagen al Document.
            doc.Add(img);

            // Cerrar el Document y el PdfWriter.
            doc.Close();

          

        }

        protected void btnGenerar_Click(object sender, EventArgs e)
        {
            generarPDF();
        }
    }
}