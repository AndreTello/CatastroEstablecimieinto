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
    public partial class Frm_Asociacion : Form
    {
        public Frm_Asociacion()
        {
            InitializeComponent();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void Frm_Asociacion_Load(object sender, EventArgs e)
        {
            cmbestado.Items.Add("0");
            cmbestado.Items.Add("1");
            cmbestado.SelectedIndex = 0;
            Mostrar_Datos();
        }

        Cls_Asociacion_BLL objbll = new Cls_Asociacion_BLL();

        private string id = null;
        private bool editar = false;

        public void Mostrar_Datos()
        {
            Cls_Asociacion_BLL objnew = new Cls_Asociacion_BLL();
            datos.DataSource = objnew.Consultar_Asociacion();
        }

        public void Limpiar()
        {
            txtcodigo.Text = string.Empty;
            txtnombre.Text = string.Empty;
            txttelefono.Text = string.Empty;
            txtmail.Text = string.Empty;
            txtcontacto.Text = string.Empty;
            txtobservacion.Text = string.Empty;
            cmbestado.SelectedIndex = 0;
        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("Ingrese el id a buscar");
            }
            else
            {
                Cls_Asociacion_BLL objnew = new Cls_Asociacion_BLL();
                datos.DataSource = objnew.Consultar_IdAsociacion(txtid.Text);
                txtid.Text = string.Empty;
            }
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                objbll.Insertar_Asociacion(txtcodigo.Text, txtnombre.Text, txttelefono.Text, txtmail.Text, txtcontacto.Text, txtobservacion.Text, cmbestado.Text);
                MessageBox.Show("REGISTRADO CORRECTAMENTE");
                Mostrar_Datos();
                Limpiar();
            }
            if (editar == true)
            {
                objbll.Editar_Asociacion(txtcodigo.Text, txtnombre.Text, txttelefono.Text, txtmail.Text, txtcontacto.Text, txtobservacion.Text, cmbestado.Text, id);
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
                txtcodigo.Text = datos.CurrentRow.Cells["asociacion_codigo"].Value.ToString();
                txtnombre.Text = datos.CurrentRow.Cells["asociacion_nombre"].Value.ToString();
                txttelefono.Text = datos.CurrentRow.Cells["asociacion_telefono"].Value.ToString();                
                txtmail.Text = datos.CurrentRow.Cells["asociacion_mail"].Value.ToString();
                txtcontacto.Text = datos.CurrentRow.Cells["asociacion_contacto"].Value.ToString();
                txtobservacion.Text = datos.CurrentRow.Cells["asociacion_observacion"].Value.ToString();
                cmbestado.Text = datos.CurrentRow.Cells["asociacion_estado"].Value.ToString();
                id = datos.CurrentRow.Cells["asociacion_id"].Value.ToString();
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
                id = datos.CurrentRow.Cells["asociacion_id"].Value.ToString();
                objbll.Eliminar_Asociacion(id);
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
