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
    public partial class Frm_Provincia : Form
    {
        public Frm_Provincia()
        {
            InitializeComponent();
        }

        Cls_Provincia_BLL objbll = new Cls_Provincia_BLL();

        private string id = null;
        private bool editar = false;

        private void Frm_Provincia_Load(object sender, EventArgs e)
        {
            cmbestado.Items.Add("0");
            cmbestado.Items.Add("1");
            cmbestado.SelectedIndex = 0;
            Mostrar_Datos();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        public void Mostrar_Datos()
        {
            Cls_Provincia_BLL objnew = new Cls_Provincia_BLL();
            datos.DataSource = objnew.Consultar_Provincia();
        }

        public void Limpiar()
        {
            txtnombre.Text = string.Empty;
            txtcodigo.Text = string.Empty;
            cmbestado.SelectedIndex = 0;
            txtobservacion.Text = string.Empty;
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                
                objbll.Insertar_Provincia(txtcodigo.Text, txtnombre.Text, txtobservacion.Text, cmbestado.Text);
                MessageBox.Show("REGISTRADO CORRECTAMENTE");
                Mostrar_Datos();
                Limpiar();
            }
            if (editar == true)
            {
                objbll.Editar_Provincia(txtcodigo.Text, txtnombre.Text, txtobservacion.Text, cmbestado.Text, id);
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
                Cls_Provincia_BLL objnew = new Cls_Provincia_BLL();
                datos.DataSource = objnew.Consultar_IdProvincia(txtid.Text);
                txtid.Text = string.Empty;
            }
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            if (datos.SelectedRows.Count > 0)
            {
                editar = true;
                txtcodigo.Text = datos.CurrentRow.Cells["provincia_codigo"].Value.ToString();
                txtnombre.Text = datos.CurrentRow.Cells["provincia_nombre"].Value.ToString();
                txtobservacion.Text = datos.CurrentRow.Cells["provincia_observacion"].Value.ToString();
                cmbestado.Text = datos.CurrentRow.Cells["provincia_estado"].Value.ToString();
                id = datos.CurrentRow.Cells["provincia_id"].Value.ToString();
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
                id = datos.CurrentRow.Cells["provincia_id"].Value.ToString();
                objbll.Eliminar_Provincia(id);
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
