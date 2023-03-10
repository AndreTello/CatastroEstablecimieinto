using BLL_CE.Administracion;
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

namespace Prueba_Postgres.Administracion
{
    public partial class Frm_Rol : Form
    {
        public Frm_Rol()
        {
            InitializeComponent();
        }

        private void Frm_Rol_Load(object sender, EventArgs e)
        {
            cmbestado.Items.Add("0");
            cmbestado.Items.Add("1");
            cmbestado.SelectedIndex = 0;
            Mostrar_Datos();
        }

        Cls_Rol_BLL objbll = new Cls_Rol_BLL();

        private string id = null;
        private bool editar = false;

        public void Mostrar_Datos()
        {
            Cls_Rol_BLL objnew = new Cls_Rol_BLL();
            datos.DataSource = objnew.Consultar_Rol();
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
                objbll.Insertar_Rol(txtnombre.Text, txtdetalle.Text, cmbestado.Text);
                MessageBox.Show("REGISTRADO CORRECTAMENTE");
                Mostrar_Datos();
                Limpiar();

            }
            if (editar == true)
            {
                objbll.Editar_Rol(id, txtnombre.Text, txtdetalle.Text, cmbestado.Text);
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
                id = datos.CurrentRow.Cells["rol_id"].Value.ToString();
                txtnombre.Text = datos.CurrentRow.Cells["rol_nombre"].Value.ToString();
                txtdetalle.Text = datos.CurrentRow.Cells["rol_detalle"].Value.ToString();
                cmbestado.Text = datos.CurrentRow.Cells["rol_estado"].Value.ToString();                
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
                id = datos.CurrentRow.Cells["rol_id"].Value.ToString();
                objbll.Eliminar_Rol(id);
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
                Cls_Rol_BLL objnew = new Cls_Rol_BLL();
                datos.DataSource = objnew.Consultar_IdRol(txtid.Text);
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
