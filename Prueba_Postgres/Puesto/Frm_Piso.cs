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
    public partial class Frm_Piso : Form
    {
        public Frm_Piso()
        {
            InitializeComponent();
        }

        private void Frm_Piso_Load(object sender, EventArgs e)
        {
            cmbestado.Items.Add("0");
            cmbestado.Items.Add("1");
            cmbestado.SelectedIndex = 0;
            Listar_Bloque();
            Mostrar_Datos();
        }

        Cls_Piso_BLL objbll = new Cls_Piso_BLL();

        private string id = null;
        private bool editar = false;

        private void Listar_Bloque()
        {
            Cls_Bloque_BLL objbll = new Cls_Bloque_BLL();
            cmbbloque.DataSource = objbll.Listar_Bloque();
            cmbbloque.DisplayMember = "bloque_nombre";
            cmbbloque.ValueMember = "bloque_id";
        }

        public void Mostrar_Datos()
        {
            Cls_Piso_BLL objnew = new Cls_Piso_BLL();
            datos.DataSource = objnew.Consultar_Piso();
        }

        public void Limpiar()
        {
            cmbbloque.SelectedIndex = 0;
            txtnombre.Text = string.Empty;
            txtcodigo.Text = string.Empty;
            cmbestado.SelectedIndex = 0;
            txtobservacion.Text = string.Empty;
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            Mostrar_Datos();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {

                objbll.Insertar_Piso(Convert.ToInt32(cmbbloque.SelectedValue), txtcodigo.Text, txtnombre.Text, txtobservacion.Text, cmbestado.Text);
                MessageBox.Show("REGISTRADO CORRECTAMENTE");
                Mostrar_Datos();
                Limpiar();
            }
            if (editar == true)
            {
                objbll.Editar_Piso(Convert.ToInt32(cmbbloque.SelectedValue), txtcodigo.Text, txtnombre.Text, txtobservacion.Text, cmbestado.Text, id);
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
                cmbbloque.Text = datos.CurrentRow.Cells["bloque_nombre"].Value.ToString();
                txtcodigo.Text = datos.CurrentRow.Cells["piso_codigo"].Value.ToString();
                txtnombre.Text = datos.CurrentRow.Cells["piso_nombre"].Value.ToString();
                txtobservacion.Text = datos.CurrentRow.Cells["piso_observacion"].Value.ToString();
                cmbestado.Text = datos.CurrentRow.Cells["piso_estado"].Value.ToString();
                id = datos.CurrentRow.Cells["piso_id"].Value.ToString();
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
                id = datos.CurrentRow.Cells["piso_id"].Value.ToString();
                objbll.Eliminar_Piso(id);
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
                Cls_Piso_BLL objnew = new Cls_Piso_BLL();
                datos.DataSource = objnew.Consultar_IdPiso(txtid.Text);
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
