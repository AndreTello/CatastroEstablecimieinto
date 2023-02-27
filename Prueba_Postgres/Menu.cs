using Prueba_Postgres.Comerciante;
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
            Frm_Canton frm_Canton= new Frm_Canton();
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
    }
}
