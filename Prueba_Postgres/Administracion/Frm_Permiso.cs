using BLL_CE.Administracion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_Postgres.Administracion
{
    public partial class Frm_Permiso : Form
    {
        public Frm_Permiso()
        {
            InitializeComponent();
        }

        private void Frm_Permiso_Load(object sender, EventArgs e)
        {
            cmbestado.Items.Add("0");
            cmbestado.Items.Add("1");
            cmbestado.SelectedIndex = 0;
            Mostrar_Datos();
        }

        Cls_Permiso_BLL objbll = new Cls_Permiso_BLL();

        private string id = null;
        private bool editar = false;

        public void Mostrar_Datos()
        {
            Cls_Permiso_BLL objnew = new Cls_Permiso_BLL();
            datos.DataSource = objnew.Consultar_Permiso();
        }

        public void Limpiar()
        {
            txtnombre.Text = string.Empty;
            txtdetalle.Text = string.Empty;
            cmbestado.SelectedIndex = 0;
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            Mostrar_Datos();
            Limpiar();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                objbll.Insertar_Permiso(txtnombre.Text, txtdetalle.Text, cmbestado.Text);
                MessageBox.Show("REGISTRADO CORRECTAMENTE");
                Mostrar_Datos();
                Limpiar();

            }
            if (editar == true)
            {
                objbll.Editar_Permiso(id, txtnombre.Text, txtdetalle.Text, cmbestado.Text);
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
                id = datos.CurrentRow.Cells["permiso_id"].Value.ToString();
                txtnombre.Text = datos.CurrentRow.Cells["permiso_nombre"].Value.ToString();
                txtdetalle.Text = datos.CurrentRow.Cells["permiso_detalle"].Value.ToString();
                cmbestado.Text = datos.CurrentRow.Cells["permiso_estado"].Value.ToString();
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
                id = datos.CurrentRow.Cells["permiso_id"].Value.ToString();
                objbll.Eliminar_Permiso(id);
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
                Cls_Permiso_BLL objnew = new Cls_Permiso_BLL();
                datos.DataSource = objnew.Consultar_IdPermiso(txtid.Text);
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
