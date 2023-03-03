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
    public partial class Frm_Documento : Form
    {
        public Frm_Documento()
        {
            InitializeComponent();
        }

        private void Frm_Documento_Load(object sender, EventArgs e)
        {
            cmbestado.Items.Add("0");
            cmbestado.Items.Add("1");
            cmbestado.SelectedIndex = 0;
            Mostrar_Datos();
            Listar_Tipo();
            Listar_Comerciantes();
        }

        Cls_Documento_Comerciante_BLL objbll = new Cls_Documento_Comerciante_BLL();

        private string id = null;
        private bool editar = false;

        public void Mostrar_Datos()
        {
            Cls_Documento_Comerciante_BLL objnew = new Cls_Documento_Comerciante_BLL();
            datos.DataSource = objnew.Consultar_Documento_Comerciante();
        }

        public void Limpiar()
        {
            cmbtipo.SelectedIndex = 0;
            cmbcomerciante.SelectedIndex = 0;
            txtnombre.Text = string.Empty;
            date.Text = string.Empty;
            txtdetalle.Text = string.Empty;
            txtobservacion.Text = string.Empty;
            cmbestado.SelectedIndex = 0;
        }

        private void Listar_Tipo()
        {
            Cls_Tipo_Documento_Comerciante_BLL objbll = new Cls_Tipo_Documento_Comerciante_BLL();
            cmbtipo.DataSource = objbll.Listar_Tipo_Documento_Comerciante();
            cmbtipo.DisplayMember = "tipo_documento_comerciante_nombre";
            cmbtipo.ValueMember = "tipo_documento_comerciante_id";
        }

        private void Listar_Comerciantes()
        {
            Cls_Comerciante_BLL objbll = new Cls_Comerciante_BLL();
            cmbcomerciante.DataSource = objbll.Listar_Comerciante();
            cmbcomerciante.DisplayMember = "comerciante_nombres_representante_legal";
            cmbcomerciante.ValueMember = "comerciante_id";
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            Mostrar_Datos();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                objbll.Insertar_Documento_Comerciante(Convert.ToInt32(cmbtipo.SelectedValue), Convert.ToInt32(cmbcomerciante.SelectedValue), txtnombre.Text, date.Text, txtdetalle.Text, txtobservacion.Text, cmbestado.Text);
                MessageBox.Show("REGISTRADO CORRECTAMENTE");
                Mostrar_Datos();
                Limpiar();
            }
            if (editar == true)
            {
                objbll.Editar_Documento_Comerciante(Convert.ToInt32(cmbtipo.SelectedValue), Convert.ToInt32(cmbcomerciante.SelectedValue), txtnombre.Text, date.Text, txtdetalle.Text, txtobservacion.Text, cmbestado.Text, id);
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
                cmbtipo.Text = datos.CurrentRow.Cells["tipo_documento_comerciante_nombre"].Value.ToString();
                cmbcomerciante.Text = datos.CurrentRow.Cells["comerciante_nombres_representante_legal"].Value.ToString();
                txtnombre.Text = datos.CurrentRow.Cells["documento_comerciante_nombre"].Value.ToString();
                date.Text = datos.CurrentRow.Cells["documento_comerciante_fecha"].Value.ToString();
                txtdetalle.Text = datos.CurrentRow.Cells["documento_comerciante_detalle"].Value.ToString();
                txtobservacion.Text = datos.CurrentRow.Cells["documento_comerciante_observacion"].Value.ToString();
                cmbestado.Text = datos.CurrentRow.Cells["documento_comerciante_estado"].Value.ToString();
                id = datos.CurrentRow.Cells["documento_comerciante_id"].Value.ToString();
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
                id = datos.CurrentRow.Cells["documento_comerciante_id"].Value.ToString();
                objbll.Eliminar_Documento_Comerciante(id);
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
                Cls_Documento_Comerciante_BLL objnew = new Cls_Documento_Comerciante_BLL();
                datos.DataSource = objnew.Consultar_IdDocumento_Comerciante(txtid.Text);
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
