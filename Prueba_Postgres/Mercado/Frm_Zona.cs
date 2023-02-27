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
    public partial class Frm_Zona : Form
    {
        public Frm_Zona()
        {
            InitializeComponent();
        }

        Cls_Zona_BLL objbll = new Cls_Zona_BLL();

        private string id = null;
        private bool editar = false;

        public void Mostrar_Datos()
        {
            Cls_Zona_BLL objnew = new Cls_Zona_BLL();
            datos.DataSource = objnew.Consultar_Zona();
        }

        public void Limpiar()
        {
            cmbcanton.SelectedIndex = 0;
            txtnombre.Text = string.Empty;
            txtcodigo.Text = string.Empty;
            cmbestado.SelectedIndex = 0;
            txtobservacion.Text = string.Empty;
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {

                objbll.Insertar_Zona(Convert.ToInt32(cmbcanton.SelectedValue), txtcodigo.Text, txtnombre.Text, txtobservacion.Text, cmbestado.Text);
                MessageBox.Show("REGISTRADO CORRECTAMENTE");
                Mostrar_Datos();
                Limpiar();
            }
            if (editar == true)
            {
                objbll.Editar_Zona(Convert.ToInt32(cmbcanton.SelectedValue), txtcodigo.Text, txtnombre.Text, txtobservacion.Text, cmbestado.Text, id);
                MessageBox.Show("ACTUALIZADO CORRECTAMENTE");
                Mostrar_Datos();
                editar = false;
                Limpiar();
            }
        }

        private void Listar_Cantones()
        {
            Cls_Canton_BLL objbll = new Cls_Canton_BLL();
            cmbcanton.DataSource = objbll.Listar_Canton();
            cmbcanton.DisplayMember = "canton_nombre";
            cmbcanton.ValueMember = "canton_id";
        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("Ingrese el id a buscar");
            }
            else
            {
                Cls_Zona_BLL objnew = new Cls_Zona_BLL();
                datos.DataSource = objnew.Consultar_IdZona(txtid.Text);
                txtid.Text = string.Empty;
            }

        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            if (datos.SelectedRows.Count > 0)
            {
                editar = true;
                cmbcanton.Text = datos.CurrentRow.Cells["canton_nombre"].Value.ToString();
                txtcodigo.Text = datos.CurrentRow.Cells["zona_codigo"].Value.ToString();
                txtnombre.Text = datos.CurrentRow.Cells["zona_nombre"].Value.ToString();
                txtobservacion.Text = datos.CurrentRow.Cells["zona_observacion"].Value.ToString();
                cmbestado.Text = datos.CurrentRow.Cells["zona_estado"].Value.ToString();
                id = datos.CurrentRow.Cells["zona_id"].Value.ToString();
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
                id = datos.CurrentRow.Cells["zona_id"].Value.ToString();
                objbll.Eliminar_Zona(id);
                MessageBox.Show("ELIMINADO CORRECTAMENTE");
                Mostrar_Datos();
                Limpiar();
            }
            else
            {
                MessageBox.Show("SELECCIONE LA FILA A ELIMINAR");
            }
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            Menu menu= new Menu();  
            menu.Show();
            this.Hide();
        }

        private void Frm_Zona_Load(object sender, EventArgs e)
        {
            cmbestado.Items.Add("0");
            cmbestado.Items.Add("1");
            cmbestado.SelectedIndex = 0;
            Listar_Cantones();
            Mostrar_Datos();
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            Mostrar_Datos();
        }
    }
}
