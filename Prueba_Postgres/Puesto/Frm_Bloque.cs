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
    public partial class Frm_Bloque : Form
    {
        public Frm_Bloque()
        {
            InitializeComponent();
        }

        private void Frm_Bloque_Load(object sender, EventArgs e)
        {
            cmbestado.Items.Add("0");
            cmbestado.Items.Add("1");
            cmbestado.SelectedIndex = 0;
            Listar_Establecimiento();
            Mostrar_Datos();
        }

        Cls_Bloque_BLL objbll = new Cls_Bloque_BLL();

        private string id = null;
        private bool editar = false;

        private void Listar_Establecimiento()
        {
            Cls_Establecimiento_BLL objbll = new Cls_Establecimiento_BLL();
            cmbestablecimiento.DataSource = objbll.Listar_Establecimiento();
            cmbestablecimiento.DisplayMember = "establecimiento_clave_catastral";
            cmbestablecimiento.ValueMember = "establecimiento_id";
        }

        public void Mostrar_Datos()
        {
            Cls_Bloque_BLL objnew = new Cls_Bloque_BLL();
            datos.DataSource = objnew.Consultar_Bloque();
        }

        public void Limpiar()
        {
            cmbestablecimiento.SelectedIndex = 0;
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

                objbll.Insertar_Bloque(Convert.ToInt32(cmbestablecimiento.SelectedValue), txtcodigo.Text, txtnombre.Text, txtobservacion.Text, cmbestado.Text);
                MessageBox.Show("REGISTRADO CORRECTAMENTE");
                Mostrar_Datos();
                Limpiar();
            }
            if (editar == true)
            {
                objbll.Editar_Bloque(Convert.ToInt32(cmbestablecimiento.SelectedValue), txtcodigo.Text, txtnombre.Text, txtobservacion.Text, cmbestado.Text, id);
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
                cmbestablecimiento.Text = datos.CurrentRow.Cells["establecimiento_clave_catastral"].Value.ToString();
                txtcodigo.Text = datos.CurrentRow.Cells["bloque_codigo"].Value.ToString();
                txtnombre.Text = datos.CurrentRow.Cells["bloque_nombre"].Value.ToString();
                txtobservacion.Text = datos.CurrentRow.Cells["bloque_observacion"].Value.ToString();
                cmbestado.Text = datos.CurrentRow.Cells["bloque_estado"].Value.ToString();
                id = datos.CurrentRow.Cells["bloque_id"].Value.ToString();
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
                id = datos.CurrentRow.Cells["bloque_id"].Value.ToString();
                objbll.Eliminar_Bloque(id);
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
                Cls_Bloque_BLL objnew = new Cls_Bloque_BLL();
                datos.DataSource = objnew.Consultar_IdBloque(txtid.Text);
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
