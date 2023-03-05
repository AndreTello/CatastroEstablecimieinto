using BLL_CE.Catastro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_Postgres.Puesto
{
    public partial class Frm_Puesto : Form
    {
        public Frm_Puesto()
        {
            InitializeComponent();
        }

        private void Frm_Puesto_Load(object sender, EventArgs e)
        {
            cmbestado.Items.Add("0");
            cmbestado.Items.Add("1");
            cmbestado.SelectedIndex = 0;
            Listar_Piso();
            Listar_Tipo_Area();
            Listar_Comerciante();
            Listar_Ayudante();
            Listar_Reemplazo();
            Listar_Documento_Puesto();
            Mostrar_Datos();
        }

        Cls_Puesto_BLL objbll = new Cls_Puesto_BLL();

        private string id = null;
        private bool editar = false;

        public void Mostrar_Datos()
        {
            Cls_Puesto_BLL objnew = new Cls_Puesto_BLL();
            datos.DataSource = objnew.Consultar_Puesto();
        }

        public void Limpiar()
        {
            cmbpiso.SelectedIndex = 0;
            cmbarea.SelectedIndex = 0;
            cmbcomerciante.SelectedIndex = 0;
            cmbayudante.SelectedIndex = 0;
            cmbreemplazo.SelectedIndex = 0;
            cmbdocumento.SelectedIndex = 0;
            txtpredio.Text = string.Empty;
            txtclave.Text = string.Empty;
            txtestadoc.Text = string.Empty;
            txtacabados.Text = string.Empty;
            txtparedes.Text = string.Empty;
            txtremodelacion.Text = string.Empty;
            cmbestado.SelectedIndex = 0;
        }

        private void Listar_Piso()
        {
            Cls_Piso_BLL objbll = new Cls_Piso_BLL();
            cmbpiso.DataSource = objbll.Listar_Piso();
            cmbpiso.DisplayMember = "piso_nombre";
            cmbpiso.ValueMember = "piso_id";
        }

        private void Listar_Tipo_Area()
        {
            Cls_Tipo_Area_BLL objbll = new Cls_Tipo_Area_BLL();
            cmbarea.DataSource = objbll.Listar_Tipo_Area();
            cmbarea.DisplayMember = "tipo_area_nombre";
            cmbarea.ValueMember = "tipo_area_id";
        }

        private void Listar_Comerciante()
        {
            Cls_Comerciante_BLL objbll = new Cls_Comerciante_BLL();
            cmbcomerciante.DataSource = objbll.Listar_Comerciante();
            cmbcomerciante.DisplayMember = "comerciante_nombres_representante_legal";
            cmbcomerciante.ValueMember = "comerciante_id";
        }

        private void Listar_Ayudante()
        {
            Cls_Ayudante_BLL objbll = new Cls_Ayudante_BLL();
            cmbayudante.DataSource = objbll.Listar_Ayudante();
            cmbayudante.DisplayMember = "ayudante_nombres";
            cmbayudante.ValueMember = "ayudante_id";
        }

        private void Listar_Reemplazo()
        {
            Cls_Reemplazo_BLL objbll = new Cls_Reemplazo_BLL();
            cmbreemplazo.DataSource = objbll.Listar_Reemplazo ();
            cmbreemplazo.DisplayMember = "reemplazo_nombres";
            cmbreemplazo.ValueMember = "reemplazo_id";
        }

        private void Listar_Documento_Puesto()
        {
            Cls_Documento_Puesto_BLL objbll = new Cls_Documento_Puesto_BLL();
            cmbdocumento.DataSource = objbll.Listar_Documento_Puesto();
            cmbdocumento.DisplayMember = "documento_puesto_nombre";
            cmbdocumento.ValueMember = "documento_puesto_id";
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            Mostrar_Datos();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {

                objbll.Insertar_Puesto(Convert.ToInt32(cmbpiso.SelectedValue), Convert.ToInt32(cmbarea.SelectedValue), Convert.ToInt32(cmbcomerciante.SelectedValue), Convert.ToInt32(cmbayudante.SelectedValue), Convert.ToInt32(cmbreemplazo.SelectedValue), Convert.ToInt32(cmbdocumento.SelectedValue), txtpredio.Text, txtclave.Text, txtestadoc.Text, txtacabados.Text, txtparedes.Text, txtremodelacion.Text, cmbestado.Text);
                MessageBox.Show("REGISTRADO CORRECTAMENTE");
                Mostrar_Datos();
                Limpiar();
            }
            if (editar == true)
            {
                objbll.Editar_Puesto(Convert.ToInt32(cmbpiso.SelectedValue), Convert.ToInt32(cmbarea.SelectedValue), Convert.ToInt32(cmbcomerciante.SelectedValue), Convert.ToInt32(cmbayudante.SelectedValue), Convert.ToInt32(cmbreemplazo.SelectedValue), Convert.ToInt32(cmbdocumento.SelectedValue), txtpredio.Text, txtclave.Text, txtestadoc.Text, txtacabados.Text, txtparedes.Text, txtremodelacion.Text, cmbestado.Text, id);
                MessageBox.Show("ACTUALIZADO CORRECTAMENTE");
                Mostrar_Datos();
                editar = false;
                Limpiar();
            }
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            if (datos.SelectedRows.Count > 0)
            {
                editar = true;
                cmbpiso.Text = datos.CurrentRow.Cells["piso_nombre"].Value.ToString();
                cmbarea.Text = datos.CurrentRow.Cells["tipo_area_nombre"].Value.ToString();
                cmbcomerciante.Text = datos.CurrentRow.Cells["comerciante_nombres_representante_legal"].Value.ToString();
                cmbayudante.Text = datos.CurrentRow.Cells["ayudante_nombres"].Value.ToString();
                cmbreemplazo.Text = datos.CurrentRow.Cells["reemplazo_nombres"].Value.ToString();
                cmbdocumento.Text = datos.CurrentRow.Cells["documento_puesto_nombre"].Value.ToString();
                txtpredio.Text = datos.CurrentRow.Cells["puesto_predio"].Value.ToString();
                txtclave.Text = datos.CurrentRow.Cells["puesto_clave_catastral"].Value.ToString();
                txtestadoc.Text = datos.CurrentRow.Cells["puesto_estado_conservacion"].Value.ToString();
                txtacabados.Text = datos.CurrentRow.Cells["puesto_acabados"].Value.ToString();
                txtparedes.Text = datos.CurrentRow.Cells["puesto_paredes"].Value.ToString();
                txtremodelacion.Text = datos.CurrentRow.Cells["puesto_remodelacion"].Value.ToString();
                cmbestado.Text = datos.CurrentRow.Cells["puesto_estado"].Value.ToString();
                id = datos.CurrentRow.Cells["puesto_id"].Value.ToString();
            }
            else
            {
                MessageBox.Show("SELECCIONE LA FILA A MODIFICAR");
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (datos.SelectedRows.Count > 0)
            {
                id = datos.CurrentRow.Cells["puesto_id"].Value.ToString();
                objbll.Eliminar_Puesto(id);
                MessageBox.Show("ELIMINADO CORRECTAMENTE");
                Mostrar_Datos();
                Limpiar();
            }
            else
            {
                MessageBox.Show("SELECCIONE LA FILA A ELIMINAR");
            }
        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("Ingrese el id a buscar");
            }
            else
            {
                Cls_Puesto_BLL objnew = new Cls_Puesto_BLL();
                datos.DataSource = objnew.Consultar_IdPuesto(txtid.Text);
                txtid.Text = string.Empty;
            }
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
