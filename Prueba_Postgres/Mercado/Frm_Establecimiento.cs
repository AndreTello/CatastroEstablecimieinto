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

namespace Prueba_Postgres
{
    public partial class Frm_Establecimiento : Form
    {
        public Frm_Establecimiento()
        {
            InitializeComponent();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void Frm_Establecimiento_Load(object sender, EventArgs e)
        {
            cmbestado.Items.Add("0");
            cmbestado.Items.Add("1");
            cmbestado.SelectedIndex = 0;
            Listar_Lote();
            Listar_Administracion();
            Listar_Tipos();
            Listar_Asociacion();
            Listar_Intervencion();
            Mostrar_Datos();
        }

        Cls_Establecimiento_BLL objbll = new Cls_Establecimiento_BLL();

        private string id = null;
        private bool editar = false;

        public void Mostrar_Datos()
        {
            Cls_Establecimiento_BLL objnew = new Cls_Establecimiento_BLL();
            datos.DataSource = objnew.Consultar_Establecimiento();
        }

        public void Limpiar()
        {
            cmblote.SelectedIndex = 0;
            cmbadministracion.SelectedIndex = 0;
            cmbtipo.SelectedIndex = 0;
            cmbasociacion.SelectedIndex = 0;
            cmbintervencion.SelectedIndex = 0;
            txtpredio.Text = string.Empty;
            txtclave.Text = string.Empty;            
            txtnomvial.Text = string.Empty;
            txtcprincipal.Text = string.Empty;
            txtcsecundaria.Text = string.Empty;
            txtparqueadero.Text = string.Empty;
            txtnparqueadero.Text = string.Empty;
            txtdias.Text = string.Empty;
            txthorarios.Text = string.Empty;
            cmbestado.SelectedIndex = 0;
        }

        private void Listar_Lote()
        {
            Cls_Lote_BLL objbll = new Cls_Lote_BLL();
            cmblote.DataSource = objbll.Listar_Lote();
            cmblote.DisplayMember = "lote_nombre";
            cmblote.ValueMember = "lote_id";
        }

        private void Listar_Administracion()
        {
            Cls_Administracion_Zonal_BLL objbll = new Cls_Administracion_Zonal_BLL();
            cmbadministracion.DataSource = objbll.Listar_Administracion_Zonal();
            cmbadministracion.DisplayMember = "administracion_zonal_nombre";
            cmbadministracion.ValueMember = "administracion_zonal_id";
        }

        private void Listar_Tipos()
        {
            Cls_Tipo_Establecimiento_BLL objbll = new Cls_Tipo_Establecimiento_BLL();
            cmbtipo.DataSource = objbll.Listar_Tipo_Establecimiento();
            cmbtipo.DisplayMember = "tipo_establecimiento_nombre";
            cmbtipo.ValueMember = "tipo_establecimiento_id";
        }

        private void Listar_Asociacion()
        {
            Cls_Asociacion_BLL objbll = new Cls_Asociacion_BLL();
            cmbasociacion.DataSource = objbll.Listar_Asociacion();
            cmbasociacion.DisplayMember = "asociacion_nombre";
            cmbasociacion.ValueMember = "asociacion_id";
        }

        private void Listar_Intervencion()
        {
            Cls_Intervencion_Tecnica_Establecimiento_BLL objbll = new Cls_Intervencion_Tecnica_Establecimiento_BLL();
            cmbintervencion.DataSource = objbll.Listar_Intervencion_Tecnica_Establecimiento();
            cmbintervencion.DisplayMember = "intervencion_tecnica_establecimiento_nombre";
            cmbintervencion.ValueMember = "intervencion_tecnica_establecimiento_id";
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {

                objbll.Insertar_Establecimiento(Convert.ToInt32(cmblote.SelectedValue), Convert.ToInt32(cmbadministracion.SelectedValue), Convert.ToInt32(cmbtipo.SelectedValue), Convert.ToInt32(cmbasociacion.SelectedValue), Convert.ToInt32(cmbintervencion.SelectedValue), txtpredio.Text, txtclave.Text, txtnomvial.Text, txtcprincipal.Text, txtcsecundaria.Text, txtparqueadero.Text, txtnparqueadero.Text, txtdias.Text, txthorarios.Text, cmbestado.Text);
                MessageBox.Show("REGISTRADO CORRECTAMENTE");
                Mostrar_Datos();
                Limpiar();
            }
            if (editar == true)
            {
                objbll.Editar_Establecimiento(Convert.ToInt32(cmblote.SelectedValue), Convert.ToInt32(cmbadministracion.SelectedValue), Convert.ToInt32(cmbtipo.SelectedValue), Convert.ToInt32(cmbasociacion.SelectedValue), Convert.ToInt32(cmbintervencion.SelectedValue), txtpredio.Text, txtclave.Text, txtnomvial.Text, txtcprincipal.Text, txtcsecundaria.Text, txtparqueadero.Text, txtnparqueadero.Text, txtdias.Text, txthorarios.Text, cmbestado.Text, id);
                MessageBox.Show("ACTUALIZADO CORRECTAMENTE");
                Mostrar_Datos();
                editar = false;
                Limpiar();
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
                Cls_Establecimiento_BLL objnew = new Cls_Establecimiento_BLL();
                datos.DataSource = objnew.Consultar_IdEstablecimiento(txtid.Text);
                txtid.Text = string.Empty;
            }

        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            if (datos.SelectedRows.Count > 0)
            {
                editar = true;
                cmblote.Text = datos.CurrentRow.Cells["lote_nombre"].Value.ToString();
                cmbadministracion.Text = datos.CurrentRow.Cells["administracion_zonal_nombre"].Value.ToString();
                cmbtipo.Text = datos.CurrentRow.Cells["tipo_establecimiento_nombre"].Value.ToString();
                cmbasociacion.Text = datos.CurrentRow.Cells["asociacion_nombre"].Value.ToString();
                cmbintervencion.Text = datos.CurrentRow.Cells["intervencion_tecnica_establecimiento_nombre"].Value.ToString();
                txtpredio.Text = datos.CurrentRow.Cells["establecimiento_predio"].Value.ToString();
                txtclave.Text = datos.CurrentRow.Cells["establecimiento_clave_catastral"].Value.ToString();
                txtnomvial.Text = datos.CurrentRow.Cells["establecimiento_nomenclatura_vial"].Value.ToString();
                txtcprincipal.Text = datos.CurrentRow.Cells["establecimiento_calle_principal"].Value.ToString();
                txtcsecundaria.Text = datos.CurrentRow.Cells["establecimiento_calle_secundaria"].Value.ToString();
                txtparqueadero.Text = datos.CurrentRow.Cells["establecimiento_paqueadero"].Value.ToString();
                txtnparqueadero.Text = datos.CurrentRow.Cells["establecimiento_numero_parqueadero"].Value.ToString();
                txtdias.Text = datos.CurrentRow.Cells["establecimiento_dias_apertura"].Value.ToString();
                txthorarios.Text = datos.CurrentRow.Cells["establecimiento_horario_atencion"].Value.ToString();
                cmbestado.Text = datos.CurrentRow.Cells["establecimiento_estado"].Value.ToString();
                id = datos.CurrentRow.Cells["establecimiento_id"].Value.ToString();
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
                id = datos.CurrentRow.Cells["establecimiento_id"].Value.ToString();
                objbll.Eliminar_Establecimiento(id);
                MessageBox.Show("ELIMINADO CORRECTAMENTE");
                Mostrar_Datos();
                Limpiar();
            }
            else
            {
                MessageBox.Show("SELECCIONE LA FILA A ELIMINAR");
            }
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            Mostrar_Datos();
        }
    }
}
