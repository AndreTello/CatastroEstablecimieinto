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

namespace Prueba_Postgres.EstatusSocial
{
    public partial class Frm_Estatus_Legal : Form
    {
        public Frm_Estatus_Legal()
        {
            InitializeComponent();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void Frm_Estatus_Legal_Load(object sender, EventArgs e)
        {
            cmbestado.Items.Add("0");
            cmbestado.Items.Add("1");
            cmbestado.SelectedIndex = 0;
            Listar_Puesto();
            Listar_Giro_Negocio();
            Mostrar_Datos();
        }

        Cls_Estatus_Legal_BLL objbll = new Cls_Estatus_Legal_BLL();

        private string id = null;
        private bool editar = false;

        public void Mostrar_Datos()
        {
            Cls_Estatus_Legal_BLL objnew = new Cls_Estatus_Legal_BLL();
            datos.DataSource = objnew.Consultar_Estatus_Legal();
        }

        public void Limpiar()
        {
            cmbpuesto.SelectedIndex = 0;
            cmbnegocio.SelectedIndex = 0;
            txtfechao.Text = string.Empty;
            txthistorial.Text = string.Empty;
            txtestadoa.Text = string.Empty;
            txtnumeropa.Text = string.Empty;
            txtcondicionu.Text = string.Empty;
            txtnotificacion.Text = string.Empty;
            txtfecharn.Text = string.Empty;
            txtconveniono.Text = string.Empty;
            txtconvenion.Text = string.Empty;
            txtconveniof.Text = string.Empty;
            txtcondicion.Text = string.Empty;
            txtcambiog.Text = string.Empty;
            txtnumerocg.Text = string.Empty;
            txtfechacg.Text = string.Empty;
            txtsanciones.Text = string.Empty;
            txtnumerors.Text = string.Empty;
            txtfechars.Text = string.Empty;
            cmbestado.SelectedIndex = 0;
        }

        private void Listar_Puesto()
        {
            Cls_Puesto_BLL objbll = new Cls_Puesto_BLL();
            cmbpuesto.DataSource = objbll.Listar_Puesto();
            cmbpuesto.DisplayMember = "puesto_clave_catastral";
            cmbpuesto.ValueMember = "puesto_id";
        }

        private void Listar_Giro_Negocio()
        {
            Cls_Giro_Negocio_BLL objbll = new Cls_Giro_Negocio_BLL();
            cmbnegocio.DataSource = objbll.Listar_Giro_Negocio();
            cmbnegocio.DisplayMember = "giro_negocio_nombre";
            cmbnegocio.ValueMember = "giro_negocio_id";
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            Mostrar_Datos();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {

                objbll.Insertar_Estatus_Legal(Convert.ToInt32(cmbpuesto.SelectedValue), Convert.ToInt32(cmbnegocio.SelectedValue), txtfechao.Text, txthistorial.Text, txtestadoa.Text, txtnumeropa.Text, txtcondicionu.Text, txtnotificacion.Text, txtfecharn.Text, txtconveniono.Text, txtconvenion.Text, txtconveniof.Text, txtcondicion.Text, txtcambiog.Text, txtnumerocg.Text, txtfechacg.Text, txtsanciones.Text, txtnumerors.Text, txtfechars.Text, cmbestado.Text);
                MessageBox.Show("REGISTRADO CORRECTAMENTE");
                Mostrar_Datos();
                Limpiar();
            }
            if (editar == true)
            {
                objbll.Editar_Estatus_Legal(Convert.ToInt32(cmbpuesto.SelectedValue), Convert.ToInt32(cmbnegocio.SelectedValue), txtfechao.Text, txthistorial.Text, txtestadoa.Text, txtnumeropa.Text, txtcondicionu.Text, txtnotificacion.Text, txtfecharn.Text, txtconveniono.Text, txtconvenion.Text, txtconveniof.Text, txtcondicion.Text, txtcambiog.Text, txtnumerocg.Text, txtfechacg.Text, txtsanciones.Text, txtnumerors.Text, txtfechars.Text, cmbestado.Text, id);
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
                cmbpuesto.Text = datos.CurrentRow.Cells["puesto_clave_catastral"].Value.ToString();
                cmbnegocio.Text = datos.CurrentRow.Cells["giro_negocio_nombre"].Value.ToString();
                txtfechao.Text = datos.CurrentRow.Cells["estatus_legal_fecha_ocupacion"].Value.ToString();
                txthistorial.Text = datos.CurrentRow.Cells["estatus_legal_historial"].Value.ToString();
                txtestadoa.Text = datos.CurrentRow.Cells["estatus_legal_estado_adjudicado"].Value.ToString();
                txtnumeropa.Text = datos.CurrentRow.Cells["estatus_legal_numero_puesto_adjudicado"].Value.ToString();
                txtcondicionu.Text = datos.CurrentRow.Cells["estatus_legal_condicion_uso"].Value.ToString();
                txtnotificacion.Text = datos.CurrentRow.Cells["estatus_legal_notificacion"].Value.ToString();
                txtfecharn.Text = datos.CurrentRow.Cells["estatus_legal_fecha_resolucion_notificacion"].Value.ToString();
                txtconveniono.Text = datos.CurrentRow.Cells["estatus_legal_convenio_nombre"].Value.ToString();
                txtconvenion.Text = datos.CurrentRow.Cells["estatus_legal_convenio_numero"].Value.ToString();
                txtconveniof.Text = datos.CurrentRow.Cells["estatus_legal_convenio_fecha"].Value.ToString();
                txtcondicion.Text = datos.CurrentRow.Cells["estatus_legal_condicion"].Value.ToString();
                txtcambiog.Text = datos.CurrentRow.Cells["estatus_legal_cambio_giro"].Value.ToString();
                txtnumerocg.Text = datos.CurrentRow.Cells["estatus_legal_numero_oficio_cambio_giro"].Value.ToString();
                txtfechacg.Text = datos.CurrentRow.Cells["estatus_legal_fecha_cambio_giro"].Value.ToString();
                txtsanciones.Text = datos.CurrentRow.Cells["estatus_legal_sanciones"].Value.ToString();
                txtnumerors.Text = datos.CurrentRow.Cells["estatus_legal_numero_resolucion_sancion"].Value.ToString();
                txtfechars.Text = datos.CurrentRow.Cells["estatus_legal_fecha_resolucion_sancion"].Value.ToString();
                cmbestado.Text = datos.CurrentRow.Cells["estatus_legal_estado"].Value.ToString();
                id = datos.CurrentRow.Cells["estatus_legal_id"].Value.ToString();
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
                id = datos.CurrentRow.Cells["estatus_legal_id"].Value.ToString();
                objbll.Eliminar_Estatus_Legal(id);
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
                Cls_Estatus_Legal_BLL objnew = new Cls_Estatus_Legal_BLL();
                datos.DataSource = objnew.Consultar_IdEstatus_Legal(txtid.Text);
                txtid.Text = string.Empty;
            }
        }
    }
}
