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
    public partial class Frm_Usuario : Form
    {
        public Frm_Usuario()
        {
            InitializeComponent();
        }

        private void Frm_Usuario_Load(object sender, EventArgs e)
        {
            cmbestado.Items.Add("0");
            cmbestado.Items.Add("1");
            cmbestado.SelectedIndex = 0;
            Mostrar_Datos();
            Listar_Rol();
        }

        Cls_Usuario_BLL objbll = new Cls_Usuario_BLL();

        private string id = null;
        private bool editar = false;

        public void Mostrar_Datos()
        {
            Cls_Usuario_BLL objnew = new Cls_Usuario_BLL();
            datos.DataSource = objnew.Consultar_Usuario();
        }

        public void Limpiar()
        {
            cmbrol.SelectedIndex = 0;
            txtlogin.Text = string.Empty;
            txtclave.Text = string.Empty;
            txtcedula.Text = string.Empty;
            txtapellidos.Text = string.Empty;
            txtnombres.Text = string.Empty;
            txtemail.Text = string.Empty;
            txtdireccion.Text = string.Empty;
            txttelefono.Text = string.Empty;
            cmbestado.SelectedIndex = 0;
        }

        private void Listar_Rol()
        {
            Cls_Rol_BLL objbll = new Cls_Rol_BLL();
            cmbrol.DataSource = objbll.Listar_Rol();
            cmbrol.DisplayMember = "rol_nombre";
            cmbrol.ValueMember = "rol_id";
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
                objbll.Insertar_Usuario(Convert.ToInt32(cmbrol.SelectedValue), txtlogin.Text, txtclave.Text, txtcedula.Text, txtapellidos.Text, txtnombres.Text, txtemail.Text, txtdireccion.Text, txttelefono.Text, cmbestado.Text);
                MessageBox.Show("REGISTRADO CORRECTAMENTE");
                Mostrar_Datos();
                Limpiar();
            }
            if (editar == true)
            {
                objbll.Editar_Usuario(id, Convert.ToInt32(cmbrol.SelectedValue), txtlogin.Text, txtclave.Text, txtcedula.Text, txtapellidos.Text, txtnombres.Text, txtemail.Text, txtdireccion.Text, txttelefono.Text, cmbestado.Text);
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
                id = datos.CurrentRow.Cells["usuario_id"].Value.ToString();
                cmbrol.Text = datos.CurrentRow.Cells["rol_nombre"].Value.ToString();
                txtlogin.Text = datos.CurrentRow.Cells["usuario_login"].Value.ToString();
                txtclave.Text = datos.CurrentRow.Cells["usuario_clave"].Value.ToString();
                txtcedula.Text = datos.CurrentRow.Cells["usuario_cedula"].Value.ToString();
                txtapellidos.Text = datos.CurrentRow.Cells["usuario_apellidos"].Value.ToString();
                txtnombres.Text = datos.CurrentRow.Cells["usuario_nombres"].Value.ToString();
                txtemail.Text = datos.CurrentRow.Cells["usuario_mail"].Value.ToString();
                txtdireccion.Text = datos.CurrentRow.Cells["usuario_direccion"].Value.ToString();
                txttelefono.Text = datos.CurrentRow.Cells["usuario_telefono"].Value.ToString();
                cmbestado.Text = datos.CurrentRow.Cells["usuario_estado"].Value.ToString();
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
                id = datos.CurrentRow.Cells["usuario_id"].Value.ToString();
                objbll.Eliminar_Usuario(id);
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
                Cls_Usuario_BLL objnew = new Cls_Usuario_BLL();
                datos.DataSource = objnew.Consultar_IdUsuario(txtid.Text);
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
