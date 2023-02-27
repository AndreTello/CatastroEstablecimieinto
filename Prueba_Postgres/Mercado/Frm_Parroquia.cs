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
    public partial class Frm_Parroquia : Form
    {
        public Frm_Parroquia()
        {
            InitializeComponent();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void Frm_Parroquia_Load(object sender, EventArgs e)
        {
            cmbestado.Items.Add("0");
            cmbestado.Items.Add("1");
            cmbestado.SelectedIndex = 0;
            Listar_Zonas();
            Mostrar_Datos();
        }

        Cls_Parroquia_BLL objbll = new Cls_Parroquia_BLL();

        private string id = null;
        private bool editar = false;

        public void Mostrar_Datos()
        {
            Cls_Parroquia_BLL objnew = new Cls_Parroquia_BLL();
            datos.DataSource = objnew.Consultar_Parroquia();
        }

        public void Limpiar()
        {
            cmbzona.SelectedIndex = 0;
            txtnombre.Text = string.Empty;
            txtcodigo.Text = string.Empty;
            cmbestado.SelectedIndex = 0;
            txtobservacion.Text = string.Empty;
        }

        private void Listar_Zonas()
        {
            Cls_Zona_BLL objbll = new Cls_Zona_BLL();
            cmbzona.DataSource = objbll.Listar_Zona();
            cmbzona.DisplayMember = "zona_nombre";
            cmbzona.ValueMember = "zona_id";
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {

                objbll.Insertar_Parroquia(Convert.ToInt32(cmbzona.SelectedValue), txtcodigo.Text, txtnombre.Text, txtobservacion.Text, cmbestado.Text);
                MessageBox.Show("REGISTRADO CORRECTAMENTE");
                Mostrar_Datos();
                Limpiar();
            }
            if (editar == true)
            {
                objbll.Editar_Parroquia(Convert.ToInt32(cmbzona.SelectedValue), txtcodigo.Text, txtnombre.Text, txtobservacion.Text, cmbestado.Text, id);
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
                Cls_Parroquia_BLL objnew = new Cls_Parroquia_BLL();
                datos.DataSource = objnew.Consultar_IdParroquia(txtid.Text);
                txtid.Text = string.Empty;
            }

        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            if (datos.SelectedRows.Count > 0)
            {
                editar = true;
                cmbzona.Text = datos.CurrentRow.Cells["zona_nombre"].Value.ToString();
                txtcodigo.Text = datos.CurrentRow.Cells["parroquia_codigo"].Value.ToString();
                txtnombre.Text = datos.CurrentRow.Cells["parroquia_nombre"].Value.ToString();
                txtobservacion.Text = datos.CurrentRow.Cells["parroquia_observacion"].Value.ToString();
                cmbestado.Text = datos.CurrentRow.Cells["parroquia_estado"].Value.ToString();
                id = datos.CurrentRow.Cells["parroquia_id"].Value.ToString();
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
                id = datos.CurrentRow.Cells["parroquia_id"].Value.ToString();
                objbll.Eliminar_Parroquia(id);
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
