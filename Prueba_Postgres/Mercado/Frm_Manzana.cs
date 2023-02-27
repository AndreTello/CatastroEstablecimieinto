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
    public partial class Frm_Manzana : Form
    {
        public Frm_Manzana()
        {
            InitializeComponent();
        }

        private void Frm_Manzana_Load(object sender, EventArgs e)
        {
            cmbestado.Items.Add("0");
            cmbestado.Items.Add("1");
            cmbestado.SelectedIndex = 0;
            Listar_Parroquias();
            Mostrar_Datos();
        }

        Cls_Manzana_BLL objbll = new Cls_Manzana_BLL();

        private string id = null;
        private bool editar = false;

        public void Mostrar_Datos()
        {
            Cls_Manzana_BLL objnew = new Cls_Manzana_BLL();
            datos.DataSource = objnew.Consultar_Manzana();
        }

        public void Limpiar()
        {
            cmbparroquia.SelectedIndex = 0;
            txtnombre.Text = string.Empty;
            txtcodigo.Text = string.Empty;
            cmbestado.SelectedIndex = 0;
            txtobservacion.Text = string.Empty;
        }

        private void Listar_Parroquias()
        {
            Cls_Parroquia_BLL objbll = new Cls_Parroquia_BLL();
            cmbparroquia.DataSource = objbll.Listar_Parroquia();
            cmbparroquia.DisplayMember = "parroquia_nombre";
            cmbparroquia.ValueMember = "parroquia_id";
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (datos.SelectedRows.Count > 0)
            {
                id = datos.CurrentRow.Cells["manzana_id"].Value.ToString();
                objbll.Eliminar_Manzana(id);
                MessageBox.Show("ELIMINADO CORRECTAMENTE");
                Mostrar_Datos();
                Limpiar();
            }
            else
            {
                MessageBox.Show("SELECCIONE LA FILA A ELIMINAR");
            }
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            if (datos.SelectedRows.Count > 0)
            {
                editar = true;
                cmbparroquia.Text = datos.CurrentRow.Cells["parroquia_nombre"].Value.ToString();
                txtcodigo.Text = datos.CurrentRow.Cells["manzana_codigo"].Value.ToString();
                txtnombre.Text = datos.CurrentRow.Cells["manzana_nombre"].Value.ToString();
                txtobservacion.Text = datos.CurrentRow.Cells["manzana_observacion"].Value.ToString();
                cmbestado.Text = datos.CurrentRow.Cells["manzana_estado"].Value.ToString();
                id = datos.CurrentRow.Cells["manzana_id"].Value.ToString();
            }
            else
            {
                MessageBox.Show("SELECCIONE LA FILA A MODIFICAR");
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
                Cls_Manzana_BLL objnew = new Cls_Manzana_BLL();
                datos.DataSource = objnew.Consultar_IdManzana(txtid.Text);
                txtid.Text = string.Empty;
            }

        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {

                objbll.Insertar_Manzana(Convert.ToInt32(cmbparroquia.SelectedValue), txtcodigo.Text, txtnombre.Text, txtobservacion.Text, cmbestado.Text);
                MessageBox.Show("REGISTRADO CORRECTAMENTE");
                Mostrar_Datos();
                Limpiar();
            }
            if (editar == true)
            {
                objbll.Editar_Manzana(Convert.ToInt32(cmbparroquia.SelectedValue), txtcodigo.Text, txtnombre.Text, txtobservacion.Text, cmbestado.Text, id);
                MessageBox.Show("ACTUALIZADO CORRECTAMENTE");
                Mostrar_Datos();
                editar = false;
                Limpiar();
            }
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            Mostrar_Datos();
        }
    }
}
