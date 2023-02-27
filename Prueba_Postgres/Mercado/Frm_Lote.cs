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
    public partial class Frm_Lote : Form
    {
        public Frm_Lote()
        {
            InitializeComponent();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void Frm_Lote_Load(object sender, EventArgs e)
        {
            cmbestado.Items.Add("0");
            cmbestado.Items.Add("1");
            cmbestado.SelectedIndex = 0;
            Listar_Manzanas();
            Mostrar_Datos();
        }

        Cls_Lote_BLL objbll = new Cls_Lote_BLL();

        private string id = null;
        private bool editar = false;

        public void Mostrar_Datos()
        {
            Cls_Lote_BLL objnew = new Cls_Lote_BLL();
            datos.DataSource = objnew.Consultar_Lote();
        }

        public void Limpiar()
        {
            cmbmanzana.SelectedIndex = 0;
            txtnombre.Text = string.Empty;
            txtcodigo.Text = string.Empty;
            cmbestado.SelectedIndex = 0;
            txtobservacion.Text = string.Empty;
        }

        private void Listar_Manzanas()
        {
            Cls_Manzana_BLL objbll = new Cls_Manzana_BLL();
            cmbmanzana.DataSource = objbll.Listar_Manzana();
            cmbmanzana.DisplayMember = "manzana_nombre";
            cmbmanzana.ValueMember = "manzana_id";
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                objbll.Insertar_Lote(Convert.ToInt32(cmbmanzana.SelectedValue), txtcodigo.Text, txtnombre.Text, txtobservacion.Text, cmbestado.Text);
                MessageBox.Show("REGISTRADO CORRECTAMENTE");
                Mostrar_Datos();
                Limpiar();
            }
            if (editar == true)
            {
                objbll.Editar_Lote(Convert.ToInt32(cmbmanzana.SelectedValue), txtcodigo.Text, txtnombre.Text, txtobservacion.Text, cmbestado.Text, id);
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
                Cls_Lote_BLL objnew = new Cls_Lote_BLL();
                datos.DataSource = objnew.Consultar_IdLote(txtid.Text);
                txtid.Text = string.Empty;
            }

        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            if (datos.SelectedRows.Count > 0)
            {
                editar = true;
                cmbmanzana.Text = datos.CurrentRow.Cells["manzana_nombre"].Value.ToString();
                txtcodigo.Text = datos.CurrentRow.Cells["lote_codigo"].Value.ToString();
                txtnombre.Text = datos.CurrentRow.Cells["lote_nombre"].Value.ToString();
                txtobservacion.Text = datos.CurrentRow.Cells["lote_observacion"].Value.ToString();
                cmbestado.Text = datos.CurrentRow.Cells["lote_estado"].Value.ToString();
                id = datos.CurrentRow.Cells["lote_id"].Value.ToString();
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
                id = datos.CurrentRow.Cells["lote_id"].Value.ToString();
                objbll.Eliminar_Lote(id);
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
