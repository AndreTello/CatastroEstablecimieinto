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
    public partial class Frm_Rol_Permiso : Form
    {
        public Frm_Rol_Permiso()
        {
            InitializeComponent();
        }

        private void Frm_Rol_Permiso_Load(object sender, EventArgs e)
        {
            cmbestado.Items.Add("0");
            cmbestado.Items.Add("1");
            cmbestado.SelectedIndex = 0;
            Mostrar_Datos();
            Listar_Rol();
            Listar_Permiso();
        }

        Cls_Rol_Permiso_BLL objbll = new Cls_Rol_Permiso_BLL();

        private string id = null;
        private bool editar = false;

        public void Mostrar_Datos()
        {
            Cls_Rol_Permiso_BLL objnew = new Cls_Rol_Permiso_BLL();
            datos.DataSource = objnew.Consultar_Rol_Permiso();
        }

        public void Limpiar()
        {
            cmbrol.SelectedIndex = 0;
            cmbpermiso.SelectedIndex = 0;           
            cmbestado.SelectedIndex = 0;
        }

        private void Listar_Rol()
        {
            Cls_Rol_BLL objbll = new Cls_Rol_BLL();
            cmbrol.DataSource = objbll.Listar_Rol();
            cmbrol.DisplayMember = "rol_nombre";
            cmbrol.ValueMember = "rol_id";
        }

        private void Listar_Permiso()
        {
            Cls_Permiso_BLL objbll = new Cls_Permiso_BLL();
            cmbpermiso.DataSource = objbll.Listar_Permiso();
            cmbpermiso.DisplayMember = "permiso_nombre";
            cmbpermiso.ValueMember = "permiso_id";
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
                objbll.Insertar_Rol_Permiso(Convert.ToInt32(cmbrol.SelectedValue), Convert.ToInt32(cmbpermiso.SelectedValue),  cmbestado.Text);
                MessageBox.Show("REGISTRADO CORRECTAMENTE");
                Mostrar_Datos();
                Limpiar();
            }
            if (editar == true)
            {
                objbll.Editar_Rol_Permiso(id, Convert.ToInt32(cmbrol.SelectedValue), Convert.ToInt32(cmbpermiso.SelectedValue), cmbestado.Text);
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
                id = datos.CurrentRow.Cells["rol_permiso_id"].Value.ToString();
                cmbrol.Text = datos.CurrentRow.Cells["rol_nombre"].Value.ToString();
                cmbpermiso.Text = datos.CurrentRow.Cells["permiso_nombre"].Value.ToString();
                cmbestado.Text = datos.CurrentRow.Cells["rol_permiso_estado"].Value.ToString();
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
                id = datos.CurrentRow.Cells["rol_permiso_id"].Value.ToString();
                objbll.Eliminar_Rol_Permiso(id);
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
                Cls_Rol_Permiso_BLL objnew = new Cls_Rol_Permiso_BLL();
                datos.DataSource = objnew.Consultar_IdRol_Permiso(txtid.Text);
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
