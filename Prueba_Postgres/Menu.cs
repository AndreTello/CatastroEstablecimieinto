using Prueba_Postgres.Administracion;
using Prueba_Postgres.Comerciante;
using Prueba_Postgres.EstatusSocial;
using Prueba_Postgres.GiroNegocio;
using Prueba_Postgres.Puesto;
using Prueba_Postgres.RazonSocioEconomicaDelComerciante;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_Postgres
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Provincia_Click(object sender, EventArgs e)
        {
            Frm_Provincia frm_Provincia = new Frm_Provincia();
            frm_Provincia.Show();
            this.Hide();
        }

        private void Canton_Click(object sender, EventArgs e)
        {
            Frm_Canton frm_Canton = new Frm_Canton();
            frm_Canton.Show();
            this.Hide();
        }

        private void Zona_Click(object sender, EventArgs e)
        {
            Frm_Zona frm_Zona = new Frm_Zona();
            frm_Zona.Show();
            this.Hide();
        }

        private void Parroquia_Click(object sender, EventArgs e)
        {
            Frm_Parroquia frm_Parroquia = new Frm_Parroquia();
            frm_Parroquia.Show();
            this.Hide();
        }

        private void Manzana_Click(object sender, EventArgs e)
        {
            Frm_Manzana frm_Manzana = new Frm_Manzana();
            frm_Manzana.Show();
            this.Hide();
        }

        private void Lote_Click(object sender, EventArgs e)
        {
            Frm_Lote frm_Lote = new Frm_Lote();
            frm_Lote.Show();
            this.Hide();
        }

        private void Administracion_Zonal_Click(object sender, EventArgs e)
        {
            Frm_Administracion_Zonal frm_Administracion = new Frm_Administracion_Zonal();
            frm_Administracion.Show();
            this.Hide();
        }

        private void Asociacion_Click(object sender, EventArgs e)
        {
            Frm_Asociacion frm_Asociacion = new Frm_Asociacion();
            frm_Asociacion.Show();
            this.Hide();
        }

        private void Tipo_Establecimiento_Click(object sender, EventArgs e)
        {
            Frm_Tipo_Establecimiento frm_Tipo_Establecimiento = new Frm_Tipo_Establecimiento();
            frm_Tipo_Establecimiento.Show();
            this.Hide();
        }

        private void Tipo_Intervencion_T_Click(object sender, EventArgs e)
        {
            Frm_Tipo_Intervencion_Tecnica_E frm_Tipo_Intervencion_Tecnica_E = new Frm_Tipo_Intervencion_Tecnica_E();
            frm_Tipo_Intervencion_Tecnica_E.Show();
            this.Hide();
        }

        private void Intervencion_Tecnica_E_Click(object sender, EventArgs e)
        {
            Frm_Intervencion_Tecnica_E frm_Intervencion_Tecnica_E = new Frm_Intervencion_Tecnica_E();
            frm_Intervencion_Tecnica_E.Show();
            this.Hide();
        }

        private void Establecimiento_Click(object sender, EventArgs e)
        {
            Frm_Establecimiento frm_Establecimiento = new Frm_Establecimiento();
            frm_Establecimiento.Show();
            this.Hide();
        }

        private void Tipo_Identificacion_Click(object sender, EventArgs e)
        {
            Frm_Tipo_Identificacion tipo_Identificacion = new Frm_Tipo_Identificacion();
            tipo_Identificacion.Show();
            this.Hide();
        }

        private void Tipo_Ocupante_Click(object sender, EventArgs e)
        {
            Frm_Tipo_Ocupante frm_Tipo_Ocupante = new Frm_Tipo_Ocupante();
            frm_Tipo_Ocupante.Show();
            this.Hide();
        }

        private void Comerciante_Click(object sender, EventArgs e)
        {
            Frm_Comerciante frm_Comerciante = new Frm_Comerciante();
            frm_Comerciante.Show();
            this.Hide();
        }

        private void Discapacidad_Click(object sender, EventArgs e)
        {
            Frm_Discapacidad frm_Discapacidad = new Frm_Discapacidad();
            frm_Discapacidad.Show();
            this.Hide();
        }

        private void Educacion_Click(object sender, EventArgs e)
        {
            Frm_Educacion frm_Educacion = new Frm_Educacion();
            frm_Educacion.Show();
            this.Hide();
        }

        private void Estado_Civil_Click(object sender, EventArgs e)
        {
            Frm_EstadoCivil frm_EstadoCivil = new Frm_EstadoCivil();
            frm_EstadoCivil.Show();
            this.Hide();
        }

        private void Etnia_Click(object sender, EventArgs e)
        {
            Frm_Etnia frm_Etnia = new Frm_Etnia();
            frm_Etnia.Show();
            this.Hide();
        }

        private void Genero_Click(object sender, EventArgs e)
        {
            Frm_Genero frm_Genero = new Frm_Genero();
            frm_Genero.Show();
            this.Hide();
        }

        private void Nacionalidad_Click(object sender, EventArgs e)
        {
            Frm_Nacionalidad frm_Nacionalidad = new Frm_Nacionalidad();
            frm_Nacionalidad.Show();
            this.Hide();
        }

        private void Razon_Social_Click(object sender, EventArgs e)
        {
            Frm_Razon_Social frm_Razon_Social = new Frm_Razon_Social();
            frm_Razon_Social.Show();
            this.Hide();
        }

        private void Ayudante_Click(object sender, EventArgs e)
        {
            Frm_Ayudante frm_Ayudante = new Frm_Ayudante();
            frm_Ayudante.Show();
            this.Hide();
        }

        private void Bloque_Click(object sender, EventArgs e)
        {
            Frm_Bloque frm_Bloque = new Frm_Bloque();
            frm_Bloque.Show();
            this.Hide();
        }

        private void Tipo_Area_Click(object sender, EventArgs e)
        {
            Frm_Tipo_Area frm_Tipo_Area = new Frm_Tipo_Area();
            frm_Tipo_Area.Show();
            this.Hide();
        }

        private void Tipo_Documento_Click(object sender, EventArgs e)
        {
            Frm_Tipo_Doc_Comerciante frm_Tipo_Documento = new Frm_Tipo_Doc_Comerciante();
            frm_Tipo_Documento.Show();
            this.Hide();
        }

        private void Reemplazo_Click(object sender, EventArgs e)
        {
            Frm_Reemplazo frm_Reemplazo = new Frm_Reemplazo();
            frm_Reemplazo.Show();
            this.Hide();
        }

        private void Piso_Click(object sender, EventArgs e)
        {
            Frm_Piso frm_Piso = new Frm_Piso();
            frm_Piso.Show();
            this.Hide();
        }

        private void Documento_Click(object sender, EventArgs e)
        {
            Frm_Documento_Comerciante frm_Documento = new Frm_Documento_Comerciante();
            frm_Documento.Show();
            this.Hide();
        }

        private void Tipo_Doc_Puesto_Click(object sender, EventArgs e)
        {
            Frm_Tipo_Doc_Puesto frm_Tipo_Doc_Puesto = new Frm_Tipo_Doc_Puesto();
            frm_Tipo_Doc_Puesto.Show();
            this.Hide();
        }

        private void Tipo_Familiar_Click(object sender, EventArgs e)
        {
            Frm_Tipo_Familiar frm_Tipo_Familiar = new Frm_Tipo_Familiar();
            frm_Tipo_Familiar.Show();
            this.Hide();
        }

        private void Familiar_Click(object sender, EventArgs e)
        {
            Frm_Familiar frm_Familiar = new Frm_Familiar();
            frm_Familiar.Show();
            this.Hide();
        }

        private void Tipo_Producto_Click(object sender, EventArgs e)
        {
            Frm_Tipo_Producto frm_Tipo_Producto = new Frm_Tipo_Producto();
            frm_Tipo_Producto.Show();
            this.Hide();
        }

        private void Giro_Negocio_Click(object sender, EventArgs e)
        {
            Frm_Giro_Negocio frm_Giro_Negocio = new Frm_Giro_Negocio();
            frm_Giro_Negocio.Show();
            this.Hide();
        }

        private void Rol_Click(object sender, EventArgs e)
        {
            Frm_Rol frm_Rol = new Frm_Rol();
            frm_Rol.Show();
            this.Hide();
        }

        private void Permiso_Click(object sender, EventArgs e)
        {
            Frm_Permiso frm_Permiso = new Frm_Permiso();
            frm_Permiso.Show();
            this.Hide();
        }

        private void Rol_Permiso_Click(object sender, EventArgs e)
        {
            Frm_Rol_Permiso frm_Rol_Permiso = new Frm_Rol_Permiso();
            frm_Rol_Permiso.Show();
            this.Hide();
        }

        private void Usuario_Click(object sender, EventArgs e)
        {
            Frm_Usuario frm_Usuario = new Frm_Usuario();
            frm_Usuario.Show();
            this.Hide();
        }

        private void Puesto_Click(object sender, EventArgs e)
        {
            Frm_Puesto frm_Puesto = new Frm_Puesto();
            frm_Puesto.Show();
            this.Hide();
        }

        private void Documento_Puesto_Click(object sender, EventArgs e)
        {
            Frm_Documento_Puesto frm_Documento_Puesto = new Frm_Documento_Puesto();
            frm_Documento_Puesto.Show();
            this.Hide();
        }

        private void Estatus_Legal_Click(object sender, EventArgs e)
        {
            Frm_Estatus_Legal frm_Estatus_Legal = new Frm_Estatus_Legal();
            frm_Estatus_Legal.Show();
            this.Hide();
        }
    }
}
